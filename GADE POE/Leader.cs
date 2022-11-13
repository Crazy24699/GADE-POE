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
        private TileType LeaderTarget { get; set; }
        public Leader(int x, int y, int EnemyArray) : base(x, y, EnemyArray)
        {
            MaxHP = 20;
            HP = MaxHP;
            Damage = 2;
            EnemyType = TileType.Leader;
            Symbol = TileType.Leader;
        }

        

        public override Movements ReturnMove(Movements move = Movements.NoMovement)
        {
            throw new NotImplementedException();
        }
        // the leader needs to target the hero and follow them.

    }
}
