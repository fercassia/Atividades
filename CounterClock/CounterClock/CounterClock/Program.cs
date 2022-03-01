using System;
using CounterClock.CounterClock;

namespace CounterClock
{
    public class Program
    {
        static void Main(string[] args)
        {
            var start = true;
            var startStopWatch = new OrderStopWatch();

            Console.WriteLine("Hello Welcome to the stopwatch!");

            while (start)
            {
                Console.WriteLine("\nType:\ns - start\np - pause\nr - restart\ne - exit");
                var choice = Console.ReadLine();

                if (choice.Equals("e"))
                {
                    Console.WriteLine("\nClosing de stopwatch!");
                    start = false;
                }
                else
                {
                    startStopWatch.Choices(choice);
                }
            }
        }
    }
}
