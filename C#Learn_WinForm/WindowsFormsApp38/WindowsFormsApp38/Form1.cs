﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //monthCalendar1.TitleBackColor = System.Drawing.Color.Blue;
            //monthCalendar1.TrailingForeColor = System.Drawing.Color.Red;
            //monthCalendar1.TitleForeColor = System.Drawing.Color.Yellow;

            //显示周数
            monthCalendar1.ShowWeekNumbers = true;
            //显示多个月份
            monthCalendar1.CalendarDimensions = new Size(2,2);
        }
    }
}
