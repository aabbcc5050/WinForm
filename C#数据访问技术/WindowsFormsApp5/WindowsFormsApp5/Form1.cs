using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=.;database=test;uid=sa;pwd=sa");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from user_test";
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read()) {
                listView1.Items.Add(sdr[1].ToString());
            }
            sdr.Close();//要关闭
            if (textBox1.Text != "") {
                cmd.CommandText = "select count(*) from user_test where user_sex='"+ textBox1.Text + "'";
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                label1.Text = "有"+ i + "个"+textBox1.Text.Trim() + "职员";
            }          
            conn.Dispose();
            button1.Enabled = false;
        }
    }
}
