using TastyFoodSolution.ViewModels.Common;
using TastyFoodSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Catolog.Products;

namespace TastyFoodSolution.ApiIntegration
{
    public interface IProductApiClient
    {
        Task<ProductViewModel> GetById(int id);

        Task<List<ProductViewModel>> GetFeaturedProducts(int take);

        Task<List<ProductViewModel>> GetLatestProducts(int take);
    }
}