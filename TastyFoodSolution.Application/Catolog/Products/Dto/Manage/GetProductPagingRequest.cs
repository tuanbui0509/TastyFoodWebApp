using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.Application.Dtos;

namespace TastyFoodSolution.Application.Catolog.Products.Dto.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string KeyWord { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
