using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponsLibrary
{
    class OrcArmor : WeaponsArmor
    {
        //FIELDS
        //Special Attribute: decrease encounter rate by 20%

        //PROPERTIES

        public int BonusSneak { get; set; }

        //CONSTRUCTORS

        public OrcArmor(string weaponName, int maxDamage, int minDamage, int bonusHitChance, int bonusBlockChance, int bonusBlockAmount, int bonusSneak)
        : base(weaponName, maxDamage, minDamage, bonusHitChance, bonusBlockChance, bonusBlockAmount)
        {
            BonusSneak = bonusSneak;
        }

        public OrcArmor()
        {
            WeaponName = "A dead Orc's Armor";
            MaxDamage = 0;
            MinDamage = 0;
            BonusHitChance = 10;
            BonusBlockChance = 20;
            BonusBlockAmount = 10;
            BonusSneak = 20;
        }



        //METHODS

        public override string ToString()
        {
            return string.Format("{0}\nAdded...\n" +
                "Damage: +{3}% chance to hit\n" + 
                "Block: +{4}% chance to block +{5}\n" +
                "Evasion: +{6}%");
        }
    }
}
