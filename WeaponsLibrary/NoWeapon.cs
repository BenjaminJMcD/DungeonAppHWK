using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponsLibrary
{
    public class NoWeapon : WeaponsArmor
    {
        //FIELDS

        //PROPERTIES

        //CONSTRUCTORS

        public NoWeapon(string weaponName, int maxDamage, int minDamage, int bonusHitChance, int bonusBlockChance, int bonusBlockAmount)
            : base(weaponName, maxDamage, minDamage, bonusHitChance, bonusBlockChance, bonusBlockAmount)
        {
            WeaponName = "You do not have a proper weapon.";
            MaxDamage = 0;
            MinDamage = 0;
            BonusHitChance = 0;
            BonusBlockChance = 0;
            BonusBlockAmount = 0;
        }

        public NoWeapon() { }

        //METHODS
    }
}
