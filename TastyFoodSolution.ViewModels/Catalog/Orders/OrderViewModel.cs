using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.Data.Entities;
using TastyFoodSolution.Data.Enums;

namespace TastyFoodSolution.ViewModels.Catalog.Orders
{
    public class OrderViewModel
    {
        public int Id { set; get; }
        public DateTime OrderDate { set; get; }
        public Guid UserId { set; get; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipEmail { set; get; }
        public string ShipPhoneNumber { set; get; }
        public OrderStatus Status { set; get; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}