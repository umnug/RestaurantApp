using FreshMvvm;
using PropertyChanged;
using RestaurantApp.Models;
using RestaurantApp.Services;
using System.Collections.Generic;

namespace RestaurantApp.PageModels
{
    [ImplementPropertyChanged]
    class MenuPageModel : FreshBasePageModel
    {
        readonly IApiService apiService;

        public List<MenuItem> MenuItems { get; set; }

        public MenuPageModel(IApiService apiService)
        {
            this.apiService = apiService;
        }

        public async override void Init(object initData)
        {
            base.Init(initData);

            MenuItems = await apiService.GetMenuItems();
        }
    }
}
