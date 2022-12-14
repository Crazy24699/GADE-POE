using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GADEpart1
{
    public class Tile
    {
        protected int x;
        protected int y;

        //Symbols for the map
        public enum TileType
        {
            Hero = 'H',
            SwampCreature = 'C',

            Leader = 'L',
            Mage = 'M',
            Gold = 'G',
            Dagger = 'D',
            LongSword = '$',
            LongBow = 'B',
            Rifle = 'R',
            EmptyTile = 'o',
            Obstacle = 'X',
            
        }

        public int XValue
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }


        }
        public int YValue
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }

        }

        public TileType Symbol
        {
            get;
            set;
        }



        //an actual contructor class that works


        public Tile(int x, int y)
        {
            XValue = x;
            YValue = y;

        }

       
    }

    public class Obstacle : Tile
    {
        public Obstacle(int XPosition, int YPosition) : base(XPosition, YPosition)
        {
            Symbol = TileType.Obstacle;
        }

    }



    public class EmptyTIle : Tile
    {
        public EmptyTIle(int XPosition, int YPositon) : base(XPosition, YPositon)
        {
            Symbol = TileType.EmptyTile;
        }
    }


}
