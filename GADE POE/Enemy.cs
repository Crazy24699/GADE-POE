using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADEpart1
{
    public abstract class Enemy : Characters
    {
        protected Random Rnd = new Random();

        public int EnemyArray { get; set; }

        public TileType EnemyType { get; set; }

        //public int EnemyGold { get; set; }
 


        //Enemy gives gold when it dies
        public Enemy(int x, int y, int EnemyArrayValue) : base(x, y)
        {
            EnemyArray = EnemyArrayValue;
            GoldStored = Rnd.Next(1, 6);
            // the combat need to work for me to check if the enemy gold is being added to the heros gold
            /*if (HP == 0)
            {
                GoldStored = GoldStored + EnemyGold;
            }*/
        }
        //Enemy stats
        public override string ToString()
        {
            if (HP <= 0)
            {
                MessageBox.Show("You win");
                Application.Exit();
            }
            // not sure how to get the enemy weapon so show as well
            // enemies spawn with specific weapons and can pick up new ones at they move. the mage has no weapons and uses fists.
            return EnemyType + "(" + CurrentHP + "/" + MaxHP + " HP" + ")" + " at " + "[" + XValue.ToString() + "," + YValue.ToString() + "] " + " (" + Damage.ToString() + " DMG" + ")"+GoldStored;

            
        }
    }
}
