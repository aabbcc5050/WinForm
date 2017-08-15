using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode tn1 = treeView1.Nodes.Add("名称");

            TreeNode ntn1 = new TreeNode("number1");
            TreeNode ntn2 = new TreeNode("number2");
            TreeNode ntn3 = new TreeNode("number3");

            tn1.Nodes.Add(ntn1);
            tn1.Nodes.Add(ntn2);
            tn1.Nodes.Add(ntn3);

            treeView1.ImageList = imageList1;
            imageList1.ImageSize = new Size(16,16);
            treeView1.ImageIndex = 0;
            treeView1.SelectedImageIndex = 1;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text = "当前选中的节点:" + e.Node.Text;
        }
    }
}
