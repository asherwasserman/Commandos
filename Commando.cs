﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.models
{
    public class Commando
    {
        private string name;
        public string codeName { get; set;}
        private string[] tools = new string[5];
        private string status;
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
            Console.WriteLine("The soldier is hiding");
            this.status = "hiding";
        }

        public virtual void Attack()
        {
            Console.WriteLine("Commando soldier attacks");
        }

        public string SayName()
        {
            Console.WriteLine("What is your rank? ");
            string runk = Console.ReadLine()!;

            if (runk == "General")
            {
                return this.name;
            }
            else if (runk == "colonel")
            {
                return this.codeName;
            }
            else
            {
                string name = "Cannot accept the name without required classification";
                return name;
            }
        }

        public class AirCommando : Commando
        {
            public AirCommando (string Name, string CodeName, string[] Tools, string Status)
                : base (Name, CodeName, Tools, Status) { }

            public override void Attack()
            {
                Console.WriteLine("Air commando soldier attacks!");
            }

        }

        public class SeaCommando : Commando
        {
            public SeaCommando(string Name, string CodeName, string[] Tools, string Status)
                : base(Name, CodeName, Tools, Status) { }

            public override void Attack()
            {
                Console.WriteLine($"Sea commando soldier attacks!");
            }

        }
    }
}
