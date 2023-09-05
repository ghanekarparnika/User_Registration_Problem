using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept_Assignment
{
    internal class Inheritance
    {

    }

    class Vehicle 
    {
        public void start()
        {
            Console.WriteLine("Start engine..");
        }

        public void stop() 
        {
            Console.WriteLine("stop engine.."); 
        }
    }

    class Car : Vehicle
    {
        public void travel()
        {
            Console.WriteLine("travelling in the car");
        }
    }

    class Train : Vehicle
    {
        public void travel() 
        {
            Console.WriteLine("travelling in the train");
        }
    }

    class Aeroplane : Vehicle
    {
        public void travel()
        {
            Console.WriteLine("travelling in the Plane");
        }
    }

}
