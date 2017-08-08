using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Multiline = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Text = "欢迎 http://www.baidu.com 啦啦啦";

            richTextBox2.Multiline = true;
            richTextBox2.ScrollBars = RichTextBoxScrollBars.Vertical;//只显示垂直滚动条
            richTextBox2.SelectionIndent = 8;
            richTextBox2.SelectionRightIndent = 12;

            richTextBox3.Multiline = true;
            richTextBox3.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox3.SelectionBullet = true;
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
