using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName;
        public string LastName;
        

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void eat()
        {
            var myRestaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {myRestaurant.Name}");
        }

        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food}");
        }

        public void eat(List<LunchBuddy> companions)
        {
            
            var myRestaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} ate at {myRestaurant.Name} with the following companions:");
            foreach(var name in companions)
            {
                Console.Write($" { name.FirstName} { name.LastName} ");
                Console.WriteLine();
            }
        }

        public void eat(string food, List<LunchBuddy> companions)
        {
            var myRestaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} ate {food} at {myRestaurant.Name} with the following companions:");
            foreach (var name in companions)
            {
                Console.Write($" { name.FirstName} { name.LastName} ");
                Console.WriteLine();
            }
        }

    }
}
