namespace Snakes
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameFieldTimer = new System.Windows.Forms.Timer(this.components);
            this.panelStart = new System.Windows.Forms.Panel();
            this.player4Right = new System.Windows.Forms.TextBox();
            this.player4Left = new System.Windows.Forms.TextBox();
            this.player4Color = new System.Windows.Forms.Panel();
            this.player4Name = new System.Windows.Forms.TextBox();
            this.player3Right = new System.Windows.Forms.TextBox();
            this.player3Left = new System.Windows.Forms.TextBox();
            this.player3Color = new System.Windows.Forms.Panel();
            this.player3Name = new System.Windows.Forms.TextBox();
            this.player2Right = new System.Windows.Forms.TextBox();
            this.player2Left = new System.Windows.Forms.TextBox();
            this.player2Color = new System.Windows.Forms.Panel();
            this.player2Name = new System.Windows.Forms.TextBox();
            this.player1Right = new System.Windows.Forms.TextBox();
            this.player1Left = new System.Windows.Forms.TextBox();
            this.player1Color = new System.Windows.Forms.Panel();
            this.player1Name = new System.Windows.Forms.TextBox();
            this.removePlayer = new System.Windows.Forms.Button();
            this.addPlayer = new System.Windows.Forms.Button();
            this.startGame = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.gameBorder = new System.Windows.Forms.Panel();
            this.gameField = new System.Windows.Forms.Panel();
            this.gPlayer4Score = new System.Windows.Forms.Label();
            this.gPlayer4Plus = new System.Windows.Forms.Label();
            this.gplayer4Name = new System.Windows.Forms.Label();
            this.gPlayer3Score = new System.Windows.Forms.Label();
            this.gPlayer3Plus = new System.Windows.Forms.Label();
            this.gplayer3Name = new System.Windows.Forms.Label();
            this.gPlayer2Score = new System.Windows.Forms.Label();
            this.gPlayer2Plus = new System.Windows.Forms.Label();
            this.gplayer2Name = new System.Windows.Forms.Label();
            this.scoreToAchieveLabel = new System.Windows.Forms.Label();
            this.gPlayer1Score = new System.Windows.Forms.Label();
            this.gPlayer1Plus = new System.Windows.Forms.Label();
            this.gplayer1Name = new System.Windows.Forms.Label();
            this.endGame = new System.Windows.Forms.Button();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.labelCountdown = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.panelStart.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.gameBorder.SuspendLayout();
            this.gameField.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameFieldTimer
            // 
            this.gameFieldTimer.Interval = 10;
            this.gameFieldTimer.Tick += new System.EventHandler(this.redrawGame);
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.player4Right);
            this.panelStart.Controls.Add(this.player4Left);
            this.panelStart.Controls.Add(this.player4Color);
            this.panelStart.Controls.Add(this.player4Name);
            this.panelStart.Controls.Add(this.player3Right);
            this.panelStart.Controls.Add(this.player3Left);
            this.panelStart.Controls.Add(this.player3Color);
            this.panelStart.Controls.Add(this.player3Name);
            this.panelStart.Controls.Add(this.player2Right);
            this.panelStart.Controls.Add(this.player2Left);
            this.panelStart.Controls.Add(this.player2Color);
            this.panelStart.Controls.Add(this.player2Name);
            this.panelStart.Controls.Add(this.player1Right);
            this.panelStart.Controls.Add(this.player1Left);
            this.panelStart.Controls.Add(this.player1Color);
            this.panelStart.Controls.Add(this.player1Name);
            this.panelStart.Controls.Add(this.removePlayer);
            this.panelStart.Controls.Add(this.addPlayer);
            this.panelStart.Controls.Add(this.startGame);
            this.panelStart.Location = new System.Drawing.Point(12, 12);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(984, 705);
            this.panelStart.TabIndex = 4;
            // 
            // player4Right
            // 
            this.player4Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.player4Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player4Right.ForeColor = System.Drawing.Color.Black;
            this.player4Right.Location = new System.Drawing.Point(660, 255);
            this.player4Right.Name = "player4Right";
            this.player4Right.Size = new System.Drawing.Size(31, 31);
            this.player4Right.TabIndex = 20;
            this.player4Right.Text = ">";
            this.player4Right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player4Right.Visible = false;
            // 
            // player4Left
            // 
            this.player4Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.player4Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player4Left.ForeColor = System.Drawing.Color.Black;
            this.player4Left.Location = new System.Drawing.Point(623, 255);
            this.player4Left.Name = "player4Left";
            this.player4Left.Size = new System.Drawing.Size(31, 31);
            this.player4Left.TabIndex = 19;
            this.player4Left.Text = "<";
            this.player4Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player4Left.Visible = false;
            // 
            // player4Color
            // 
            this.player4Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.player4Color.Location = new System.Drawing.Point(330, 255);
            this.player4Color.Name = "player4Color";
            this.player4Color.Size = new System.Drawing.Size(31, 31);
            this.player4Color.TabIndex = 18;
            this.player4Color.Visible = false;
            // 
            // player4Name
            // 
            this.player4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player4Name.Location = new System.Drawing.Point(367, 255);
            this.player4Name.Name = "player4Name";
            this.player4Name.Size = new System.Drawing.Size(250, 31);
            this.player4Name.TabIndex = 17;
            this.player4Name.Text = "Player4";
            this.player4Name.Visible = false;
            // 
            // player3Right
            // 
            this.player3Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.player3Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3Right.ForeColor = System.Drawing.Color.Black;
            this.player3Right.Location = new System.Drawing.Point(660, 195);
            this.player3Right.Name = "player3Right";
            this.player3Right.Size = new System.Drawing.Size(31, 31);
            this.player3Right.TabIndex = 16;
            this.player3Right.Text = ">";
            this.player3Right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player3Right.Visible = false;
            // 
            // player3Left
            // 
            this.player3Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.player3Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3Left.ForeColor = System.Drawing.Color.Black;
            this.player3Left.Location = new System.Drawing.Point(623, 195);
            this.player3Left.Name = "player3Left";
            this.player3Left.Size = new System.Drawing.Size(31, 31);
            this.player3Left.TabIndex = 15;
            this.player3Left.Text = "<";
            this.player3Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player3Left.Visible = false;
            // 
            // player3Color
            // 
            this.player3Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.player3Color.Location = new System.Drawing.Point(330, 195);
            this.player3Color.Name = "player3Color";
            this.player3Color.Size = new System.Drawing.Size(31, 31);
            this.player3Color.TabIndex = 14;
            this.player3Color.Visible = false;
            // 
            // player3Name
            // 
            this.player3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3Name.Location = new System.Drawing.Point(367, 195);
            this.player3Name.Name = "player3Name";
            this.player3Name.Size = new System.Drawing.Size(250, 31);
            this.player3Name.TabIndex = 13;
            this.player3Name.Text = "Player3";
            this.player3Name.Visible = false;
            // 
            // player2Right
            // 
            this.player2Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.player2Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Right.ForeColor = System.Drawing.Color.Black;
            this.player2Right.Location = new System.Drawing.Point(660, 135);
            this.player2Right.Name = "player2Right";
            this.player2Right.Size = new System.Drawing.Size(31, 31);
            this.player2Right.TabIndex = 12;
            this.player2Right.Text = ">";
            this.player2Right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player2Right.Visible = false;
            // 
            // player2Left
            // 
            this.player2Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.player2Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Left.ForeColor = System.Drawing.Color.Black;
            this.player2Left.Location = new System.Drawing.Point(623, 135);
            this.player2Left.Name = "player2Left";
            this.player2Left.Size = new System.Drawing.Size(31, 31);
            this.player2Left.TabIndex = 11;
            this.player2Left.Text = "<";
            this.player2Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player2Left.Visible = false;
            // 
            // player2Color
            // 
            this.player2Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.player2Color.Location = new System.Drawing.Point(330, 135);
            this.player2Color.Name = "player2Color";
            this.player2Color.Size = new System.Drawing.Size(31, 31);
            this.player2Color.TabIndex = 10;
            this.player2Color.Visible = false;
            // 
            // player2Name
            // 
            this.player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Name.Location = new System.Drawing.Point(367, 135);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(250, 31);
            this.player2Name.TabIndex = 9;
            this.player2Name.Text = "Player2";
            this.player2Name.Visible = false;
            // 
            // player1Right
            // 
            this.player1Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.player1Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Right.ForeColor = System.Drawing.Color.Black;
            this.player1Right.Location = new System.Drawing.Point(660, 75);
            this.player1Right.Name = "player1Right";
            this.player1Right.Size = new System.Drawing.Size(31, 31);
            this.player1Right.TabIndex = 8;
            this.player1Right.Text = ">";
            this.player1Right.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player1Left
            // 
            this.player1Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.player1Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Left.ForeColor = System.Drawing.Color.Black;
            this.player1Left.Location = new System.Drawing.Point(623, 75);
            this.player1Left.Name = "player1Left";
            this.player1Left.Size = new System.Drawing.Size(31, 31);
            this.player1Left.TabIndex = 6;
            this.player1Left.Text = "<";
            this.player1Left.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // player1Color
            // 
            this.player1Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.player1Color.Location = new System.Drawing.Point(330, 75);
            this.player1Color.Name = "player1Color";
            this.player1Color.Size = new System.Drawing.Size(31, 31);
            this.player1Color.TabIndex = 5;
            // 
            // player1Name
            // 
            this.player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.Location = new System.Drawing.Point(367, 75);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(250, 31);
            this.player1Name.TabIndex = 4;
            this.player1Name.Text = "Player1";
            // 
            // removePlayer
            // 
            this.removePlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.removePlayer.Enabled = false;
            this.removePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePlayer.ForeColor = System.Drawing.Color.White;
            this.removePlayer.Location = new System.Drawing.Point(200, 595);
            this.removePlayer.Name = "removePlayer";
            this.removePlayer.Size = new System.Drawing.Size(250, 35);
            this.removePlayer.TabIndex = 2;
            this.removePlayer.Text = "Remove player";
            this.removePlayer.UseVisualStyleBackColor = false;
            this.removePlayer.Click += new System.EventHandler(this.removePlayer_Click);
            // 
            // addPlayer
            // 
            this.addPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.addPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayer.ForeColor = System.Drawing.Color.White;
            this.addPlayer.Location = new System.Drawing.Point(200, 550);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(250, 35);
            this.addPlayer.TabIndex = 1;
            this.addPlayer.Text = "Add player";
            this.addPlayer.UseVisualStyleBackColor = false;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click);
            // 
            // startGame
            // 
            this.startGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.startGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.ForeColor = System.Drawing.Color.White;
            this.startGame.Location = new System.Drawing.Point(550, 550);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(250, 80);
            this.startGame.TabIndex = 0;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.gameBorder);
            this.panelGame.Controls.Add(this.gPlayer4Score);
            this.panelGame.Controls.Add(this.gPlayer4Plus);
            this.panelGame.Controls.Add(this.gplayer4Name);
            this.panelGame.Controls.Add(this.gPlayer3Score);
            this.panelGame.Controls.Add(this.gPlayer3Plus);
            this.panelGame.Controls.Add(this.gplayer3Name);
            this.panelGame.Controls.Add(this.gPlayer2Score);
            this.panelGame.Controls.Add(this.gPlayer2Plus);
            this.panelGame.Controls.Add(this.gplayer2Name);
            this.panelGame.Controls.Add(this.scoreToAchieveLabel);
            this.panelGame.Controls.Add(this.gPlayer1Score);
            this.panelGame.Controls.Add(this.gPlayer1Plus);
            this.panelGame.Controls.Add(this.gplayer1Name);
            this.panelGame.Controls.Add(this.endGame);
            this.panelGame.Location = new System.Drawing.Point(12, 12);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(984, 713);
            this.panelGame.TabIndex = 5;
            this.panelGame.Visible = false;
            // 
            // gameBorder
            // 
            this.gameBorder.BackColor = System.Drawing.Color.White;
            this.gameBorder.Controls.Add(this.gameField);
            this.gameBorder.Location = new System.Drawing.Point(296, 0);
            this.gameBorder.Name = "gameBorder";
            this.gameBorder.Size = new System.Drawing.Size(700, 705);
            this.gameBorder.TabIndex = 21;
            // 
            // gameField
            // 
            this.gameField.BackColor = System.Drawing.Color.Black;
            this.gameField.Controls.Add(this.winnerLabel);
            this.gameField.Controls.Add(this.labelCountdown);
            this.gameField.Location = new System.Drawing.Point(3, 3);
            this.gameField.Name = "gameField";
            this.gameField.Size = new System.Drawing.Size(682, 699);
            this.gameField.TabIndex = 4;
            // 
            // gPlayer4Score
            // 
            this.gPlayer4Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gPlayer4Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.gPlayer4Score.ForeColor = System.Drawing.Color.White;
            this.gPlayer4Score.Location = new System.Drawing.Point(238, 388);
            this.gPlayer4Score.Name = "gPlayer4Score";
            this.gPlayer4Score.Size = new System.Drawing.Size(51, 25);
            this.gPlayer4Score.TabIndex = 20;
            this.gPlayer4Score.Text = "0";
            this.gPlayer4Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gPlayer4Score.Visible = false;
            // 
            // gPlayer4Plus
            // 
            this.gPlayer4Plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.gPlayer4Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.gPlayer4Plus.ForeColor = System.Drawing.Color.White;
            this.gPlayer4Plus.Location = new System.Drawing.Point(2, 390);
            this.gPlayer4Plus.Name = "gPlayer4Plus";
            this.gPlayer4Plus.Size = new System.Drawing.Size(38, 25);
            this.gPlayer4Plus.TabIndex = 19;
            this.gPlayer4Plus.Visible = false;
            // 
            // gplayer4Name
            // 
            this.gplayer4Name.AutoSize = true;
            this.gplayer4Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gplayer4Name.ForeColor = System.Drawing.Color.White;
            this.gplayer4Name.Location = new System.Drawing.Point(63, 388);
            this.gplayer4Name.Name = "gplayer4Name";
            this.gplayer4Name.Size = new System.Drawing.Size(83, 25);
            this.gplayer4Name.TabIndex = 18;
            this.gplayer4Name.Text = "player1";
            this.gplayer4Name.Visible = false;
            // 
            // gPlayer3Score
            // 
            this.gPlayer3Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gPlayer3Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.gPlayer3Score.ForeColor = System.Drawing.Color.White;
            this.gPlayer3Score.Location = new System.Drawing.Point(238, 328);
            this.gPlayer3Score.Name = "gPlayer3Score";
            this.gPlayer3Score.Size = new System.Drawing.Size(51, 25);
            this.gPlayer3Score.TabIndex = 17;
            this.gPlayer3Score.Text = "0";
            this.gPlayer3Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gPlayer3Score.Visible = false;
            // 
            // gPlayer3Plus
            // 
            this.gPlayer3Plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.gPlayer3Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.gPlayer3Plus.ForeColor = System.Drawing.Color.White;
            this.gPlayer3Plus.Location = new System.Drawing.Point(2, 330);
            this.gPlayer3Plus.Name = "gPlayer3Plus";
            this.gPlayer3Plus.Size = new System.Drawing.Size(38, 25);
            this.gPlayer3Plus.TabIndex = 16;
            this.gPlayer3Plus.Visible = false;
            // 
            // gplayer3Name
            // 
            this.gplayer3Name.AutoSize = true;
            this.gplayer3Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gplayer3Name.ForeColor = System.Drawing.Color.White;
            this.gplayer3Name.Location = new System.Drawing.Point(63, 328);
            this.gplayer3Name.Name = "gplayer3Name";
            this.gplayer3Name.Size = new System.Drawing.Size(83, 25);
            this.gplayer3Name.TabIndex = 15;
            this.gplayer3Name.Text = "player1";
            this.gplayer3Name.Visible = false;
            // 
            // gPlayer2Score
            // 
            this.gPlayer2Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.gPlayer2Score.ForeColor = System.Drawing.Color.White;
            this.gPlayer2Score.Location = new System.Drawing.Point(239, 270);
            this.gPlayer2Score.Name = "gPlayer2Score";
            this.gPlayer2Score.Size = new System.Drawing.Size(51, 25);
            this.gPlayer2Score.TabIndex = 14;
            this.gPlayer2Score.Text = "0";
            this.gPlayer2Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gPlayer2Score.Visible = false;
            // 
            // gPlayer2Plus
            // 
            this.gPlayer2Plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.gPlayer2Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.gPlayer2Plus.ForeColor = System.Drawing.Color.White;
            this.gPlayer2Plus.Location = new System.Drawing.Point(2, 270);
            this.gPlayer2Plus.Name = "gPlayer2Plus";
            this.gPlayer2Plus.Size = new System.Drawing.Size(38, 25);
            this.gPlayer2Plus.TabIndex = 13;
            this.gPlayer2Plus.Visible = false;
            // 
            // gplayer2Name
            // 
            this.gplayer2Name.AutoSize = true;
            this.gplayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gplayer2Name.ForeColor = System.Drawing.Color.White;
            this.gplayer2Name.Location = new System.Drawing.Point(63, 270);
            this.gplayer2Name.Name = "gplayer2Name";
            this.gplayer2Name.Size = new System.Drawing.Size(83, 25);
            this.gplayer2Name.TabIndex = 12;
            this.gplayer2Name.Text = "player1";
            this.gplayer2Name.Visible = false;
            // 
            // scoreToAchieveLabel
            // 
            this.scoreToAchieveLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.scoreToAchieveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreToAchieveLabel.ForeColor = System.Drawing.Color.White;
            this.scoreToAchieveLabel.Location = new System.Drawing.Point(61, 75);
            this.scoreToAchieveLabel.Name = "scoreToAchieveLabel";
            this.scoreToAchieveLabel.Size = new System.Drawing.Size(161, 53);
            this.scoreToAchieveLabel.TabIndex = 11;
            this.scoreToAchieveLabel.Text = "40";
            this.scoreToAchieveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gPlayer1Score
            // 
            this.gPlayer1Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gPlayer1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.gPlayer1Score.ForeColor = System.Drawing.Color.White;
            this.gPlayer1Score.Location = new System.Drawing.Point(238, 210);
            this.gPlayer1Score.Name = "gPlayer1Score";
            this.gPlayer1Score.Size = new System.Drawing.Size(51, 25);
            this.gPlayer1Score.TabIndex = 10;
            this.gPlayer1Score.Text = "0";
            this.gPlayer1Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gPlayer1Plus
            // 
            this.gPlayer1Plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.gPlayer1Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.gPlayer1Plus.ForeColor = System.Drawing.Color.White;
            this.gPlayer1Plus.Location = new System.Drawing.Point(2, 210);
            this.gPlayer1Plus.Name = "gPlayer1Plus";
            this.gPlayer1Plus.Size = new System.Drawing.Size(38, 25);
            this.gPlayer1Plus.TabIndex = 9;
            // 
            // gplayer1Name
            // 
            this.gplayer1Name.AutoSize = true;
            this.gplayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gplayer1Name.ForeColor = System.Drawing.Color.White;
            this.gplayer1Name.Location = new System.Drawing.Point(63, 210);
            this.gplayer1Name.Name = "gplayer1Name";
            this.gplayer1Name.Size = new System.Drawing.Size(83, 25);
            this.gplayer1Name.TabIndex = 8;
            this.gplayer1Name.Text = "player1";
            // 
            // endGame
            // 
            this.endGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.endGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGame.ForeColor = System.Drawing.Color.White;
            this.endGame.Location = new System.Drawing.Point(15, 550);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(250, 88);
            this.endGame.TabIndex = 1;
            this.endGame.Text = "Leave Game";
            this.endGame.UseVisualStyleBackColor = false;
            this.endGame.Click += new System.EventHandler(this.endGame_Click);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // labelCountdown
            // 
            this.labelCountdown.AutoSize = true;
            this.labelCountdown.BackColor = System.Drawing.Color.Transparent;
            this.labelCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountdown.ForeColor = System.Drawing.Color.White;
            this.labelCountdown.Location = new System.Drawing.Point(294, 259);
            this.labelCountdown.Name = "labelCountdown";
            this.labelCountdown.Size = new System.Drawing.Size(98, 108);
            this.labelCountdown.TabIndex = 22;
            this.labelCountdown.Text = "5";
            this.labelCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winnerLabel
            // 
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.White;
            this.winnerLabel.Location = new System.Drawing.Point(112, 106);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(482, 410);
            this.winnerLabel.TabIndex = 22;
            this.winnerLabel.Text = "Winner: ";
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winnerLabel.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelStart);
            this.KeyPreview = true;
            this.Name = "Game";
            this.Text = "Snakes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.gameBorder.ResumeLayout(false);
            this.gameField.ResumeLayout(false);
            this.gameField.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameFieldTimer;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.Button removePlayer;
        private System.Windows.Forms.TextBox player1Name;
        private System.Windows.Forms.Panel player1Color;
        private System.Windows.Forms.TextBox player1Left;
        private System.Windows.Forms.TextBox player4Right;
        private System.Windows.Forms.TextBox player4Left;
        private System.Windows.Forms.Panel player4Color;
        private System.Windows.Forms.TextBox player4Name;
        private System.Windows.Forms.TextBox player3Right;
        private System.Windows.Forms.TextBox player3Left;
        private System.Windows.Forms.Panel player3Color;
        private System.Windows.Forms.TextBox player3Name;
        private System.Windows.Forms.TextBox player2Right;
        private System.Windows.Forms.TextBox player2Left;
        private System.Windows.Forms.Panel player2Color;
        private System.Windows.Forms.TextBox player2Name;
        private System.Windows.Forms.TextBox player1Right;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Button endGame;
        private System.Windows.Forms.Panel gameField;
        private System.Windows.Forms.Label gplayer1Name;
        private System.Windows.Forms.Label gPlayer4Score;
        private System.Windows.Forms.Label gPlayer4Plus;
        private System.Windows.Forms.Label gplayer4Name;
        private System.Windows.Forms.Label gPlayer3Score;
        private System.Windows.Forms.Label gPlayer3Plus;
        private System.Windows.Forms.Label gplayer3Name;
        private System.Windows.Forms.Label gPlayer2Score;
        private System.Windows.Forms.Label gPlayer2Plus;
        private System.Windows.Forms.Label gplayer2Name;
        private System.Windows.Forms.Label scoreToAchieveLabel;
        private System.Windows.Forms.Label gPlayer1Score;
        private System.Windows.Forms.Label gPlayer1Plus;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Panel gameBorder;
        private System.Windows.Forms.Label labelCountdown;
        private System.Windows.Forms.Label winnerLabel;
    }
}

