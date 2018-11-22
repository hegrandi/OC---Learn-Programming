using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2C5
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare a variable in global scope
            var root = "I'm available to all lines of code within my context";

            if (2 == 4 / 2)
            {
                // declare a variable within a scope of "if" statement
                const string spy = "I'm a spy";
                Console.WriteLine(root); // Ok
                Console.WriteLine(spy); // Ok 
            }

            // attempt to access a variable declared within "if" statement
            Console.WriteLine(spy); // Error 

            void helpfulFunction()
            {
                const string anotherSpy = "I'm another spy";
                Console.WriteLine(root); // Ok
                Console.WriteLine(anotherSpy); // Ok 

                // attempt to access a variable declared within an external "if" statement
                Console.WriteLine(spy); // Error  
            }

            // attempt to access a variable declared within a function
            Console.WriteLine(anotherSpy); // Error  
            Console.WriteLine(root); // Ok 

            var unicorn = new Unicorn();

            Console.WriteLine(unicorn.power); // Ok  

            unicorn.height = 180; // Error
            unicorn.sleep(); // Error
            unicorn.run(); // Ok
        }

    }

    class Unicorn
    {
        // properties
        int height = 170;
        double power = double.PositiveInfinity;

        // methods
        void sleep()
        {
            const int minutesToSleep = 120;

            // attempt to access
            Console.WriteLine(minutesToSleep); // Ok  
            Console.WriteLine(minutesToRun); // Error  
            Console.WriteLine(height); // Ok  
            Console.WriteLine(power); // Ok   
        }

        void run()
        {
            const int minutesToRun = 60;

            // attempt to access
            Console.WriteLine(minutesToSleep); // Error  
            Console.WriteLine(minutesToRun); // Ok  
            Console.WriteLine(height); // Ok  
            Console.WriteLine(power); // Ok    
        }
    }

    class Unicorn2
    {
        public class PublicClass
        {

        }

        private class PrivateClass
        {

        }

        // properties
        private int height = 170;
        public double power = double.PositiveInfinity;

        // methods
        private void sleep()
        {
        }

        public void run()
        {
        }
    }

    public class PublicClass
    {
        public bool publicProperty = true;

        internal int internalProperty = 0;

        private const string fileprivateProperty = "Hello!";

        private void privateMethod()
        {
        }
    }
} 
