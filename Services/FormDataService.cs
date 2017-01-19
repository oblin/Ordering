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
        List<SelectListItem> GetStages();
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

        public List<SelectListItem> GetStages()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() { Value = "1", Text = "Intake" },
                new SelectListItem() { Value = "2", Text = "Inventory Fulfillment" },
                new SelectListItem() { Value = "3", Text = "Billing" },
                new SelectListItem() { Value = "4", Text = "Prep for Shipping" },
                new SelectListItem() { Value = "5", Text = "Shipped" },
                new SelectListItem() { Value = "6", Text = "Delivery Confirmation" },
                new SelectListItem() { Value = "7", Text = "On Hold" }
            };
        }
    }
}