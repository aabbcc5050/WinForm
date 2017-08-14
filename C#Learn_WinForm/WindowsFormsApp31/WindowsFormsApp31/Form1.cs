using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
            listView1.LargeImageList = imageList1;
            listView1.Items.Add("用一生下载你1");
            listView1.Items.Add("用一生下载你2");
            listView1.Items.Add("用一生下载你3");
            listView1.Items.Add("用一生下载你4");
            listView1.Items.Add("用一生下载你5");
            listView1.Items[0].ImageIndex = 0;
            listView1.Items[1].ImageIndex = 1;
            listView1.Items[2].ImageIndex = 0;
            listView1.Items[3].ImageIndex = 1;
            listView1.Items[4].ImageIndex = 0;
        }
    }
}
