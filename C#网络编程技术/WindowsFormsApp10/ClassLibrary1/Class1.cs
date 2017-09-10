using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Class1
    {
        public const int port = 11000;
        public void StartListener()
        {
            UdpClient udpclient = new UdpClient(port);
            IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, port);  //IP地址+端口号
            try
            {
                while (true)
                {
                    byte[] bytes = udpclient.Receive(ref ipendpoint);
                    string strIP = "信息来自" + ipendpoint.Address.ToString();
                    string strInfo = Encoding.GetEncoding("gb2312").GetString(bytes, 0, bytes.Length);
                    MessageBox.Show(strInfo, strIP);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                udpclient.Close();
            }
        }

        public string Send(String strServer, string strContent)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress ipaddress = IPAddress.Parse(strServer);
            byte[] btContent = Encoding.GetEncoding("gb2312").GetBytes(strContent);
            IPEndPoint ipendpoint = new IPEndPoint(ipaddress, 11000);
            socket.SendTo(btContent, ipendpoint);
            socket.Close();
            return "发送成功";
        }
    }
}
