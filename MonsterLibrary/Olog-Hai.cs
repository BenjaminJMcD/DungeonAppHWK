using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Olog_Hai : Monster
    {
        //FIELDS
        //Special Attribute: 10% chance 1 hit KO
        //Only occurs with Path 2

        //PROPERTIES

        public int OneHitKO { get; set; }

        //CONSTRUCTORS

        public Olog_Hai(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, int oneHitKO)
            : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount)
        {
            OneHitKO = oneHitKO;
        }

        public Olog_Hai()
        {
            Name = "Massive Olog Hai";
            Description = ""; //TO DO - OLOG HAI DESCRIPTION
            MaxLife = 80;
            Life = 80;
            MaxDamage = 50;
            MinDamage = 1;
            HitChance = 20;
            BlockChance = 10;
            BlockAmount = 10;
            OneHitKO = 10;
        }

        //METHODS




    }
}
