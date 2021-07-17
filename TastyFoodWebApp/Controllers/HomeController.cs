using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TastyFoodSolution.ApiIntegration;
using TastyFoodSolution.Utilities.Constants;
using TastyFoodSolution.ViewModels.Catolog.Products;
using TastyFoodWebApp.Models;

namespace TastyFoodWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductApiClient _productApiClient;

        public HomeController(ILogger<HomeController> logger, IProductApiClient productApiClient)
        {
            _logger = logger;
            _productApiClient = productApiClient;
        }

        [HttpGet()]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                FeatureProducts = await _productApiClient.GetFeaturedProducts(SystemConstants.ProductSettings.NumberOfFeaturedProducts),
                //LatestProducts = await _productApiClient.GetLatestProducts(SystemConstants.ProductSettings.NumberOfLatestProducts),
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SetCultureCookie(string cltr, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cltr)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(returnUrl);
        }
    }
}