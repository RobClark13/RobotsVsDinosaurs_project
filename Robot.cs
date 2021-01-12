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
        public List<Weapon> weaponList = new List<Weapon>()

        {
        new Weapon ("Electroshock", 1),
        new Weapon ("E-5 Blaster", 2),
        new Weapon("Vibroblade", 3),
        new Weapon ("Bowcaster", 4)
        };
        Random rand;

        //constructor
        public Robot(string robotName, int robotHealth, int robotPowerLevel, string weaponName, int weaponAttackPower)
        {
            this.robotName = robotName;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            this.robotWeapon = new Weapon(weaponName, weaponAttackPower); //RobotChooseWeapon();
        }

        //member methods (CAN DO)

        public int WeaponChoiceNumber()
        {
            return rand.Next(3);
        }

        public void RobotAttack(Dinosaur dinosaur)
        {
            dinosaur.dinoHealth -= robotWeapon.weaponAttackPower;
            robotPowerLevel -= 10;
        }

        public void RobotRest()
        {
            robotPowerLevel = 100;
            Console.WriteLine(robotName+ " shuts down for maintenance");
        }

        public void RobotChooseWeapon()
        {




        }
        




    }
}

    