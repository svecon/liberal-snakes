using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snakes
{
    public class Player
    {
        Game game;

        public string name;
        public Keys[] keys;
        public Color color;
        
        public int score;

        public Snake snake;

        public Player(Color color, Keys[] keys, Game game) {
            this.color = color;
            this.keys = keys;
            this.game = game;

            this.snake = createSnake();
        }

        Snake createSnake(){
            return new Snake(keys, color, game, this);
        }

        public void PrepareForNewRound() {
            game.GetCollisions().RemoveSnake(snake.id);
            snake.id = game.GetNewId();
            game.GetCollisions().AddSnake(snake.id);

            snake.crashed = false;
            snake.ExpirePowerups(true);
            snake.NewRandomPosition();
        }
    }
}
