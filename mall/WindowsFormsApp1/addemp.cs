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
    public partial class addemp : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-75IR95H\\SQLEXPRESS;Initial Catalog=mall;Integrated Security=True");
        public addemp()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into employee values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox10.Text + "','" + textBox11.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record inserted successfully");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminterface af = new adminterface();
            af.Show();
            this.Hide();
        }
    }
}
