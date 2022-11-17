using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    internal class RangedWeapon : Weapon
    {
        public enum Types
        {
            Rifle,
            Longbow
        }
        //Ranged weapons stats
        public RangedWeapon(int XPosition, int YPosition, Types Weapons) : base(XPosition, YPosition)
        {
            if (Weapons == Types.Rifle)
            {
                WeaponDurability = 3;
                WeaponRange = 3;
                WeaponDamage = 5;
                WeaponCost = 7;
            }
            if (Weapons == Types.Longbow)
            {
                WeaponDurability = 4;
                WeaponRange = 2;
                WeaponDamage = 4;
                WeaponCost = 6;
            }
        }

        public override string ToString()
        {
            return null;
        }

        public override int WeaponRange { get => base.WeaponRange; set => base.WeaponRange = 1; }
    }
}
