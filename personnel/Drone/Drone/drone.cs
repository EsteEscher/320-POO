using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone
{
    public class Drone
    {
        //propreties
        private int _posx;
        private int _posy;
        private int _batterie;

        public int Batterie { get => _batterie; set => _batterie = value; }

        public Drone(int posx, int posy, int batterie)
        {
            this._posx = posx;
            this._posy = posy;
            this._batterie = batterie;
        }
        public Drone()
        {
            this._posx = 0;
            this._posy = 0;
            this._batterie = 66;
        }
        public void draw()
        {
            Console.SetCursorPosition(_posx, _posy);
            Console.Write("x-0-x");
        }
        public void changeState()
        {
            if (_batterie < 2)
            {
                Console.Clear();
                Console.SetCursorPosition(_posx, _posy);
                Console.Write("x---x");
                return;
            }
            _posx++;
            _batterie -= 2;
        }
    }
}
