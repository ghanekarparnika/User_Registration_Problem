using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_Core_Program
{
    internal class Harmonic_Number
    {
        public static void test3()
        {

            Console.Write("Enter the value of N (positive integer): ");
            if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
            {
                double harmonicValue = CalculateHarmonicNumber(N);
                Console.WriteLine($"The {N}th Harmonic Number is: {harmonicValue}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer for N.");
            }


            static double CalculateHarmonicNumber(int N)
            {
                double harmonicValue = 0.0;

                for (int i = 1; i <= N; i++)
                {
                    harmonicValue += 1.0 / i;
                }

                return harmonicValue;
            }



        }
    }
}
