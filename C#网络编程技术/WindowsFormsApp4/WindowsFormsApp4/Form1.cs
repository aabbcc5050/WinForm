using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
            richTextBox1.Text = string.Empty;
            WebClient wclient = new WebClient();
            wclient.BaseAddress = textBox1.Text;
            wclient.Encoding = Encoding.UTF8;
            wclient.Headers.Add("Content-type", "application/x-www.from-urlencoded");
            Stream stream = wclient.OpenRead(textBox1.Text);
            StreamReader sreader = new StreamReader(stream);
            string str = string.Empty;
            while ((str = sreader.ReadLine())!=null) {
                richTextBox1.Text += str + "\n";
            }
            wclient.DownloadFile(textBox1.Text, DateTime.Now.ToFileTime() + ".txt");
            MessageBox.Show("保存文件成功!");
        }
    }
}
