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

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=.;database=test;uid=sa;pwd=sa;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from "+textBox1.Text.Trim(),conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                MessageBox.Show(textBox1.Text.Trim() + "表中有数据");
            }
            else {
                MessageBox.Show(textBox1.Text.Trim() + "表中没有数据");
            }
            

        }
    }
}
