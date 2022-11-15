﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GADEpart1
{
    public abstract class Enemy : Characters
    {
        protected Random random = new Random();

        public int EnemyArray { get; set; }

        public TileType EnemyType { get; set; }

        public int EnemyGold { get; set; }
 


        public Enemy(int x, int y, int EnemyArrayValue) : base(x, y)
        {
            EnemyArray = EnemyArrayValue;

            if (HP == 0)
            {
                GoldStored = GoldStored + EnemyGold;
            }
        }

        public override string ToString()
        {
            // not sure how to get the enemy weapon so show as well
            // enemies spawn with specific weapons and can pick up new ones at they move. the mage has no weapons and uses fists.
            return EnemyType + "(" + CurrentHP + "/" + MaxHP + " HP" + ")" + " at " + "[" + x.ToString() + "," + y.ToString() + "]" + " " + "(" + Damage.ToString() + " DMG" + ")";

            
        }
    }
}
