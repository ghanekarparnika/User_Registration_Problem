using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Fibonacci
    {
        public static void fibo()
        {

            Console.Write("Enter the number of terms in the Fibonacci series: ");
            long n=Convert.ToInt64(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            int firstTerm = 0;
            int secondTerm = 1;

            Console.WriteLine("Fibonacci series of " +n+" terms:");

            // Print the first two terms
            Console.Write(firstTerm+" , "+secondTerm);

            for (int i = 2; i < n; i++)
            {
                // Calculate the next term
                int nextTerm = firstTerm + secondTerm;

                // Print the next term
                Console.Write(" , "+nextTerm);

                // Update the first and second terms for the next iteration
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }

            Console.WriteLine();

        }

    }
}

