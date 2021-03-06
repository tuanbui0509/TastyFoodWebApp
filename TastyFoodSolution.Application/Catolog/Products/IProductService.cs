using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Catalog.ProductImage;
using TastyFoodSolution.ViewModels.Catalog.Products;
using TastyFoodSolution.ViewModels.Catolog.Products;
using TastyFoodSolution.ViewModels.Common;

namespace TastyFoodSolution.Application.Catolog.Products
{
    public interface IProductService
    {
        // product
        Task<int> Create(ProductCreateRequest request);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<int> Update(ProductUpdateRequest request);

        Task<ProductViewModel> GetById(int productId);

        Task<ReviewViewModel> GetByIdReview(int reviewId);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task<bool> ChangeActive(int productId);

        Task AddViewcount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(int categoryId);

        Task<List<ProductViewModel>> GetAllProduct();

        //product feature
        Task<List<ProductViewModel>> GetFeaturedProducts(int take);

        Task<List<ProductViewModel>> GetLatestProducts(int take);

        Task<List<ProductViewModel>> GetBestSellerProducts(int take);

        //review
        Task<int> CreateReview(ReviewCreateRequest request);

        Task<List<ReviewViewModel>> GetAllReviews(int productId);

        #region Api Other

        // Image
        //Task<int> AddImage(int productId, ProductImageCreateRequest request);

        //Task<int> RemoveImage(int imageId);

        //Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);

        //Task<ProductImageViewModel> GetImageById(int imageId);

        //Task<List<ProductImageViewModel>> GetListImages(int productId);

        //Task<int> Delete(int productId);

        #endregion Api Other
    }
}