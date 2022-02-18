using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace RaceLibrary
{
    public class Elf : Player
    {
        //FIELDS
        //Special Attribute: +20 to HitChance

        //PROPERTIES

        public int KeenEye { get; set; }

        //CONSTRUCTORS

        public Elf(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, Race characterRace, WeaponsArmor equippedWeapon)
        : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount, characterRace, equippedWeapon);


        public Elf()
        {
            Name = "Legolas";
            Description = ""; //TO DO - LEGOLAS DESCRIPTION
            MaxLife = 60;
            Life = 60;
            MaxDamage = 30;
            MinDamage = 20;
            HitChance = 90;
            BlockChance = 70;
            BlockAmount = 15;
            EquippedWeapon = ElvishDagger; //TO DO - WEAPONS LIBRARY
        }

        //METHODS


    }
}
