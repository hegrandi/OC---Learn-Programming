using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1C2
{
    class program
    {
        static void Main(string[] args)
        {
            var myTodoList = new List<string>();

            myTodoList.Add("Wake up");
            myTodoList.Add("Shower");
            myTodoList.Add("Have breakfast");
            myTodoList.Add("Go to work");
            displayListOfString(myTodoList);

            myTodoList.RemoveAt(2);
            displayListOfString(myTodoList);

            myTodoList[1] = "Take Bath";
            displayListOfString(myTodoList);

            //myTodoList.Add("Work good");
            //myTodoList.Add("Eat");
            //myTodoList.Add("Back to work");
            //displayListOfString(myTodoList);  
        }

        public static void displayListOfString(List<string> myTodoList)
        {
            Console.WriteLine("Here is the list");
            for (int i = 0; i < myTodoList.Count; i++)
            {
                Console.WriteLine("Task N° {0} is {1}", i, myTodoList[i]);
            }
        }
    }
}
