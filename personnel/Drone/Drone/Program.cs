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
            //Premier clear et appariton de départ drone
            Console.Clear();
            Console.Write("x-0-x");

            //Variable
            int posX = 0;
            int posY = 10;
            int posX1 = 5;
            int posY1 = 5;
            int batterie = 50;
            int batterie2 = 50;

            //Boucle pour le faire avancer
            while (batterie >= 2)
            {
                posX++;
                posX1++;
                batterie = battLoss(batterie);
                drawDrone(posX, posY);
                drawDrone(posX1, posY1);
                Thread.Sleep(150);
                Console.Clear();
            }
            Console.Clear();
            death(posX, posY);
            death(posX1, posY1);
            Console.Read();

        }
        static void drawDrone(int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write("x-0-x");
            
        }
        static int battLoss(int batterie)
        {
            batterie -= 2;
            return batterie;
        }
        static void death(int posX, int posY)
        {
            //Last position + death
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("x---x");
            Console.ForegroundColor = ConsoleColor.White;
        }
}
}
