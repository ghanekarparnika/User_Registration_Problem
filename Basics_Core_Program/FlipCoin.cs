using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_Core_Program
{
    internal class FlipCoin
    {
        public static void test()
        {
            Console.Write("Enter the number of times to flip the coin: ");

            int numberofFlips=Convert.ToInt32(Console.ReadLine());
            if (numberofFlips > 0)
            {
                int headsCount = 0;
                int tailsCount = 0;
                Random random = new Random();

                for (int i = 0; i < numberofFlips; i++)
                {
                    // Generate a random value between 0 and 1
                    double randomValue = random.NextDouble();

                    // If the value is less than 0.5, consider it as heads; otherwise, tails
                    if (randomValue < 0.5)
                    {
                        headsCount++;
                       
                    }
                    else
                    {
                        tailsCount++;
                    }
                }

                // Calculate the percentage of heads and tails
                double headsPercentage = (double)headsCount / numberofFlips * 100;
                double tailsPercentage = (double)tailsCount / numberofFlips * 100;

                Console.WriteLine("count of head:"+headsCount);
                Console.WriteLine("Percentage of Heads:"+headsPercentage);
                Console.WriteLine("cpont of tail:"+tailsCount);
                Console.WriteLine("Percentage of Tails:"+tailsPercentage);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }

    }
}
