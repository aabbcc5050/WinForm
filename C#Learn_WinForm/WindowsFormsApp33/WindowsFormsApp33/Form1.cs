using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp33
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
            TreeNode tn2 = treeView1.Nodes.Add("性别");
            TreeNode tn3 = treeView1.Nodes.Add("年龄");

            TreeNode ntn1 = new TreeNode("用一生下载你");
            TreeNode ntn2 = new TreeNode("xxxx");
            TreeNode ntn3 = new TreeNode("一生所爱");

            tn1.Nodes.Add(ntn1);
            tn1.Nodes.Add(ntn2);
            tn1.Nodes.Add(ntn3);

            TreeNode stn1 = new TreeNode("男");
            TreeNode stn2 = new TreeNode("女");
            TreeNode stn3 = new TreeNode("男");

            tn2.Nodes.Add(stn1);
            tn2.Nodes.Add(stn2);
            tn2.Nodes.Add(stn3);

            TreeNode atn1 = new TreeNode("28");
            TreeNode atn2 = new TreeNode("27");
            TreeNode atn3 = new TreeNode("26");

            tn3.Nodes.Add(atn1);
            tn3.Nodes.Add(atn2);
            tn3.Nodes.Add(atn3);
        }
    }
}
