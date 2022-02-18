using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Galadhrim : WeaponsArmor
    {
        //FIELDS

        //PROPERTIES

        //CONSTRUCTORS

        public Galadhrim(string weaponName, int maxDamage, int minDamage, int bonusHitChance, int bonusBlockChance, int bonusBlockAmount)
        : base(weaponName, maxDamage, minDamage, bonusHitChance, bonusBlockChance, bonusBlockAmount);

        public Galadhrim()
        {
            WeaponName = "Bestowed to Legolas by Galadriel... his mighty bow, Galadhrim";
            MaxDamage = 40;
            MinDamage = 1;
            BonusHitChance = 15;
            BonusBlockChance = 5;
            BonusBlockAmount = 10;
        }


        //METHODS
    }
}
