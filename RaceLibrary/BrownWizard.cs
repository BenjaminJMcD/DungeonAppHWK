using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace RaceLibrary
{
    public class BrownWizard : Player
    {
        //FIELDS
        //Special Attribute: Calls on crows to commit extra 10 dmg per turn

        //PROPERTIES

        public int Crows { get; set; }

        //CONSTRUCTORS

        public BrownWizard(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, Race characterRace, WeaponsArmor equippedWeapon, int crows)
        : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount, characterRace, equippedWeapon)
        {
            Crows = crows;
        }

        public Hobbit()
        {
            Name = "Radagast";
            Description = ""; //TO DO - Radagast DESCRIPTION
            MaxLife = 90;
            Life = 90;
            MaxDamage = 40;
            MinDamage = 20;
            HitChance = 70;
            BlockChance = 40;
            BlockAmount = 20;
            EquippedWeapon = TwistedStaff; //TO DO - WEAPONS LIBRARY
            //Crows = Calc.damage + 10;  TO DO - CROWS MECHANIC
        }

        //METHODS
    }
}
