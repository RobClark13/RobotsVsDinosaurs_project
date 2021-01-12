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
        Random robotRandom;
        Random robotAttackModifier;

        //constructor
        public Robot(string robotName, int robotHealth, int robotPowerLevel, string weaponName, int weaponAttackPower)
        {
            this.robotName = robotName;
            this.robotHealth = robotHealth;
            this.robotPowerLevel = robotPowerLevel;
            this.robotWeapon = new Weapon(weaponName, weaponAttackPower); //RobotChooseWeapon();
            robotRandom = new Random();
            robotAttackModifier = new Random();
        }

        //member methods (CAN DO)

        public int WeaponChoiceNumber()
        {
            return robotRandom.Next(3);
        }

        public int RobotAttackModifier()
        {
            return robotAttackModifier.Next(1,4);

        }

        public void RobotAttack(Dinosaur dinosaur)
        {
            int robotAttackModifier = RobotAttackModifier();
            dinosaur.dinoHealth -= robotWeapon.weaponAttackPower*robotAttackModifier;
            robotPowerLevel -= 10;
        }

        public void RobotRest()
        {
            robotPowerLevel = 100;
            Console.WriteLine(robotName+ " shuts down for maintenance");
        }

        public void RobotChooseWeapon(Fleet fleet)
        {
            int weaponChoiceNumber = WeaponChoiceNumber();
            fleet.fleetList[0].robotWeapon = weaponList[weaponChoiceNumber];
        }
        




    }
}

    