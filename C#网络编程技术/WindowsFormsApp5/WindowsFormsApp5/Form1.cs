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

namespace WindowsFormsApp5
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
            WebRequest webrequest = WebRequest.Create(textBox1.Text);
            webrequest.Credentials = CredentialCache.DefaultCredentials;
            richTextBox1.Text = "请求内容长度:" + webrequest.ContentLength;
            richTextBox1.Text += "\n该请求的协议方法:" + webrequest.Method;
            richTextBox1.Text += "\n访问internet的网络代理:" + webrequest.Proxy;
            richTextBox1.Text += "\n与该请求关联的internet URI:" + webrequest.RequestUri;
            richTextBox1.Text += "\n超时时间" + webrequest.Timeout;
            WebResponse webresponse = webrequest.GetResponse();
            richTextBox1.Text += "\n响应请求的internet URI:" + webresponse.ResponseUri;
            Stream stream = webresponse.GetResponseStream();
            StreamReader sreader = new StreamReader(stream);
            richTextBox1.Text += "\n" + sreader.ReadToEnd();
            sreader.Close();
            stream.Close();
            webresponse.Close();
        }
    }
}
