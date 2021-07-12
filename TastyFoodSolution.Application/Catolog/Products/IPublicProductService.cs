using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.Application.Catolog.Products.Dto;
using TastyFoodSolution.Application.Catolog.Products.Dto.Public;
using TastyFoodSolution.Application.Dtos;

namespace TastyFoodSolution.Application.Catolog.Products
{
    public interface IPublicProductService
    {
        public Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
