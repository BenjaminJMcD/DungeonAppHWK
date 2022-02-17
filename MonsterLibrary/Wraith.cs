using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Wraith : Monster
    {

        //FIELDS
        //Special Attribute: 30% chance to poison
        //10% chance to appear at volcano

        //PROPERTIES

        public int Poison { get; set; }

        //CONSTRUCTORS

        public Wraith(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, int poison)
    : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount)
        {
            Poison = poison;
        }

        public Wraith()
        {
            Name = "Dreadful Ring Wraith";
            Description = ""; //TO DO - WRAITH DESCRIPTION
            MaxLife = 100;
            Life = 100;
            MaxDamage = 50;
            MinDamage = 10;
            HitChance = 50;
            BlockChance = 20;
            BlockAmount = 20;
            Poison = 20;
        }

        //METHODS



    }
}
