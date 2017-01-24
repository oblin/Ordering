using System;
using System.IO;
using System.Linq.Expressions;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ordering.Helpers
{
    public static class CutomHtmlHelpers
    {
        public static IHtmlContent LabeledTextBoxFor<TModel, TResult>(
            this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression,
            string labelText)
        {
            var label = htmlHelper.LabelFor(expression, labelText);
            var textbox = htmlHelper.TextBoxFor(expression, new { @class = "form-control" });

            using (var writer = new StringWriter())
            {
                label.WriteTo(writer, HtmlEncoder.Default);
                textbox.WriteTo(writer, HtmlEncoder.Default);

                return new HtmlString(writer.GetStringBuilder().ToString());
            }
        }
    }
}
