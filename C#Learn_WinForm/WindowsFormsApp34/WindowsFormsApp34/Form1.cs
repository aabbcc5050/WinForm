using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp34
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

            TreeNode ntn1 = new TreeNode("名称1");
            TreeNode ntn2 = new TreeNode("名称2");
            TreeNode ntn3 = new TreeNode("名称3");

            tn1.Nodes.Add(ntn1);
            tn1.Nodes.Add(ntn2);
            tn1.Nodes.Add(ntn3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "名称")
            {
                MessageBox.Show("请选择要删除的子节点");
            }
            else {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
        }
    }
}
