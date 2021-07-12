using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.Application.Dtos;

namespace TastyFoodSolution.Application.Catolog.Products.Dto.Public
{
    public class GetProductPagingRequest:PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
