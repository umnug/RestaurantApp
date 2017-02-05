using FreshMvvm;
using Newtonsoft.Json;
using PropertyChanged;
using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.PageModels
{
    [ImplementPropertyChanged]
    class MenuPageModel : FreshBasePageModel
    {
        public List<MenuItem> MenuItems { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);

            MenuItems = JsonConvert.DeserializeObject<List<MenuItem>>(
                "[ { \"Name\": \"All American Cheeseburger \", \"Description\": \"American cheese, lettuce, tomato, pickles, mayo & mustard\", \"Price\": \".99\", \"ThumbnailUri\": \"http://bit.ly/2kg8DYx\" }, { \"Name\": \"Utah Cheeseburger\", \"Description\": \"American cheese, lettuce, tomato, pickles, & fry-sauce\", \"Price\": \".99\", \"ThumbnailUri\": \"http://bit.ly/2kg8DYx\" }, { \"Name\": \"Mushroom Bacon Swiss\", \"Description\": \"Mushrooms, mushroom sauce, bacon, swiss, lettus, tomato & mayo\", \"Price\": \".39\", \"ThumbnailUri\": \"http://bit.ly/2kg8DYx\" }, { \"Name\": \"Bacon Ranch Burger\", \"Description\": \"Bacon, American cheese, lettuce, tomato, onion & ranch dressing\", \"Price\": \".99\", \"ThumbnailUri\": \"http://bit.ly/2kg8DYx\" }, { \"Name\": \"Cheesesteake Burger\", \"Description\": \"Steak, pepperjack, swiss, peppers, onion, mushrooms, with horseradish & mayo\", \"Price\": \".69\", \"ThumbnailUri\": \"http://bit.ly/2kg8DYx\" }]");
        }
    }
}
