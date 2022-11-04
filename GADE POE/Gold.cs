using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_POE
{
    public class Gold : Item
    {
        private Random Rnd = new Random();

        //public int ReturnGold()
        //{
        //    return GoldAmount;
        //}

        //used for loading from the save file 
        //public Gold(int XPosition, int YPosition, int GoldAmountSaved) : base(XPosition, YPosition)
        //{
        //    GoldAmount = Rnd.Next(1, 6);
        //    Symbol = TileType.Gold;
        //}


        public Gold(int XPosition, int YPosition) : base(XPosition, YPosition)
        {
            GoldAmount = Rnd.Next(1, 6);
            Symbol = TileType.Gold;
        }

        public override string ToString()
        {
            return TileType.Gold.ToString();
        }
    }
}
