using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using WeaponsLibrary;


namespace RaceLibrary
{
    public class Elf : Player
    {

        NoWeapon noweapon = new NoWeapon();



        //FIELDS
        //Special Attribute: High HitChance
        public int KeenEye { get; set; }

        //PROPERTIES

        //CONSTRUCTORS

        public Elf(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, WeaponsArmor equippedWeapon, int keenEye)
        : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount, equippedWeapon)
        {
            KeenEye = keenEye;
        }


        public Elf()
        {
            Name = "Legolas";
            Description = "An ageless Woodland Elf with a keen eye";
            MaxLife = 60;
            Life = 60;
            MaxDamage = 30;
            MinDamage = 20;
            HitChance = 90;
            BlockChance = 70;
            BlockAmount = 15;
            EquippedWeapon = noweapon;
        }


        //METHODS

        //CalcWeapon

    }
}
