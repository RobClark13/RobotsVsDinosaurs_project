using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        //member variables (HAS A)
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;
        Weapon robotWeapon;

        //constructor
        public Robot(string robotName, int robotHealth, int robotPowerLevel, string weaponName, int weaponAttackPower)
        {
            this.robotName = robotName;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            this.robotWeapon = new Weapon(weaponName, weaponAttackPower);
        }

        //member methods (CAN DO)

        public void RobotAttack(Dinosaur dinosaur)
        {
            dinosaur.dinoHealth -= robotWeapon.weaponAttackPower;
        }




    }
}

    