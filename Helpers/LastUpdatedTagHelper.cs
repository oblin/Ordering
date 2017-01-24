using System;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Ordering.Helpers
{
    [HtmlTargetElementAttribute("span", Attributes = "last-updated")]
    public class LastUpdatedTagHelper : TagHelper
    {
        public DateTime LastUpdated { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (LastUpdated < DateTime.Now.AddDays(-3))
            {
                output.Attributes.SetAttribute("class", "text-danger pull-right");
            }
        }
    }
}
