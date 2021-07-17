using TastyFoodSolution.ApiIntegration;
using TastyFoodSolution.ViewModels.Catalog.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Catolog.Products;

namespace TastyFoodSolution.ApiIntegration
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<CategoryViewModel>> GetAll()
        {
            return await GetListAsync<CategoryViewModel>("/api/categories?");
        }

        public async Task<List<ProductViewModel>> GetAllProductById(int id)
        {
            return await GetListAsync<ProductViewModel>($"/api/categories/{id}/products");
        }

        public async Task<CategoryViewModel> GetById(int id)
        {
            return await GetAsync<CategoryViewModel>($"/api/categories/{id}");
        }
    }
}