using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantApp.Models;
using Refit;
using RestaurantApp.Services.Interfaces;
using System.Net.Http;

namespace RestaurantApp.Services
{
    public class ApiService : IApiService
    {
        IApiDefs api;

        public ApiService()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("http://10.0.2.2:8915") // Android loopback
                //BaseAddress = new Uri("http://localhost:8915") // UWP Friendly
            };

            api = RestService.For<IApiDefs>(client);
        }

        public async Task<List<MenuItem>> GetMenuItems()
        {
            return await api.GetMenuItems();
        }
    }
}
