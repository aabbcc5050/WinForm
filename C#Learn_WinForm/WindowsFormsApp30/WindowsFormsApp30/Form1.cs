using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.LargeImageList = imageList1;
            imageList1.ImageSize = new Size(37,36);
            listView1.SmallImageList = imageList1;
            listView1.Items.Add("添加1");
            listView1.Items.Add("添加2");
            listView1.Items[0].ImageIndex = 0;
            listView1.Items[1].ImageIndex = 1;
        }
    }
}
