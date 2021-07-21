using TastyFoodSolution.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Catolog.Products;

namespace TastyFoodSolution.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryViewModel>> GetAll();

        Task<CategoryViewModel> GetById(int id);

        Task<List<ProductViewModel>> GetAllProductById(int id);
    }
}