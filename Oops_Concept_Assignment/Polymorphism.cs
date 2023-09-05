using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept_Assignment
{
    internal class Polymorphism
    {
    }

    class Animal 
    {       
        public virtual void makeSound()
        {
            Console.WriteLine("animals making sound");
        }
    }

    class Tiger : Animal 
    { 
        //overriding or runtime polymorphism or dynamic
        //same method name with same parameter
         public override void makeSound()
        {
            Console.WriteLine("roar....");
        }

        public void consume(string hunt)
        {
            Console.WriteLine("consuming "+hunt);

        }


        //overloading or compile-Time polymorphism or static
        //same method name with diff numbers of parameters
        public void consume(string str1,string str2) 
        {
            Console.WriteLine("consuming "+str1+" and "+str2);
        }

    }
    class Dog : Animal 
    {
        public override void makeSound() 
        {
            Console.WriteLine("Bark....");
        }
    }
}
