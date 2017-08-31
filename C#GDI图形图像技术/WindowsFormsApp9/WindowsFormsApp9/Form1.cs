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

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateImage();
        }

        private void CreateImage() {
            SqlConnection conn = new SqlConnection("server=.;database=test;uid=sa;pwd=sa;");
            conn.Open();
            string str2 = "select sum(column3) from mytable";
            SqlCommand cmd = new SqlCommand(str2,conn);
            int sum = Convert.ToInt32(cmd.ExecuteScalar());
            SqlDataAdapter sda = new SqlDataAdapter("select * from mytable", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            int man1 = Convert.ToInt32(ds.Tables[0].Rows[0][2].ToString());
            int man2 = Convert.ToInt32(ds.Tables[0].Rows[1][2].ToString());
            int man3 = Convert.ToInt32(ds.Tables[0].Rows[2][2].ToString());

            int width = 600;
            int height = 600;
            Bitmap bitmap = new Bitmap(width,height);
            Graphics g = Graphics.FromImage(bitmap);
            try
            {
                g.Clear(Color.White);
                Pen pen1 = new Pen(Color.Red);
                //创建brush,设置颜色
                Brush brush1 = new SolidBrush(Color.PowderBlue);
                Brush brush2 = new SolidBrush(Color.Blue);
                Brush brush3 = new SolidBrush(Color.Wheat);
                Brush brush4 = new SolidBrush(Color.Orange);
                //创建font,设置字体
                Font font1 = new Font("Courier new", 16, FontStyle.Bold);
                Font font2 = new Font("Courier new", 8);
                //绘制背景图
                g.FillRectangle(brush1, 0, 0, width, height);
                g.DrawString("公司员工年龄比利饼形图", font1, brush2, new Point(80, 20));
                int piex = 100;
                int piey = 60;
                int piew = 200;
                int pieh = 200;

                float f1 = Convert.ToSingle((360 / Convert.ToSingle(sum)) * Convert.ToSingle(man1));
                float f2 = Convert.ToSingle((360 / Convert.ToSingle(sum)) * Convert.ToSingle(man2));
                float f3 = Convert.ToSingle((360 / Convert.ToSingle(sum)) * Convert.ToSingle(man3));

                g.FillPie(brush2, piex, piey, piew, pieh, 0, f1);
                g.FillPie(brush3, piex, piey, piew, pieh, f1, f2);
                g.FillPie(brush4, piex, piey, piew, pieh, f1+f2, f3);
                //绘制标识
                g.DrawRectangle(pen1, 50, 300, 310, 130);

                g.FillRectangle(brush2, 90, 320, 20, 10);
                g.DrawString("man1的比列:" + Convert.ToSingle(man1) * 100 / Convert.ToSingle(sum) + "%", font2, brush2, 120, 320);
                g.FillRectangle(brush3, 90, 360, 20, 10);
                g.DrawString("man2的比列:" + Convert.ToSingle(man2) * 100 / Convert.ToSingle(sum) + "%", font2, brush2, 120, 360);
                g.FillRectangle(brush4, 90, 400, 20, 10);
                g.DrawString("man3的比列:" + Convert.ToSingle(man3) * 100 / Convert.ToSingle(sum) + "%", font2, brush2, 120, 400);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            pictureBox1.Image = bitmap;
        }
    }
}
