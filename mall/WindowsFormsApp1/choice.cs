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
    public partial class choice : Form
    {
        public choice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminlogin adminmenu = new adminlogin();
            this.Hide();
            adminmenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emplogin emplogin = new emplogin();
            this.Hide();
            emplogin.Show();
        }
    }
}
