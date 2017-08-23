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

namespace WindowsFormsApp3
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
                MessageBox.Show("文件名不能为空!");
            }
            else {
                FileInfo finfo = new FileInfo(textBox1.Text);
                if (finfo.Exists)
                {
                    MessageBox.Show("该文件已经存在");
                }
                else {
                    finfo.Create();
                }
            }
        }
    }
}
