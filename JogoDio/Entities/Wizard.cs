using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDio.Entities
{
    internal class Wizard : Hero
    {
        public Wizard ()
        {
        }

        public Wizard (string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public override string Attack()
        {
            return Name + "lançou uma magia!";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return Name + " lançou uma magia super efetiva com bônus de ataque de " + bonus;
            }
            else
            {
                return Name + " lançou uma magia fraca com bônus de ataque de " + bonus;
            }
            
        }
    }
}
