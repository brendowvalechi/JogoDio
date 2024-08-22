using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDio.Entities
{
    internal class BlackWizard : Wizard
    {
        public BlackWizard()
        {
        }

        public BlackWizard(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
    }
}
