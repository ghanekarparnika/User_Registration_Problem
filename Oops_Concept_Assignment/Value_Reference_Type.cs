using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept_Assignment
{
    internal class Value_Reference_Type
    {

        public string Name;
        public void  ValueType()
        {
            int x = 10;
            Console.Write("x: "+x);
            Console.WriteLine("------------>Declaring and initializing an int (value type) variable");
            int y = x;
            Console.Write("int y=x;");
            Console.WriteLine("------------>Creating a copy of the value of x");
            x = 40;
            Console.Write("x=40;");
            Console.WriteLine("-------------->Modifying x");
            Console.Write("x: " + x);
            Console.WriteLine("-------------->Output: x: 20");
            Console.Write("y: " + y);
            Console.WriteLine("--------------->Output: y: 10 (y remains unchanged)");


        }
    }
}
