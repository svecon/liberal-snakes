using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snakes
{
    public class Snake
    {

        Game game;
        public Player player;

        Pen trailingPen;
        List<Powerup> powerups;

        public Keys[] keys;
        Color color;

        public int x;
        public int y;
        double angle;

        public bool crashed;

        public bool isDrawing;
        public DateTime isNotDrowingUntil;

        public double turningSpeed;
        public double speed;
        public int size;
        public int inverse;
        public bool rightAngleTurns;

        public int id;

        double tempX;
        double tempY;

        int turningDirection;

        Pen penGreen;
        Pen penRed;

        public Snake(Keys[] keys, Color color, Game game, Player player)
        {
            // Params
            this.color = color;
            this.keys = keys;

            this.game = game;
            this.player = player;

            // Defaults
            this.speed = Game.snakeDefaultSpeed;
            this.turningSpeed = Game.snakeDefaultTurningSpeed;
            this.size = Game.snakeDefaultSize;

            this.isDrawing = true;
            this.inverse = 1;
            this.crashed = false;

            this.isNotDrowingUntil = DateTime.Now;

            // Pen
            RecreateTrailingPen();

            // Poweups
            powerups = new List<Powerup>();
            penGreen = new Pen(new SolidBrush(Color.PaleGreen), 4);
            penRed = new Pen(new SolidBrush(Color.PaleVioletRed), 4);
        }

        public void NewRandomPosition()
        {
            x = Randomizer.Next(game.getWidth() - (2 * 50)) + 50;
            y = Randomizer.Next(game.getHeight() - (2 * 50)) + 50;
            angle = Randomizer.Next(629) / 100;
        }

        double getSpeed()
        {
            return speed * FPSCounter.AdjustSpeed();
        }

        void calculateNewPosition()
        {
            // Turning
            angle += turningDirection * inverse * turningSpeed * FPSCounter.AdjustSpeed();

            // Moving
            double calcX = Math.Cos(angle) * getSpeed();
            double calcY = Math.Sin(angle) * getSpeed();

            tempX += calcX;
            tempY += calcY;

            x += (int)Math.Ceiling(tempX);
            y += (int)Math.Ceiling(tempY);

            tempX -= Math.Ceiling(tempX);
            tempY -= Math.Ceiling(tempY);

        }

        public bool Move(Graphics g)
        {
            int prevX = x;
            int prevY = y;
            calculateNewPosition();

            if ((isNotDrowingUntil < DateTime.Now) && (!findPowerup(PowerupEffects.Effects.greenInvisibility)))
                isDrawing = true;

            TryMakeingSpace();

            if (isDrawing)
                g.DrawLine(trailingPen, prevX, prevY, x, y);

            if (game.GetCollisions().HasCrashed(this))
            {
                crashed = true;
                return false;
            }

            // Remove expired powerups
            ExpirePowerups(false);

            return true;
        }

        public void RecreateTrailingPen()
        {
            trailingPen = new Pen(new SolidBrush(color), size);
            trailingPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            trailingPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        public void DrawHead(Graphics g, bool toDrawDirection)
        {
            g.FillEllipse(new SolidBrush(color), x - size / 2, y - size / 2, size, size);

            int i = 1;
            foreach (Powerup p in powerups)
            {
                int nSize = size + (i * 12);
                double arcAngle = (p.expirationTime - DateTime.Now).TotalMilliseconds / p.duration / 1000;
                g.DrawArc((int)p.effect % 2 == 0 ? penRed : penGreen, x - nSize / 2, y - nSize / 2, nSize, nSize, 0, (int)(360 * arcAngle));
                i++;
            }

            if (toDrawDirection)
                drawDirection(g);
        }

        void drawDirection(Graphics g)
        {
            int vx = x + (int)(40 * Math.Cos(angle));
            int vy = y + (int)(40 * Math.Sin(angle));
            g.DrawLine(new Pen(new SolidBrush(color), 3), x, y, vx, vy);

            g.DrawLine(new Pen(new SolidBrush(color), 3), vx, vy, x + (int)(30 * Math.Cos(angle + Math.PI / 12)), y + (int)(30 * Math.Sin(angle + Math.PI / 12)));
            g.DrawLine(new Pen(new SolidBrush(color), 3), vx, vy, x + (int)(30 * Math.Cos(angle - Math.PI / 12)), y + (int)(30 * Math.Sin(angle - Math.PI / 12)));
        }

        public void TurnLeft()
        {
            turningDirection = -1;

            if (rightAngleTurns)
            {
                angle -= inverse * Math.PI / 2;
                turningDirection = 0;
            }
        }

        public void TurnRight()
        {
            turningDirection = 1;

            if (rightAngleTurns)
            {
                angle += inverse * Math.PI / 2;
                turningDirection = 0;
            }
        }

        public void StopTurningLeft()
        {
            if (turningDirection == -1) // if you are already turning right and then KeyUp on left is thrown
                turningDirection = 0;
        }

        public void StopTurningRight()
        {
            if (turningDirection == 1)
                turningDirection = 0;
        }

        public void AddPowerup(Powerup p)
        {
            int powerupId = findPowerup(p);

            if ((powerupId == -1) || (p.unique == false))
            {
                PowerupEffects.Start(this, p);
                powerups.Add(p);
            }
            else
                powerups[powerupId].expirationTime = p.expirationTime;
        }

        int findPowerup(Powerup pwr)
        {
            for (int i = 0; i < powerups.Count; i++)
                if (powerups[i].effect == pwr.effect)
                    return i;
            return -1;
        }

        bool findPowerup(PowerupEffects.Effects ef)
        {
            for (int i = 0; i < powerups.Count; i++)
                if (powerups[i].effect == ef)
                    return true;
            return false;
        }

        public void ExpirePowerups(bool force)
        {
            for (int i = powerups.Count - 1; i >= 0; i--)
            {
                if (force || (powerups[i].expirationTime < DateTime.Now))
                {
                    PowerupEffects.End(this, powerups[i]);
                    powerups.RemoveAt(i);
                }
            }
        }

        public void DontDraw(int millisec)
        {
            isDrawing = false;
            isNotDrowingUntil = DateTime.Now.AddMilliseconds(millisec);
        }

        public void DontDraw(DateTime until)
        {
            isDrawing = false;
            isNotDrowingUntil = until;
        }

        void TryMakeingSpace()
        {
            if (isNotDrowingUntil < DateTime.Now)
            {
                if (Randomizer.Next(1000) > 985)
                {
                    DontDraw((int)(500 / speed));
                }

            }
        }

    }

}
