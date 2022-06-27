using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
     internal int Health = 100;
     internal int Energy = 50;
     internal string name;
     internal int damage;
     

     

        Elements weakness = Elements.Water;

         internal List<Skill> Skills = new List<Skill>();

        public void TakeDamage(int Damage)
        {

            Health = Health - Damage;
        }

        public void DepleteEnergy(int energy)
        {
            Energy = Energy - energy;
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
        public void doBattle(ConsoleMon a, ConsoleMon b)
        {
            Random rand = new Random();
            

            while (a.Health > 0 || b.Health > 0)
            {
                Skill aSkill = a.Skills[rand.Next(a.Skills.Count)];
                aSkill.UseOn(b, a);
                

                Skill bSkill = b.Skills[rand.Next(b.Skills.Count)];
                bSkill.UseOn(a, b);

                Console.WriteLine(a.Health);
                Console.WriteLine(b.Health);
            }
        }
            
        

    }
}

    