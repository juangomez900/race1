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
    public partial class start_of_game : Form
    {
        public start_of_game()
        {
            InitializeComponent();
        }

        private void mainmenu_Click(object sender, EventArgs e)
        {
            race myDriverForm = new race();


            myDriverForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bit.ly/race125");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://schools.graniteschools.org/cyprushigh/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCK64Zag04CQcV850P4ApiXg");
        }

        private void gameabout_Click(object sender, EventArgs e)
        {
          what_this_game_is_about myDriverForm = new what_this_game_is_about();


            myDriverForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
