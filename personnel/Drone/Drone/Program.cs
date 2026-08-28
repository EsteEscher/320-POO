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
            const int posY = 10;
            int batterie = 50;

            //Fonction pour le faire avancer
            while (batterie >= 2)
            {
                Console.Clear();
                batterie = batterie - 2;
                posX++;
                Console.SetCursorPosition(posX, posY);
                Console.Write("x-0-x");
                Thread.Sleep(150);
            }

            //Last position + death
            Console.Clear() ;
            Console.SetCursorPosition(posX, posY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("x---x");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Read();

        }
    }
}
