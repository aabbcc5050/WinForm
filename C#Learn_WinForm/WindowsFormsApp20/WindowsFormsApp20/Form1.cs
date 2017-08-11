using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.ImageList = imageList1;
            tabPage1.ImageIndex = 0;
            tabPage2.ImageIndex = 0;
            string Title = "新增选项卡"+(tabControl1.TabCount+1).ToString();
            TabPage MyTabPage = new TabPage(Title);
            tabControl1.TabPages.Add(MyTabPage);
        }
    }
}
