using System;
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

        public Enemy(int x, int y, int EnemyArrayValue) : base(x, y)
        {
            EnemyArray = EnemyArrayValue;
        }

        public override string ToString()
        {
            return EnemyType + "(" + CurrentHP + "/" + MaxHP + " HP" + ")" + " at " + "[" + x.ToString() + "," + y.ToString() + "]" + " " + "(" + Damage.ToString() + " DMG" + ")";

            
        }
    }
}
