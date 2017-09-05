using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcpListener tcplistener = null;
            IPAddress ipaddress = IPAddress.Parse(textBox1.Text);

            int port = Convert.ToInt32(textBox2.Text);
            tcplistener = new TcpListener(ipaddress, port);
            tcplistener.Start();
            richTextBox1.Text = "等待连接...\n";
            TcpClient tcpClient = null;
            if (tcplistener.Pending())
            {
                tcpClient = tcplistener.AcceptTcpClient();
            }
            else {
                tcpClient = new TcpClient(textBox1.Text, port);
            }
            richTextBox1.Text = "连接成功!\n";
            tcpClient.Close();
            tcplistener.Stop();
        }
    }
}
