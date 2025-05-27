using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
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

        }

        public void Hide()
        {

        }

        public void Attack()
        {

        }
    }
}
