using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    internal abstract class Vehicle2
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("The vehicle is moving!");
        }
    }
    class Car2 : Vehicle2
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    class Bicycle2 : Vehicle2
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat2 : Vehicle2
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}
