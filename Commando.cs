using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.models
{
    public class Commando
    {
        public string name;
        public string codeName;
        public string[] tools = new string[5];
        public string status;
        public Commando(string Name, string CodeName, string[] Tools, string Status)
        {
            name = Name;
            codeName = CodeName;
            tools = Tools;
            status = Status;
        }

        public void Walk()
        {
            Console.WriteLine("The soldier goes");
            this.status = "walking";
        }

        public void Hide()
        {
            Console.WriteLine("The soldier is hiding ");
            this.status = "hiding";
        }

        public void Attack()
        {
            Console.WriteLine($"The soldier: {this.name} attacks");
        }
    }
}
