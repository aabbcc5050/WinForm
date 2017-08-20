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

        SqlConnection conn;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tttt() {
            conn = new SqlConnection("server=.;database=test;uid=sa;pwd=sa;");
            DataSet ds = new DataSet();
            DataSet ds1 = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from user_test", conn);
            sda.Fill(ds);
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from user1                                                  ", conn);
            SqlCommandBuilder sbl = new SqlCommandBuilder(sda1);
            sda1.Fill(ds1);
            ds1.Merge(ds, true, MissingSchemaAction.AddWithKey);
            dataGridView1.DataSource = ds1.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tttt();
        }
    }
}
