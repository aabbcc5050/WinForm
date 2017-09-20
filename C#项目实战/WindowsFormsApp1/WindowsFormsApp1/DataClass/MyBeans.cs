using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataClass
{
    class MyBeans
    {

        #region 全局变量
        public static string Login_id = "";                                          //全局变量,记录当前登录的用户编号
        public static string Login_Name = "";                                        //全局变量,记录当前登录的用户名
        public static string Mean_SQL = "", Mean_Table = "", Mean_Field = "";        //记录"基础信息"各窗体的表名,sql语句和要添加和修改的字段名
        public static SqlConnection My_con;                                          //My_con,判断数据库是否连接成功
        public static string M_str_sqlcon = "Data Source=mrlx\\lx;Database=db_PWMS;Userid=sa;PWD=";
        public static int Login_n = 0;                                               //用户登录与重新登录的标识
        public static string AllSql = "select * from tb_StaffBasic";                 //存储职工基本信息表中的SQL语句
        #endregion

        //建立数据库连接,并返回连接信息
        public static SqlConnection getcon() {
            My_con = new SqlConnection(M_str_sqlcon);
            My_con.Open();
            return My_con;
        }

        //关闭数据库连接
        public void con_close() {
            if (My_con.State == ConnectionState.Open) {
                My_con.Close();
                My_con.Dispose();
            }
        }

        //读取数据库中的信息,返回SqlDataReader
        public SqlDataReader getcom(string SQLstr) {
            getcon();
            SqlCommand My_com = My_con.CreateCommand();
            My_com.CommandText = SQLstr;
            SqlDataReader My_read = My_com.ExecuteReader();
            return My_read;
        }

        //对数据库增删改,无返回值
        public void getsqlcom(string SQLstr) {
            getcon();
            SqlCommand SQLcon = new SqlCommand(SQLstr, My_con);
            SQLcon.ExecuteNonQuery();
            SQLcon.Dispose();
            con_close();
        }

        //对数据库增删改,返回DataSet
        public DataSet GetDataSet(string SQLstr,string tableName) {
            getcon();
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLstr, My_con);
            DataSet My_DataSet = new DataSet();
            SQLda.Fill(My_DataSet, tableName);
            con_close();
            return My_DataSet;
        }
    }
}
