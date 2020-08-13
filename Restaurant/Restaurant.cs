using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LunchBuddies.Restaurant
{
    class Restaurants
    {

        private List<string> RestaurantNames = new List<string>() { "West Coast Taco", "Bojangles", "Yada Deli", "Blackhorse Brewery" };

        public string Name { get; set; }

        public Restaurants()
        {
            var random = new Random();
            Name = RestaurantNames[random.Next(RestaurantNames.Count)];
        }
    }
}