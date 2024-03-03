using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOut_Game_in_C_
{
    public partial class Form1 : Form
    {
        bool goLeft;
        bool goRight;
        bool isGameOver;

        int score;
        int ballx;
        int bally;
        int playerSpeed;

        Random rnd= new Random();


        
        public Form1()
        {
            InitializeComponent();
            setUpGame();

        }
        private void setUpGame()
        {
            score = 0;
            ballx = 5;
            bally=5;
            playerSpeed = 12;
            txtScore.Text = "Score : " + score;
            gameTimer.Start();

            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    x.BackColor=Color.FromArgb(rnd.Next(256),rnd.Next(256), rnd.Next(256));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {

            if(goLeft==true && Player.Left > 0)
            {
                Player.Left -= playerSpeed;
            }

            if (goRight==true && Player.Right < 774)
            {
                Player.Left += playerSpeed;
            }
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft=false;

            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
           
        }

        private void keyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
