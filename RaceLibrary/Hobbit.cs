using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using WeaponsLibrary;

namespace RaceLibrary
{
    public class Hobbit : Player
    {

        NoWeapon noweapon = new NoWeapon();

        //FIELDS
        //Special Attribute: -10 to encounter chance
        //Two hobbits travel together. If first dies, may be retrieved atop optional tower

        //PROPERTIES
        public int Sneak { get; set; }

        //CONSTRUCTORS

        public Hobbit(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, WeaponsArmor equippedWeapon, int sneak)
        : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount, equippedWeapon)
        {
            Sneak = sneak;
        }

        public Hobbit()
        {
            Name = "Pip & Merry";
            Description = ""; //TO DO - HOBBIT DESCRIPTION
            MaxLife = 110;
            Life = 110;
            MaxDamage = 20;
            MinDamage = 15;
            HitChance = 40;
            BlockChance = 60;
            BlockAmount = 15;
            EquippedWeapon = noweapon;
            Sneak = 10; //TO DO - ENCOUNTER MECHANIC
        }

        //METHODS


    }
}
