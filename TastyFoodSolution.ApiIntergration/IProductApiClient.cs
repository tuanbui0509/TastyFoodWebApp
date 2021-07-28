using TastyFoodSolution.ViewModels.Common;
using TastyFoodSolution.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Catolog.Products;
using TastyFoodSolution.ViewModels.Catalog.Products;

namespace TastyFoodSolution.ApiIntegration
{
    public interface IProductApiClient
    {
        Task<ProductViewModel> GetById(int id);

        Task<ApiResult<bool>> CreateReview(ReviewCreateRequest request);

        Task<List<ReviewViewModel>> GetAllReviews(int productId);

        Task<List<ProductViewModel>> GetFeaturedProducts(int take);

        Task<List<ProductViewModel>> GetLatestProducts(int take);

        Task<List<ProductViewModel>> GetBestSellerProducts(int take);

        Task AddViewcount(int productId);
    }
}