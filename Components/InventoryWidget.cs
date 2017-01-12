using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ordering.Components
{
    public class InventoryWidget: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var inventory = new List<InventoryItem>()
            {
                new InventoryItem() { Name = "Banner", Count = 8 },
                new InventoryItem() { Name = "Markers", Count = 3 },
                new InventoryItem() { Name = "Jacket", Count = 14 },
                new InventoryItem() { Name = "Hoodie", Count = 1 }
            };

            return View(inventory);
        }
    }

    public class InventoryItem
    {
        public InventoryItem() {}

        public int Count { get; set; }
        public string Name { get; set; }
    }
}