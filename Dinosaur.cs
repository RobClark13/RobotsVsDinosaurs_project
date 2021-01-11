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

        public Dinosaur(string dinoName, int dinoHealth, int dinoEnergy, int dinoAttackPower)
        {
            this.dinoName = dinoName;
            this.dinoHealth = dinoHealth;
            this.dinoEnergy = dinoEnergy;
            this.dinoAttackPower = dinoAttackPower;
        }

        public void DinoAttack(Robot robot)
        {
            robot.robotHealth -= dinoAttackPower;
        }






    }
}
