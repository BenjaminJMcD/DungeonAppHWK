using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class WeaponsArmor
    {
        //FIELDS
        private string _weaponName;
        private int _minDamage;
        private int _maxDamage;
        private int _bonusHitChance;
        private int _bonusBlockChance;
        private int _bonusBlockAmount;

        //PROPERTIES

        public string WeaponName
        {
            get { return _weaponName; }
            set { _weaponName = value; }
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public int BonusBlockChance
        {
            get { return _bonusBlockChance; }
            set { _bonusBlockChance = value; }
        }
        public int BonusBlockAmount
        {
            get { return _bonusBlockAmount; }
            set { _bonusBlockAmount = value; }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }


        //CONSTRUCTORS

        public WeaponsArmor(string weaponName, int maxDamage, int minDamage, int bonusHitChance, int bonusBlockChance, int bonusBlockAmount)
        {
            WeaponName = weaponName;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
            BonusBlockChance = bonusBlockChance;
            BonusBlockAmount = bonusBlockAmount;
        }

        public WeaponsArmor() { }

        //METHODS

        public override string ToString()
        {
            return string.Format("\n{0}\n{1} to {2} Damage\n" +
                "Bonus HitChance: +{3}%\n" +
                "Bonus BlockChance: +{4}% for +{5} Damage",
                WeaponName,
                MinDamage,
                MaxDamage,
                BonusHitChance,
                BonusBlockChance,
                BonusBlockAmount);
        }
    }
}
