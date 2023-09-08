using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Assig3
{
    internal class DuplicateElements
    {
        public static int checkDouble_Elememts(int[] arr) 
        {
            int count = 0;
           // int [] cpy;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        Console.WriteLine("Duplicates element " + arr[i]);
                        break; // To avoid counting the same duplicate element multiple times
                    }
                }
            }

            return count;
        }
    }
}
