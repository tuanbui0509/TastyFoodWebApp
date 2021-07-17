using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Catalog.Categories;
using TastyFoodSolution.ViewModels.Catolog.Products;
using TastyFoodSolution.ViewModels.Common;

namespace TastyFoodWebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryViewModel Category { get; set; }

        public PagedResult<ProductViewModel> Products { get; set; }
    }
}