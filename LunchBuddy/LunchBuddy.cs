using System;
using System.Collections.Generic;
using System.Text;
using LunchBuddies.Restaurant;

namespace LunchBuddies.LunchBuddy
{
    class LunchBuddys
    {
        public string FirstName{ get; } 
        public string LastName{ get; }

        public LunchBuddys(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Eat()
        {
            var restaurant = new Restaurants();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name}.");
        }

        public void Eat(string typeOfFood)
        {
            var restaurant = new Restaurants();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} eating {typeOfFood}.");
        }

        public void Eat(List<LunchBuddys> companions)
        {
            var restaurant = new Restaurants();
            var firstName = new List<string> { };
            foreach (var companion in companions)
            {
                var name = companion.FirstName;
                firstName.Add(name);
            }
            string buddies = string.Join(",", firstName);
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} eating with {buddies}");

        }

            public void Eat(string typeOfFood, List<LunchBuddys> companions)
        {
            var restaurant = new Restaurants();
            var firstName = new List<string> { };
            foreach (var companion in companions)
            {
                var name = companion.FirstName;
                firstName.Add(name);
            }
            string buddies = string.Join(",", firstName);
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} eating {typeOfFood} with {buddies}");
        }

    }
}
