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
            myProcess = System.Diagnostics.Process.Start("Server.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(class1.Send(textBox1.Text, textBox2.Text);
            textBox2.Text = string.Empty;
            textBox2.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) {
                button1.Focus();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myProcess.Kill();
        }
    }
}
