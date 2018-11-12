using System; 

namespace P1C1
{
    class program
    {
        static void Main(string[] args)
        {
            string currentTask = string.Empty;
            //Assign a value to the currentTask
            //TODO: change the value with *your* current task!
            currentTask = "writing a course";
            //Print a welcome message including the value of the currentTask variable
            PrintCurrentTask(currentTask);
        }

        //PrintCurrentTask prints a welcome message customized with the provided task
        public static void PrintCurrentTask(string task)
        {
            //WriteLine is a *function* that does the Job of printing whatever you set 
            Console.WriteLine("Welcome! I'm glad you are " + task);
        }
    }
}
