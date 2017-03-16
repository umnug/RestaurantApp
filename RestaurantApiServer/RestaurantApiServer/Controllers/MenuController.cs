using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantApiServer.Models;
using Newtonsoft.Json;
using RestaurantApiServer.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantApiServer.Controllers
{
    // This will become "/api/Menu" from reflection.
    [Route("api/[controller]")]
    public class MenuController : Controller
    {
        readonly IMenuItemsService menuItemService;

        public MenuController(IMenuItemsService menuItemService)
        {
            this.menuItemService = menuItemService;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<MenuItem>> Get()
        {
            return await menuItemService.GetMenuItems();
        }

        [HttpPost]
        public async Task<IEnumerable<MenuItem>> Post([FromBody] List<MenuItem> items)
        {
            return await menuItemService.SaveMenuItems(items);
        }
    }
}
