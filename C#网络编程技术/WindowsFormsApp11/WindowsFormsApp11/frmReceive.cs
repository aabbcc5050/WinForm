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
        private string[] PopMail(TcpClient tcpclient,int i) {
            string strRet;
            string[] arrRet = new string[20];
            bool strBody = false;
            string[] arrTemp;
            strRet = SendPopCmd(tcpclient, "retr" + i.ToString());
            if (!JudgeString(strRet)) {
                return "-ERR -ERR".Split(" ".ToCharArray());
            }
            arrRet[0] = "+OK";
            while (sreader.Peek()!=46) {
                strRet = sreader.ReadLine();
                arrTemp = strRet.Split(".".ToCharArray());
                if (strRet == "") {
                    strBody = true;
                }
                if (arrTemp[0].ToLower() == "date") {
                    arrRet[1] = arrTemp[1];
                }
                if (arrTemp[0].ToLower() == "from") {
                    arrRet[2] = (arrTemp[1].Substring(arrTemp[1].LastIndexOf("<") + 1)).Replace(">", "");
                }
                if(arrTemp[0].ToLower() == "to") {
                    arrRet[3] = (arrTemp[1].Substring(arrTemp[1].LastIndexOf("<") + 1)).Replace(">", "");
                }
                if(arrTemp[0].ToLower() == "subject") {
                    arrRet[5] = arrTemp[1].ToString();
                }
                if (strBody) {
                    arrRet[5] = arrRet[5] + strRet + "\n";
                }
            }
            return arrRet;
        }

        public static string Base64Decode(string str) {
            return Encoding.UTF8.GetString(Convert.FromBase64String(str));
        }

        private void button3_Click(object sender, EventArgs e)
        {//登录按钮
            string user = txtMail.Text;
            string pass = txtPOP.Text;
            string[] arrRet;
            pwd = pass;
            strserver = txtPOP.Text;
            tcpclient = new TcpClient();
            try
            {
                tcpclient.Connect(strserver, 110);          //连接远程主机
                sreader = new StreamReader(tcpclient.GetStream(), Encoding.Default);
                sreader.ReadLine();
                strRet = Logon(tcpclient, user, pass);
                if (!JudgeString(strRet)) {
                    MessageBox.Show("用户名或者密码不匹配");
                    return;
                }
                arrRet = StaticMailBox(tcpclient);
                if (arrRet[0] != "+OK") {
                    MessageBox.Show("出错了!");
                    return;
                }
                richTextBox1.AppendText("当前用户:" + user + "\n");
                richTextBox1.AppendText("邮箱中共有:" + arrRet[1] + "封邮件\n");
                richTextBox1.AppendText("当前用户:" + user + "\n");
                k = Convert.ToInt32(arrRet[1]);
                txtPOP.ReadOnly = txtMail.ReadOnly = txtPwd.ReadOnly = true;
                button3.Enabled = false;
                button1.Enabled = true;
                MessageBox.Show("登录成功!");
            }
            catch {
                MessageBox.Show("连接服务器失败!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//接受按钮
            try
            {
                if (txtNum.Text != "")
                {
                    if (Convert.ToInt32(txtNum.Text) > k || Convert.ToInt32(txtNum.Text) <= 0)
                    {
                        MessageBox.Show("输入的索引错误");
                    }
                    else
                    {
                        richTextBox1.Clear();
                        string[] arrRets = PopMail(tcpclient, Convert.ToInt32(txtNum.Text));
                        richTextBox1.AppendText("当前是第" + txtNum.Text + "封信" + "\n");
                        richTextBox1.AppendText("邮件日期:" + arrRets[1]  + "\n");
                        richTextBox1.AppendText("发信人:" + arrRets[2]  + "\n");
                        richTextBox1.AppendText("收信人:" + arrRets[3] + "\n");
                        richTextBox1.AppendText("邮件主题:" + Base64Decode(arrRets[4])  + "\n");
                        richTextBox1.AppendText("邮件内容:" + Base64Decode(arrRets[5]));
                    }
                }
                else {
                    MessageBox.Show("邮件索引错误!");
                }
            }
            catch {
                MessageBox.Show("接收邮件发生错误!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//退出按钮
            tcpclient.Close();
        }
    }
}
