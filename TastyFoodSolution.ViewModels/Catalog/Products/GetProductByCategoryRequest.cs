using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Common;

namespace TastyFoodSolution.ViewModels.Catolog.Products
{
    public class GetProductByCategoryRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}