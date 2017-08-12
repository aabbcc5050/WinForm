using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
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
            Image image1 = Image.FromFile(path1, true);
            imageList1.Images.Add(image1);
            imageList1.ImageSize = new Size(200, 165);
            pictureBox1.Width = 200;
            pictureBox1.Height = 165;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Count == 0)
            {
                MessageBox.Show("没有图片");
            }
            else {
                pictureBox1.Image = imageList1.Images[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Empty)
            {
                MessageBox.Show("没有图片可以删除");
            }
            else {
                imageList1.Images.RemoveAt(0);
            }
            
        }
    }
}
