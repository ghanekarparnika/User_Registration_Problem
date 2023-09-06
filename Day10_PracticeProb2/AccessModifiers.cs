using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_PracticeProb2
{
    internal class AccessModifiers
    {
        private int id = 1;
        public string Name = "parnika";
        protected long PhoneNo = 9945231456;
        internal int Age = 24;
        
        public void disp()
        {
            Console.WriteLine("Private acess Modifier accesible in the same class only: "+id);
            Console.WriteLine("protected accessible in same: "+PhoneNo);
            Console.WriteLine("internal accessible in same class:"+Age);
            Console.WriteLine("public is accessible in same class:" + Name);
        }
    }
    class Child : AccessModifiers 
    {
        public void disp1()
        {
            Console.WriteLine("protected only accessible in same class and child class: "+PhoneNo);
            Console.WriteLine("internal accessible in child class:" + Age);
            Console.WriteLine("public is accessible in child class:" + Name);
        }
    }
    class Myaclass
    {
        public void disp3()
        {
          
           AccessModifiers a=new AccessModifiers();
           // Console.WriteLine("protected only accessible in same class and child class: " + a.PhoneNo);
            Console.WriteLine("internal accessible in other class in same project:" + a.Age);
            Console.WriteLine("public accessible in other class in same project:" + a.Name);
        }
    }
}
