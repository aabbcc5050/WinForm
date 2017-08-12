using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            string path1 = path + @"\01.jpg";
            string path2 = path + @"\02.jpg";
            Image image1 = Image.FromFile(path1,true);
            Image image2 = Image.FromFile(path2,true);
            imageList1.Images.Add(image1);
            imageList1.Images.Add(image2);
            imageList1.ImageSize = new Size(200,165);
            pictureBox1.Width = 200;
            pictureBox1.Height = 165;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            //string path = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("\\"));
            string path1 = path + @"\01.jpg";
            MessageBox.Show(path1);
        }
    }
}
