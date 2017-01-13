using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ordering.Components
{
    public class SurveyWidget: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int productId)
        {
            var products = new List<SurveyProduct>()
            {
                new SurveyProduct() { Id = 1, Name = "Banners", VoteCount = 8 },
                new SurveyProduct() { Id = 2, Name = "Posters", VoteCount = 1 },
                new SurveyProduct() { Id = 3, Name = "Jackets", VoteCount = 4 },
                new SurveyProduct() { Id = 4, Name = "Hoodies", VoteCount = 2 }
            };

            if (productId > 0)
            {
                products.FirstOrDefault(x => x.Id == productId).VoteCount += 1;
                return View("Results", products);
            }
            
            return View(products);
        }
    }

    public class SurveyProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VoteCount { get; set; }
    }
}