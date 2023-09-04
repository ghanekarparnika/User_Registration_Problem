using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Coupon_Number
    {
        public static void checkCoupon()
        {
           
          
                Console.Write("Enter the number of distinct coupon numbers (N): ");

            int N=Convert.ToInt32(Console.ReadLine());

                if ( N <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    return;
                }

                int[] coupons = new int[N];
                int count = 0;
                HashSet<int> distinctCoupons = new HashSet<int>();

                while (distinctCoupons.Count < N)
                {
                    int randomCoupon = GenerateRandomCoupon(N);
                    count++;

                    if (!distinctCoupons.Contains(randomCoupon))
                    {
                        distinctCoupons.Add(randomCoupon);
                        Console.WriteLine($"Coupon {randomCoupon} collected.");
                    }
                }

                Console.WriteLine("Total random numbers needed to have all distinct coupons:" +count);
            }

            // Function to generate a random coupon number
            static int GenerateRandomCoupon(int N)
            {
                Random random = new Random();
                return random.Next(1, N + 1);
            }
        

    }
}

