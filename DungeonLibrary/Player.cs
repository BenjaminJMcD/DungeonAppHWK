using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace DungeonLibrary
{
    public class Player : Character
    {
        //FIELDS


        //PROPERTIES

        public WeaponsArmor EquippedWeapon { get; set; }

        //Constuctor

        public Player(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, WeaponsArmor equippedWeapon)
        {
            Name = name;
            Description = description;
            MaxLife = maxLife;
            Life = life;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            HitChance = hitChance;
            BlockChance = blockChance;
            BlockAmount = blockAmount;
            EquippedWeapon = equippedWeapon;
        }

        public Player() { }

        //METHODS

        public override string ToString()
        {
            return string.Format("\nPlayer Info\n\n" + "{0}\n{1}\n\n" + "Current Health: {2} / {3}\n" + "Damage: {4}% effective for {5} to {6} damage\n" + "Armor: {7}% effective for {8} damage",
                Name,
                Description,
                Life,
                MaxLife,
                HitChance,
                MinDamage,
                MaxDamage,
                BlockChance,
                BlockAmount);
        }



        public override int CalcBlockChance()
        {
            return base.BlockChance + EquippedWeapon.BonusBlockChance;
        }

        public override int CalcBlockAmount()
        {
            return base.BlockAmount + EquippedWeapon.BonusBlockAmount;
        }

        public override int CalcDamage()
        {
            Random rand = new Random();

            int damage = rand.Next(MinDamage + EquippedWeapon.MinDamage, MaxDamage + EquippedWeapon.MaxDamage);

            return damage;
        }
   
        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }



    }
}
