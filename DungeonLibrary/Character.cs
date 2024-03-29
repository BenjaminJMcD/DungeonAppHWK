﻿using System;
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

        //PROPERTIES

        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxLife { get; set; }
        public int MaxDamage { get; set; }
        public int HitChance { get; set; }
        public int BlockChance { get; set; }
        public int BlockAmount { get; set; }
        public int MinDamage { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }//end if
            }//end set
        }//end pub int



        //CONSTRUCTORS

        //METHODS

        public virtual int CalcBlockAmount()
        {
            return BlockAmount;
        }

        public virtual int CalcBlockChance()
        {
            return BlockChance;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }
    }
}
