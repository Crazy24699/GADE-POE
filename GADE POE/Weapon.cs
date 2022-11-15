using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    public abstract class Weapon : Item
    {
        protected int Damage;
        public int WeaponDamage
        {
            get { return Damage; }
            set { Damage = value; }
        }
        protected int Range;
        public virtual int WeaponRange
        {
            get { return Range; }
            set { Range = value; }
        }
        protected int Durability;
        public int WeaponDurability
        {
            get { return Durability; }
            set { Durability = value; }
        }
        protected int Cost;
        public int WeaponCost
        {
            get { return Cost; }
            set { Cost = value; }
        }
        public enum Type
        {
            Dagger,
            Longsword,
            Longbow,
            Rifle
        }
        public Type WeaponType
        {
            get;
            set;
        }
        
          
        


        public string CurrentWeapon
        {
            get { return CurrentWeapon; }
            set { CurrentWeapon = value; }
        }

        /*public string NewWeapon
        {
            get { return NewWeapon; }
            set { NewWeapon = value; }
        }*/
        public Weapon(int XPosition,int YPosition) : base(XPosition,YPosition)
        {
            Symbol = TileType.LongSword;
            Symbol = TileType.Dagger;
            Symbol = TileType.LongBow;
            Symbol = TileType.Rifle;

        }
    }
}
