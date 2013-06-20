using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    static class Randomizer
    {
        static Random r;

        public static void Load()
        {
            r = new Random();
        }

        public static int Next(int max)
        {
            return r.Next(max);
        }
    }
}
