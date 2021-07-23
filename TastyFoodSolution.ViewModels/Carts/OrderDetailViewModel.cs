using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyFoodSolution.ViewModels.Carts
{
    public class OrderDetailViewModel
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}