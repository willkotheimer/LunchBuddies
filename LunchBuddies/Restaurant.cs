using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        public string Name;
        private List<string> restaurantNames = new List<string> 
        {"Chicago Pizza", "Jets Pizza", "Firehouse Pizza","5 Points Pizza", "Tazikis", "Chickfila", "Pueblo Real"};
        public Restaurant()
        {
            Random rnd = new Random();
            int index = rnd.Next(restaurantNames.Count);
            Name = restaurantNames[index];
        }
    }
}
