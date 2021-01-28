using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchbuddy1 = new LunchBuddy("Will", "K");
            lunchbuddy1.eat();
            lunchbuddy1.eat("Pizza");
            lunchbuddy1.eat(new List<LunchBuddy> 
            { 
                new LunchBuddy("Thor", "ofAsgard"),
                new LunchBuddy("Tony", "Stark")
            });

            lunchbuddy1.eat("Pizza", new List<LunchBuddy>
            {
                new LunchBuddy("Natasha", "Romanov"),
                new LunchBuddy("Steve", "Rodgers")
            });

        }
    }
}
