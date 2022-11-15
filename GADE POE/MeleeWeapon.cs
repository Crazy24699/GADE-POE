using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_POE
{
    public class MeleeWeapon : Weapon
    {
        public enum Types
        {
            Dagger,
            LongSword
        }

        public MeleeWeapon(int XPosition, int YPosition, Types MeleeTypes) : base(XPosition, YPosition)
        {
            if(MeleeTypes == Types.Dagger)
            {
                WeaponDurability = 10;
                WeaponDamage = 3;
                WeaponCost = 3;
            }
            if(MeleeTypes == Types.LongSword)
            {
                WeaponDurability = 6;
                WeaponDamage = 4;
                WeaponCost = 5;
            }
        }


        public override string ToString()
        {
            return null;
        }

        public override int WeaponRange { get => base.WeaponRange; set => base.WeaponRange = 1; }

    }
}
