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

            Console.WriteLine("=====================================================");

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            if (IsValidLastName(lastName))
            {
                Console.WriteLine("Valid last name!");
            }
            else
            {
                Console.WriteLine("Invalid last name. It should start with a capital letter and have a minimum of 3 characters.");
            }

            Console.WriteLine("=====================================================");
            Console.WriteLine("Enter your email address: ");
            Console.WriteLine("Email should be in this format: abc.xyz@bl.co.in");
            string emailAddress = Console.ReadLine();

            if (IsValidEmail(emailAddress))
            {
                Console.WriteLine("Valid email address!");
            }
            else
            {
                Console.WriteLine("Invalid email address.");
            }

            Console.WriteLine("=====================================================");
            Console.WriteLine("Enter your mobile number:");
            string mobileNumber = Console.ReadLine();

            if (IsValidMobileNumber(mobileNumber))
            {
                Console.WriteLine("Valid mobile number!");
            }
            else
            {
                Console.WriteLine("Invalid mobile number. Please enter in the format: CountryCode 10DigitNumber");
            }

            Console.WriteLine("=====================================================");
            Console.WriteLine("Enter your password:");
            Console.WriteLine("1.Password should consist minimum 8 characters");
            string password = Console.ReadLine();

            if (IsValidPassword(password))
            {
                Console.WriteLine("Valid password!");
            }
            else
            {
                Console.WriteLine("Invalid password. Please check: if your password consist 1.mini 8 characters");
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

        //UC2
        static bool IsValidLastName(string lastName)
        {
            // Define the regular expression pattern for a valid last name.
            string pattern = @"^[A-Z][A-Za-z]{2,}$";

            // Use Regex.IsMatch to check if the input matches the pattern.
            return Regex.IsMatch(lastName, pattern);
        }

        //UC3

        static bool IsValidEmail(string email)
        {

            // abc.xyz@bl.co.in  
            // Define the regular expression pattern for a valid email.
            string pattern = @"^[a-zA-Z]+(\.[a-zA-Z]+)?@(bl)\.(co)(\.in)?$"; // Explanation below

            // Use Regex.IsMatch to check if the input matches the pattern.
            return Regex.IsMatch(email, pattern);
        }


        //UC4-

        static bool IsValidMobileNumber(string mobile)
        {
            // Define a regular expression pattern for a mobile number.
            string pattern = @"^\d{2} \d{10}$"; 

            // Use Regex.IsMatch to check if the input matches the pattern.
            return Regex.IsMatch(mobile, pattern);
        }

        //UC5-

        static bool IsValidPassword(string password)
        {
            // Define a regular expression pattern for a mobile number.
            string pattern = @"^.{8,}$"; 

            // Use Regex.IsMatch to check if the input matches the pattern.
            return Regex.IsMatch(password, pattern);
        }


    }
}
