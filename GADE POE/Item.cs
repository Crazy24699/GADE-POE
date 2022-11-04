using GADEpart1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    public abstract class Item : Tile
    {
        private int GoldNum;
        public int GoldAmount
        {
            get { return GoldNum; }
            set { GoldNum = value; }
        }

        public Item(int XPosition, int YPosition) : base(XPosition, YPosition)
        {

        }

        public abstract override string ToString();
    }
}
