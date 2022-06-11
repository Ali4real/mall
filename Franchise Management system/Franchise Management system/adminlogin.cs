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
    public partial class adminlogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-75IR95H\\SQLEXPRESS;Initial Catalog=FMS;Integrated Security=True");
        public adminlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) admin where id = '"+textBox1.Text+"' and pass='"+textBox2.Text+"'");
            int a = (int)cmd.ExecuteScalar();
            if(a>0){
                Form4 f4 = new Form4();
                this.Hide();
                f4.Show();
            }
            else{
                MessageBox.Show("invalid ceredentials....!");
               
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
