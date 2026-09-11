using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Helpers
{
    internal static class RandomHelpers
    {
        private static Random _alea = new Random();
        public static int Generating(int max)
        {
            return _alea.Next(max);
        }
    }
}
