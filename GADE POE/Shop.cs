using GADEpart1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    public class Shop
    {
        private Weapon[] Weapons= new Weapon[3];
        private Random Rnd = new Random();

        //the person buying the gold
        private Characters Character { get; set; }


        public Shop(Characters Buyer) 
        {
            for (int i = 0; i < Weapons.Length; i++)
            {


            }
        }

        private Weapon RandomWeapon(Weapon ChosenWeapon)
        {
            int RandomWeapon = 0;
            RandomWeapon = Rnd.Next(0, 4);


                    //picks a random weapon based on the random variable it generated at the beggining of the code
            switch (RandomWeapon)
            {
                case 1:
                    ChosenWeapon.CurrectWeapon = "Dagger";
                    break;
                case 2:
                    ChosenWeapon.CurrectWeapon = "Longsword";
                    break;
                case 3:
                    ChosenWeapon.CurrectWeapon = "Longbow";
                    break;
                case 4:
                    ChosenWeapon.CurrectWeapon = "Rifle";
                    break;
            }


            return ChosenWeapon;
        }


        public bool CanBuy(int Num)
        {

            return Character.GoldStored > Num;
        }

        public void Buy(int num)
        {

                    //checks if the target thats buying the item has enough money to buy the item from them 
            if (CanBuy(num))
            {   
                    //the if target thats buying does have enough money then it decreases the amount
                Character.GoldStored -= num;
            }
        }

        
    }
}
