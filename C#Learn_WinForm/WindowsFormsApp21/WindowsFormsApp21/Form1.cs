using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
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
            tabControl1.Appearance = TabAppearance.Buttons;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Title = "新增选项卡"+(tabControl1.TabCount+1).ToString();
            TabPage MyTabPage = new TabPage(Title);
            tabControl1.TabPages.Add(MyTabPage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                MessageBox.Show("请选择要删除的选项卡");
            }
            else {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
        }
    }
}
