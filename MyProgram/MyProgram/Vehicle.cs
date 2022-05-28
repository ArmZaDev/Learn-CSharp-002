using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    internal class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("The vehicle is moving!");
        }
    }
    class CarA : Vehicle
    {
        public int wheels = 4;
    }
    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}
