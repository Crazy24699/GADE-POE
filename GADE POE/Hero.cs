using GADE_POE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADEpart1
{
    public class Hero : Characters
    {
        //the hero constructor class
        public Hero(int x, int y, int MaxHp) : base(x, y)
        {
            Damage = 2;
            MaxHP = 10;
            HP = MaxHP;
            Symbol = TileType.Hero;
            //HeldWeapon = CurrentWeapon;
            

        }

       

        public bool OnGoldTile { get; set; } = false;

        public override Movements ReturnMove(Movements move)
        {
            //Add functionality for if the player can move, if they are against a wall then they can not.
            if (CharacterView[(int)move].Symbol == TileType.EmptyTile)
            {
                return move;
            }
            else if (CharacterView[(int)move].Symbol == TileType.Gold)
            {
                OnGoldTile = true;
                return move;
            }

            return Movements.NoMovement;
        }

        public override string ToString()
        {
            // not sure how to actually get the weapon info to show up.
            // if the hero has a weapon the durability must be shown as well.

            return "PlayerStats:    \nHP:" + HP + "\nCurrent Weapon:" + "\nWeapon Range" + "\nWeapon Damage:" + Damage + "\nDurability:" +"\nGold" + GoldStored +"\n [" + x + "," + y + "]";
        }

    }
}
