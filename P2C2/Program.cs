using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2C2
{
    class Program
    {
        static void Main()
        {
            int count = 10;

            //float length   = 10.0F;
            //double width   = 10.0;

            float length = 1876.79F;
            double width = 1876.79797657;

            //double a = 1876.79797657765609870978709780987;
            //float b = 1876.79797657765609870978709780987F;
            //var c = 1876.79797657765609870978709780987;

            //var a = 10;
            //var b = 4;
            //var c = a / b;

            //double a = 10;
            //double b = 4;
            //var c = a / b;

            //var c = 10 / 4.0;
            //var c = 10 / 4;

            //int a  = 10;
            //double b = 4;
            //var c = a / b; // Error

            //int a = 10;
            //double b = 4;
            //var c = a / (int)b; // Ok

            int a = 10;
            double b = 4;
            var c = (double)a / b; // Ok

            var city = "New York";
            string movie = "Best ever";
            string pet;
            var emptyString = "";

            var firstFavoriteCity = "New York";
            var secondFavoriteCity = "Buenos Aires";
            //var favorites = firstFavoriteCity + secondFavoriteCity; // -> "New YorkBuenos Aires"

            var favorites = string.Format("My favorite cities are {0} and {1}", firstFavoriteCity, secondFavoriteCity); // -> "My favorite cities are New York and Buenos Aires" 

            var favoriteCity = "Buenos Aires";
            var numberOfTrips = 5;
            var story = string.Format("I've traveled to {0} {1} times!", favoriteCity, numberOfTrips); // -> "I've traveled to Buenos Aires 5 times!"
        }
    }
}
