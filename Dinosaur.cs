using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        public string dinoName;
        public int dinoHealth;
        public int dinoEnergy;
        public int dinoAttackPower;
        Random dinorand;
        public string[] dinoAttackNameArray = { "Tail Swing", "Head Butt", "Claw", "Bite" };
        public int[] dinoAttackPowerArray = { 1, 2, 3, 4 };


        public Dinosaur(string dinoName, int dinoHealth, int dinoEnergy, int dinoAttackPower)
        {
            this.dinoName = dinoName;
            this.dinoHealth = dinoHealth;
            this.dinoEnergy = dinoEnergy;
            this.dinoAttackPower = dinoAttackPower;
            dinorand = new Random();
        }


        public void DinoAttack(Robot robot)
        {
            robot.robotHealth -= dinoAttackPower;
        }

        public int DinoAttackNumber()
        {
            return dinorand.Next(3);

        }

        public int DinoAttackModifier()
        {
            return dinorand.Next(1, 5);

        }

        public void DinoChooseAttack(Robot robot)
        {
            int dinoAttackNumber = DinoAttackNumber();
            int dinoAttackModifier = DinoAttackModifier();
            robot.robotHealth -= dinoAttackPowerArray[dinoAttackNumber] * dinoAttackModifier;
            dinoEnergy -= 10;
            Console.WriteLine(dinoEnergy);
            Console.ReadLine();
        }

        public void DinoRest()
        {
            Console.WriteLine(dinoName + " takes a nap" ); 
            dinoEnergy = 100;

        }







    }
}
