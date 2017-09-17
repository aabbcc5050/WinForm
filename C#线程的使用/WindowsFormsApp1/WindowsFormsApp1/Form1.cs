using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            string strinfo = string.Empty;
            Thread myThread = new Thread(new ThreadStart(threadOut));
            myThread.Start();
            strinfo = "线程唯一标识符: " + myThread.ManagedThreadId;
            strinfo += "\n 线程名称: " + myThread.Name;
            strinfo += "\n 线程状态: " + myThread.ThreadState.ToString();
            strinfo += "\n 线程优先级: " + myThread.Priority.ToString();
            strinfo += "\n 是否为后台线程: " + myThread.IsBackground;
            //Thread.Sleep(1000);
            myThread.Abort("退出");
            myThread.Join();
            MessageBox.Show("线程运行结束");
            richTextBox1.Text = strinfo;
        }

        public void threadOut() {
            MessageBox.Show("主线程开始运行");
        }
    }
}
