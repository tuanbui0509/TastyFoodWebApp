using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Catalog.Orders;
using TastyFoodSolution.ViewModels.Common;
using TastyFoodSolution.ViewModels.System.Users;

namespace TastyFoodSolution.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);

        Task<ApiResult<bool>> Register(RegisterRequest request);

        Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);

        Task<List<UserVm>> GetUsers();

        Task<ApiResult<UserVm>> GetById(Guid id);

        Task<List<OrderViewModel>> GetOrdersByUser(Guid userId);

        //Task<ApiResult<bool>> Delete(Guid id);
    }
}