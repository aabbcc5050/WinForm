using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2017,8,16);
            monthCalendar1.AddBoldedDate(dt);
            monthCalendar1.UpdateBoldedDates();

            textBox1.Text = monthCalendar1.TodayDate.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = monthCalendar1.SelectionStart.ToString();
            textBox3.Text = monthCalendar1.SelectionEnd.ToString();
        }
    }
}
