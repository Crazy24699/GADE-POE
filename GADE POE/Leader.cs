using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GADEpart1;

namespace GADE_POE
{
    public class Leader : Enemy
    {
        public bool TileClear = true;          //if the tile that the enemy is meant to move to, is clear
        public int XCord;
        public int YCord;
        private Hero Hero;
        //private TileType LeaderTarget { get; set; }
        public Leader(int x, int y, int EnemyArray) : base(x, y, EnemyArray)
        {
            MaxHP = 20;
            HP = MaxHP;
            Damage = 2;
            GoldStored = 2;
            EnemyType = TileType.Leader;
            Symbol = TileType.Leader;
        }

        public override Movements ReturnMove(Movements Move = 0)
        {
            //1 is down, 2 is up, 3 is left, 4 is right
            Move = (Movements)Direction;
            if (CharacterView[(int)Move].Symbol == TileType.EmptyTile)
            {
                Debug.WriteLine(Move);
                return Move;
            }
            else
            {

           
                return Movements.NoMovement;

            }

        }
    }
}
