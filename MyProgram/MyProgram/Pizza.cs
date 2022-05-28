using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    internal class Pizza
    {
        string bread;
        string sauce;
        string cheese;
        string topping;

        public Pizza(string bread)
        {
            this.bread = bread;
        }
        public Pizza(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;   
        }
        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }
}
