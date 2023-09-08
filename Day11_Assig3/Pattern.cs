using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Assig3
{
    internal class Pattern
    {
        public static void pattern1() 
        {
            int n = 8; // Number of rows

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void pattern2() 
        {
            int n = 7; // Number of rows
            int m = 7; // Number of columns

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == m)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  "); // Print spaces for inner part
                    }
                }
                Console.WriteLine();
                Console.WriteLine();// Move to the next row
            }
        }
    }
}
