using GADEpart1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_POE
{
    public class SwampCreature : Enemy
    {
        public int Directions;
        public bool TileClear = true;          //if the tile that the enemy is meant to move to, is clear
        public int XCord;
        public int YCord;

        //New 
        public SwampCreature(int x, int y, int EnemyArray) : base(x, y, EnemyArray)
        {
            MaxHP = 10;
            HP = MaxHP;
            Damage = 1;
            GoldStored = 1;
            EnemyType = TileType.SwampCreature;
            Symbol = TileType.SwampCreature;
        }
        public override Movements ReturnMove(Movements Move = 0)
        {




            //1 is down, 2 is up, 3 is left, 4 is right
            for (int i = 0; i < 3; i++)
            {
                Random Direction = new Random();
                Directions = Direction.Next(1, 5);
                Move = (Movements)Directions;
                if (CharacterView[(int)Move].Symbol == TileType.EmptyTile)
                {
                    return Move;
                }
            }
            return Movements.NoMovement;
        }

    }
}
