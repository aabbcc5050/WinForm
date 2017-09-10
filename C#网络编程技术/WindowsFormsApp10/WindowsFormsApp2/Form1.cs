using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


        Class1 class1 = new Class1();
        System.Diagnostics.Process myProcess;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string exepath = @"I:\github\WinForm\C#网络编程技术\WindowsFormsApp10\WindowsFormsApp10\bin\Debug\WindowsFormsApp10.exe";
            string exepath = @"I:\github\WinForm\C#网络编程技术\WindowsFormsApp10\WindowsFormsApp10\obj\Debug\WindowsFormsApp10.exe";
            myProcess = System.Diagnostics.Process.Start(exepath);//这里是个坑,本项目无法调试通过,放弃治疗
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(class1.Send(textBox1.Text, textBox2.Text));
            textBox2.Text = string.Empty;
            textBox2.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1.Focus();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myProcess.Kill();
        }
    }
}
