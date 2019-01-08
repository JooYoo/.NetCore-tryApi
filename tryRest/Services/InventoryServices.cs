using System.Collections.Generic;
using tryRest.Models;

namespace tryRest.Services
{
    public class InventoryServices : IInventoryServices
    {
        private readonly Dictionary<string, InventoryItems> inventoryItems;
        public InventoryServices()
        {
            inventoryItems = new Dictionary<string, InventoryItems>();
        }

        public InventoryItems AddInventoryItems(InventoryItems items)
        {
            inventoryItems.Add(items.ItemName, items);

            return items;
        }

        public Dictionary<string, InventoryItems> GetInventoryItems()
        {
            return inventoryItems;
        }
    }
}
