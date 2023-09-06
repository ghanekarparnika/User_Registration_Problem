using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_PracticeProb2
{
    internal class Constructor_Types
    {
        public int Value { get; set; }

        // Default Constructor
        public Constructor_Types()
        {
            Value = 0; // Default initialization
            Console.WriteLine("Default Constructor");
        }

        // Parameterized Constructor
        public Constructor_Types(int value)
        {
            Value = value;
            Console.WriteLine("Parameterized Constructor");
        }

        // Copy Constructor
        public Constructor_Types(Constructor_Types other)
        {
            Value = other.Value;
            Console.WriteLine("Copy Constructor");
        }
    }
}
