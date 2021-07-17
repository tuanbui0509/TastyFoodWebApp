using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Catolog.Products;

namespace TastyFoodWebApp.Models
{
    public class HomeViewModel
    {
        public List<ProductViewModel> FeatureProducts { get; set; }
        public List<ProductViewModel> LatestProducts { get; set; }
        public List<ProductViewModel> BestSellerProducts { get; set; }
    }
}