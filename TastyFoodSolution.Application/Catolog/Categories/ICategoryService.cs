using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Catalog.Categories;
using TastyFoodSolution.ViewModels.Catolog.Products;

namespace TastyFoodSolution.Application.Catalog.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>> GetAll();

        Task<List<ProductViewModel>> GetAllProductById(int categoryId);

        Task<CategoryViewModel> GetById(int id);
    }
}