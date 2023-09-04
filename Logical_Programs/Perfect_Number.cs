using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Perfect_Number
    {
        public static void checkPerfectNum()
        {
                Console.Write("Enter a positive integer: ");
            int number=Convert.ToInt32(Console.ReadLine());

                if ( number <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    return;
                }

                // Calculate the sum of divisors excluding the number itself
                int sum = 0;
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }

                // Check if the number is a Perfect Number
                if (sum == number)
                {
                    Console.WriteLine(number +" is a Perfect Number.");
                }
                else
                {
                    Console.WriteLine(number+ " is not a Perfect Number.");
                }
            
        }

    }
}

