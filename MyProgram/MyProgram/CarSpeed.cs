using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class CarSpeed
    {
        //class CarSpeed getters & setter
        private int speed;

        public CarSpeed(int speed)
        {
            Speed = speed;
        }
        public int Speed
        {
            get { return speed; } //read
            set                   //writable
            { 
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }       
            }
        }
    }
}
