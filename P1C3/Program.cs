using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1C3
{
    class Program
    {
        void Main(string[] args)
        {
            var myTodoList = new TodoList();
            myTodoList.Add("Wake up");
            myTodoList.Add("Shower");
            myTodoList.Add("Have breakfast");
            myTodoList.Add("Go to work");
            myTodoList.Display();
            myTodoList.Remove(2);
            myTodoList.Display();
            myTodoList.Rename(1, "Take bath");
            myTodoList.Display();
        }
    }

    class TodoList
    {
        public List<string> tasks = new List<string>();

        //Add appends a new task to the list of tasks
        public void Add(string taskName)
        {
            tasks.Add(taskName);
        }

        //Display prints all the tasks of the list
        public void Display()
        {
            Console.WriteLine("Here is the list");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine("Task N° {0} is {1}", i, tasks[i]);
            }
        }

        //Remove a string from the slice at the specified index
        public void Remove(int taskName)
        {
            tasks.RemoveAt(taskName);
        }

        // Rename a task
        public void Rename(int taskID, string taskName)
        {
            tasks[taskID] = taskName;
        }
    }
}
