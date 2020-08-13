using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using LunchBuddies.LunchBuddy;
using LunchBuddies.Restaurant;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchBuddy1 = new LunchBuddys("Ronald", "Reagan");
            var lunchBuddy2 = new LunchBuddys("Pope", "John Paul");
            var lunchBuddy3 = new LunchBuddys("Tim", "Howard");
            var lunchBuddy4 = new LunchBuddys("Bob", "Hope");
            var lunchBuddy5 = new LunchBuddys("Morgan", "Freeman");

            List<LunchBuddys> companions = new List<LunchBuddys> { };

            companions.Add(lunchBuddy1);
            companions.Add(lunchBuddy2);
            companions.Add(lunchBuddy3);
            companions.Add(lunchBuddy4);
            companions.Add(lunchBuddy5);


            lunchBuddy2.Eat();
            lunchBuddy3.Eat("Burgers");
            lunchBuddy4.Eat(companions);
            lunchBuddy1.Eat("pizza", companions);




        }
    }
}
