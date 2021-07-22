using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.Application.System.Users;
using TastyFoodSolution.Data.EF;
using TastyFoodSolution.Data.Entities;
using TastyFoodSolution.ViewModels.Carts;
using TastyFoodSolution.ViewModels.System.Users;

namespace TastyFoodSolution.Application.Catolog.Orders
{
    public class OrderSevice : IOrderSevice
    {
        private readonly TastyFoodDBContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IUserService _userService;

        // Tokens
        private readonly IConfiguration _config;

        public OrderSevice(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager,
            IConfiguration config, IUserService userService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
            _userService = userService;
        }

        public OrderSevice(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<int> Create(CheckoutRequest request)
        {
            //var userId = await _userService.GetById(request.UserId);
            var user = await _userManager.FindByIdAsync(request.UserId.ToString());
            var orderDetails = new List<OrderDetail>();
            foreach (var item in request.OrderDetails)
            {
                orderDetails.Add(new OrderDetail()
                {
                    Quantity = item.Quantity,
                    ProductId = item.ProductId
                });
            }

            var order = new Order()
            {
                ShipAddress = request.Address,
                OrderDate = DateTime.Now,
                ShipEmail = request.Email,
                ShipPhoneNumber = request.PhoneNumber,
                ShipName = request.Name,
                UserId = request.UserId,
                Status = Data.Enums.OrderStatus.InProgress,
                OrderDetails = orderDetails,
                AppUser = user
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order.Id;
        }

        public Task<CheckoutRequest> GetById(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}