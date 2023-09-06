using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_PracticeProb2
{
    internal class InterfaceDemo
    {
    }
    interface Shape
    {
        public void Area();
    }

    class Circle : Shape 
    {
        public void Area() 
        {
            double r = 5;
            double Result = 3.14 * r;
            Console.WriteLine("Area of circle: " + Result);
        }
    }
    class Rectangle : Shape 
    {
        public void Area()
        {
            double l = 5, b=6;
            double Result = l * b;
            Console.WriteLine("Area of Rectangle: " + Result);
        }
    }
    class Triangle : Shape 
    {
        public void Area()
        {
            double b = 5,h=3.6;

            double Result = (b * h)/2;
            Console.WriteLine("Area of Triangle: " + Result);
        }
    }
}
