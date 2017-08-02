﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否查看窗体!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.OK) {

            }
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("你点击了窗口");
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭窗体", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else {
                e.Cancel = true;
            }
        }


    }
}
