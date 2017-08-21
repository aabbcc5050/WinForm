using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdanna",10,FontStyle.Bold);
            dataGridView1.Columns[0].Name = "编号";
            dataGridView1.Columns[1].Name = "姓名";
            dataGridView1.Columns[2].Name = "年龄";
            dataGridView1.Columns[3].Name = "性别";
            string[] row1 = { "0001", "小吕1", "28", "男" };
            string[] row2 = { "0001", "小吕2", "28", "男" };
            string[] row3 = { "0001", "小吕3", "28", "男" };
            string[] row4 = { "0001", "小吕4", "28", "男" };
            string[] row5 = { "0001", "小吕5", "28", "男" };
            string[] row6 = { "0001", "小吕6", "28", "男" };
            object[] rows = { row1 , row2 , row3 , row4 , row5 , row6 };
            foreach (string[] rowArray in rows) {
                dataGridView1.Rows.Add(rowArray);
            }


            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//整行选择
            dataGridView1.ReadOnly = true;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red;//设置选择行的背景色
        }
    }
}
