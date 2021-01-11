using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        Robot r2 = new Robot("R2", 100, 200, "laser", 5);
        Robot c3p0 = new Robot("C3P0", 50, 100, "Slap", 2);
        Robot hk47 = new Robot("HK-47", 500, 500, "Rifle", 10);

        List<Robot> fleetList = new List<Robot>()

        {
        new Robot("R2", 100, 200, "laser", 5),
        new Robot("C3P0", 50, 100, "Slap", 2),
        new Robot("HK-47", 500, 500, "Rifle", 10)

        };




    }
}
