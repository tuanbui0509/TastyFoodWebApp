using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyFoodSolution.ViewModels.Catalog.Products
{
    internal class ReviewUpdateRequest
    {
        public int Id { set; get; }
        public Guid UserId { set; get; }
        public int ProductId { set; get; }
        public DateTime ReviewDate { set; get; }
        public string Comment { set; get; }
        public int Rate { set; get; }
    }
}