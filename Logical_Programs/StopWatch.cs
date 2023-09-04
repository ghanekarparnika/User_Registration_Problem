using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class StopWatch
    {
        public static void play()
        {

                Console.WriteLine("Stopwatch Program");
                Console.WriteLine("Press 'S' to start the stopwatch.");
                Console.WriteLine("Press 'E' to end the stopwatch.");
                Console.WriteLine("Press 'Q' to quit the program.");

                Stopwatch stopwatch = new Stopwatch();

                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    Console.WriteLine(); // Move to the next line after key press

                    switch (key.KeyChar)
                    {
                        case 'S':
                        case 's':
                            if (!stopwatch.IsRunning)
                            {
                                stopwatch.Start();
                                Console.WriteLine("Stopwatch started.");
                            }
                            else
                            {
                                Console.WriteLine("Stopwatch is already running.");
                            }
                            break;

                        case 'E':
                        case 'e':
                            if (stopwatch.IsRunning)
                            {
                                stopwatch.Stop();
                                TimeSpan elapsed = stopwatch.Elapsed;
                                Console.WriteLine($"Stopwatch stopped. Elapsed time: "+elapsed.TotalSeconds+" seconds");
                            }
                            else
                            {
                                Console.WriteLine("Stopwatch is not running.");
                            }
                            break;

                        case 'Q':
                        case 'q':
                            return;

                        default:
                            Console.WriteLine("Invalid input. Press 'S' to start, 'E' to end, or 'Q' to quit.");
                            break;
                    }
                }
            
        }


    }
}

