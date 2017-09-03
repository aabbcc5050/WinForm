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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress[] ips = Dns.GetHostAddresses(textBox1.Text);
            foreach (IPAddress ip in ips) {
                label2.Text = "国际网络协议地址:" + ip.Address + "\nIP地址的地址族:" + ip.AddressFamily.ToString() +
                    "\n是否IPv6链接本地地址:" + ip.IsIPv6LinkLocal;
            }
        }
    }
}
