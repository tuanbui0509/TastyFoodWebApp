using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Carts;
using TastyFoodSolution.ViewModels.Common;

namespace TastyFoodSolution.ApiIntergration
{
    public interface IOrderApiClient
    {
        Task<ApiResult<bool>> CreateOrder(CheckoutRequest request);

        Task<CheckoutRequest> GetById(int orderId);
    }
}