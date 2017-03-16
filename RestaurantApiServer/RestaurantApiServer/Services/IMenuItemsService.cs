using RestaurantApiServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantApiServer.Services
{
    public interface IMenuItemsService
    {
        Task<List<MenuItem>> GetMenuItems();
        Task<List<MenuItem>> SaveMenuItems(List<MenuItem> items);
    }
}
