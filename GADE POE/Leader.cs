using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GADEpart1;

namespace GADE_POE
{
    internal class Leader : Enemy
    {
        public int Directions;
        public bool TileClear = true;          //if the tile that the enemy is meant to move to, is clear
        public int XCord;
        public int YCord;

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
            for (int i = 0; i < 3; i++)
            {
                Random Direction = new Random();
                Directions = Direction.Next(0, 5);
                Move = (Movements)Directions;
                if (CharacterView[(int)Move].Symbol == TileType.EmptyTile)
                {
                    return Move;
                }
            }
            return Movements.NoMovement;
            // the leader needs to target the hero and follow them.

        }
    }
}
