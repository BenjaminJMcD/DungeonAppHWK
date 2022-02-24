using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using WeaponsLibrary;


namespace RaceLibrary
{
    public class Human : Player
    {

        Broadsword broadsword = new Broadsword();
        NoWeapon noweapon = new NoWeapon();

        //FIELDS
        //Special Attribute: 20 damage if block

        //PROPERTIES

        public int ParryChance { get; set; }
        public int ParryAmount { get; set; }

        //CONSTRUCTORS

        public Human(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, WeaponsArmor equippedWeapon, int parryChance, int parryAmount)
        : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount, equippedWeapon)
        {
            ParryChance = parryChance;
            ParryAmount = parryAmount;
        }

        public Human()
        {
            Name = "Aragorn";
            Description = "A Numenorean and the rightful king of men. His skill with a blade is nigh unmatched";
            MaxLife = 70;
            Life = 70;
            MaxDamage = 30;
            MinDamage = 20;
            HitChance = 60;
            BlockChance = 60;
            BlockAmount = 15;
            EquippedWeapon = noweapon;
            ParryChance = 30;
            ParryAmount = 10;
        }

        //METHODS


    }
}
