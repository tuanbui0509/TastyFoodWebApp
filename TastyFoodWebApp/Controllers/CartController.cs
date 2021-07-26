using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.ApiIntegration;
using TastyFoodSolution.ApiIntergration;
using TastyFoodSolution.Utilities.Constants;
using TastyFoodSolution.ViewModels.Carts;
using TastyFoodWebApp.Models;

namespace TastyFoodWebApp.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IOrderApiClient _orderApiClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;

        public CartController(IProductApiClient productApiClient, IOrderApiClient orderApiClient, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _productApiClient = productApiClient;
            _orderApiClient = orderApiClient;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View(GetCheckoutViewModel());
        }

        [HttpPost]
        public IActionResult Checkout(CheckoutViewModel request)
        {
            var model = GetCheckoutViewModel();
            var orderDetails = new List<OrderDetailViewModel>();
            foreach (var item in model.CartItems)
            {
                orderDetails.Add(new OrderDetailViewModel()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    Price = item.Price * item.Quantity
                });
            }

            var checkoutRequest = new CheckoutRequest()
            {
                Address = request.CheckoutModel.Address,
                Name = request.CheckoutModel.Name,
                Email = request.CheckoutModel.Email,
                PhoneNumber = request.CheckoutModel.PhoneNumber,
                OrderDetails = orderDetails,
            };
            //TODO: Add to API
            var create = _orderApiClient.CreateOrder(checkoutRequest);
            if (create.Result.IsSuccessed)
            {
                TempData["SuccessMsg"] = "Order puschased successful";
                removeAllCart();
            }
            else
            {
                TempData["SuccessMsg"] = "Order puschased failseful";
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult GetListItems()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            return Ok(currentCart);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int id)
        {
            var product = await _productApiClient.GetById(id);

            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
                if (currentCart.Exists(x => x.ProductId == id))
                {
                    var item = currentCart.Find(x => x.ProductId == id);
                    item.Quantity++;
                }
                else
                {
                    int quantity = 1;
                    if (currentCart.Any(x => x.ProductId == id))
                    {
                        quantity = currentCart.First(x => x.ProductId == id).Quantity + 1;
                    }
                    var cartItem = new CartItemViewModel()
                    {
                        ProductId = id,
                        Description = product.Description,
                        Image = product.ThumbnailImage,
                        Name = product.Name,
                        Price = product.Price,
                        Quantity = quantity
                    };
                    currentCart.Add(cartItem);
                }
            }
            else
            {
                int quantity = 1;
                if (currentCart.Any(x => x.ProductId == id))
                {
                    quantity = currentCart.First(x => x.ProductId == id).Quantity + 1;
                }
                var cartItem = new CartItemViewModel()
                {
                    ProductId = id,
                    Description = product.Description,
                    Image = product.ThumbnailImage,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = quantity
                };
                currentCart.Add(cartItem);
            }

            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }

        [HttpPost]
        public IActionResult UpdateCart([FromBody] CartItemViewModel model)
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);

            foreach (var item in currentCart)
            {
                if (item.ProductId == model.ProductId)
                {
                    if (model.Quantity == 0)
                    {
                        currentCart.Remove(item);
                        break;
                    }
                    item.Quantity = model.Quantity;
                }
            }

            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));
            return Ok(currentCart);
        }

        private CheckoutViewModel GetCheckoutViewModel()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = new List<CartItemViewModel>();
            if (session != null)
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            var checkoutVm = new CheckoutViewModel()
            {
                CartItems = currentCart,
                CheckoutModel = new CheckoutRequest()
            };
            return checkoutVm;
        }

        private void removeAllCart()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
            currentCart.Clear();
            HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(currentCart));

        }
    }
}