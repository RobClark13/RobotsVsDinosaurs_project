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
            robot.robotHealth -=  dinoAttackPower;
        }

        public int DinoAttackNumber()
        {
            return dinorand.Next(3);

        }
        
        public void DinoChooseAttack(Robot robot)
        {        
        
            int dinoAttackNumber = DinoAttackNumber();
            Console.WriteLine(dinoAttackNameArray[dinoAttackNumber]);
            Console.WriteLine(dinoAttackPowerArray[dinoAttackNumber]);
            robot.robotHealth -= dinoAttackPowerArray[dinoAttackNumber];
        }






    }
}
