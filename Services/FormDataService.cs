using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ordering.Components;

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
    }
}