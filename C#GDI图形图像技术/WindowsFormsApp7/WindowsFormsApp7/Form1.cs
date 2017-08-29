using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Red,3);
            g.DrawPie(pen,50,50,120,100,210,120);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Green,3);
            Point p1 = new Point(80,20);
            Point p2 = new Point(40,50);
            Point p3 = new Point(80,80);
            Point p4 = new Point(160,80);
            Point p5 = new Point(200,50);
            Point p6 = new Point(160,20);
            Point[] mypoint = { p1, p2, p3, p4, p5, p6 };
            g.DrawPolygon(pen,mypoint);
        }
    }
}
