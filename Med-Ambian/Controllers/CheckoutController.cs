using DataModels.Models.Cart;
using DataModels.Models.Order;
using Dtos.CartDtos;
using Med_Ambian.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.CartService;
using Services.OrderServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Med_Ambian.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly IOrderService _orderService;
        public CheckoutController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        public async Task<IActionResult> Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cart");
            await _orderService.Create(cart);
            return View(cart.Select(x=>new CartDto { 
            ProductId=x.ProductId,
            ProductName=x.Name,
            Quantity=x.ProductCount,
            Total=x.Price*x.ProductCount
            }).ToList());
        }
    }
}
