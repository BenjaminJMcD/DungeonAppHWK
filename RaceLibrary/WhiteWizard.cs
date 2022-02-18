using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace RaceLibrary
{
    public class WhiteWizard : Player
    {
        //FIELDS
        //Special Attribute: -10 to opponent's HitChance

        //PROPERTIES

        public int BlindingAura { get; set; }

        //CONSTRUCTORS

        public WhiteWizard(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, Race characterRace, WeaponsArmor equippedWeapon, int blindingAura)
: base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount, characterRace, equippedWeapon)
        {
            BlindingAura = blindingAura;
        }

        public WhiteWizard()
        {
            Name = "Gandalf";
            Description = ""; //TO DO - Gandalf DESCRIPTION
            MaxLife = 100;
            Life = 100;
            MaxDamage = 40;
            MinDamage = 20;
            HitChance = 70;
            BlockChance = 40;
            BlockAmount = 20;
            EquippedWeapon = WhiteStaff; //TO DO - WEAPONS LIBRARY
            BlindingAura = 80;
        }

        //METHODS


    }
}
