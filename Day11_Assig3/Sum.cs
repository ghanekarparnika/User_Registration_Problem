using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Assig3
{
    internal class Sum
    {
        public static void add()
        {
            int number = 1234;
            int temp = number;
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10; // Get the last digit and add it to the sum
                number /= 10;      // Remove the last digit from the number
            }

            Console.WriteLine("sum of all digits in "+temp +" is: "+sum);

        }
        
        
    }
}
