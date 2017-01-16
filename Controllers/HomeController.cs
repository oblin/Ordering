using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ordering.Models;

namespace Ordering.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var orders = new List<Order>()
            {
                new Order { Name = "Dones id elit non", LastUpdated = DateTime.Now.AddDays(-2), Description = "Test 1" },
                new Order { Name = "Maecenas sed diam eget risus", LastUpdated = DateTime.Now.AddDays(-5), Description = "Test 2" },
                new Order { Name = "Maecenas sed", LastUpdated = DateTime.Now.AddDays(-7), Description = "Test 3" }
            };

            ViewBag.Orders = orders;
            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Vote(int Id)
        {
            return ViewComponent("SurveyWidget", new { productId = Id });
        }
    }
}
