﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Text;

            textBox2.Text = dateTimePicker1.Value.Year.ToString();
            textBox3.Text = dateTimePicker1.Value.Month.ToString();
            textBox4.Text = dateTimePicker1.Value.Day.ToString();
        }
    }
}
