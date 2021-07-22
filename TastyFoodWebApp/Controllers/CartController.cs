using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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

        public CartController(IProductApiClient productApiClient, IOrderApiClient orderApiClient, IHttpContextAccessor httpContextAccessor)
        {
            _productApiClient = productApiClient;
            _orderApiClient = orderApiClient;
            _httpContextAccessor = httpContextAccessor;
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
            var username = _httpContextAccessor.HttpContext.User.Identity.Name;
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var orderDetails = new List<OrderDetailViewModel>();
            foreach (var item in model.CartItems)
            {
                orderDetails.Add(new OrderDetailViewModel()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
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
            if (create.Result != null && create.Result.IsSuccessed)
            {
                TempData["SuccessMsg"] = "Order puschased successful";
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
                foreach (var item in currentCart)
                {
                    if (item.ProductId == id)
                    {
                        item.Quantity++;
                        break;
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
                        break;
                    }
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
    }
}