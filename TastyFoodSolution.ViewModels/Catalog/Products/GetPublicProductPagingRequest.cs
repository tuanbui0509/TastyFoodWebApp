using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Common;

namespace TastyFoodSolution.ViewModels.Catolog.Products
{
    public class GetPublicProductPagingRequest:PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
