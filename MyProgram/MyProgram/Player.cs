using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class Player
    {
        //class Player List of objects
        public String Username;

        public Player(string username)
        {
            Username = username;
        }
        public override string ToString()
        {
            return Username;
        }
    }
}
