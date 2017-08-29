using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
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
            Pen pen = new Pen(Color.Black,3);
            g.DrawEllipse(pen,100,50,100,50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Red,3);
            Rectangle rectangle = new Rectangle(70,20,100,60);
            g.DrawArc(pen,rectangle,210,120);
        }
    }
}
