using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponsLibrary
{
    public class Broadsword : WeaponsArmor
    {
        //FIELDS

        //PROPERTIES

        //CONSTRUCTORS

        public Broadsword(string weaponName, int maxDamage, int minDamage, int bonusHitChance, int bonusBlockChance, int bonusBlockAmount)
        : base(weaponName, maxDamage, minDamage, bonusHitChance, bonusBlockChance, bonusBlockAmount)
        {
            WeaponName = "Broadsword";
            MaxDamage = 15;
            MinDamage = 5;
            BonusHitChance = 10;
            BonusBlockChance = 10;
            BonusBlockAmount = 10;
        }

        public Broadsword()
        {

        }

        //METHODS
    }
}
