using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Assig3
{
    internal class UniqueElements
    {
        public static void printUnique()
        {
            int[] arr = { 1, 2, 3, 4, 2, 3, 5, 6, 7, 1 };
            Console.Write("Unique Elements are: ");

            for (int i = 0; i < arr.Length; i++) 
            {
                bool Isunique = true;
                for (int j = i+1;j < arr.Length;j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Isunique = false;
                        break;
                    }
                }
            if(Isunique) 
                {
                    Console.Write(arr[i]+" ");
                }
            }
        }
    }
}
