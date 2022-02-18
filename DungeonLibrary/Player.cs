using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace DungeonLibrary
{
    public class Player : Character
    {
        //FIELDS

        //PROPERTIES

        public Race CharacterRace { get; set; }

        public WeaponsArmor EquippedWeapon { get; set; }

        //Constuctor

        public Player(string name, string description, int maxLife, int life, int maxDamage, int minDamage, int hitChance, int blockChance, int blockAmount, Race characterRace, WeaponsArmor equippedWeapon)
        {
            Name = name;
            Description = description;
            MaxLife = maxLife;
            Life = life;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            HitChance = hitChance;
            BlockChance = blockChance;
            BlockAmount = blockAmount;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
        }

        //METHODS

        public override string ToString()
        {
            return string.Format("\nPlayer Info\n" + "{0}\n{1}\n\n" + "Current Health: {2} / {3}\n" + "Damage: {4} to {5}\n" + "Armor: {6}% effective for {7} damage",
                Name,
                Description,
                Life,
                MaxLife,
                MinDamage,
                MaxDamage,
                BlockChance,
                BlockAmount);


        }




    }
}
