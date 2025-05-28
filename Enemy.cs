using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    public class Enemy
    {
        private string name;
        private int life = 100;
        private bool status = true;
        public Enemy (string Name)
        {
            name = Name;
        }

        public void Shout()
        {
            Console.WriteLine("I am an enemy");
        }


    }

    public class EnemyFactory
    {
        public List<Enemy> enemys = new List<Enemy>();
        private List<string> enemysNames = new List<string>
        {
            "Khalid",
            "Yusuf",
            "Nabil",
            "Tariq",
            "Fadi",
            "Rami",
            "Samir",
            "Omar",
            "Hassan",
            "Adil",
            "muchamad"
        };
        public void AddEnemy()
        {
            Random rand = new Random();
            string name = enemysNames[rand.Next(11)];
            Enemy newEnemy = new Enemy(name);
            enemys.Add(newEnemy);
        }.
        
        

    }
}
