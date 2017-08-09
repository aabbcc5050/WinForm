using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
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
                MessageBox.Show("请输入姓名");
                textBox1.Focus();
            }
            else {
                if (textBox1.Text == "xxx")
                {
                    panel1.Show();
                }
                else {
                    MessageBox.Show("插入此人");
                    textBox1.Text = "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            richTextBox1.Text = "姓名:xxx\n性别:男\n年龄:22\n名族:汉\n";
        }
    }
}
