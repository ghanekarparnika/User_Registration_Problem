using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Problem
{
   public class User_Registration
    {

        public static void addUserInfo()
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            if (IsValidFirstName(firstName))
            {
                Console.WriteLine("Valid first name!");
            }
            else
            {
                Console.WriteLine("Invalid first name. It should start with a capital letter and have a minimum of 3 characters.");
            }

          

        }


        //UC1
        static bool IsValidFirstName(string firstName)
        {
            // Define the regular expression pattern for a valid last name.
            string pattern = @"^[A-Z][A-Za-z]{2,}$";

            // Use Regex.IsMatch to check if the input matches the pattern.
            return Regex.IsMatch(firstName, pattern);
        }


    }
}
