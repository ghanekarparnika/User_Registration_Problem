using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Prime_Number
    {
        public static void checkPrime()
        {
          
           
                Console.Write("Enter a positive integer: ");
             
                int number=Convert.ToInt32(Console.ReadLine());

                if (number <= 1)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer greater than 1.");
                    return;
                }

                bool isPrime = true;

                // Check for divisibility from 2 to the square root of the number
                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                // Check if the number is a Prime Number
                if (isPrime)
                {
                    Console.WriteLine(number +" is a Prime Number.");
                }
                else
                {
                    Console.WriteLine(number+" is not a Prime Number.");
                }
            
        }

    }
}

