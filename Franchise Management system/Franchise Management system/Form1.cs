using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace Franchise_Management_system
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-75IR95H\\SQLEXPRESS;Initial Catalog=FMS;Integrated Security=True");
       
        
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        //    System.Media.SoundPlayer player = new SoundPlayer(@"C:\Users\Abdullah\Desktop\Tom and Jerry Scream (online-audio-converter.com).wav");
         //   player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
         //   System.Media.SoundPlayer player = new SoundPlayer(@"C:\Users\Abdullah\Desktop\Tom and Jerry Scream (online-audio-converter.com).wav");
         //   player.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into product values ('" + textBox1.Text + "','" + textBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("yess ");
        //    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Abdullah\Desktop\Tom and Jerry Scream (online-audio-converter.com).wav");
        //    player.Play();
        }
    }
}
