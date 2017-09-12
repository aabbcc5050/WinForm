using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class frmReceive : Form
    {
        public frmReceive()
        {
            InitializeComponent();
        }

        public static string strserver;
        public static string pwd;
        public static int k;
        public static TcpClient tcpclient;
        public static StreamReader sreader;
        public static string strRet;
        //向服务发送命令
        private string SendPopCmd(TcpClient tcpclient,string strCmd) {
            Byte[] arrCmd;
            string strRet;
            Stream stream = tcpclient.GetStream();
            strCmd = strCmd + "\r\n";
            arrCmd = Encoding.Default.GetBytes(strCmd.ToCharArray());
            stream.Write(arrCmd, 0, strCmd.Length);
            strRet = sreader.ReadLine();
            return strRet;
        }
        //该方法用来对获取连接的用户身份进行验证
        private string Logon(TcpClient tcpclient,string user,string pass) {
            string strRet;
            strRet = SendPopCmd(tcpclient, "user" + user);
            strRet = SendPopCmd(tcpclient, "pass" + pass);
            return strRet;
        }
        private string[] StaticMailBox(TcpClient tcpclient) {
            string strRet = SendPopCmd(tcpclient, "stat");
            if (JudgeString(strRet))
            {
                return "-ERR -ERR".Split(" ".ToCharArray());
            }
            else {
                string[] arrRet = strRet.Split(" ".ToCharArray());
                return arrRet;
            }
        }
        //判断返回的字符串信息,如果是+OK,证明登录成功,否则登录失败
        private bool JudgeString(string strCheck) {
            return strCheck.Substring(0, 3) == "+OK";
        }
    }
}
