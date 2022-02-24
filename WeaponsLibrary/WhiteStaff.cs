using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace WeaponsLibrary
{
    public class WhiteStaff : WeaponsArmor
    {
        //FIELDS

        //PROPERTIES

        //CONSTRUCTORS

        public WhiteStaff(string weaponName, int maxDamage, int minDamage, int bonusHitChance, int bonusBlockChance, int bonusBlockAmount)
        : base(weaponName, maxDamage, minDamage, bonusHitChance, bonusBlockChance, bonusBlockAmount)
        {
            WeaponName = "Shining a glorious, piercing light - the staff of Gandalf the White";
            MaxDamage = 20;
            MinDamage = 10;
            BonusHitChance = 10;
            BonusBlockChance = 30;
            BonusBlockAmount = 10;
        }

        public WhiteStaff() { }

        //METHODS


    }
}
