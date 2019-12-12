using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_game_1
{
    public partial class race : Form
    {
        public race()
        {
            InitializeComponent();
            Over.Visible = false;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(8);
            enemy (3);
            gameover();
           
        }



        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemy3.Top >= 500)
            {
                x = r.Next(0, 100);

                enemy3.Location = new Point(x, 0);
            }

            //enemy2
            else { enemy2.Top += speed; }

            if (enemy2.Top >= 500)
            {
                x = r.Next(0, 400);

                enemy2.Location = new Point(x, 0);
            }
            else { enemy2.Top += speed; }


            if (enemy1.Top >= 500)
            {
                x = r.Next(200, 350);

                enemy1.Location = new Point(x, 0);
            }
            else { enemy1.Top += speed; }
        }








        //retart


      




























        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemy1.Bounds))
           {
                timer1.Enabled = false;
                Over.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }

        }

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }

            if (pictureBox5.Top >= 500)
            { pictureBox5.Top = 0; }
            else { pictureBox5.Top += speed; }



        }



        private void Car_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Car_Click(object sender, EventArgs e)
        {

        }
        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                    car.Left += -8;

            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 380)
                    car.Left += 8;

                if (e.KeyCode == Keys.Down)

                    if (gamespeed > 0)
                    { gamespeed--; }


                if (e.KeyCode == Keys.Up)

                    if (gamespeed < 21)
                    { gamespeed++; }





            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

          

        }

        private void redo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void exitgame_Click(object sender, EventArgs e)
        {
           
        }

        private void mainmenu_Click(object sender, EventArgs e)
        {
            start_of_game myDriverForm = new start_of_game();


            myDriverForm.Show();
        }

        private void enemy1_Click(object sender, EventArgs e)
        {

        }

        private void ca1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
