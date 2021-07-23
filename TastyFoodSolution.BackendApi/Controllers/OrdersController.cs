using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyFoodSolution.Application.Catolog.Orders;
using TastyFoodSolution.ViewModels.Carts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TastyFoodSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderSevice _orderService;

        public OrdersController(IOrderSevice orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{orderId}")]
        public async Task<ActionResult> GetById(int orderId)
        {
            var order = await _orderService.GetById(orderId);
            if (order == null)
                return BadRequest("Cannot find product");
            return Ok(order);
        }

        [HttpPost]
        public async Task<ActionResult> CreateOrder([FromBody] CheckoutRequest request)
        {
            var OrderId = await _orderService.Create(request);
            if (OrderId == 0)
                return BadRequest();
            var order = await _orderService.GetById(OrderId);
            return CreatedAtAction(nameof(GetById), new { id = OrderId }, order);
        }
    }
}