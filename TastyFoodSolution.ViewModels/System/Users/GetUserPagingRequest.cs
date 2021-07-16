using System;
using System.Collections.Generic;
using System.Text;
using TastyFoodSolution.ViewModels.Common;

namespace TastyFoodSolution.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}