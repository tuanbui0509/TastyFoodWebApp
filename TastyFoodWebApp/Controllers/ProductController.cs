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
            return View(new ProductDetailViewModel()
            {
                Product = product,
                RelatedProducts = await _categoryApiClient.GetAllProductById(product.CategoryId),
            }); ;
        }
    }
}