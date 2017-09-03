using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入主机地址!");
            }
            else {
                textBox2.Text = string.Empty;
                IPAddress[] ips = Dns.GetHostAddresses(textBox1.Text);
                foreach (IPAddress ip in ips) {
                    textBox2.Text = ip.ToString();
                }
                textBox3.Text = Dns.GetHostName();
                textBox4.Text = Dns.GetHostByName(Dns.GetHostName()).HostName;
            }
        }
    }
}
