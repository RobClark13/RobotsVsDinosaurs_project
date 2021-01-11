using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {



        //member variables
        

        //constructor



        //member methods



        public void RunBattle()
        {
            Fleet fleet = new Fleet();
            Herd herd = new Herd();
           
        Console.WriteLine("Welcome to the Jungle");
            while (fleet.fleetList[0].robotHealth > 0 && herd.herdList[0].dinoHealth > 0)
            {
                fleet.fleetList[0].RobotAttack(herd.herdList[0]);
                herd.herdList[0].DinoAttack(fleet.fleetList[0]);
                Console.WriteLine(herd.herdList[0].dinoName + "'s health is at: " + herd.herdList[0].dinoHealth);
                Console.WriteLine(fleet.fleetList[0].robotName + "'s health is at: " + fleet.fleetList[0].robotHealth);

                Console.ReadLine();
                if (fleet.fleetList[0].robotHealth <= 0)
                {
                    fleet.fleetList.RemoveAt(0);
                }
                else if (herd.herdList[0].dinoHealth <= 0)
                {
                    herd.herdList.RemoveAt(0);
                }
            }
           
                     
                        
           


            
            




            
            
            





        }




        

    }
        
        

        
    
    
}


