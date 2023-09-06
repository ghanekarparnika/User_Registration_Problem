using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept_Assignment
{
    internal class Inheritance_Types
    {
        public void Type()
        {
            Console.WriteLine("1.Single level Inheritance---->one parent class have only one child class\n2.Multilevel Inheritance---->one parent class have one child class and that child class can further have one child class and so on..." +
                "\n3.Hierarchical Inheritance---->one parent class have multiple child classes\n4.Multiple Inheritance---->Not allow in .Net but we can achive it by using Interfaces");
        }

    }


    //Single level inheritance
    class A
    {

    }
    class B : A
    {
    }
    //multilevel inheritance

    class X
    { 
    }
    class   Y : X  
    {
    }
    class Z : Y
    {
    }

    //Hierarchical inheritance-one parent class have multiple child class

    class P { }
    class Q : P { }
    class R : P { }
    class S : P { }

    //multiple inheritance not allow in .net

}
