using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class MouthOfSauron : Monster
    {
        //FIELDS
        //Special Attribute: Low chance showing up (certain path + certain # turns)
        //30% chance lowering your attack by 10

        //PROPERTIES

        public int Hypnotize { get; set; }

        //CONSTRUCTORS 

        public MouthOfSauron(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, int hypnotize)
            : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount)
        {
            Hypnotize = hypnotize;
        }

        public MouthOfSauron()
        {
            Name = "Mouth of Sauron";
            Description = ""; //TO DO - MOUTH OF SAURON DESCRIPTION
            MaxLife = 90;
            Life = 90;
            MaxDamage = 50;
            MinDamage = 15;
            HitChance = 70;
            BlockChance = 25;
            BlockAmount = 20;
            Hypnotize = 30;
        }

        //METHODS
    }
}
