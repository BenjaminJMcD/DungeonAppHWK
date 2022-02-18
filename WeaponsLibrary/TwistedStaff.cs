using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace WeaponsLibrary
{
    public class TwistedStaff : WeaponsArmor
    {
        //FIELDS

        //PROPERTIES

        public int CrystalHeal { get; set; }
        public int HealAmount { get; set; }

        //CONSTRUCTORS

        public TwistedStaff(string weaponName, int maxDamage, int minDamage, int bonusHitChance, int bonusBlockChance, int bonusBlockAmount, int crystalHeal, int healAmount)
        : base(weaponName, maxDamage, minDamage, bonusHitChance, bonusBlockChance, bonusBlockAmount)
        {
            CrystalHeal = CrystalHeal;
            HealAmount = HealAmount;
        }

        public TwistedStaff()
        {
            WeaponName = "A twisted sprig with a curious blue crystal afixed to the crown";
            MaxDamage = 20;
            MinDamage = 1;
            BonusHitChance = 10;
            BonusBlockChance = 30;
            BonusBlockAmount = 10;
            CrystalHeal = 60;
            HealAmount = 10;
        }


        //METHODS

        public override string ToString()
        {
            return string.Format("{0}\nAdded... \n" + 
                "Damage: +{3}% chance for +{2} to +{1} damage\n" +
                 "Block: +{4}% for {5} Damage\n" + 
                 "Chance to heal: {6}% for {7} life");
        }

    }
}
