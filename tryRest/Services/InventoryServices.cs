using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
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

       

        KeyValuePair<string, InventoryItems> IInventoryServices.GetItem(int id)
        {
           return inventoryItems.First(x => x.Value.Id == id);
        }
    }
}
