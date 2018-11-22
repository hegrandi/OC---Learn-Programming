using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3C3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Clap your hands!");
            }

            var i = 1;
            Console.WriteLine("Clap your hands!");

            var i = 2;
            Console.WriteLine("Clap your hands!");

            var i = 3;
            Console.WriteLine("Clap your hands!");

            var i = 4;
            Console.WriteLine("Clap your hands!");

            var i = 5;
            Console.WriteLine("Clap your hands!");

            string[] basket = { "apple", "orange", "banana" };

            for (int fruit = 0; fruit < basket.Length; fruit++)
            {
                Console.WriteLine(basket[fruit]);
            }

            Dictionary<string, int> myTeam = new Dictionary<string, int>();
            myTeam.Add("Developers", 5);
            myTeam.Add("Designers", 2);

            for (int index = 0; index < myTeam.Count; index++)
            {
                var team = myTeam.ElementAt(index);
                var itemKey = team.Key;
                var itemValue = team.Value;
                Console.WriteLine("We have {0} {1}", itemValue, itemKey);
            }

            var numberOfTrees = 0;

            while (numberOfTrees < 10)
            {
                numberOfTrees += 1;
                Console.WriteLine("I planted {0} trees", numberOfTrees);
            }
            Console.WriteLine("I have a forest!");

            var theSunIsUp = true;

            while (theSunIsUp)
            {
                Console.WriteLine("Stay awake...forever!");
            }
            Console.WriteLine("Go to sleep!");

            //var pushUpGoal = 10;
            //do
            //{
            //    Console.WriteLine("Push up!");
            //    pushUpGoal -= 1;
            //} while (pushUpGoal > 0);

            var pushUpGoal = 0;
            while (pushUpGoal > 0)
            {
                Console.WriteLine("Push up!");
                pushUpGoal -= 1;
            }

            // do/while loop
            var pushUpGoal = 0;
            do
            {
                Console.WriteLine("Push up!");
                pushUpGoal -= 1;
            } while (pushUpGoal > 0);

            for (int i = 0; i < 10; i++)
            {
                // instruction set 1
                if (i == 2 || i == 5)
                {
                    continue;
                }
                // instruction set 2
            }

            string[] basket = { "apple", "orange", "banana" };

            for (int fruit = 0; fruit < basket.Length; fruit++)
            {
                if (basket[fruit] == "orange")
                {
                    Console.WriteLine("I have{0}!", basket[fruit]);
                    break;
                }
            }
        }
    }
}
