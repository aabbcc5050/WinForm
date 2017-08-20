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

        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter sda;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=.;database=test;uid=sa;pwd=sa;");
            SqlCommand cmd = new SqlCommand("select * from user_test",conn);
            sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            ds = new DataSet();
            sda.Fill(ds,"cs");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["cs"];
            sda.FillSchema(dt,SchemaType.Mapped);
            DataRow dr = dt.Rows.Find(textBox1.Text);
            dr["user_id"] = textBox1.Text.Trim();
            dr["user_name"] = textBox2.Text.Trim();
            dr["user_sex"] = textBox3.Text.Trim();
            dr["user_age"] = textBox4.Text.Trim();
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[3].Value.ToString();
        }
    }
}
