using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2C2B
{
    class Program
    {
        void Main(string[] args)
        {
            greetigs();

            // calling a function with parameters
            greet("Becky"); // -> Hello, Becky!
            greet("John"); // -> Hello, John!

            greet(name : "Becky");
            greet(name: "John");

            int increment(int a)
            {
                return a + 1;
            }

            Console.WriteLine(increment(100));  // -> 11
        }

        void greetigs()
        {
            // block of code to be executed
            Console.WriteLine("Hello!");
        }

        void greet(string name)
        {
            // block of code to be executed
            Console.WriteLine(string.Format("Hello {0}!", name));
        }

        int increment(int a)
        {
            return a + 1;
        } 
    }
}
