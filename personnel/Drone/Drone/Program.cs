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
            Drone drone1 = new Drone(10, 6, 76);
            Drone drone2 = new Drone(13, 4, 66);


            while (drone1.Batterie > 0 || drone2.Batterie > 0)
            {
                Console.Clear();
                drone1.changeState();
                drone1.draw();
                drone2.changeState();
                drone2.draw();
                Thread.Sleep(100);
            }
        }
    }
}
