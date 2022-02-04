using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        //FIELDS

        private int _life;
        private int _minDamage;

        //PROPERTIES

        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxLife { get; set; }
        public int MaxDamage { get; set; }
        public int HitChance { get; set; }
        public int BlockChance { get; set; }
        public int BlockAmount { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }//end if
            }//end set
        }//end pub int

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }//end if
            }//end set
        }//end pub int

        //CONSTRUCTORS

        //METHODS
    }
}
