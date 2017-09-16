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
        private static string TopKey = "HARDWARE";
        private static string SubKey = "LS";

        private void button1_Click(object sender, EventArgs e)
        {
            String key = textBox1.Text;
            String value = textBox2.Text;
            if (key == string.Empty) {
                MessageBox.Show("请输入key");
                return;
            }
            if (value == string.Empty)
            {
                MessageBox.Show("请输入value");
                return;
            }
            try {
                RegistryKey hklm = Registry.LocalMachine;
                RegistryKey sortware = hklm.OpenSubKey(TopKey, true);
                RegistryKey main1 = sortware.CreateSubKey(SubKey);
                RegistryKey ddd = main1.CreateSubKey(key);
                ddd.SetValue("value", value);
                MessageBox.Show("创建成功");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String key = textBox1.Text;
            String value = textBox2.Text;
            if (key == string.Empty)
            {
                MessageBox.Show("请输入key");
                return;
            }
            if (value == string.Empty)
            {
                MessageBox.Show("请输入value");
                return;
            }
            try
            {
                RegistryKey hklm = Registry.LocalMachine;
                RegistryKey sortware = hklm.OpenSubKey(TopKey, true);
                RegistryKey dddw = sortware.OpenSubKey(SubKey, true);
                RegistryKey ddd = dddw.OpenSubKey(key, true);
                ddd.SetValue("value", value);
                MessageBox.Show("修改成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String key = textBox1.Text;
            if (key == string.Empty)
            {
                MessageBox.Show("请输入key");
                return;
            }
            try
            {
                RegistryKey hklm = Registry.LocalMachine;
                RegistryKey sortware = hklm.OpenSubKey(TopKey, true);
                RegistryKey no1= sortware.OpenSubKey(SubKey, true);
                no1.DeleteSubKey(key, false);//删除键和值
                //no1.DeleteValue(key, false);//删除键值
                //no1.DeleteSubKeyTree(key, false);//删除,如果有子健,子健也会被删除
                MessageBox.Show("删除成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
