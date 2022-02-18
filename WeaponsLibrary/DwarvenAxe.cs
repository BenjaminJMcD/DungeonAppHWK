using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponsLibrary
{
    public class DwarvenAxe : WeaponsArmor
    {
        //FIELDS

        //PROPERTIES

        //CONSTRUCTORS

        public DwarvenAxe(string weaponName, int maxDamage, int minDamage, int bonusHitChance, int bonusBlockChance, int bonusBlockAmount)
        : base(weaponName, maxDamage, minDamage, bonusHitChance, bonusBlockChance, bonusBlockAmount);

        public DwarvenAxe()
        {
            WeaponName = "Forged by Master Dwarves, Gimli's Double-Bladed Axe";
            MaxDamage = 25;
            MinDamage = 15;
            BonusHitChance = 20;
            BonusBlockChance = 20;
            BonusBlockAmount = 20;
        }


        //METHODS
    }
}
