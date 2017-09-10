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

namespace WindowsFormsApp11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Class1 class1 = new Class1();
        System.Diagnostics.Process myProcess;
        private void Form2_Load(object sender, EventArgs e)
        {
            
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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myProcess.Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myProcess = System.Diagnostics.Process.Start("WindowsFormsApp11.exe");//这里是个坑,本项目无法调试通过
        }
    }
}
