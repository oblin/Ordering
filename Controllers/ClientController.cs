using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ordering.Models;

namespace Ordering.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult NewClient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewClient(Client newClient)
        {
            if (ModelState.IsValid)
            {
                // save updated data to database

                return RedirectToAction("Index", "Home");
            }
            else 
            {
                return View(newClient);
            }
        }
    }
}
