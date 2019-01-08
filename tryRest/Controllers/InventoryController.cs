using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using tryRest.Models;
using tryRest.Services;

namespace tryRest.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryServices services;
        public InventoryController(IInventoryServices services)
        {
            this.services = services;
        }

        [HttpPost]
        [Route("AddInventoryItems")]
        public ActionResult<InventoryItems> AddInventoryItems(InventoryItems items)
        {
            var inventoryItems = services.AddInventoryItems(items);

            if (inventoryItems ==null)
            {
                return NotFound();
            }

            return inventoryItems;
        }

        [HttpGet]
        [Route("GetInventoryItems")]
        public ActionResult<Dictionary<string, InventoryItems>> GetInventoryItems()
        {
            var inventoryItems = services.GetInventoryItems();

            if (inventoryItems.Count == 0)
            {
                return NotFound();
            }

            return inventoryItems;
        }
    }
}