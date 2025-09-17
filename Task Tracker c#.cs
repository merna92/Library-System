
using System.Diagnostics;

namespace TaskTracker
{
    internal class Program
    {
        //add task
        //view all tasks
        //combleted tasks
        //delete task
        //exsit

        static string[] tasks = new string[100];
        static int TaskIndex = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************Welcome To My Task Tracker**********************************************");
            
            Console.WriteLine("1: add task");
            Console.WriteLine("2: view all tasks");
            Console.WriteLine("3: combleted tasks");
            Console.WriteLine("4: delete task");
            Console.WriteLine("5: exsit");
            while (true)
            {
                Console.WriteLine("Enter Your Choose From 1 To 5:");
                
                string userchoose = Console.ReadLine();
                switch (userchoose)
                {
                    case "1":
                        //add task
                        AddTasks();
                        break;
                    case "2":
                        //view task
                        ViewTasks();
                        break;
                    case "3":
                        //Mark Complete
                        MarkComplete();
                        break;
                    case "4":
                        //remove task
                        Removetasks();
                        break;
                    case "5":
                        //exsit task
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Enter Number From 1 To 5 Only ");
                        break;
                }
            }
          
        }
        private static void AddTasks()
        {
            Console.WriteLine("Enter Task Title ");
            string TaskTitle = Console.ReadLine();
            tasks[TaskIndex] = TaskTitle;
            Console.WriteLine("Task Added Succesfully");
            TaskIndex++;

        }

        private static void ViewTasks()

        {
            Console.WriteLine("Tasks List:");
            for (int i = 0; i <TaskIndex; i++) 
            {
                Console.WriteLine($"{i+1}Task Title:{tasks[i]}");
            }

        }
        private static void MarkComplete()
        {
            Console.WriteLine("Enter Task Number :");
            int TaskId =int.Parse(Console.ReadLine());
            tasks[TaskId] = tasks[TaskId] + " completed";

        }
        private static void Removetasks()
        {
            Console.WriteLine("Enter Task Number :");
            int TaskId = int.Parse(Console.ReadLine());
            tasks[TaskId] = " ";


        }
    }

}
