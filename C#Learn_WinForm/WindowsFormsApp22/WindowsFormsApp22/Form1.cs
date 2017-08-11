using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message(sender, e);
        }

        private void 打开QToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message(sender, e);
        }

        private void 关闭CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message(sender, e);
        }

        private void 保存CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            message(sender, e);
        }

        private void message(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;
            MessageBox.Show("你点击了" + tsm.Text);
        }
    }
}
