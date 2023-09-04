using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_Core_Program
{
    internal class Swap_Numbers
    {

        

        public static void swap()
        {
            int a = 2;
            int b = 4;
            Console.WriteLine("before swap a:"+a+" b:"+b);
            int temp=b;
            b= a;
            a= temp;
            Console.WriteLine("after Swap a:"+a+"b:"+b);



        }
    }
}
