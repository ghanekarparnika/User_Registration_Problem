using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_Core_Program
{
    internal class Vowel_Consonant
    {
        public static void check1() 
        {
           
                Console.WriteLine("Enter a single alphabet: ");

                // Read the user input as a string
                string input = Console.ReadLine();

                // Check if the input is a single character
                if (input.Length == 1)
                {
                    char character = input[0];

                    // Convert the character to lowercase to handle both cases
                    char lowerChar = Char.ToLower(character);

                    // Check if the character is a vowel or consonant
                    if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
                    {
                        Console.WriteLine(character+" is a vowel.");
                    }
                    else
                    {
                        Console.WriteLine(character+ " is a consonant.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a single alphabet.");
                }
            
        }

    }
}

