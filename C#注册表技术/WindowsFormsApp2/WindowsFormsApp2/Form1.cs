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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            RegistryKey regkey = Registry.LocalMachine;
            RegistryKey sys = regkey.OpenSubKey(@"SOFTWARE");
            foreach (string str in sys.GetSubKeyNames()) {
                listBox1.Items.Add("子项目:" + str);
                RegistryKey sikey = sys.OpenSubKey(str);
                foreach (string sVName in sikey.GetValueNames()) {
                    listBox1.Items.Add(sVName + sikey.GetValue(sVName));
                }
            }
        }
    }
}
