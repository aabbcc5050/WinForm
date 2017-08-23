using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
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
                MessageBox.Show("文件夹名称不能为空");
            }
            else {
                DirectoryInfo dinfo = new DirectoryInfo(textBox1.Text);
                if (dinfo.Exists)
                {
                    MessageBox.Show("该文件夹已经存在");
                }
                else {
                    dinfo.Create();
                }
            }
        }
    }
}
