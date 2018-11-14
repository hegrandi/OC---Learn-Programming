using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1C4
{
    class Program
    {
        static void Main()
        {
            var myTodoList = new NewTodoList();
            myTodoList.Add("Wake up");
            myTodoList.Add("Shower");
            myTodoList.Add("Have breakfast");
            myTodoList.Add("Go to work");
            myTodoList.Display();
            myTodoList.MarkAsDone("Wake up");
            myTodoList.Remove("Have breakfast");
            myTodoList.Rename("Shower", "Take bath");
            myTodoList.MarkAsDone("Take bath");
            myTodoList.MarkAsDone("Go to work");
        }

        class NewTodoList
        {
            public Dictionary<string, bool> TodoList = new Dictionary<string, bool>();

            // Add a string at the end of the slice
            public void Add(string taskName)
            {
                TodoList.Add(taskName, false);
            }

            // Display prints all the tasks of the list
            public void Display()
            {
                Console.WriteLine("Here is the list");

                foreach (var task in TodoList)
                {
                    if (task.Value == true)
                        Console.WriteLine("Task {0} is completed", task.Key);
                    else if (task.Value == false)
                        Console.WriteLine("Task {0} is completed", task.Key); 
                }
            }

            // Remove a task 
            public void Remove(string taskName)
            {
                TodoList.Remove(taskName);
            }

            // Rename a task
            public void Rename(string oldTaskName, string taskName)
            {
                var dic = TodoList.Where(d => d.Key == oldTaskName).FirstOrDefault();
                TodoList.Add(taskName, dic.Value);
                TodoList.Remove(dic.Key);
            }

            // MarkAsDone marks a task as done
            public void MarkAsDone(string taskName)
            {
                TodoList[taskName] = true;
            }
        }
    }
}
