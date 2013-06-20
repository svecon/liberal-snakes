using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes
{
    public partial class Game : Form
    {
        public PictureBox map; // game field
        Collisions collisions;
        List<Snake> snakes;
        List<Coin> coins;
        List<Powerup> powerups; // all existing powerups
        Dictionary<int, Powerup> powerupsActivated; // visible on game field
        int idInc; // ID increment
        int maxScore; // score to win the game
        DateTime startGameAt; // countdown
        DateTime refreshMapAt; // countdown
        int alive; // number of snakes still alive
        int playersCount;
        List<Player> players;
        public Bitmap snakesBMP; // bitmap shared among snakes
        // continue the game after all other snakes are dead (multiplayer)
        bool waitingForFinish;

        public const int snakeDefaultSize = 10;
        public const int snakeDefaultSpeed = 2;
        public const double snakeDefaultTurningSpeed = 0.05;

        List<Keys[]> defaultKeys = new List<Keys[]>
        { 
            new Keys[] { Keys.Left, Keys.Right },
            new Keys[] { Keys.A, Keys.S },
            new Keys[] { Keys.V, Keys.B },
            new Keys[] { Keys.K, Keys.L }
        };
        List<Color> defaultColors = new List<Color>
        {
            ColorTranslator.FromHtml("#FF4545"),
            ColorTranslator.FromHtml("#4444FF"),
            ColorTranslator.FromHtml("#6AFF30"),
            ColorTranslator.FromHtml("#FFE92B"),
        };

        public Game()
        {
            InitializeComponent();

            snakes = new List<Snake>();
            players = new List<Player>();

            coins = new List<Coin>();

            powerupsActivated = new Dictionary<int, Powerup>();
            powerups = new List<Powerup>();

            // register all powerups
            powerups.Add(new Powerup(126, 168, 10, PowerupEffects.Effects.greenSlow));
            powerups.Add(new Powerup(42, 168, 3, PowerupEffects.Effects.greenSpeed));
            powerups.Add(new Powerup(84, 125, 15, PowerupEffects.Effects.greenThin));
            powerups.Add(new Powerup(84, 84, 7, PowerupEffects.Effects.redThick));
            powerups.Add(new Powerup(0, 125, 15, PowerupEffects.Effects.greenTurns));
            powerups.Add(new Powerup(42, 126, 7, PowerupEffects.Effects.redTurns));
            powerups.Add(new Powerup(168, 0, 15, PowerupEffects.Effects.greenRightAngle, true));
            powerups.Add(new Powerup(0, 83, 7, PowerupEffects.Effects.redRightAngle, true));
            powerups.Add(new Powerup(84, 42, 5, PowerupEffects.Effects.redInverse));
            powerups.Add(new Powerup(126, 84, 6, PowerupEffects.Effects.greenInvisibility, true));

            Randomizer.Load();
            FPSCounter.CreateLabel(this);

            // generate game field (picture box)
            map = new System.Windows.Forms.PictureBox();
            map.Parent = gameField;
            map.Location = new System.Drawing.Point(0, 0);
            map.Name = "map";
            map.Size = new System.Drawing.Size(gameField.Width, gameField.Height);
            map.TabIndex = 0;
            map.TabStop = false;
            map.Image = new Bitmap(getWidth(), getHeight());

            collisions = new Collisions(gameField.Width, gameField.Height, this);
            createNewGraphics();

            // at least one player always plays
            createPlayer();
        }

        public int getWidth()
        {
            return gameField.Width;
        }

        public int getHeight()
        {
            return gameField.Height;
        }

        void createNewGraphics()
        {
            snakesBMP = new Bitmap(GetGameField().Width, GetGameField().Height);
            //snakesBMP.MakeTransparent(Color.Black);
        }

        /// <summary>
        /// Random position away from edges
        /// </summary>
        /// <param name="size"></param>
        /// <param name="max"></param>
        /// <returns>int</returns>
        int randomPosition(int size, int max)
        {
            return Randomizer.Next(max - (2 * size)) + size;
        }

        /// <summary>
        /// Main function.
        /// Redraws bitmaps, moves snakes, creates powerups
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void redrawGame(object sender, EventArgs e)
        {
            if (Randomizer.Next(1000) > 996)
            {
                addPowerup();
            }

            using (Graphics g = Graphics.FromImage(map.Image))
            {
                // Black transparent background
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Black);

                if ((alive == 1 && playersCount > 1) || (alive == 0))
                    beginCountdown();

                if ((refreshMapAt > DateTime.Now) || (startGameAt < DateTime.Now))
                    foreach (Snake s in snakes)
                    {
                        if (s.crashed)
                            continue;

                        Graphics snakesGraphics = Graphics.FromImage(snakesBMP);
                        snakesGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        if (!s.Move(snakesGraphics))
                        {
                            alive--;

                            foreach (Player p in players)
                            {
                                if (p.snake.crashed == false)
                                    p.score += 5;
                            }

                            redrawScoreBoard();
                        }
                    }

                // Powerups
                Bitmap powerups = Properties.Resources.powerups;
                powerups.MakeTransparent(Color.Black);

                foreach (KeyValuePair<int, Powerup> pwr in powerupsActivated)
                {
                    Bitmap bpwr = (Bitmap)powerups.Clone(
                        new Rectangle(pwr.Value.spriteX, pwr.Value.spriteY, pwr.Value.size, pwr.Value.size), System.Drawing.Imaging.PixelFormat.DontCare
                        );
                    g.DrawImage(bpwr, pwr.Value.x - bpwr.Width / 2, pwr.Value.y - bpwr.Height / 2);
                }

                // Coins
                Bitmap coinsbmp = Properties.Resources.coins;
                powerups.MakeTransparent(Color.Black);

                foreach (Coin c in coins)
                {
                    Bitmap bpwr = (Bitmap)coinsbmp.Clone(
                        new Rectangle(c.spriteX, c.spriteY, c.size, c.size), System.Drawing.Imaging.PixelFormat.DontCare
                        );
                    g.DrawImage(bpwr, c.x - bpwr.Width / 2, c.y - bpwr.Height / 2);
                }

                // Draw snakes
                g.DrawImage(snakesBMP, 0, 0, snakesBMP.Width, snakesBMP.Height);

                foreach (Snake s in snakes)
                    s.DrawHead(g, startGameAt > DateTime.Now);
            }

            Refresh();
            FPSCounter.Tick();
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (Snake s in snakes)
            {
                if (s.keys[0] == e.KeyCode)
                    s.TurnLeft();
                else if (s.keys[1] == e.KeyCode)
                    s.TurnRight();
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (Snake s in snakes)
            {
                if (s.keys[0] == e.KeyCode)
                    s.StopTurningLeft();
                else if (s.keys[1] == e.KeyCode)
                    s.StopTurningRight();
            }
        }

        public Panel GetGameField()
        {
            return gameField;
        }

        public Collisions GetCollisions()
        {
            return collisions;
        }

        public int GetNewId()
        {
            return ++idInc;
        }

        void addPowerup()
        {
            // clone from available powerups
            Powerup pwr = powerups[Randomizer.Next(powerups.Count)].Clone();

            // for singleplayer pick only the green ones
            bool pickedRandom = false;
            if (snakes.Count > 1 || (int)pwr.effect % 2 == 1)
                pickedRandom = true;
            while (!pickedRandom)
            {
                pwr = powerups[Randomizer.Next(powerups.Count)].Clone();

                if (snakes.Count > 1 || (int)pwr.effect % 2 == 1)
                    pickedRandom = true;
            }

            pwr.ChangeLocation(randomPosition(pwr.size, gameField.Width), randomPosition(pwr.size, gameField.Height));

            int id = GetNewId();
            GetCollisions().FillPowerup(pwr, id);
            powerupsActivated.Add(id, pwr);
        }

        public bool IsThisActivePowerup(int id)
        {
            return powerupsActivated.ContainsKey(id);
        }

        public void SnakeHitPowerup(Snake snake, int powerupId)
        {
            powerupsActivated[powerupId].AddExpirationTime();

            // took green powerups (for myself)
            if ((int)powerupsActivated[powerupId].effect % 2 == 1)
                snake.AddPowerup(powerupsActivated[powerupId]);
            // took red powerup (for all others)
            else
            {
                foreach (Snake s in snakes)
                {
                    if (s != snake)
                        s.AddPowerup(powerupsActivated[powerupId]);
                }
            }

            powerupsActivated.Remove(powerupId);
        }

        public bool IsThisActiveCoin(int id)
        {
            for (int i = 0; i < coins.Count; i++)
                if (coins[i].id == id)
                    return true;
            return false;
        }

        public void SnakeHitCoin(Snake snake, int coinId)
        {
            for (int i = 0; i < coins.Count; i++)
                if (coins[i].id == coinId)
                    coins.RemoveAt(i);

            snake.player.score += 2;

            redrawScoreBoard();

            createCoin();
        }

        void createCoin()
        {
            Coin c = new Coin(259, 0, 3, 20, GetNewId());
            c.ChangeLocation(randomPosition(20, gameField.Width), randomPosition(20, gameField.Height));

            GetCollisions().FillCoin(c, c.id);

            coins.Add(c);
        }

        Player createPlayer()
        {
            playersCount++;

            Color c = defaultColors.ElementAt(0);
            Keys[] k = defaultKeys.ElementAt(0);
            defaultColors.RemoveAt(0);
            defaultKeys.RemoveAt(0);

            Player p = new Player(c, k, this);
            players.Add(p);
            snakes.Add(p.snake);

            return p;
        }

        private void addPlayer_Click(object sender, EventArgs e)
        {
            Player p = createPlayer();

            int i = playersCount;
            (this.panelStart.Controls["player" + i.ToString() + "Color"] as Panel).BackColor = p.color;
            (this.panelStart.Controls["player" + i.ToString() + "Color"] as Panel).Show();

            //(this.panelStart.Controls["player" + i.ToString() + "Name"] as TextBox).Text = "Player"+i.ToString();
            (this.panelStart.Controls["player" + i.ToString() + "Name"] as TextBox).Show();

            (this.panelStart.Controls["player" + i.ToString() + "Left"] as TextBox).BackColor = p.color;
            (this.panelStart.Controls["player" + i.ToString() + "Left"] as TextBox).Text = p.keys[0].ToString();
            (this.panelStart.Controls["player" + i.ToString() + "Left"] as TextBox).Show();

            (this.panelStart.Controls["player" + i.ToString() + "Right"] as TextBox).BackColor = p.color;
            (this.panelStart.Controls["player" + i.ToString() + "Right"] as TextBox).Text = p.keys[1].ToString();
            (this.panelStart.Controls["player" + i.ToString() + "Right"] as TextBox).Show();


            removePlayer.Enabled = true;
            if (snakes.Count == 4)
                addPlayer.Enabled = false;
        }

        private void removePlayer_Click(object sender, EventArgs e)
        {
            playersCount--;
            int i = playersCount + 1;

            defaultColors.Add(players[i - 1].color);
            defaultKeys.Add(players[i - 1].keys);

            snakes.RemoveAt(i - 1);
            players.RemoveAt(i - 1);

            (this.panelStart.Controls["player" + i.ToString() + "Color"] as Panel).Hide();
            (this.panelStart.Controls["player" + i.ToString() + "Name"] as TextBox).Hide();
            (this.panelStart.Controls["player" + i.ToString() + "Left"] as TextBox).Hide();
            (this.panelStart.Controls["player" + i.ToString() + "Right"] as TextBox).Hide();

            addPlayer.Enabled = true;
            if (snakes.Count == 1)
                removePlayer.Enabled = false;
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playersCount; i++)
            {
                players[i].name = (this.panelStart.Controls["player" + (i + 1).ToString() + "Name"] as TextBox).Text;
                players[i].score = 0;

                (this.panelGame.Controls["gplayer" + (i + 1).ToString() + "Name"] as Label).Show();
                (this.panelGame.Controls["gplayer" + (i + 1).ToString() + "Score"] as Label).Show();
                (this.panelGame.Controls["gplayer" + (i + 1).ToString() + "Plus"] as Label).Show();
            }
            winnerLabel.Visible = false;

            maxScore = playersCount > 1 ? 10 * 5 * playersCount : 999;
            scoreToAchieveLabel.Text = maxScore.ToString();

            redrawScoreBoard();

            panelStart.Visible = false;
            panelGame.Visible = true;

            beginCountdown();
        }

        private void endGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < snakes.Count; i++)
            {
                // prepare for new game
                (this.panelGame.Controls["gplayer" + (i + 1).ToString() + "Name"] as Label).Hide();
                (this.panelGame.Controls["gplayer" + (i + 1).ToString() + "Score"] as Label).Hide();
                (this.panelGame.Controls["gplayer" + (i + 1).ToString() + "Plus"] as Label).Hide();
            }

            panelStart.Visible = true;
            panelStart.Enabled = true;
            panelGame.Visible = false;
            waitingForFinish = false;

            countdownTimer.Stop();
            gameFieldTimer.Stop();
        }

        void redrawScoreBoard()
        {
            int i = 1;

            players = players.OrderByDescending(s => s.score).ToList();
            foreach (Player p in players)
            {
                (this.panelGame.Controls["gplayer" + i.ToString() + "Plus"] as Label).BackColor = p.color;
                (this.panelGame.Controls["gplayer" + i.ToString() + "Name"] as Label).Text = p.name;
                (this.panelGame.Controls["gplayer" + i.ToString() + "Score"] as Label).Text = p.score.ToString();

                // change leading color (under winning score)
                if (i == 1)
                    scoreToAchieveLabel.BackColor = p.color;

                i++;
            }
        }

        void beginCountdown()
        {
            if (waitingForFinish)
                return;

            waitingForFinish = true;

            coins.Clear();

            // multiplayer
            if (players[0].score >= maxScore)
            {
                winnerLabel.Visible = true;
                winnerLabel.Text = "Winner: \n" + players[0].name;
                gameFieldTimer.Stop();
                return;
            }

            // singleplayer
            if ((playersCount == 1) && (players[0].score > 0))
            {
                winnerLabel.Visible = true;
                winnerLabel.Text = "Game over\n" + players[0].score + " points";
                gameFieldTimer.Stop();
                return;
            }

            refreshMapAt = DateTime.Now.AddSeconds(5);
            startGameAt = refreshMapAt.AddSeconds(3);

            countdownTimer.Start();
            labelCountdown.Visible = true;
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            int remaining = (int)(refreshMapAt - DateTime.Now).TotalSeconds + 1;


            if (remaining <= 0) // starting new round
            {
                gameFieldTimer.Stop();
                countdownTimer.Stop();
                waitingForFinish = false;

                alive = playersCount;
                //idInc = 0;
                powerupsActivated.Clear();
                coins.Clear();

                //collisions = new Collisions(gameField.Width, gameField.Height, this);
                int x = (int)Math.Ceiling((double)playersCount / 2);
                for (int i = 0; i < x; i++)
                {
                    createCoin();
                }

                createNewGraphics();

                foreach (Player p in players)
                {
                    p.PrepareForNewRound();
                    p.snake.DontDraw(startGameAt.AddSeconds(2));
                }

                gameFieldTimer.Start();
                labelCountdown.Visible = false;

            }

            labelCountdown.Text = remaining.ToString();
        }
    }
}
