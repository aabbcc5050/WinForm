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

namespace WindowsFormsApp8
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
            UdpClient udpclient = new UdpClient(Convert.ToInt32(textBox2.Text));
            udpclient.Connect(textBox1.Text, Convert.ToInt32(textBox2.Text));
            Byte[] sendBytes = Encoding.Default.GetBytes(textBox3.Text);
            udpclient.Send(sendBytes, sendBytes.Length);
            IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, 0);
            Byte[] receiveBytes = udpclient.Receive(ref ipendpoint);
            string returnData = Encoding.Default.GetString(receiveBytes);
            richTextBox1.Text = "接受到的信息:" + returnData.ToString();
            richTextBox1.Text += "\n这条信息来自主机" + ipendpoint.Address.ToString() + "上的" + ipendpoint.Port.ToString() + "端口";
            udpclient.Close();
        }
    }
}
