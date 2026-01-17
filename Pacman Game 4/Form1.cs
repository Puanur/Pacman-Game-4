using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_Game_4
{
    public partial class Form1 : Form
    {
        bool goup, godown, goleft, goright;
        bool noup, nodown, noleft, noright;
        List<PictureBox> walls = new List<PictureBox>();
        List<PictureBox> coins = new List<PictureBox>();
        int speed = 8;
        int score = 0;

        Ghost red, yellow, blue, pink;
        List<Ghost> ghosts = new List<Ghost>();

        public Form1()
        {
            InitializeComponent();
            SetUp();
        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && !noleft )
            {
                goright = godown = goup = false;
                noright = nodown = noup = false;
                goleft = true;
                pacman.Image = Properties.Resources.pacman_left;
            }
            if (e.KeyCode == Keys.Right && !noright)
            {
                goleft = goup = godown = false;
                noleft = noup = nodown = false;
                goright = true;
                pacman.Image = Properties.Resources.pacman_right;
            }
            if (e.KeyCode == Keys.Up && !noup)
            {
                goleft = goright = godown = false;
                noleft = noright = nodown = false;
                goup = true;
                pacman.Image = Properties.Resources.pacman_up;
            }
            if (e.KeyCode == Keys.Down && !nodown)
            {
                goleft = goright = goup = false;
                noleft = noright = noup = false;
                godown = true;
                pacman.Image = Properties.Resources.pacman_down;
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            PlayerMovements();

            foreach (PictureBox wall in walls)
            {
                CheckBoundaries(pacman, wall);
            }

            foreach (PictureBox coin in coins)
            {
                CollectingCoins(pacman, coin);
            }

            if (score == coins.Count())
            {
                ShowCoins();
                score = 0;
            }

            red.GhostMovement(pacman);
            blue.GhostMovement(pacman);
            yellow.GhostMovement(pacman);
            pink.GhostMovement(pacman);

            foreach (Ghost ghost in ghosts)
            {
                GhostCollision(ghost, pacman, ghost.image);
            }
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            panelMenu.Enabled = false;
            panelMenu.Visible = false;

            goleft = goright = goup = godown = false;
            noleft = noright = noup = nodown = false;
            score = 0;

            red.image.Location = new Point(100, 100);
            blue.image.Location = new Point(848, 597);
            yellow.image.Location = new Point(132, 584);
            pink.image.Location = new Point(877, 130);
            GameTimer.Start();
        }

        private void SetUp()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "wall")
                {
                    walls.Add((PictureBox)x);
                }
                if (x is PictureBox && x.Tag == "coin")
                { 
                coins.Add((PictureBox)x);
                }
            }

            red = new Ghost(this, Properties.Resources.red, 100, 100);
            ghosts.Add(red);
            blue = new Ghost(this, Properties.Resources.blue, 848, 597);
            ghosts.Add(blue);
            yellow = new Ghost(this, Properties.Resources.yellow, 132, 584);
            ghosts.Add(yellow);
            pink = new Ghost(this, Properties.Resources.pink, 877, 130);
            ghosts.Add(pink);
        }

        private void PlayerMovements()
        {
            if (goleft) { pacman.Left -= speed; }
            if (goright) { pacman.Left += speed; }
            if (goup) { pacman.Top -= speed; }
            if (godown) { pacman.Top += speed; }

            if (pacman.Left < -30)
            {
                pacman.Left = this.ClientSize.Width - pacman.Width;
            }
            if (pacman.Left + pacman.Width > this.ClientSize.Width)
            {
                pacman.Left = -10;
            }
            if (pacman.Top < -30)
            {
                pacman.Top = this.ClientSize.Height - pacman.Height;
            }
            if (pacman.Top + pacman.Width > this.ClientSize.Height)
            {
                pacman.Top = -10;
            }
        }
        private void ShowCoins()
        {
            foreach (PictureBox coin in coins)
            {
                coin.Visible = true;
            }
        }

        private void CheckBoundaries(PictureBox pacman, PictureBox wall)
        {
            if (pacman.Bounds.IntersectsWith(wall.Bounds))
            {
                if (goleft)
                {
                    noleft = true;
                    goleft = false;
                    pacman.Left = wall.Right + 2;
                }
                if (goright)
                {
                    noright = true;
                    goright = false;
                    pacman.Left = wall.Left - pacman.Width - 2;
                }
                if (goup)
                {
                    noup = true;
                    goup = false;
                    pacman.Top = wall.Bottom + 2;
                }
                if (godown)
                {
                    nodown = true;
                    godown = false;
                    pacman.Top = wall.Top - pacman.Height - 2;
                }
            }
        }

        private void CollectingCoins(PictureBox pacman, PictureBox coin)
        {
            if (pacman.Bounds.IntersectsWith(coin.Bounds))
            {
                if (coin.Visible)
                {
                    coin.Visible = false;
                    score += 1;
                }
            }
        }

        private void GhostCollision(Ghost g, PictureBox pacman, PictureBox ghost)
        {
            if (pacman.Bounds.IntersectsWith(ghost.Bounds))
            {
                GameOver("You Died, Score: " + score);
                g.ChangeDirection();
            }
        }

        private void GameOver(string message)
        {
            panelMenu.Visible = true;
            panelMenu.Enabled = true;
            GameTimer.Stop();
            ShowCoins();
            pacman.Location = new Point(493, 327);
            lblInfo.Text = message;
            lblInfo.Visible = true;
            button1.Text = "Play again" ;
        }
    }
    } 
