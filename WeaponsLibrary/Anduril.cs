using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Anduril : WeaponsArmor
    {
        //FIELDS

        //PROPERTIES

        //CONSTRUCTORS

        public Anduril(string weaponName, int maxDamage, int minDamage, int bonusHitChance, int bonusBlockChance, int bonusBlockAmount)
        : base(weaponName, maxDamage, minDamage, bonusHitChance, bonusBlockChance, bonusBlockAmount)
        {
            WeaponName = "Reforged from the shards of Narsil - Anduril";
            MaxDamage = 30;
            MinDamage = 10;
            BonusHitChance = 10;
            BonusBlockChance = 10;
            BonusBlockAmount = 10;
        }

        public Anduril() { }

        //METHODS

    }
}
