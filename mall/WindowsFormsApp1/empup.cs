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
    public partial class empup : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-75IR95H\\SQLEXPRESS;Initial Catalog=mall;Integrated Security=True");
        public empup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update product set pid ='"+textBox2.Text+"', pname = '"+textBox3.Text+"', price = '"+textBox4.Text+"', Vname='"+textBox5.Text+"' where pid ='"+textBox1.Text+"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("updated successfully");
        }
    }
}
