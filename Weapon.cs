using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        public string weaponName;
        public int weaponAttackPower;

        public Weapon(string weaponName, int weaponAttackPower)
        {
            this.weaponName = weaponName;
            this.weaponAttackPower = weaponAttackPower;
        }

    }
}
