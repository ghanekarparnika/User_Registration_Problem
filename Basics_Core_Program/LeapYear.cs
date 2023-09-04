using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Leap Year
a. I/P -> Year, ensure it is a 4 digit number.
b. Logic -> Determine if it is a Leap Year.
c. O/P -> Print the year is a Leap Year or not.*/

namespace Basics_Core_Program
{
    internal class LeapYear
    {
        public static void test1()
        {

            Console.Write("Enter a year (4 digits): ");
            int year=Convert.ToInt32(Console.ReadLine());
           
                if (IsLeapYear(year))
                {
                    Console.WriteLine(year +" is a Leap Year.");
                }
                else
                {
                    Console.WriteLine(year+" is not a Leap Year.");
                }
           
        }

        // Function to check if a year is a leap year
        static bool IsLeapYear(int year)
        {
            // A year is a leap year if it is divisible by 4
            // If it is also divisible by 100, it must be divisible by 400 to be a leap year
            return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);
        }
    }
   

        
    
}
