using GADEpart1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_POE
{
    public class GameEngine
    {

        //private Gold[] GoldObject;
        //public Gold[] GoldRef
        //{
        //    get { return GoldObject; }
        //    set { GoldObject = value; }
        //}
        //public int MapHeight;
        //public int MapWidth;
        //public int EnemyCount;
        //public int HP;
        //public int HeroXCord;
        //public int HeroYCord;


        private Map MapRef;
        public Map Map
        {
            get { return MapRef; }
            set { MapRef= value; }
        }


        //public Enemy[] enemies;
        //public Enemy[] Enemies
        //{
        //    get
        //    {
        //        return enemies;
        //    }
        //    set
        //    {
        //        enemies = value;
        //    }
        //}

        public static Tile.TileType Symbol;

        //public bool UpInput = true, DownInput = true, LeftInput = true, RightInput = true;
        //public bool CanMove = true;        //If the player is able to move, if there arent any obstacles in the way. 



        //public SwampCreature SwampCreatureRef = new SwampCreature(0, 0, 0);
        //public Mage MageRef = new Mage(0, 0, 0);

        int i = 0;
        public GameEngine()
        {
            Map = new Map(10, 16, 12, 6, 4, 3);
        }


        public void RandomizeGold()
        {
            //GoldRef = new Gold[5];
            //for (; i < 5;)
            //{
            //    //the random gold values
            //    Random GldRnd = new Random();
            //    Random GoldX = new Random();
            //    Random GoldY = new Random();
            //    int X = GoldX.Next(3, 10);
            //    int Y = GoldY.Next(3, 6);


            //    //GoldRef[i] = new Gold(Y, ,5X);
            //    //GoldRef[i].Xposition = X;
            //    //GoldRef[i].Yposition = Y;
            //    //MapGrid[Y, X] = "G";


            //    i++;

            //}

        }

        //Checks the players state, namely if they are alive or dead 

        public void CheckPlayerState(Hero Hero)
        {
            if (Hero.Dead())
            {
                Map.MapGrid[Hero.YValue, Hero.XValue] = new EmptyTIle(Hero.YValue, Hero.XValue);
            }
        }

        public void CheckEnemyState(Enemy Enemy)
        {
            if (Enemy.Dead())
            {
                for (int i = Enemy.EnemyArray; i < Map.TotalEnemyCount - 1; i++)
                {
                    Map.Enemies[i] = Map.Enemies[i + 1];
                    Map.Enemies[i].EnemyArray--;
                }
                Map.TotalEnemyCount--;

                Map.MapGrid[Enemy.YValue, Enemy.XValue] = new EmptyTIle(Enemy.XValue, Enemy.YValue);
            }
        }

        public void EnemyMovement()
        {
            for (int EnemyNum = 0; EnemyNum < Map.TotalEnemyCount; EnemyNum++)
            {
                Map.Enemies[EnemyNum].Move(Map.Enemies[EnemyNum].ReturnMove(), Map.Enemies[EnemyNum]);
                Map.UpdateVision();


            }
        }

        //public void DefineBarrier()
        //{
        //    if (Hero.XValue >= 14)
        //    {
        //        RightInput = false;
        //    }
        //    if (Hero.YValue >= 6)
        //    {
        //        DownInput = false;
        //    }
        //    if (Hero.XValue <= 1)
        //    {
        //        LeftInput = false;
        //    }
        //    if (Hero.YValue <= 1)
        //    {
        //        UpInput = false;
        //    }


        //    if (Hero.XValue <= 13)
        //    {
        //        RightInput = true;
        //    }
        //    if (Hero.YValue <= 5)
        //    {
        //        DownInput = true;
        //    }
        //    if (Hero.XValue >= 2)
        //    {

        //        LeftInput = true;
        //    }
        //    if (Hero.YValue >= 2)
        //    {
        //        UpInput = true;
        //    }


        //}

        public void EnemyAttack()
        {
            for (int EnemyNum = 0; EnemyNum < Map.TotalEnemyCount;)
            {
                if (Map.Enemies[EnemyNum].CheckRange(Map.Hero))
                {
                    Map.Enemies[EnemyNum].Attack(Map.Hero);
                }

                if (MapRef.Enemies[EnemyNum].Symbol == Tile.TileType.Mage)
                {
                    for (int TargetsInRange = 0; TargetsInRange < Map.TotalEnemyCount;)
                    {
                        if (MapRef.Enemies[EnemyNum].CheckRange(Map.Enemies[TargetsInRange]))
                        {
                            Map.Enemies[EnemyNum].Attack(Map.Enemies[EnemyNum]);
                            CheckEnemyState(MapRef.Enemies[EnemyNum]);
                        }

                        TargetsInRange++;
                    }
                }

                EnemyNum++;
            }
            CheckPlayerState(Map.Hero);
        }

        public void MovePlayer(Characters.Movements Direction)
        {

            Map.Hero.Move(Map.Hero.ReturnMove(Direction), Map.Hero);
            if (Map.Hero.OnGoldTile)
            {
                Map.Hero.PickUp(Map.GetPositonInfo(Map.Hero.XValue, Map.Hero.YValue));
                Map.Hero.OnGoldTile = false;
            }
            Map.UpdateVision();
        }

        public void Save()
        {
            string filename = "map.bin";

            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            //bw.Write(MapImage);

            bw.Close();
            fs.Close();

            Debug.WriteLine(fs.Name);
        }

        public void Load()
        {
            FileStream fs = new FileStream("map.bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            string previousMap = br.ReadInt32() + ":" + br.ReadInt32();
            Console.WriteLine(previousMap);
        }

    }
}
