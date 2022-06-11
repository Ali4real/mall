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
    
    public partial class admin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-75IR95H\\SQLEXPRESS;Initial Catalog=mall;Integrated Security=True");
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cd = new SqlCommand("select count(*) from adm where id='"+textBox1.Text+"' and pass='"+textBox2.Text+"'",con);
            int a = (int)cd.ExecuteScalar();
            if (a > 0)
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("invalid ceredentials....!");
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminmenu adm = new adminmenu();
            this.Hide();
            adm.Show();
        }
    }
}
