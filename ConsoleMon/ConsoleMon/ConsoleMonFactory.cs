using ConsoleMonsters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ConsoleMonsters.Tools;

namespace ConsoleMonsters
{
    class ConsoleMonData
    {
        internal string monsterLine;
        internal string skillLine;
    }
    class ConsoleMonFactory
    {
        private Dictionary<string, ConsoleMonData> templates = new Dictionary<string, ConsoleMonData>();

        public void Load(string datafile)
        {
            //lees je regels in 
            string file = Path.Combine(PathHelper.ExeDir(), "monsterdata.txt");

           string[] lines = File.ReadAllLines(file);

            for (int i = 0; i < lines.Length; i += 2)//loop over je regels per 2 (i+=2))
            {
                ConsoleMonData data = new ConsoleMonData();
                //zet monsterLine (regel1) & skillLine (regel2)
                data.monsterLine = lines[i];
                data.skillLine = lines[i+1];

                //split monsterline op ',' en pak de eerste, dit zou je monsterType moeten zijn
                string monsterType = data.monsterLine.Split(',')[0];



                //even toevoegen
                templates.Add(monsterType, data);

            }

        }

        private ConsoleMon.ConsoleMon MakeConsoleMon(ConsoleMonData data)
        {
            ConsoleMon.ConsoleMon temp = new ConsoleMon.ConsoleMon();
            //split de monsterLine uit data weer op ','
            string[] properties = data.monsterLine.Split(',');


            //monsterType bestaat nog niet op ConsoleMon, voeg deze toe, deze variable heeft type string
            temp.MonsterType = properties[0];

            //vergeet niet dat health een int is, hoe ging je ook al weer van een string naar een int?
            temp.Health = data.monsterLine[2];
            temp.damage = data.monsterLine[3];
            //misschien heet Weakness anders bij jullie
            temp.Weakness = LoadElement(????);


            //nu de skills, OOF!
            string[] skillSep = data.skillLine.Split(';');
            //nu hebben we de verschillende skills in strings in skillSep (bv skillSep[0] is de data van de eerste skill)

            for (/*loop over skillSep SLA 0 over*/)
            {
                Skill skill = //laad de skill met de LoadSkill function

                //voeg nu skill van hierboven toe aan de skills van temp
                temp.Skills ????
            }
            return temp;
        }
        private Skill LoadSkill(string skillstring)
        {
            string[] split = skillstring.Split(',');

            //mogelijk heten deze varible net iets anders bij jullie, map het dan op de goede!
            Skill skill = new Skill()
            {
                name = split[0],
                damage = int.Parse(split[2]),
                energyCost = int.Parse(split[4]),
                element = LoadElement(split[6])
            };
            return skill;

        }


        //misschien dat jouw enum niet Element heet, dan even Element vervangen door jouw naam
        private static Element LoadElement(string split)
        {
            //als deze crashed, misschien hebben jullie andere enum values (bv je hebt geen Fire maar water)
            return (Element)Enum.Parse(typeof(Element), split);
        }

        //30 may 2022 12:26 aangepast
        internal ConsoleMon.ConsoleMon Make(string monstertype)
        {
            return MakeConsoleMon(templates[monstertype]);
        }
        
    }
}
