using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponsLibrary
{
    public class ElvishDagger : WeaponsArmor
    {
        //FIELDS

        //PROPERTIES

        //CONSTRUCTORS

        public ElvishDagger(string weaponName, int maxDamage, int minDamage, int bonusHitChance, int bonusBlockChance, int bonusBlockAmount)
        : base(weaponName, maxDamage, minDamage, bonusHitChance, bonusBlockChance, bonusBlockAmount)
        {
            WeaponName = "A small elvish blade. Fit for a Hobbit";
            MaxDamage = 30;
            MinDamage = 10;
            BonusHitChance = 10;
            BonusBlockChance = 10;
            BonusBlockAmount = 10;
        }

        public ElvishDagger() { }

        //METHODS
    }
}
