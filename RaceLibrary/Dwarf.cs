using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using WeaponsLibrary;

namespace RaceLibrary
{
    public class Dwarf : Player
    {

        NoWeapon noweapon = new NoWeapon();

        //FIELDS
        //Special Attribute: +10 MaxDamage to weapons

        //PROPERTIES

        public int AxeMaster { get; set; }


        //CONSTRUCTORS

        public Dwarf(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, WeaponsArmor equippedWeapon, int axeMaster)
        : base(name, description, maxLife, life, maxDamage, minDamage, hitChance, blockChance, blockAmount, equippedWeapon)
        {
            AxeMaster = axeMaster;
        }

        public Dwarf()
        {
            Name = "Gimli";
            Description = "A sturdy Dwarf with a long, braided beard. His skill is much higher with a weapon he has forged himself!";
            MaxLife = 80;
            Life = 80;
            MaxDamage = 30;
            MinDamage = 20;
            HitChance = 50;
            BlockChance = 60;
            BlockAmount = 15;
            EquippedWeapon = noweapon;
            AxeMaster = 10;    
        }



        //METHODS

        //CalcBonusMaxDamage()
          //  if (EquippedWeapon != null)

    }
}
