using Drones.Helpers;
using Drones.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drones
{
    public class Pizzeria
    {
        private int _x;
        private int _y;
        private const int SIZEELLIPSE = 50;

        public Pizzeria(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        #region  ================ Rendu graphique  ================

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            Pen pen = new Pen(Color.Gray, 3);
            drawingSpace.Graphics.DrawRectangle(pen, X - SIZEELLIPSE / 2, Y - SIZEELLIPSE / 2, SIZEELLIPSE, SIZEELLIPSE);

        }
        #endregion


        public static void RegisterPizzeria(List<Pizzeria> Pizzi)
        {
            

            for (int i = 0; i < 5; i++)
            {
                int x = RandomHelpers.Next(50, Config.AIRSPACE_WIDTH - SIZEELLIPSE);
                int y = RandomHelpers.Next(50, Config.AIRSPACE_HEIGHT - SIZEELLIPSE);


                try
                {
                    foreach (Pizzeria p in Pizzi)
                    {
                        if (x + SIZEELLIPSE / 2 >= p.X - SIZEELLIPSE / 2 && y + SIZEELLIPSE / 2 >= p.Y - SIZEELLIPSE / 2 && x - SIZEELLIPSE / 2 >= p.X - SIZEELLIPSE / 2 && y - SIZEELLIPSE / 2 >= p.Y - SIZEELLIPSE / 2 )
                        {

                        }
                    }
                }
                catch
                {

                }
                Pizzi.Add(new Pizzeria(x, y));
            }
        }
    }
}
