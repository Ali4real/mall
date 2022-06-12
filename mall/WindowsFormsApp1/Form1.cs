using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            empad empad = new empad();
            this.Hide();
            empad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empup empup = new empup();
            this.Hide();
            empup.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            empvr empvr = new empvr();
            this.Hide();
            empvr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            choice ch = new choice();
            this.Hide();
            ch.Show();
        }
    }
}
