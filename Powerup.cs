using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    public class Powerup
    {
        public int x;
        public int y;

        public int spriteX;
        public int spriteY;
        public int size;
        public PowerupEffects.Effects effect;

        public bool unique;

        public int duration;
        public DateTime startTime;
        public DateTime expirationTime;

        public Powerup(int x, int y, int duration, PowerupEffects.Effects ef, bool unique)
        {
            this.spriteX = x;
            this.spriteY = y;

            this.duration = duration;

            this.size = 40;

            this.effect = ef;

            this.unique = unique;
        }

        public Powerup(int x, int y, int duration, PowerupEffects.Effects ef) :
            this(x, y, duration, ef, false) { }

        public void ChangeLocation(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Powerup Clone()
        {
            return new Powerup(spriteX, spriteY, duration, effect, unique);
        }

        public void AddExpirationTime()
        {
            startTime = DateTime.Now;
            expirationTime = DateTime.Now.AddSeconds(duration);
        }

    }
}
