﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastyFoodSolution.ViewModels.Carts
{
    public class CheckoutRequest
    {
        public Guid UserId { set; get; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public List<OrderDetailViewModel> OrderDetails { set; get; } = new List<OrderDetailViewModel>();
    }
}