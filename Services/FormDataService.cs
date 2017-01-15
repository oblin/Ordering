using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ordering.Components;
using Ordering.Models;

namespace Ordering.Services
{
    public interface IFormDataService
    {
        List<SelectListItem> GetLocations();
        List<SelectListItem> GetClientTypes();
    }

    public class FormDataService : IFormDataService
    {
        public List<SelectListItem> GetClientTypes()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() { Text = "Northeast", Value = "1" },
                new SelectListItem() { Text = "West", Value = "2" },
                new SelectListItem() { Text = "Downtown", Value = "3" },
                new SelectListItem() { Text = "Township", Value = "4" }
            };
        }

        public List<SelectListItem> GetLocations()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() { Text = "Small Business", Value = "S" },
                new SelectListItem() { Text = "Individual", Value = "I" },
                new SelectListItem() { Text = "Corporation", Value = "C" }
            };
        }

        public List<OrderProductVM> GetStages()
        {
            return new List<OrderProductVM>()
            {
                new OrderProductVM() { Id = 1, Name = "Intake" },
                new OrderProductVM() { Id = 2, Name = "Inventory Fulfillment" },
                new OrderProductVM() { Id = 3, Name = "Billing" },
                new OrderProductVM() { Id = 4, Name = "Prep for Shipping" },
                new OrderProductVM() { Id = 5, Name = "Shipped" },
                new OrderProductVM() { Id = 6, Name = "Delivery Confirmation" },
                new OrderProductVM() { Id = 7, Name = "On Hold" }
            };
        }
    }
}