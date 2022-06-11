using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Franchise_Management_system
{
    public partial class admin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-75IR95H\\SQLEXPRESS;Initial Catalog=FMS;Integrated Security=True");
        public admin()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from lgi where id= '" + textBox1.Text + "' and pass= '" + textBox2.Text + "'",con);
            int a = (int)cmd.ExecuteScalar();
            if (a > 0)
            {
                Form1 ff = new Form1();
                ff.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid ceredentials.....!");
                con.Close();
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminlogin al = new adminlogin();
            this.Hide();
            al.Show();
        }
    }
}
