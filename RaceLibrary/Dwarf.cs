using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace RaceLibrary
{
    public class Dwarf : Player
    {
        //FIELDS
        //Special Attribute: +10 MaxDamage to weapons

        //PROPERTIES

        public int AxeMaster { get; set; }

        //CONSTRUCTORS

        public Dwarf(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, Race characterRace, Weapon equippedWeapon, int axeMaster)
        : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount, characterRace, equippedWeapon)
        {
            AxeMaster = axeMaster;
        }

        public Dwarf()
        {
            Name = "Gimli";
            Description = ""; //TO DO - DWARF DESCRIPTION
            MaxLife = 80;
            Life = 80;
            MaxDamage = 30;
            MinDamage = 20;
            HitChance = 40;
            BlockChance = 60;
            BlockAmount = 15;
            EquippedWeapon = Axe; //TO DO - WEAPONS LIBRARY
            //AxeMaster = Calc.EquippedWeapon Damage + 10; TO DO - AXEMASTER MECHANIC
        }

        //METHODS


    }
}
