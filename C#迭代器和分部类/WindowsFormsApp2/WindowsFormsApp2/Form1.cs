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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                account at = new account();
                int M = int.Parse(textBox1.Text.Trim());
                int N = int.Parse(textBox2.Text.Trim());
                string str = comboBox1.Text;
                switch (str) {
                    case "加" : textBox3.Text = at.addition(M, N).ToString();break;
                    case "减": textBox3.Text = at.subtraction(M, N).ToString(); break;
                    case "乘": textBox3.Text = at.multiplication(M, N).ToString(); break;
                    case "除": textBox3.Text = at.division(M, N).ToString(); break;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        partial class account {
            public int addition(int a, int b) {
                return a + b;
            }
        }

        partial class account
        {
            public int multiplication(int a, int b)
            {
                return a * b;
            }
        }

        partial class account
        {
            public int subtraction(int a, int b)
            {
                return a - b;
            }
        }

        partial class account
        {
            public int division(int a, int b)
            {
                return a / b;
            }
        }
    }
}
