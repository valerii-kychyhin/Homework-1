using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = "The Joker";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = "The Jack of Hearts";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = "The Queen of Hearts";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = "The King of Hearts";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "The Ace of Hearts";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
