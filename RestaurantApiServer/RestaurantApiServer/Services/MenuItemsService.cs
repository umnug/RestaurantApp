using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantApiServer.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace RestaurantApiServer.Services
{
    public class MenuItemsService : IMenuItemsService
    {
        readonly RestaurantContext context;

        public MenuItemsService(RestaurantContext context)
        {
            this.context = context;
        }
        
        public async Task<List<MenuItem>> GetMenuItems()
        {
            //return JsonConvert.DeserializeObject<List<MenuItem>>("[ { \"Name\": \"All American Cheeseburger \", \"Description\": \"American cheese, lettuce, tomato, pickles, mayo & mustard\", \"Price\": \".99\", \"ThumbnailUri\": \"http://bit.ly/2kg8DYx\" }, { \"Name\": \"Utah Cheeseburger\", \"Description\": \"American cheese, lettuce, tomato, pickles, & fry-sauce\", \"Price\": \".99\", \"ThumbnailUri\": \"http://bit.ly/2kg8DYx\" }, { \"Name\": \"Mushroom Bacon Swiss\", \"Description\": \"Mushrooms, mushroom sauce, bacon, swiss, lettus, tomato & mayo\", \"Price\": \".39\", \"ThumbnailUri\": \"http://bit.ly/2kg8DYx\" }, { \"Name\": \"Bacon Ranch Burger\", \"Description\": \"Bacon, American cheese, lettuce, tomato, onion & ranch dressing\", \"Price\": \".99\", \"ThumbnailUri\": \"http://bit.ly/2kg8DYx\" }, { \"Name\": \"Cheesesteake Burger\", \"Description\": \"Steak, pepperjack, swiss, peppers, onion, mushrooms, with horseradish & mayo\", \"Price\": \".69\", \"ThumbnailUri\": \"http://bit.ly/2kg8DYx\" }]");

            return await context.MenuItems.ToListAsync();
        }

        public async Task<List<MenuItem>> SaveMenuItems(List<MenuItem> items)
        {
            context.AddRange(items);

            await context.SaveChangesAsync();

            return items;
        }
    }
}
