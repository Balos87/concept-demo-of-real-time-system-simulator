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
            Thread clockThread = new Thread(new ThreadStart(Clock));
            clockThread.Start();

            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting program.");
                    break;
                }
                // Additional commands can be handled here

            }
            // Joining the clockthread before exiting
            clockThread.Join();
        }
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