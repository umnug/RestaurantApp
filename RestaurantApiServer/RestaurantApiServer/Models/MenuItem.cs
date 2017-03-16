using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApiServer.Models
{
    public class MenuItem
    {
        // EF will automatically make a property named Id the primary key.
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ThumbnailUri { get; set; }
    }
}
