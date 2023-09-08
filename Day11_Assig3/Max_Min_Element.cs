using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day11_Assig3
{
    internal class Max_Min_Element
    {
        public static void printMax_Min()
        {
            int[] arr = { 12, 45, 23, 67, 89, 34, 100, 3 };

            if (arr.Length == 0)
            {
                Console.WriteLine("The array is empty.");
                return;
            }

            int max = arr[0]; // Initialize max to the first element
            int min = arr[0]; // Initialize min to the first element

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i]; // Update max if a larger element is found
                }

                if (arr[i] < min)
                {
                    min = arr[i]; // Update min if a smaller element is found
                }
            }


            Console.WriteLine("Maximum element: " + max);
            Console.WriteLine("Minimum element: " + min);
        
        }
    }
}
