using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Axe : WeaponsArmor
    {
        //FIELDS

        //PROPERTIES

        //CONSTRUCTORS

        public Axe(string weaponName, int maxDamage, int minDamage, int bonusHitChance, int bonusBlockChance, int bonusBlockAmount)
        : base(weaponName, maxDamage, minDamage, bonusHitChance, bonusBlockChance, bonusBlockAmount);

        public Axe()
        {
            WeaponName = "Sturdy Axe";
            MaxDamage = 20;
            MinDamage = 1;
            BonusHitChance = 10;
            BonusBlockChance = 10;
            BonusBlockAmount = 10;
        }


        //METHODS
    }
}
