using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    public static class PowerupEffects
    {

        public enum Effects
        {
            greenSpeed = 1,
            redSpeed = 2,
            greenSlow = 3,
            redSlow = 4,
            greenThin = 5,
            redThick = 6,
            greenTurns = 7,
            redTurns = 8,

            greenRightAngle = 9,
            redRightAngle = 10,

            greenInvisibility = 11,
            redInverse = 12,
        }

        public static void Start(Snake s, Powerup p)
        {

            switch (p.effect)
            {
                case Effects.greenSpeed:
                    s.speed *= 2;
                    s.turningSpeed *= 1.5;
                    break;
                case Effects.redSpeed:
                    s.speed *= 2;
                    break;
                case Effects.greenSlow:
                    s.speed /= 2;
                    break;
                case Effects.redSlow:
                    s.speed /= 2;
                    s.turningSpeed /= 1.5;
                    break;
                case Effects.greenThin:
                    s.size /= 2;
                    s.RecreateTrailingPen();
                    break;
                case Effects.redThick:
                    s.size *= 2;
                    s.RecreateTrailingPen();
                    break;
                case Effects.greenTurns:
                    s.turningSpeed *= 1.5;
                    break;
                case Effects.redTurns:
                    s.turningSpeed /= 1.5;
                    break;
                case Effects.greenRightAngle:
                case Effects.redRightAngle:
                    s.rightAngleTurns = !s.rightAngleTurns;
                    break;
                case Effects.greenInvisibility:
                    s.isDrawing = false;
                    break;
                case Effects.redInverse:
                    s.inverse *= -1;
                    break;
                default:
                    break;
            }
        }

        public static void End(Snake s, Powerup p)
        {

            switch (p.effect)
            {
                case Effects.greenSpeed:
                    s.speed /= 2;
                    s.turningSpeed /= 1.5;
                    break;
                case Effects.redSpeed:
                    s.speed /= 2;
                    break;
                case Effects.greenSlow:
                    s.speed *= 2;
                    break;
                case Effects.redSlow:
                    s.speed *= 2;
                    s.turningSpeed *= 1.5;
                    break;
                case Effects.greenThin:
                    s.size *= 2;
                    s.RecreateTrailingPen();
                    break;
                case Effects.redThick:
                    s.size /= 2;
                    s.RecreateTrailingPen();
                    break;
                case Effects.greenTurns:
                    s.turningSpeed /= 1.5;
                    break;
                case Effects.redTurns:
                    s.turningSpeed *= 1.5;
                    break;
                case Effects.greenRightAngle:
                case Effects.redRightAngle:
                    s.rightAngleTurns = !s.rightAngleTurns;
                    break;
                case Effects.greenInvisibility:
                    s.isDrawing = true;
                    break;
                case Effects.redInverse:
                    s.inverse *= -1;
                    break;
                default:
                    break;
            }
        }
    }
}
