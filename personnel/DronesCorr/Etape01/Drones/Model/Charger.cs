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
    public class Charger
    {
        private int _x;
        private int _y;
        private const int SIZEELLIPSE = 20;

        public Charger(int x, int y)
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
            Pen pen = new Pen(Color.Black, 3);
            drawingSpace.Graphics.DrawEllipse(pen, X, Y, SIZEELLIPSE, SIZEELLIPSE);

        }
        #endregion
    }
}
