using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMon
    {
      int Health = 5;
      int Energy = 0;
      string name = "licky";

     List<Skill> Skills = new List<Skill>();

       
     

        public void TakeDamage(int Damage)
        {

            Health =- Damage;
        }

        public void DepleteEnergy(int energy)
        {
            Energy =- energy;
        }

       
    }
}
