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

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = textBox1.Text;
            int port = Convert.ToInt32(textBox2.Text);
            string strContent = SocketSendReceive(server, port);
            MessageBox.Show(strContent);
        }

        private static Socket ConnectSocket(string server,int port) {
            Socket socket = null;
            IPHostEntry iphostentry = Dns.GetHostEntry(server);
            foreach (IPAddress address in iphostentry.AddressList)
            {
                IPEndPoint ipepoint = new IPEndPoint(address, port);
                Socket newSocket = new Socket(ipepoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                newSocket.Connect(ipepoint);
                if (newSocket.Connected)
                {
                    socket = newSocket;
                    break;
                }
                else {
                    continue;
                }             
            }
            return socket;

        }

        private static string SocketSendReceive(string server, int port) {
            string request = "GET/HTTP/1.1\n主机:" + server + "\n连接:关闭\n";
            Byte[] btSend = Encoding.ASCII.GetBytes(request);
            Byte[] btReceived = new Byte[256];
            Socket socket = ConnectSocket(server, port);
            if (socket == null) {
                return ("连接失败!");
            }
            socket.Send(btSend, btSend.Length, 0);
            int intContent = 0;
            string strContent = server + "上的默认页面内容:\n";
            do
            {
                intContent = socket.Receive(btReceived, btReceived.Length, 0);
                strContent += Encoding.ASCII.GetString(btReceived, 0, intContent);
            }
            while (intContent > 0);
            return strContent;
        }
    }
}
