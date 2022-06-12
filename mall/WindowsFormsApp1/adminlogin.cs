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

namespace WindowsFormsApp1
{
    public partial class adminlogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-75IR95H\\SQLEXPRESS;Initial Catalog=mall;Integrated Security=True");
        public adminlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choice choice = new choice();
            this.Hide();
            choice.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from adm", con);
            int a = (int)cmd.ExecuteScalar();
            if (a > 0)
            {
                adminterface af = new adminterface();
                af.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid ceredendials....!");
                con.Close();
            }

        }
    }
}
