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

namespace WindowsFormsApp4
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
            cmd.CommandText = "update user_test set user_sex='女'";
            cmd.CommandType = CommandType.Text;
            int i = Convert.ToInt32(cmd.ExecuteNonQuery());
            label1.Text = "更新了"+i+"条数据";
        }
    }
}
