using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string[] month = new string[12] { "一月","二月", "三月" , "四月" , "五月" , "六月" , "七月" , "八月" ,
                "九月" , "十月" ,"十一月","十二月" };
            float[] d = new float[12] { 20.5F,60,10.8F,15.6F,30,70.9F,50.3F,30.7F,70,50.4F,30.8F,20};
            //画图初始化
            Bitmap bMap = new Bitmap(500, 500);
            Graphics gph = Graphics.FromImage(bMap);
            gph.Clear(Color.White);
            PointF cPt = new PointF(40, 420);//中心点
            PointF[] xPt = new PointF[3] { new PointF(cPt.Y + 15, cPt.Y), new PointF(cPt.Y, cPt.Y - 8), new PointF(cPt.Y, cPt.Y + 8) };
            PointF[] yPt = new PointF[3] { new PointF(cPt.X, cPt.X - 15), new PointF(cPt.X - 8, cPt.X), new PointF(cPt.X + 8, cPt.X) };
            //X轴
            gph.DrawString("某工厂产品月生产量图标", new Font("宋体", 14), Brushes.Black, new PointF(cPt.X + 60, cPt.X));
            gph.DrawLine(Pens.Black,cPt.X,cPt.Y,cPt.Y,cPt.Y);
            gph.DrawPolygon(Pens.Black, xPt);
            gph.DrawString("月份", new Font("宋体", 12), Brushes.Black, new PointF(cPt.Y + 10, cPt.Y + 10));
            //Y轴
            gph.DrawLine(Pens.Black, cPt.X, cPt.Y, cPt.X, cPt.X);
            gph.DrawPolygon(Pens.Black, yPt);
            gph.FillPolygon(new SolidBrush(Color.Black), yPt);
            gph.DrawString("单位(万)", new Font("宋体", 12), Brushes.Black, new PointF(0, 7));
            for (int i = 1; i <= 12; i++) {
                //X刻度
                if (i < 11) {
                    gph.DrawString((i * 10).ToString(), new Font("宋体", 11), Brushes.Black, new PointF(cPt.X - 30, cPt.Y - i * 30 - 6));
                    gph.DrawLine(Pens.Black, cPt.X - 3, cPt.Y - i * 30, cPt.X, cPt.Y - i * 30);
                }
                //X轴项目
                gph.DrawString(month[i - 1].Substring(0, 1), new Font("宋体", 11), Brushes.Black, new PointF(cPt.X + i * 30 - 5, cPt.Y + 5));
                gph.DrawString(month[i - 1].Substring(1, 1), new Font("宋体", 11), Brushes.Black, new PointF(cPt.X + i * 30 - 5, cPt.Y + 20));
                if (month[i - 1].Length > 2) {
                    gph.DrawString(month[i - 1].Substring(0, 1), new Font("宋体", 11), Brushes.Black, new PointF(cPt.X + i * 30 - 5, cPt.Y + 35));
                }
                //点
                gph.DrawEllipse(Pens.Black, cPt.X + i * 30 - 1.5F, cPt.Y - d[i - 1] * 3 - 1.5F, 3, 3);
                gph.FillEllipse(new SolidBrush(Color.Black), cPt.X + i * 30 - 1.5F, cPt.Y - d[i - 1] * 3 - 1.5F, 3, 3);
                //画数值
                gph.DrawString(d[i - 1].ToString(), new Font("宋体", 11), Brushes.Black, new PointF(cPt.X + i * 30, cPt.Y - d[i - 1] * 3));
                //画折现
                if (i > 1) {
                    gph.DrawLine(Pens.Red, cPt.X + (i - 1) * 30, cPt.Y - d[i - 2] * 3, cPt.X + i * 30, cPt.Y - d[i - 1] * 3);
                }
            }
            pictureBox1.Image = bMap;
        }
    }
}
