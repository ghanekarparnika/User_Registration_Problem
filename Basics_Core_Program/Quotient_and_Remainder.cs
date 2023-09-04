using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_Core_Program
{
    internal class Quotient_and_Remainder
    {
        public static void test5()
        {
            Console.Write("Enter the dividend: ");
            int dividend=Convert.ToInt32(Console.ReadLine());

           
                Console.Write("Enter the divisor: ");
            int divisor=Convert.ToInt32(Console.ReadLine());
                if (divisor != 0)
                {
                    int quotient = dividend / divisor;
                    int remainder = dividend % divisor;

                    Console.WriteLine("Quotient: "+quotient);
                    Console.WriteLine("Remainder: "+remainder);
                }
                else
                {
                    Console.WriteLine("Invalid input for divisor. Please enter a non-zero integer.");
                }
          
           
        }


    }
}
    

