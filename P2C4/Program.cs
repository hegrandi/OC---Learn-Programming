using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2C4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr;
            string[] fruits = { "apple", "orange", "banana" }; // Ok
            string[] newArr = { "apple", "orange", 10 }; // Error

            string[] myArrayOfStrings; // declaration by specifying the type of elements (short version)  

            string[] fruit = { "apple", "orange", "banana" }; // declaration by specifying the type AND assigning elements

            int[] myVariableArray = { 10, 12 };
            myVariableArray = new int[] { 0, 2 };

            const int[] myConstantArray = { 10, 12 };
            myConstantArray = new int[] { 0, 2 }; // Error

            int[] myArray = { 10, 12 };
            myArray = new int[] { 11, 12 };
            //myArray[0] = 13;
            Console.WriteLine(myArray[0]);

            List<int> list = new List<int>(myArray);

            list.Add(15);
            list.Insert(2, 14);
            list.RemoveAt(1);

            myArray = list.ToArray();

            int[] myAdrray = { 10, 12 };
            Console.WriteLine(myAdrray.Length);
            list.Insert(myAdrray.Length, 14);

            string[] basket = { "apple", "orange", "banana" };
            for (var i = 0; i < basket.Length; i++)
            {
                Console.WriteLine(basket[i]);
            }

            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("Jenny", 34);
            ages.Add("Livia", 28);
            ages.Add("Paul", 31);
            ages.Add("jenny", 21);

            Console.WriteLine(ages["Jenny"]);
            Console.WriteLine(ages["jenny"]);

            const string kJenny = "Jenny";
            const string kLivia = "Livia";
            const string kPaul = "Paul";

            // use constants as keys
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("Jenny", 34);
            ages.Add("Livia", 28);
            ages.Add("Paul", 31);

            // access an element
            Console.WriteLine(ages[kJenny]); // -> 34 

            Dictionary<int, string> weekdays = new Dictionary<int, string>();
            weekdays.Add(1, "Sunday");
            weekdays.Add(3, "Tuesday");

            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("Jenny", 34); // Ok
            ages.Add("Livia", 28); // Ok
            ages.Add("Paul", 31); // Ok  

            Dictionary<string, int> mixedInfo = new Dictionary<string, int>();
            mixedInfo.Add("Jenny", 34); // Ok  
            mixedInfo.Add("Livia", 28); // Ok  
            //mixedInfo.Add("Paul", "Designer");  // Error 

            Dictionary<string, int> confusingInfo = new Dictionary<string, int>();
            confusingInfo.Add("Jenny", 34); // Ok  
            confusingInfo.Add("Livia", 28); // Ok  
            //confusingInfo.Add(10, 31); // Error 


            Dictionary<string, string> professions = new Dictionary<string, string>(); // [String: String]
            professions.Add("Livia", "Business owner");
            professions.Add("Business owner", "Developer");
            professions.Add("Paul", "Designer");

            Dictionary<bool, string> truth = new Dictionary<bool, string>(); // [Bool: String]
            truth.Add(true, "Truth");
            truth.Add(false, "Lie");

            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            myDictionary.Add("Developers", 5);
            myDictionary.Add("Designers", 2);

            Dictionary<string, int> myDictionary;
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            Console.WriteLine(myDictionary["Developers"]); // -> 5 
            myDictionary["Developers"] = 6;

            Console.WriteLine(myDictionary["Developers"]); // -> 6 

            myDictionary["Managers"] = 2; // ["Developers": 6, "Designers": 2, "Managers": 2]

            myDictionary.Remove("Designers"); // ["Developers": 6, "Managers": 2]

            Console.WriteLine(myDictionary.Count); // -> 2 

            Dictionary<string, int> myTeam = new Dictionary<string, int>(); 
            myTeam.Add("Developers", 5);
            myTeam.Add("Designers", 2);

            foreach (var team in myTeam)
            {
                Console.WriteLine(string.Format("We have {0} {1}", team.Value, team.Key));
            }
        }
    }
}
