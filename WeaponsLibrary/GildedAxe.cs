using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponsLibrary
{
    public class GildedAxe :WeaponsArmor
    {
        //FIELDS

        //PROPERTIES

        //CONSTRUCTORS

        public GildedAxe(string weaponName, int maxDamage, int minDamage, int bonusHitChance, int bonusBlockChance, int bonusBlockAmount)
        : base(weaponName, maxDamage, minDamage, bonusHitChance, bonusBlockChance, bonusBlockAmount);

        public GildedBlade()
        {
            WeaponName = "A gilded human axe of very nice craftmanship";
            MaxDamage = 35;
            MinDamage = 1;
            BonusHitChance = 10;
            BonusBlockChance = 20;
            BonusBlockAmount = 10;
        }


        //METHODS
    }
}
