using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2C1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ongoingAllowance = 500;
            var savings = 1000;

            savings = savings + 100;
            // short version
            savings += 100;

            ongoingAllowance = ongoingAllowance - 50;
            var numberOfDaysToSave = (5000 - ongoingAllowance) / 500;
            ongoingAllowance = ongoingAllowance + (30 - 10) * 7;

            var text = "A wonderful string that consists of various var charecters";
            var numberOfVowels = 0;
            var percentage = 0.0;

            const int  numberOfWeekdays = 7;
            const string myFavouriteFood = "Icecream";

            var numberOfPets = 1;
            var currentSeason = "Winter";

            //numberOfWeekdays = numberOfWeekdays + 1;  // Error
            //myFavouriteFood = "Cake";  // Error

            numberOfPets = 3; // Ok
            currentSeason = "Summer";  // Ok
        }
    }
}
