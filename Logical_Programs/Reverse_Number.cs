using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Reverse_Number
    {
        public static void CheckReverese()
        {
         
           
                Console.Write("Enter a positive integer: ");
            int number=Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                    return;
                }

                int originalNumber = number;
                int reverse = 0;

                while (number > 0)
                {
                    int remainder = number % 10;
                    reverse = reverse * 10 + remainder;
                    number = number / 10;
                }

                Console.WriteLine("Reverse of " +originalNumber+" is "+ reverse);
            
        }

    }
}

