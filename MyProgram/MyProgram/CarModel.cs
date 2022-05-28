using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class CarModel
    {
        //class CarModel auto implemented properties
        /*
        string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        */

        public string Model { get; set; }

        public CarModel(string model)
        {
            this.Model = model;
        }
    }
}
