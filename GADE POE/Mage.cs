using GADEpart1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_POE
{
    public class Mage : Enemy
    {
        public Mage(int x, int y, int EnemyArray) : base(x, y, EnemyArray)
        {
            MaxHP = 5;
            HP = MaxHP;
            Damage = 5;
            EnemyGold = 3;
            EnemyType = TileType.Mage;
            Symbol = TileType.Mage;
        }

        

        public override Movements ReturnMove(Movements Move = 0)
        {

            Random random = new Random();


            Type Direction = typeof(Movements);
            Array Movement = Direction.GetEnumValues();

            return Move;
        }
        public override bool CheckRange(Characters target)
        {
            double Distance = Math.Pow(target.XValue - XValue, 2) + Math.Pow(target.YValue - YValue, 2);
            Distance = Math.Abs(Distance);

            return Distance <= 2 && Distance > 0;
        }


    }
}
