using System.Collections.Generic;
using Ordering.Components;

namespace Ordering.Services
{
    public interface IInventoryService
    {
        List<InventoryItem> GetInventoryLevels(int threshold);       
    }
}