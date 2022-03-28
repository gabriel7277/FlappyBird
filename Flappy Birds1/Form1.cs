using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Text;
using System.Windows.Forms;

namespace Flappy_Birds1
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            pipebottom.Left -= pipeSpeed;
            pipetop.Left -= pipeSpeed;
            scoreText.Text = " Score: " + score;

            if (pipebottom.Left < -150)
            {
                pipebottom.Left = 800;
                score++;
            }
            if (pipetop.Left < -180)
            {
                pipetop.Left = 950;
                score++;
            }

            if (FlappyBird.Bounds.IntersectsWith(pipebottom.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(pipetop.Bounds) ||
                FlappyBird.Bounds.IntersectsWith(ground.Bounds) || FlappyBird.Top < -25
                )
            {
                endGame();
            }
            if (score > 5)
            {
                pipeSpeed = 15;
            }
        }
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

        }

        private void endGame()
        {
            gametimer.Stop();
            scoreText.Text += "  Game over!";
        }

    }
}
