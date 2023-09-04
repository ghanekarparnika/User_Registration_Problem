using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_Core_Program
{
    internal class Largest_Num
    {
        public static void check3() 
        {
          
                Console.WriteLine("Enter three numbers: ");

                // Read three numbers as input
                Console.Write("Enter the first number: ");
            int number1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int number2=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Third number: ");
            int number3=Convert.ToInt32(Console.ReadLine());    



            // Find the largest among the three numbers
            int largest = number1;

                if (number2 > largest)
                {
                    largest = number2;
                }

                if (number3 > largest)
                {
                    largest = number3;
                }

                Console.WriteLine($"The largest number among {number1}, {number2}, and {number3} is: {largest}");
            
        }

    }
}

