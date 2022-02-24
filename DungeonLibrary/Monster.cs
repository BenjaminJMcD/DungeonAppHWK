using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //FIELDS
        //Attributes: HitChance, BlockChance, BlockAmount, MaxDamage, MinDamage, MaxLife, Life, Name, Description

        //private int _life;
        //private int _minDamage;

        //PROPERTIES  ****SEE CHARACTER       

        //CONSTRUCTORS

        public Monster(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount)
        {
            Name = name;
            Description = description;
            MaxLife = maxLife;
            Life = life;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            HitChance = hitChance;
            BlockChance = blockChance;
            BlockAmount = blockAmount;
        }

        public Monster() { }

        //METHODS

        public override string ToString()
        {
            return string.Format("\n*** Enemy Info ***\n" + "{0}\n{1}\n\n" + "Current Health: {2} / {3}\n" + "Damage: {6}% chance to hit {4} to {5}\n" + "Armor: {7}% effective for {8} damage",
                Name,
                Description,
                Life,
                MaxLife,
                MinDamage,
                MaxDamage,
                HitChance,
                BlockChance,
                BlockAmount);

        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage);

        }



    }//end class
}//end namespace
