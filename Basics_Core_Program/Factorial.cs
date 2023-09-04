using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_Core_Program
{
    internal class Factorial
    {
        public static void test4()
        {
            Console.Write("Enter a number to find its prime factors: ");
            int N=Convert.ToInt32(Console.ReadLine());
            if (N > 1)
            {
                Console.WriteLine($"Prime factors of {N}:");
                FindPrimeFactors(N);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number greater than 1.");
            }
        }

        static void FindPrimeFactors(int N)
        {
            for (int i = 2; i * i <= N; i++)
            {
                while (N % i == 0)
                {
                    Console.WriteLine(i);
                    N /= i;
                }
            }

            // If N is still greater than 1, it is a prime factor itself
            if (N > 1)
            {
                Console.WriteLine(N);
            }
        }


        }
    }

