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

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter adapter;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("server=.;database=test;uid=sa;pwd=sa;");
            SqlDataAdapter sda = new SqlDataAdapter("select * from user_test", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "user");
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.RowHeadersVisible = false;//禁止显示行标题
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Width = 84;
            }
            button1.Enabled = false;
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dbUpdate()) {
                MessageBox.Show("修改成功!");
            }
        }

        private DataTable dbconn(string strSql) {
            conn.Open();
            this.adapter = new SqlDataAdapter(strSql,conn);
            DataTable dtSelect = new DataTable();
            int rnt = this.adapter.Fill(dtSelect);
            conn.Close();
            return dtSelect;
        }

        private Boolean dbUpdate() {
            string strSql = "select * from user_test";
            DataTable dtUpdate = new DataTable();
            dtUpdate = this.dbconn(strSql);
            DataTable dtShow = new DataTable();
            dtShow = (DataTable)this.dataGridView1.DataSource;
            for (int i=0;i<dtShow.Rows.Count;i++) {
                dtUpdate.ImportRow(dtShow.Rows[i]);
            }
            try
            {
                this.conn.Open();
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(this.adapter);
                this.adapter.Update(dtUpdate);
                this.conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
            dtUpdate.AcceptChanges();
            return true;
        }
    }
}
