﻿using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 class1 = new Class1();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            class1.StartListener();
        }
    }
}
