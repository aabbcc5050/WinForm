using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 500;
            progressBar1.Step = 1;
            for (int i=0;i<500;i++) {
                progressBar1.PerformStep();
                textBox1.Text = "进度条:" + progressBar1.Value.ToString();
            }
        }
    }
}
