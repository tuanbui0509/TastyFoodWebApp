using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Catalog.Categories;
using TastyFoodSolution.ViewModels.Catolog.Products;

namespace TastyFoodWebApp.Models
{
    public class CategoryListViewModel
    {
        public List<CategoryViewModel> ListCategory { get; set; }
        public List<ProductViewModel> ListProductByCategoryId { get; set; }
        public List<ProductViewModel> ListProductPopular { get; set; }
        public CategoryViewModel CategoryItem { get; set; }
    }
}