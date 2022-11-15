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
        


        private Map MapRef;
        public Map Map
        {
            get { return MapRef; }
            set { MapRef= value; }
        }

        private Shop ShopRef;
        public Shop Shop
        {
            get { return ShopRef; }
            set { ShopRef= value; }
        }

        private Hero HeroRef;
        public Hero Hero
        {
            get { return HeroRef; }
            set { HeroRef= value; }
        }

        public static Tile.TileType Symbol;
        int i = 0;
        public GameEngine()
        {
            Map = new Map(10, 16, 12, 6, 4, 3);
            Shop = new Shop(Hero);
        }

        //Checks the players state, namely if they are alive or dead 

        public void CheckPlayerState(Hero Hero)
        {
            if (Hero.Dead())
            {
                Map.MapGrid[Hero.YValue, Hero.XValue] = new EmptyTIle(Hero.YValue, Hero.XValue);
            }
        }

        public void BuyItem(int Slot)
        {
            //Shop.Debuging();
            
            
            //Check funds and if the buyer has enough then the item is transfered
            //switch (Shop.Weapons[Slot].CurrectWeapon)
            //{
            //    case "Dagger":
            //        Shop.Buy(Shop.Weapons[Slot].WeaponCost, Slot);
            //        MessageBox.Show(Shop.Weapons[Slot].WeaponCost.ToString());
            //        break;
            //    case "LongSword":
            //        Shop.Buy(Shop.Weapons[Slot].WeaponCost, Slot);
            //        break;
            //}


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
            for (int EnemyNum = 0; EnemyNum < Map.TotalEnemyCount; EnemyNum++) 
            {
                if (Map.Enemies[EnemyNum].CheckRange(Map.Hero))
                {
                    //Debug.WriteLine(Map.Enemies[EnemyNum].EnemyType.ToString()+Map.Enemies[EnemyNum].XValue.ToString()+Map.Enemies[EnemyNum].YValue.ToString());
                    Map.Enemies[EnemyNum].Attack(Map.Hero);
                }

                if (MapRef.Enemies[EnemyNum].Symbol == Tile.TileType.Mage)
                {
                    for (int TargetsInRange = 0; TargetsInRange < Map.TotalEnemyCount; TargetsInRange++)
                    {
                        if (MapRef.Enemies[EnemyNum].CheckRange(Map.Enemies[TargetsInRange]))
                        {
                           
                            Map.Enemies[EnemyNum].Attack(Map.Enemies[TargetsInRange]);
                            CheckEnemyState(MapRef.Enemies[TargetsInRange]);
                        }

                        
                    }
                }

                
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
