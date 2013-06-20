using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Snakes
{
    public class Collisions
    {

        Game game;
        int[,] field;
        Dictionary<int, Dictionary<Point, int>> pointsHistory;
        int pointsHistoryAge;

        public Collisions(int x, int y, Game game)
        {
            this.game = game;
            field = new int[x, y];
            pointsHistory = new Dictionary<int, Dictionary<Point, int>>();

        }

        public void AddSnake(int id)
        {
            pointsHistory[id] = new Dictionary<Point, int>();
        }

        public void RemoveSnake(int id)
        {
            pointsHistory.Remove(id);
        }

        public bool HasCrashed(Snake snake)
        {
            int r = snake.size / 2;

            Dictionary<Point, int> snakeHistory = pointsHistory[snake.id];
            snakeHistory = snakeHistory.Where(pair => pair.Value >= pointsHistoryAge - snake.size*3).ToDictionary(pair => pair.Key, pair => pair.Value);

            for (int i = -r; i <= r; i++)
                for (int j = -r; j <= r; j++)
                    if ((i * i) + (j * j) <= r * r)
                    {
                        if ((snake.x + i < 0) || (snake.y + j < 0) || (snake.x + i >= field.GetLength(0)) || (snake.y + j >= field.GetLength(1)))
                            return true;

                        Point point = new Point(snake.x + i, snake.y + j);

                        if ((snake.isDrawing) && (!snakeHistory.ContainsKey(point)) && (pointsHistory.ContainsKey(field[snake.x + i, snake.y + j])))
                            return true;

                        if (game.IsThisActivePowerup(field[snake.x + i, snake.y + j]))
                            game.SnakeHitPowerup(snake, field[snake.x + i, snake.y + j]);

                        if (game.IsThisActiveCoin(field[snake.x + i, snake.y + j]))
                            game.SnakeHitCoin(snake, field[snake.x + i, snake.y + j]);

                        if (snake.isDrawing)
                            field[snake.x + i, snake.y + j] = snake.id;

                        if ((!snakeHistory.ContainsKey(point)))
                            snakeHistory.Add(point, pointsHistoryAge);
                        else
                            snakeHistory[point] = pointsHistoryAge;
                    }

            pointsHistory[snake.id] = snakeHistory;
            pointsHistoryAge++;
            return false;
        }

        public void FillPowerup(Powerup pwr, int id)
        {
            int r = pwr.size / 2;
            for (int i = -r; i <= r; i++)
                for (int j = -r; j <= r; j++)
                    if ((i * i) + (j * j) <= r * r)
                        // disallow snake overriding
                        if (!pointsHistory.ContainsKey(field[pwr.x + i, pwr.y + j]))
                            field[pwr.x + i, pwr.y + j] = id;
        }

        public void FillCoin(Coin coin, int id)
        {
            int r = coin.size / 2;
            for (int i = -r; i <= r; i++)
                for (int j = -r; j <= r; j++)
                    if ((i * i) + (j * j) <= r * r)
                        // disallow snake overriding
                        if (!pointsHistory.ContainsKey(field[coin.x + i, coin.y + j]))
                            field[coin.x + i, coin.y + j] = id;
        }

    }
}
