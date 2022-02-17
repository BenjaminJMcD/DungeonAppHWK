using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Orc : Monster
    {
        //FIELDS
        //Special Attribute: 20% Chance Steal Item

        //PROPERTIES

        public int Steal { get; set; }

        //CONSTRUCTORS

        public Orc(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, int steal)
            : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount)
        {
            Steal = steal; 
        }

        public Orc()
        {
            Name = "Scrappy Orc";
            Description = ""; //TO DO - ORC DESCRIPTION
            MaxLife = 50;
            Life = 50;
            MaxDamage = 20;
            MinDamage = 1;
            HitChance = 40;
            BlockChance = 10;
            BlockAmount = 10;
            Steal = 20;
        }

        //METHODS

    }
}
