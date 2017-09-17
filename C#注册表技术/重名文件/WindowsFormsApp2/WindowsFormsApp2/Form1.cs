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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string documentKey = "{450D8FBA-AD25-11D0-98A8-0800361B1103}";
        private string netKey = "{208D2C60-3AEA-1069-A2D7-08002B30309D}";
        private string computerKey = "{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
        private string IeKey = "{871C5380-42A0-1069-A2EA-08002B30309D}";

        private void button1_Click(object sender, EventArgs e)
        {
            int i0 = checkBox1.Checked ? 0 : 1;
            int i1 = checkBox2.Checked ? 0 : 1;
            int i2 = checkBox3.Checked ? 0 : 1;
            int i3 = checkBox4.Checked ? 0 : 1;
            RegistryKey reg = null;
            try
            {
                //部分没效果,可能是xp系统才有效(不管他)
                reg = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel");
                //reg = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel");
                reg.SetValue(documentKey, i0, RegistryValueKind.DWord);
                reg.SetValue(netKey, i1, RegistryValueKind.DWord);
                reg.SetValue(computerKey, i2, RegistryValueKind.DWord);
                reg.SetValue(IeKey, i3, RegistryValueKind.DWord);
                reg.Close();
                MessageBox.Show("执行完毕!请刷新页面或者重启!");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
