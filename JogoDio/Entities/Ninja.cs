using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JogoDio.Entities
{
    internal class Ninja : Hero
    {
        public Ninja()
        {
        }

        public Ninja(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public override string Attack()
        {
            return Name + "atacou furtivamente!";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return Name + " lançou um ataque super efetivo com bônus de ataque de " + bonus;
            }
            else
            {
                return Name + " lançou uma ataque fraco com bônus de ataque de " + bonus;
            }

        }
    }
}
