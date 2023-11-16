using System;
using System.Threading;

namespace DemoRealTimeSystemSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Real-Time system simulator started.");
            Console.WriteLine("Type 'exit' to stop the program.");

            // Creating and starting the clock thread.
            // The thread is instanciated the same way as a class.
            Thread clockThread = new Thread(new ThreadStart(Clock));
            // Starts the Thread
            clockThread.Start();

            // A while loop that lets the user type what ever they want,
            // untill they tipe 'exit'.
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting program.");
                    break;
                }
                else if (userInput.ToLower() == "clear")
                {
                    Console.Clear();
                    Console.WriteLine("The screen has been cleared.");
                }
                else if (userInput.ToLower() == "check system")
                {
                    Console.WriteLine("The system is up and running");
                }
                else if (userInput.ToLower() == "commands")
                {
                    Console.WriteLine("Commands:\n\tTo exit: 'exit'\n\tTo clear prompt: clear\n\tTo system check: check system");
                }
                else
                {
                    Console.WriteLine($"Command unknown: '{userInput}'. Please type commands to see a list of commands availble.");
                }
                // Additional commands can be handled here

            }
            // Joining the clockthread before exiting
            //By joining, what happens: When the main thread exit, it wait untill next thread will run its course before shutting down.
            clockThread.Join();
        }
        //Method for displaying the time. Its in a whileloop and will continue-forever.
        //Simply because there is no end-function set.
        //The Thread.Sleep makes the thread tick again after set parameter, in this case: 1sec.
        static void Clock()
        {
            while (true)
            {
                Console.WriteLine($"Current Time: {DateTime.Now.ToLongTimeString()}");
                Thread.Sleep(1000); // Sleeps for 1second
            }
        }
    }
}