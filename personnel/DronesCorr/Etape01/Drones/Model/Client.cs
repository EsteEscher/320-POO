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
    public class Client
    {
        private int _x;
        private int _y;
        private const int SIZEELLIPSE = 30;

        public Client(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        private (int, int) Newtarg()
        {
            return (RandomHelpers.Next(Config.AIRSPACE_WIDTH), RandomHelpers.Next(Config.AIRSPACE_HEIGHT));
        }

        #region  ================ Rendu graphique  ================

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            Pen pen = new Pen(Color.Green, 3);
            drawingSpace.Graphics.DrawRectangle(pen, X - SIZEELLIPSE / 2, Y - SIZEELLIPSE / 2, SIZEELLIPSE, SIZEELLIPSE);

        }
        #endregion
    }
}
