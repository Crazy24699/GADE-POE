using GADE_POE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADEpart1
{
    public class Map
    {

        ///<summary> 
        ///you want to switch all this to a string jaggad array and not a char one  
        ///Char only has one character per text and the advantages of it being used here 
        ///wont show up for us
        /// </summary>

        //public int MapHeight = 0;
        //public int MapWidth = 0;
        public int xAxis = 0;
        public int yAxis = 0;
        public Random Rnd = new Random();

        private Enemy[] enemies;
        public Enemy[] Enemies { get; set; }
        public Item[] Items { get; set; }

        private Hero HeroRef;
        public Hero Hero
        {
            get { return HeroRef; }
            set { HeroRef = value; }

        }

        public string MapImage;

        public int TotalGold;
        public int GoldNum;

        public int TotalEnemyCount;
        public int EnemyCount;

        public int[,] EnemyCords = {

            {0,0},          //enemies 1 through 5, the cords of the tiles they are on 
            {0,0},
            {0,0},
            {0,0},
            {0,0},

        };

        public static Tile[,] MapGrid { get; set; }



        //I have both the x and y cords here as well as the actual names of the text boxes, whichever we dont use we delete.

        //public int[] XBarier =
        //{
        //    1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,
        //};
        //public int[] YBarrier =
        //{
        //    1,2,3,4,5,6,7,8,
        //};

        //public string[] Barrier =
        //{

        //    //might have to change this to x and y cords. Depends 
        //    "1;1","1;2","1;3","1;4","1;5","1;6","1;7","1;8","1;9","1;10","1;11","1;12","1;13","1;14","1;15","1;16",
        //    "2;1","3;1","4;1","5;1","6;1","7;1",
        //    "2;16","3;16","4;16","5;16","6;16","7;16",
        //    "8;1","8;2","8;3","8;4","8;5","8;6","8;7","8;8","8;9","8;10","8;11","8;12","8;13","8;14","8;15","8;16",


        //                            //NOTE TO THE PERSON MARKING THIS

        //    //If i had more time i would have loved to make it search the active form for any text boxes that have the letter 'x'
        //    //in them, but there is not enough time for how much we have to do so here is a very bad way of doing a world barrier. 

        //};




        //creates a new public random x and y value for the hero's cordinates
        public Random HeroX = new Random();
        public Random HeroY = new Random();


        public Map(int MaxHeight, int MaxWidth, int MinWidth, int MinHight, int EnemyCountRef, int TotalGoldPiles)
        {
            yAxis = Rnd.Next(MinHight, MaxHeight);
            xAxis = Rnd.Next(MinWidth, MaxWidth);
            MapGrid = new Tile[yAxis, xAxis];

            TotalEnemyCount = EnemyCountRef;
            Enemies = new Enemy[TotalEnemyCount];

            TotalGold = TotalGoldPiles;
            Items = new Item[TotalGold];


            for (int Row = 0; Row < MapGrid.GetLength(0); Row++)
            {
                for (int Column = 0; Column < MapGrid.GetLength(1); Column++)
                {
                    //will set the top and bottom to a barrier (Obstacle)
                    if (Row == 0 || Row == yAxis - 1)
                    {
                        MapGrid[Row, Column] = new Obstacle(Column, Row);
                    }
                    //Will set the right and left walls to the barrier(Obstacle)
                    else if (Column == 0 || Column == xAxis - 1)
                    {
                        MapGrid[Row, Column] = new Obstacle(Column, Row);
                    }
                    //Sets the remaning parts of the map to empty tiles
                    else
                    {
                        MapGrid[Row, Column] = new EmptyTIle(Column, Row);
                    }
                }
            }

            int RandomizeEnemies;
            for (EnemyCount = 0; EnemyCount < TotalEnemyCount; EnemyCount++)
            {
                RandomizeEnemies = Rnd.Next(3);
                if (RandomizeEnemies == 0)
                {
                    TileCreate(Tile.TileType.SwampCreature);
                }
                if (RandomizeEnemies == 1)
                {
                    TileCreate(Tile.TileType.Mage);
                }
                if (RandomizeEnemies == 2)
                {
                    TileCreate(Tile.TileType.Leader);
                }

            }

            for (GoldNum = 0; GoldNum < TotalGold; GoldNum++)
            {
                TileCreate(Tile.TileType.Gold);
            }

            TileCreate(Tile.TileType.Hero);
            UpdateVision();
        }



        //saves all the coordinates of the players and enemies on the map. 
        public void UpdateVision()
        {
            Hero.CharacterView[0] = MapGrid[Hero.YValue, Hero.XValue];
            Hero.CharacterView[1] = MapGrid[Hero.YValue - 1, Hero.XValue];
            Hero.CharacterView[2] = MapGrid[Hero.YValue + 1, Hero.XValue];
            Hero.CharacterView[3] = MapGrid[Hero.YValue, Hero.XValue - 1];
            Hero.CharacterView[4] = MapGrid[Hero.YValue, Hero.XValue + 1];

            for (int i = 0; i < TotalEnemyCount; i++)
            {
                Enemies[i].CharacterView[0] = MapGrid[Enemies[i].YValue, Enemies[i].XValue];
                Enemies[i].CharacterView[1] = MapGrid[Enemies[i].YValue - 1, Enemies[i].XValue];
                Enemies[i].CharacterView[2] = MapGrid[Enemies[i].YValue + 1, Enemies[i].XValue];
                Enemies[i].CharacterView[3] = MapGrid[Enemies[i].YValue, Enemies[i].XValue - 1];
                Enemies[i].CharacterView[4] = MapGrid[Enemies[i].YValue, Enemies[i].XValue + 1];
            }

        }


        public Item GetPositonInfo(int ItemXVal, int ItemYVal)
        {
            Item ItemAtPosition;

            for (int ItemList = 0; ItemList < Items.Length; ItemList++)
            {
                if (Items[ItemList] != null)
                {
                    if (Items[ItemList].XValue == ItemXVal && Items[ItemList].YValue == ItemYVal)
                    {

                        ItemAtPosition = Items[ItemList];
                        Items[ItemList] = null;
                        return ItemAtPosition;

                    }
                }


                
            }

            return null;
        }

        public Tile TileCreate(Tile.TileType Type)
        {
            int PositionX = 0;
            int PositionY = 0;

            do
            {
                PositionX = Rnd.Next(1, xAxis - 1);
                PositionY = Rnd.Next(1, yAxis - 1);
            }
            while (MapGrid[PositionY, PositionX].Symbol != Tile.TileType.EmptyTile);


            if (Type == Tile.TileType.SwampCreature)
            {
                Enemies[EnemyCount] = new SwampCreature(PositionX, PositionY, EnemyCount);
                MapGrid[PositionY, PositionX] = Enemies[EnemyCount];
            }
            else if (Type == Tile.TileType.Mage)
            {
                Enemies[EnemyCount] = new Mage(PositionX, PositionY, EnemyCount);
                MapGrid[PositionY, PositionX] = Enemies[EnemyCount];
            }
            else if (Type == Tile.TileType.Leader)
            {
                Enemies[EnemyCount] = new Leader(PositionX, PositionY, EnemyCount);
                MapGrid[PositionY, PositionX] = Enemies[EnemyCount];
            }
            else if (Type == Tile.TileType.Hero)
            {
                Hero = new Hero(PositionX, PositionY, 30);
                MapGrid[PositionY, PositionX] = Hero;
            }
            else
            {
                Items[GoldNum] = new Gold(PositionX, PositionY);
                MapGrid[PositionY, PositionX] = Items[GoldNum];
            }

            return MapGrid[PositionY, PositionX];
        }


        public void GenerateGold()
        {

        }

        public void GenerateMap()
        {
            MapImage = "";
            for (int row = 0; row < MapGrid.GetLength(0); row++)
            {
                for (int column = 0; column < MapGrid.GetLength(1); column++)
                {
                    MapImage = MapImage + (char)MapGrid[row, column].Symbol;
                }
                MapImage = MapImage + "\n";
            }
        }

        public override string ToString()
        {
            string MapImages = "";
            for (int row = 0; row < MapGrid.GetLength(0); row++)
            {
                for (int column = 0; column < MapGrid.GetLength(1); column++)
                {
                    MapImages = MapImages + (char)MapGrid[row, column].Symbol;
                }
                MapImages = MapImages + "\n";
            }
            return MapImages;
        }

    }
}
