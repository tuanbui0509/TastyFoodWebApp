using System;
using System.Collections.Generic;
using System.Text;

namespace TastyFoodSolution.ViewModels.Common
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T resultObj, IList<string> roles)
        {
            IsSuccessed = true;
            ResultObj = resultObj;
            Roles = roles;
        }

        public ApiSuccessResult(T resultObj)
        {
            IsSuccessed = true;
            ResultObj = resultObj;
        }

        public ApiSuccessResult()
        {
            IsSuccessed = true;
        }
    }
}