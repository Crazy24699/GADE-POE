using GADEpart1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_POE
{
    public class Shop
    {
        //public Weapon[] Weapons= new Weapon[3];
        private Weapon[] WeaponRef;
        public Weapon[] Weapons
        {
            get;
            set;
        }
        private Random Rnd = new Random();

        public int XPos;
        public int YPos;
        //the person buying the gold
        private Characters Character { get; set; }


        public Shop(Characters Buyer) 
        {
            Weapons = new Weapon[3];
            for (int i = 0; i < Weapons.Length; i++)
            {
                RandomWeapon(i);

                //MessageBox.Show(Weapons[i].WeaponType.ToString());
            }



        }
        private Weapon RandomWeapon(int WeaponSlot)
        {
            int RandomWeapon = 0;
            RandomWeapon = Rnd.Next(1, 5);
            Debug.WriteLine(RandomWeapon);
            


                    //picks a random weapon based on the random variable it generated at the beggining of the code
            switch (RandomWeapon)
            {
                case 1:
                    Weapons[WeaponSlot] = new MeleeWeapon(XPos, YPos, MeleeWeapon.Types.Dagger);
                    Weapons[WeaponSlot].WeaponType = Weapon.Type.Dagger;
                    
                    break;
                case 2:
                    Weapons[WeaponSlot] = new MeleeWeapon(XPos, YPos, MeleeWeapon.Types.LongSword);
                    Weapons[WeaponSlot].WeaponType = Weapon.Type.Longsword;
                    break;
                case 3:
                    Weapons[WeaponSlot] = new RangedWeapon(XPos, YPos, RangedWeapon.Types.Longbow);
                    Weapons[WeaponSlot].WeaponType = Weapon.Type.Longbow;

                    break;
                case 4:
                    Weapons[WeaponSlot] = new RangedWeapon(XPos, YPos, RangedWeapon.Types.Rifle);
                    Weapons[WeaponSlot].WeaponType = Weapon.Type.Rifle;
                    break;
            }

            return null;
        }

                    //testing
        public void handleWeapon(int Slot)
        {
            RandomWeapon(Slot);
        }

        public bool CanBuy(int Num)
        {

            return Character.GoldStored > Num;
        }

        public void Buy(int num, int SlotTaken)
        {

            //checks if the target thats buying the item has enough money to buy the item from them 
            if (CanBuy(num)) 
            {
                //the if target thats buying does have enough money then it decreases the amount
                Character.GoldStored -= num;
                RandomWeapon(SlotTaken);
            }
        }

        
    }
}
