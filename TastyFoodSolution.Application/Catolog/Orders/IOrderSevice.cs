﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.ViewModels.Carts;
using TastyFoodSolution.ViewModels.Catalog.Orders;

namespace TastyFoodSolution.Application.Catolog.Orders
{
    public interface IOrderSevice
    {
        Task<int> Create(CheckoutRequest request);

        Task<OrderViewModel> GetById(int orderId);

        //Task<CheckoutRequest> GetAllOrder(int productId);
    }
}