using System;
using System.Collections.Generic;
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
        public static string Mean_SQL = "", Mean_Table = "", Mean_Field = "";        
        public static SqlConnection My_con;
        public static string M_str_sqlcon = "Data Source=mrlx\\lx;Database=db_PWMS;Userid=sa;PWD=";
        public static int Login_n = 0;
        public static string AllSql = "select * from tb_StaffBasic";
        #endregion
    }
}
