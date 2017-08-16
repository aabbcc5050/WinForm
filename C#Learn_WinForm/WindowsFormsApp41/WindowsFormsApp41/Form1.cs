using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strPath = Application.StartupPath.Substring(0,Application.StartupPath.Substring(0,Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            strPath += @"\helpPage.htm";
            helpProvider1.HelpNamespace = strPath;
            helpProvider1.SetShowHelp(this,true);
        }
    }
}
