using System;

namespace ConsoleMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleMon oui = new ConsoleMon();
            ConsoleMon bonjour = new ConsoleMon();

            Skill fireBall = new Skill();
            Skill slap = new Skill();
            Skill gun = new Skill();
            Skill iceBall = new Skill();

            oui.Skills.Add(fireBall);
            oui.Skills.Add(slap);

            bonjour.Skills.Add(iceBall);
            bonjour.Skills.Add(gun);

            fireBall.damage = 5;
            fireBall.energyCost = 5;
            slap.damage = 3;
            slap.energyCost = 2;
            gun.damage = 3;
            gun.energyCost = 2;
            iceBall.damage = 4;
            iceBall.energyCost = 4;

            ConsoleMon a = oui;
            ConsoleMon b = bonjour;

            ConsoleMonArena consolemonArena = new ConsoleMonArena();
            consolemonArena.doBattle(a, b);
        }
    }
}
