using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace RaceLibrary
{
    public class Hobbit : Player
    {
        //FIELDS
        //Special Attribute: -10 to encounter chance
        //Two hobbits travel together. If first dies, may be retrieved atop optional tower

        //PROPERTIES

        public int Sneak { get; set; }

        //CONSTRUCTORS

        public Hobbit(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, Race characterRace, WeaponsArmor equippedWeapon, int sneak)
        : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount, characterRace, equippedWeapon)
        {
            Sneak = sneak;
        }

        public Hobbit()
        {
            Name = "Pip & Merry";
            Description = ""; //TO DO - HOBBIT DESCRIPTION
            MaxLife = 50;
            Life = 50;
            MaxDamage = 20;
            MinDamage = 10;
            HitChance = 40;
            BlockChance = 60;
            BlockAmount = 15;
            EquippedWeapon = null; //TO DO - WEAPONS LIBRARY
            //Sneak = Calc.Encounter -10; //TO DO - SNEAK MECHANIC
        }


        //METHODS


    }
}
