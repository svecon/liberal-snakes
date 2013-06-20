using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    public class Coin
    {
        public int x;
        public int y;

        public int spriteX;
        public int spriteY;
        public int size;
        public int value;
        public int id;

        public Coin(int x, int y, int val, int size, int id)
        {
            this.spriteX = x;
            this.spriteY = y;

            this.size = size;
            this.value = val;

            this.id = id;
        }

        public void ChangeLocation(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
