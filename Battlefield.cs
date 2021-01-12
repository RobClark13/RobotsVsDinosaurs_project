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
            WeaponList weapon_List = new WeaponList();
            Fleet fleet = new Fleet();
            Herd herd = new Herd();
           
        Console.WriteLine("Welcome to the Jungle");
            fleet.fleetList[0].RobotChooseWeapon(fleet);
            while (fleet.fleetList.Count > 0 && herd.herdList.Count > 0)
            {
                fleet.fleetList[0].RobotAttack(herd.herdList[0]);
                herd.herdList[0].DinoChooseAttack(fleet.fleetList[0]);
                Console.WriteLine(herd.herdList[0].dinoName + "'s health is at: " + herd.herdList[0].dinoHealth);
                Console.WriteLine(fleet.fleetList[0].robotName + "'s health is at: " + fleet.fleetList[0].robotHealth);

                if (herd.herdList[0].dinoEnergy <= 0 && fleet.fleetList[0].robotPowerLevel <= 0)
                {
                    herd.herdList[0].DinoRest();
                    fleet.fleetList[0].RobotRest();
                }
                else if (herd.herdList[0].dinoEnergy <= 0)
                {
                    herd.herdList[0].DinoRest();
                    fleet.fleetList[0].RobotAttack(herd.herdList[0]);
                }
                else if (fleet.fleetList[0].robotPowerLevel <= 0)
                {
                    fleet.fleetList[0].RobotRest();
                    herd.herdList[0].DinoChooseAttack(fleet.fleetList[0]);
                }

                if (fleet.fleetList[0].robotHealth <= 0)
                {
                    Console.WriteLine(fleet.fleetList[0].robotName + " is defeated");
                    Console.ReadLine();
                    fleet.fleetList.RemoveAt(0);
                    fleet.fleetList[0].RobotChooseWeapon(fleet);
                }
                else if (herd.herdList[0].dinoHealth <= 0)
                {
                    Console.WriteLine(herd.herdList[0].dinoName + " is defeated");
                    Console.ReadLine();
                    herd.herdList.RemoveAt(0);
                }

            }
            if (fleet.fleetList.Count == 0)
            {
                Console.WriteLine("Dinosaurs Win");

            }
            else
            {
                Console.WriteLine("Robots Win");
            }

            Console.ReadLine();
                     
                        
           


            
            




            
            
            





        }




        

    }
        
        

        
    
    
}


