using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ordering.Models;

namespace Ordering.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult NewOrder()
        {
            var newOrder = new Order();
            newOrder.Products = new List<OrderProductVM>()
            {
                new OrderProductVM() { Id = 1, Name = "Hoodie" },
                new OrderProductVM() { Id = 2, Name = "T-Shirt" },
                new OrderProductVM() { Id = 3, Name = "Table Cloth" },
            };
            return View(newOrder);
        }

        [HttpPost]
        public IActionResult NewOrder(Order newOrder)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
