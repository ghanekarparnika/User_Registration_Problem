using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Assig3
{
    internal class Frequency
    {
        public static void calFrequency()
        {
            int[] arr = { 1, 2, 3, 4, 2, 3, 5, 6, 7, 1 };

            int[] frequency = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (frequency[i] == -1)
                {
                    continue; // Element already counted as a duplicate
                }

                int count = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        frequency[j] = -1; // Mark as a duplicate
                    }
                }

                frequency[i] = count;
            }
            Console.WriteLine("Element\tFrequency");

            for (int i = 0; i < arr.Length; i++)
            {
                if (frequency[i] != -1)
                {
                    Console.WriteLine(arr[i]+ "\t"+frequency[i]);
                }
            }
        }
    }
}
