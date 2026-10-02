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
        private const int SIZEELLIPSE = 10;

        public Client(int x, int y)
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
            drawingSpace.Graphics.FillRectangle(Brushes.Green, X - SIZEELLIPSE / 2, Y - SIZEELLIPSE / 2, SIZEELLIPSE, SIZEELLIPSE);

        }
        #endregion

    }
}
