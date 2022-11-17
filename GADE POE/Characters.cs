using GADE_POE;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADEpart1
{
    public abstract class Characters : Tile
    {

        public Characters(int x, int y) : base(x, y)
        {

        }

        protected int HP { get; set; }
        protected int TotalHP { get; set; }

        public int CurrentHP
        {
            get { return HP; }
            set { HP = value; }
        }
        public int MaxHP
        {
            get { return TotalHP; }
            set { TotalHP = value; }
        }
        protected int Damage { get; set; }
        public int TargetDistance = 0;
        public int XDistance = 0;
        protected int YDistance = 0;

        public int GoldStored { get; set; }

        public int Direction;

        
        public string CurrentWeapon { get; set; }


        public enum Movements
        {
            NoMovement,
            Up,
            Down,
            Left,
            Right,
        }
        public Tile[] CharacterView { get; set; } = new Tile[5];
        public bool Dead()
        {
            return CurrentHP <= 0;
        }

        public virtual bool CheckRange(Characters target)
        {

            return DistanceTo(target) == 1;
        }


        public void ChooseDirection(Hero Hero)
        {
            Debug.WriteLine(Hero.XValue);
            int YVal = this.YValue - Hero.YValue;
            int XVal = this.XValue - Hero.XValue;
            if (YVal< 0)
            {
                YVal *= -1;
            }
            if(XVal< 0)
            {
                XVal *= -1;
            }
            if (YVal > XVal)
            {
                if (this.YValue < Hero.YValue)
                {
                    //Down  1
                    Direction = 2;
                    //Debug.WriteLine(Direction);
                }

                if (this.YValue > Hero.YValue)
                {
                    //Up    2
                    Direction = 1;
                    //Debug.WriteLine(Direction);
                }

            }


            if (XVal == YVal && XVal<=1 && YVal<=1) 
            {
                Debug.WriteLine("Go random");
            }


            if (YVal < XVal)
            {
                if (this.XValue<Hero.XValue)
                {
                    //left  3
                    Direction = 4;
                    //Debug.WriteLine(Direction);
                }

                if (this.XValue>Hero.XValue)
                {
                    //right 4
                    Direction = 3;
                    //Debug.WriteLine(Direction);
                }
            }
        }

        public int DistanceTo(Characters target)
        {

            TargetDistance = Math.Abs((target.x - XValue) + (target.y - YValue));
            //XDistance = target.x - XValue;
            //YDistance = target.y - YValue;
            
            return TargetDistance;
        }

        public void Attack(Characters Target)
        {
            Target.HP = Target.HP - Damage;
        }

        public void PickUp(Item ItemPickup)
        {

            if (ItemPickup.Symbol == TileType.Gold)
            {
                GoldStored += ItemPickup.GoldAmount;
            }
           
            
        }
        //loot function
        public void Loot(Characters Target)
        {

            if (Target.HP == 0)
            {
                GoldStored = Target.GoldStored + GoldStored;
            }
        }

        public void Move(Movements move, Tile TileEntity)
        {

            Map.MapGrid[YValue, XValue] = new EmptyTIle(XValue, YValue);
            if (move == Movements.Up)
            {
                YValue = YValue - 1;
                //Debug.WriteLine("upwards");
            }
            if (move == Movements.Down)
            {
                YValue = YValue + 1;
            }
            if (move == Movements.Right)
            {
                XValue = XValue + 1;
                //Debug.WriteLine("Right");
            }
            if (move == Movements.Left)
            {
                XValue = XValue - 1;
            }
            if (move == Movements.NoMovement)
            {
                
            }

            Map.MapGrid[YValue, XValue] = TileEntity;
        }

        public abstract Movements ReturnMove(Movements move = 0);

        public abstract override string ToString();






    }
}