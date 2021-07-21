using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyFoodSolution.ApiIntegration;
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
            var RelatedProducts = await _categoryApiClient.GetAllProductById(product.CategoryId);
            return View(new ProductDetailViewModel()
            {
                Product = product,
                RelatedProducts = RelatedProducts
            }); ;
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
    }
}