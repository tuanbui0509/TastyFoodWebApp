using TastyFoodSolution.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TastyFoodSolution.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryViewModel>> GetAll();
    }
}