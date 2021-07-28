using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyFoodSolution.ApiIntegration;
using TastyFoodSolution.Utilities.Constants;
using TastyFoodSolution.ViewModels.Catalog.Products;
using TastyFoodSolution.ViewModels.Catolog.Products;
using TastyFoodWebApp.Models;

namespace TastyFoodWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;

        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }

        [HttpGet()]
        public async Task<IActionResult> Detail(int id)
        {
            var product = await _productApiClient.GetById(id);
            _productApiClient.AddViewcount(id);
            var session = HttpContext.Session.GetString(SystemConstants.CartSession);
            List<CartItemViewModel> currentProduct = new List<CartItemViewModel>();
            if (session != null)
            {
                currentProduct = JsonConvert.DeserializeObject<List<CartItemViewModel>>(session);
                foreach (var item in currentProduct)
                {
                    if (item.ProductId == id)
                    {
                        product.QuantityOrder = item.Quantity;
                    }
                }
            }
            var RelatedProducts = await _categoryApiClient.GetAllProductById(product.CategoryId);
            var Reviews = await _productApiClient.GetAllReviews(id);
            return View(new ProductDetailViewModel()
            {
                Product = product,
                RelatedProducts = RelatedProducts,
                Reviews = Reviews
            });
        }

        [HttpGet("categories")]
        public async Task<IActionResult> Category()
        {
            var categories = await _categoryApiClient.GetAll();
            return View(new CategoryListViewModel()
            {
                ListCategory = categories
            }); ;
        }

        [HttpGet("categories/{categoryId}")]
        public async Task<IActionResult> ProductCategory(int categoryId)
        {
            return View(new CategoryListViewModel()
            {
                ListProductByCategoryId = await _categoryApiClient.GetAllProductById(categoryId),
                ListProductPopular = await _productApiClient.GetBestSellerProducts(3),
                CategoryItem = await _categoryApiClient.GetById(categoryId)
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateReview([FromBody] ReviewCreateRequest request)
        {
            var id = request.ProductId;
            var create = await _productApiClient.CreateReview(request);
            var Reviews = await _productApiClient.GetAllReviews(request.ProductId);
            return Ok(Reviews);
        }
    }
}