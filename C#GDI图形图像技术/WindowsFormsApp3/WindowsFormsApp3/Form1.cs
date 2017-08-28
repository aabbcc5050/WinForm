using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(100, 100);
            Point p2 = new Point(150, 150);
            LinearGradientBrush lgb = new LinearGradientBrush(p1, p2, Color.Black, Color.White);
            Graphics ghs = this.CreateGraphics();
            lgb.WrapMode = WrapMode.TileFlipX;
            ghs.FillRectangle(lgb,15,15,150,150);
        }
    }
}
