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

        public string HeroWeapon;
        public int WeaponDurability;
        public int WeaponRange;


        //the hero constructor class
        public Hero(int x, int y, int MaxHp) : base(x, y)
        {
            Damage = 2;
            MaxHP = 20;
            HP = MaxHP;
            HeroWeapon = CurrentWeapon;
            Symbol = TileType.Hero;
            GoldStored = 10;
            //HeldWeapon = CurrentWeapon;
            ReadWeapon();
            
            if (HP == 0)
            {
                MessageBox.Show("You Died");
                Application.Exit();
            }

        }

        // Puts the weapon and its stats in the Hero's stats
        public void ReadWeapon()
        {
            switch (HeroWeapon)
            {
                default:
                    HeroWeapon = "Bare Hands";
                    Damage = 2;
                    WeaponRange = 1;
                    break;
                case "Dagger":
                    HeroWeapon = "Dagger";
                    Damage = 3;
                    WeaponDurability = 10;
                    WeaponRange = 1;
                    break;
                case "Longsword":
                    HeroWeapon = "Longsword";
                    Damage = 4;
                    WeaponDurability = 6;
                    WeaponRange = 1;
                    break;
                case "Longbow":
                    HeroWeapon = "Longbow";
                    Damage = 4;
                    WeaponDurability = 4;
                    WeaponRange = 2;
                    break;
                case "Rifle":
                    HeroWeapon = "Rifle";
                    Damage = 5;
                    WeaponDurability = 3;
                    WeaponRange = 3;
                    break;
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


        }

        public override string ToString()
        {
            //The heros stats

            return "PlayerStats: \nHP:" + HP + "\nCurrent Weapon: " + HeroWeapon + "\nWeapon Range: " + WeaponRange + "\nWeapon Damage:" + Damage + "\nDurability: " + WeaponDurability + "\nGold" + GoldStored + "\n [" + x + "," + y + "]";
        }

    }
}
