using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        string name = "Lick";
        

        Elements element = Elements.Fire;

        public void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);

        }

        internal Skill()
        {

        }
        internal Skill(Skill copyFrom)
        {
            this.damage = copyFrom.damage;
            this.energyCost = copyFrom.energyCost;
            this.name = copyFrom.name;
        }
    }
}
