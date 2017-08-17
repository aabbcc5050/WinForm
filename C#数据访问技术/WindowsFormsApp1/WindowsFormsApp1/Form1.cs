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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入要连接的数据库名称");
            }
            else {
                try {
                    string ConStr = "server=.;database=" + textBox1.Text.Trim()+ ";uid=sa;pwd=sa;";
                    SqlConnection conn = new SqlConnection(ConStr);
                    conn.Open();
                    if (conn.State==ConnectionState.Open) {
                        label2.Text = "数据库["+textBox1.Text.Trim()+"]";
                    }
                } catch {
                    MessageBox.Show("连接数据库失败!");
                }
            }
        }

    }
}
