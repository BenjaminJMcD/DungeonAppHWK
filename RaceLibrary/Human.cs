using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace RaceLibrary
{
    public class Human : Player
    {
        //FIELDS
        //Special Attribute: 20 damage if block

        //PROPERTIES

        public int Parry { get; set; }

        //CONSTRUCTORS

        public Human(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, Race characterRace, WeaponsArmor equippedWeapon, int Parry)
        : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount, characterRace, equippedWeapon)
        {
            Parry = parry;
        }

        public Human()
        {
            Name = "Aragorn";
            Description = ""; //TO DO - HUMAN DESCRIPTION
            MaxLife = 70;
            Life = 70;
            MaxDamage = 30;
            MinDamage = 20;
            HitChance = 60;
            BlockChance = 60;
            BlockAmount = 15;
            EquippedWeapon = BroadSword; //TO DO - WEAPONS LIBRARY
            //Parry = Calc.Damage bool true; //TO DO - PARRY MECHANIC
        }

        //METHODS


    }
}
