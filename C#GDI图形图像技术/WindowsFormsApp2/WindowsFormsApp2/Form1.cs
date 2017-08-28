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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics ghs = this.CreateGraphics();
            for (int i=1;i<6;i++) {
                HatchStyle hs = (HatchStyle)(5 + i);
                HatchBrush hb = new HatchBrush(hs,Color.White);
                Rectangle rtl = new Rectangle(10, 50 * i, 50 * i, 50);
                ghs.FillRectangle(hb,rtl);
            }
        }
    }
}
