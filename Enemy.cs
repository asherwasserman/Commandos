using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    public class Enemy
    {
        protected string name;
        protected int life = 100;
        protected bool status = true;
        public Enemy (string Name)
        {
            name = Name;
        }

        public void Shout()
        {
            Console.WriteLine("I am an enemy");
        }


    }
}
