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

        public string CurrentWeapon;
        public int WeaponDurability;
        public int WeaponRange;


        //the hero constructor class
        public Hero(int x, int y, int MaxHp) : base(x, y)
        {
            Damage = 2;
            MaxHP = 100;
            HP = MaxHP;
            Symbol = TileType.Hero;
            GoldStored = 10;
            //HeldWeapon = CurrentWeapon;
            
            

        }


        public void ReadWeapon()
        {
            switch (CurrentWeapon)
            {
                default:
                    CurrentWeapon = "Bare Hands";
                    break;
                case "Dagger":
                    CurrentWeapon = "Dagger";
                    break;
                case "Longsword":
                    CurrentWeapon = "Longsword";
                    break;
                case "Longbow":
                    CurrentWeapon = "Longbow";
                    break;
                case "Rifle":
                    CurrentWeapon = "Rifle";
                    break;
            }

            if (CurrentWeapon == "Bare Hands")
            {
                Damage = 2;
                WeaponRange = 1;
            }
            else if (CurrentWeapon == "Dagger")
            {
                Damage = 3;
                WeaponDurability = 10;
                WeaponRange = 1;
            }
            else if (CurrentWeapon == "Longsword")
            {
                Damage = 4;
                WeaponDurability = 6;
                WeaponRange = 1;
            }
            else if (CurrentWeapon == "Longbow")
            {
                Damage = 4;
                WeaponDurability = 4;
                WeaponRange = 2;
            }
            else if (CurrentWeapon == "Rifle")
            {
                Damage = 5;
                WeaponDurability = 3;
                WeaponRange = 3;
            }
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
            else return Movements.NoMovement;

            //update the polayers damage when they get a new weapon 


        }

        public override string ToString()
        {
            // not sure how to actually get the weapon info to show up.
            // if the hero has a weapon the durability must be shown as well.

            return "PlayerStats: \nHP:" + HP + "\nCurrent Weapon: " + CurrentWeapon + "\nWeapon Range: " + WeaponRange + "\nWeapon Damage:" + Damage + "\nDurability: " + WeaponDurability + "\nGold" + GoldStored + "\n [" + x + "," + y + "]";
        }

    }
}
