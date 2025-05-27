using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    public class Weapon
    {
        public string name;
        public string manufacturer;
        public int numberOfBalls;

        public Weapon (string Name, string Manufacturer, int NumberOfBalls)
        {
            name = Name;
            manufacturer = Manufacturer;
            numberOfBalls = NumberOfBalls;
        }

        public void Shoot()
        {

        }

    }
}
