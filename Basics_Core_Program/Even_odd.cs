using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_Core_Program
{
    internal class Even_odd
    {
        public static void check()
        {
            Console.WriteLine("Enter a number: ");

            // Read the user input as a string
            int number = Convert.ToInt32(Console.ReadLine());

                // Check if the number is even or odd
                if (number % 2 == 0)
                {
                    Console.WriteLine(number +" is even.");
                }
                else
                {
                    Console.WriteLine(number+" is odd.");
                }
           
        }
    }
}
