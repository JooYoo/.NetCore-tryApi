using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
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

        [HttpGet]
        [Route("GetItem/{id}")]
        public ActionResult<InventoryItems> GetInventoryItem(int id)
        {
            var inventoryItem = services.GetItem(id);

            if (inventoryItem.Value == null)
            {
                return NotFound();
            }
            return inventoryItem.Value;
        }

    }
}