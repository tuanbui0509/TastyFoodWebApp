using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyFoodSolution.ViewModels.Catalog.Products
{
    public class ReviewCreateRequest
    {
        public Guid UserId { set; get; }

        public string Comment { set; get; }
        public int Rate { set; get; }
        public int ProductId { set; get; }
    }
}