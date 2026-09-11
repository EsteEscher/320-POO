using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable
            List<Drone> drones = new List<Drone>
            {
                new Drone(10, 6, 76),
                new Drone(13, 4, 66)
            };

            int count = 0;

            while (OneIsAlive(drones))
            {
                Console.Clear();

                foreach (Drone drone in drones)
                {
                    drone.changeState();
                    drone.draw();
                }
                Thread.Sleep(150);
                count++;

                if (count == 10)
                {
                    drones.Add(new Drone(12, 4, 50));
                }
            }
        }
        static bool OneIsAlive(List<Drone> drones)
        {
            foreach (Drone drone in drones) 
            {
                if (drone.Batterie > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
