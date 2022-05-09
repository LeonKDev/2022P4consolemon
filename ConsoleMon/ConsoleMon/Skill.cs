using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class Skill
    {
        float damage = 0;
        float energyCost = 0;
        string name = "Lick";

        public void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(5);
            target.TakeDamage(5);

        }
    }


}
