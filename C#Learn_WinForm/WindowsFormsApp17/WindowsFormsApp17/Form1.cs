using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
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
                MessageBox.Show("添加的项目不能为空");
            }
            else {
                listBox1.Items.Add(textBox1.Text);
                listBox1.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;//运行多选
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "共选择了:"+listBox1.SelectedItems.Count.ToString();
        }
    }
}
