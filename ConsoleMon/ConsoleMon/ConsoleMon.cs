using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    enum Elements
    {
        Fire,
        Water,
        Dark,
        Light
    }

    internal class ConsoleMon
    {
     internal int Health = 5;
     internal int Energy = 0;
     internal string name, MonsterType;
     internal int damage;
     

     

        Elements weakness = Elements.Water;

        List<Skill> Skills = new List<Skill>();

        public void TakeDamage(int Damage)
        {

            Health =- Damage;
        }

        public void DepleteEnergy(int energy)
        {
            Energy = -energy;
        }  

        internal ConsoleMon()
        {

        }

        internal ConsoleMon(ConsoleMon copyFrom)
        {
            this.name = copyFrom.name;
            this.Health = copyFrom.Health;
            this.Energy = copyFrom.Energy;

            damage = copyFrom.damage;
            //[attack, fireball, screech]

            for (int i = 0; i < copyFrom.Skills.Count; i++)
            {
                Skill copyFromThisSkill = copyFrom.Skills[i];
                Skill copy = new Skill(copyFromThisSkill);

                this.Skills.Add(copy);
            }
        }
    }
    
    internal class ConsoleMonArena
    {

    }

    
}

    