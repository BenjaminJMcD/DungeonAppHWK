using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Sting : WeaponsArmor
    {
        public Sting(string weaponName, int maxDamage, int minDamage, int bonusHitChance, int bonusBlockChance, int bonusBlockAmount)
        : base(weaponName, maxDamage, minDamage, bonusHitChance, bonusBlockChance, bonusBlockAmount) { }

        public Sting()
        {
            WeaponName = "A fine elvish blade that glows blue when orcs are near";
            MaxDamage = 40;
            MinDamage = 10;
            BonusHitChance = 20;
            BonusBlockChance = 20;
            BonusBlockAmount = 20;
        }
    }
}
