using TastyFoodSolution.ViewModels.Common;
using TastyFoodSolution.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TastyFoodSolution.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
    }
}