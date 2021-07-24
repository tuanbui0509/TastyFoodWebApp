using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TastyFoodSolution.Application.System.Users;
using TastyFoodSolution.Data.EF;
using TastyFoodSolution.Data.Entities;
using TastyFoodSolution.ViewModels.Carts;
using TastyFoodSolution.ViewModels.Catalog.Orders;

namespace TastyFoodSolution.Application.Catolog.Orders
{
    public class OrderSevice : IOrderSevice
    {
        private readonly TastyFoodDBContext _context;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IUserService _userService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        // Tokens
        private readonly IConfiguration _config;

        public OrderSevice(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            RoleManager<AppRole> roleManager,
            IConfiguration config, IUserService userService, IHttpContextAccessor httpContextAccessor, TastyFoodDBContext dBContext)
        {
            _context = dBContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<int> Create(CheckoutRequest request)
        {
            var userName = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByNameAsync(userName);

            var orderDetails = new List<OrderDetail>();

            var order = new Order()
            {
                ShipAddress = request.Address,
                OrderDate = DateTime.Now,
                ShipEmail = request.Email,
                ShipPhoneNumber = request.PhoneNumber,
                ShipName = request.Name,
                UserId = user.Id,
                Status = Data.Enums.OrderStatus.InProgress,
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            foreach (var item in request.OrderDetails)
            {
                orderDetails.Add(new OrderDetail()
                {
                    Quantity = item.Quantity,
                    ProductId = item.ProductId,
                    Price = item.Price,
                    OrderId = order.Id
                });
            }
            foreach (var item in orderDetails)
            {
                _context.OrderDetails.Add(item);
            }

            await _context.SaveChangesAsync();
            return order.Id;
        }

        public async Task<OrderViewModel> GetById(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            List<OrderDetail> orderDetails = await _context.OrderDetails.Where(x => x.OrderId == orderId).ToListAsync();
            //foreach (var item in orderDetails)
            //{
            //    _context.OrderDetails.Add(item);
            //}
            var orderViewModel = new OrderViewModel()
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                UserId = order.UserId,
                ShipName = order.ShipName,
                ShipAddress = order.ShipAddress,
                ShipEmail = order.ShipEmail,
                ShipPhoneNumber = order.ShipPhoneNumber,
                Status = order.Status,
                OrderDetails = orderDetails
            };
            return orderViewModel;
        }
    }
}