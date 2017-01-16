using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ordering.Services;

namespace Ordering.Components
{
    public class InventoryWidget: ViewComponent
    {
        private IInventoryService _inventoryService;

        public InventoryWidget(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int threshold = 10)
        {
            return View(_inventoryService.GetInventoryLevels(threshold));
        }
    }

    public class InventoryItem
    {
        public InventoryItem() {}

        public int Count { get; set; }
        public string Name { get; set; }
    }
}
