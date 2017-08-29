using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen blackPen = new Pen(Color.Black,3);
            Point p1 = new Point(10, 50);
            Point p2 = new Point(100, 50);
            Graphics g = this.CreateGraphics();
            g.DrawLine(blackPen,p1,p2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Red, 3);
            g.DrawLine(pen,150,30,150,100);

        }
    }
}
