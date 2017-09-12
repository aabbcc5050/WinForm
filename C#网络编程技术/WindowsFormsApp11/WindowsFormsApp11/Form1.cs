using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form fromSend = new frmSend();
        Form fromReceive = new frmReceive();

        private void 邮件发送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fromSend.Show();
            fromReceive.Hide();

        }

        private void 邮件接收ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fromSend.Hide();
            fromReceive.Show();
        }
    }
}
