using TastyFoodSolution.Utilities.Constants;
using TastyFoodSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Catolog.Products;
using TastyFoodSolution.ViewModels.Catalog.Products;

namespace TastyFoodSolution.ApiIntegration
{
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ProductApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ProductViewModel> GetById(int id)
        {
            var data = await GetAsync<ProductViewModel>($"/api/products/{id}");
            return data;
        }

        public async Task<List<ProductViewModel>> GetFeaturedProducts(int take)
        {
            var data = await GetListAsync<ProductViewModel>($"/api/products/featured/{take}");
            return data;
        }

        public async Task<List<ProductViewModel>> GetLatestProducts(int take)
        {
            var data = await GetListAsync<ProductViewModel>($"/api/products/latest/{take}");
            return data;
        }

        public async Task<List<ProductViewModel>> GetBestSellerProducts(int take)
        {
            var data = await GetListAsync<ProductViewModel>($"/api/products/best-seller/{take}");
            return data;
        }

        public async Task AddViewcount(int productId)
        {
            var request = $"productId: {productId}";
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PatchAsync($"/api/products/AddViewcount", httpContent);
            var result = await response.Content.ReadAsStringAsync();
        }

        public async Task<ApiResult<bool>> CreateReview(ReviewCreateRequest request)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"/api/products/CreateReview", httpContent);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }

        public async Task<List<ReviewViewModel>> GetAllReviews(int productId)
        {
            var data = await GetListAsync<ReviewViewModel>($"/api/products/GetAllReviews/{productId}");
            return data;
        }
    }
}