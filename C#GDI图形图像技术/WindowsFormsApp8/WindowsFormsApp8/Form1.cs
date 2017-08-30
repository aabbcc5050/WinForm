using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private int Sum;
        SqlConnection conn;
        private void CreateImage() {
            conn = new SqlConnection("server=.;database=test;uid=sa;pwd=sa;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select sum(column3) from mytable",conn);
            Sum = (int)cmd.ExecuteScalar();
            SqlDataAdapter sda = new SqlDataAdapter("select * from mytable", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            //票数
            int tp1 = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
            int tp2 = Convert.ToInt32(ds.Tables[0].Rows[1][2].ToString());
            int tp3 = Convert.ToInt32(ds.Tables[0].Rows[2][2].ToString());
            int tp4 = Convert.ToInt32(ds.Tables[0].Rows[3][2].ToString());
            //计算百分比
            float tpp1 = Convert.ToSingle(Convert.ToSingle(tp1) * 100 / Convert.ToSingle(Sum));
            float tpp2 = Convert.ToSingle(Convert.ToSingle(tp2) * 100 / Convert.ToSingle(Sum));
            float tpp3 = Convert.ToSingle(Convert.ToSingle(tp3) * 100 / Convert.ToSingle(Sum));
            float tpp4 = Convert.ToSingle(Convert.ToSingle(tp4) * 100 / Convert.ToSingle(Sum));
            int width = 300;
            int height = 300;
            Bitmap bitmap = new Bitmap(width,height);
            Graphics g = Graphics.FromImage(bitmap);
            try
            {
                g.Clear(Color.White);
                Brush brush1 = new SolidBrush(Color.White);
                Brush brush2 = new SolidBrush(Color.Black);
                Brush brush3 = new SolidBrush(Color.Red);
                Brush brush4 = new SolidBrush(Color.Green);
                Brush brush5 = new SolidBrush(Color.Orange);
                Brush brush6 = new SolidBrush(Color.DarkBlue);

                Font font1 = new Font("Courier New", 16, FontStyle.Bold);
                Font font2 = new Font("Courier New", 8);
                g.FillRectangle(brush1,0,0,width,height);
                g.DrawString("投票结果",font1,brush2,new Point(90,20));
                Point p1 = new Point(70,50);
                Point p2 = new Point(230,50);
                g.DrawLine(new Pen(Color.Black),p1,p2);
                //绘制文字
                g.DrawString("歌曲1:", font2, brush2, new Point(32, 80));
                g.DrawString("歌曲2:", font2, brush2, new Point(32, 110));
                g.DrawString("歌曲3:", font2, brush2, new Point(32, 140));
                g.DrawString("歌曲4:", font2, brush2, new Point(32, 170));
                //绘制柱形图
                g.FillRectangle(brush3, 95, 80, tpp1, 17);
                g.FillRectangle(brush4, 95, 110, tpp2, 17);
                g.FillRectangle(brush5, 95, 140, tpp3, 17);
                g.FillRectangle(brush6, 95, 170, tpp4, 17);
                //绘制所有选项的票数显示
                g.DrawRectangle(new Pen(Color.Green), 10, 210, 280, 80);
                g.DrawString("歌曲1:" + tp1.ToString()+"票",font2,brush2,new Point(15,220));
                g.DrawString("歌曲2:" + tp2.ToString() + "票", font2, brush2, new Point(150, 220));
                g.DrawString("歌曲3:" + tp3.ToString() + "票", font2, brush2, new Point(15, 260));
                g.DrawString("歌曲4:" + tp4.ToString() + "票", font2, brush2, new Point(150, 260));
                pictureBox1.Image = bitmap;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateImage();
        }
    }
}
