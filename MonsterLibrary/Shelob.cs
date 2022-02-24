using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Shelob:Monster
    {
        //FIELDS
        //Special Attributes: 40% chance attack again
        //Only occurs with path 1

        //PROPERTIES

        public int MultiAttack { get; set; }

        //CONSTRUCTORS

        public Shelob(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, int multiAttack)
    : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount)
        {
            MultiAttack = multiAttack;
        }

        public Shelob()
        {
            Name = "Shelob";
            Description = "A Giant wretched spider!!  ... Its movements are too fast to be seen.";
            MaxLife = 50;
            Life = 50;
            MaxDamage = 10;
            MinDamage = 1;
            HitChance = 60;
            BlockChance = 20;
            BlockAmount = 10;
            MultiAttack = 25;
        }

        //METHODS
    }
}
