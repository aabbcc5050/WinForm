using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string key1 = "NoRun";
        string key2 = "NoSMHelp";
        string key3 = "NoFind";
        string key4 = "notraycontextmenu";
        string key5 = "HideClock";

        int hideValue = 1;
        int showValue = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            regSetKeyAndValue(key1,hideValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            regSetKeyAndValue(key2, hideValue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            regSetKeyAndValue(key3, hideValue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            regSetKeyAndValue(key4, hideValue);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            regSetKeyAndValue(key5, hideValue);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            regSetKeyAndValue(key1, showValue);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            regSetKeyAndValue(key2, showValue);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            regSetKeyAndValue(key3, showValue);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            regSetKeyAndValue(key4, showValue);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            regSetKeyAndValue(key5, showValue);
        }

        private void regSetKeyAndValue(String key, int value)
        {
            try
            {
                RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer");
                reg.SetValue(key, value);
                reg.Close();
                MessageBox.Show("执行成功!请刷新桌面或者重新启动计算机", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
