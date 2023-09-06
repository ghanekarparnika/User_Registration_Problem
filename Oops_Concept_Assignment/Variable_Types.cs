using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept_Assignment
{
    internal class Variable_Types
    {
        int a = 2;
        long phoneNo = 7745345289;
        double num = 20.89;
        float f = 45.7f;
        string str = "Hello";
        char letter = 'A';
        bool check = true;
        public void checkDataTypes() 
        {
            Console.WriteLine("DataType of "+a+" is "+a.GetType());
            Console.WriteLine("DataType of " + phoneNo + " is " + phoneNo.GetType());
            Console.WriteLine("DataType of " + num + " is " + num.GetType());
            Console.WriteLine("DataType of " + f + " is " + f.GetType());
            Console.WriteLine("DataType of " + str + " is " + str.GetType());
            Console.WriteLine("DataType of " + letter + " is " + letter.GetType());
            Console.WriteLine("DataType of " + check + " is " + check.GetType());
        }

    }
}
