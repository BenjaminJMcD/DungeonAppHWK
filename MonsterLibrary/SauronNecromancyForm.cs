using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class SauronNecromancyForm : Monster
    {
        //FIELDS
        //20% chance showing up (near exit of castle)
        //No Battle
        //50% chance death, 50% chance fall back 3 turns
        //Unknown Max Life (>9000)

        //PROPERTIES

        public bool BlownOffTower { get; set; }

        //CONSTRUCTORS

        public SauronNecromancyForm(string name, string description, int maxLife, bool blownOffTower)
        {
            Name = name;
            Description = description;
            MaxLife = maxLife;
            BlownOffTower = blownOffTower;
        }

        public SauronNecromancyForm()
        {
            Name = "Sauron manifested in his necromancy form";
            Description = ""; //TO DO = SAURON DESCRIPTION
            MaxLife = 9001;
            BlownOffTower = false;
        }


        //METHODS

        //Need RANDOM bool public override
        // If true, fall to death. If false, move back 3 spaces
    }
}
