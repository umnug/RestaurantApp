using Refit;
using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Services.Interfaces
{
    interface IApiDefs
    {
        [Get("/api/menu")]
        Task<List<MenuItem>> GetMenuItems();
    }
}
