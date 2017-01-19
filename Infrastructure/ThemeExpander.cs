using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Razor;

namespace Ordering.Infrastructure
{
    public class ThemeExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            string theme = "Alternate";
            return new List<string>()
            {
                "/Themes/" + theme + "/{1}/{0}.cshtml",
                "/Themes/" + theme + "/Shared/{0}.cshtml",
                "/Themes/Default/{1}/{0}.cshtml",
                "/Themes/Default/Shared/{0}.cshtml",
            };
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
            // 主要目的在於提供計算 View location 是否改變與發布
            // throw new NotImplementedException();
        }
    }
}