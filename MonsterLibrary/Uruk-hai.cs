using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Uruk_hai : Monster
    {
        //FIELDS
        //Special Attribute: 20% Chance Critical (2x) Damage
        //Only occurs with certain path in Path 1
        
        //PROPERTIES

        public int Crit { get; set; }

        //CONSTRUCTORS

        public Uruk_hai(string name, string description, int maxLife, int Life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, int critical)
            : base(name, description, maxLife, Life, maxDamage, minDamage, hitChance, blockChance, blockAmount)
        {
            Crit = critical;
        }

        public Uruk_hai()
        {
            Name = "Fiersome Uruk Hai";
            Description = ""; //TO DO - URUK HAI DESCRIPTION
            MaxLife = 70;
            Life = 70;
            MaxDamage = 30;
            MinDamage = 10;
            HitChance = 70;
            BlockChance = 15;
            BlockAmount = 20;
            Crit = 20;
            
        }



        //METHODS
    }
}
