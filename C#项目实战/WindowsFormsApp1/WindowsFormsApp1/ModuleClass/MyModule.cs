using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ModuleClass
{
    class MyModule
    {
        #region
        DataClass.MyBeans MyDataClass = new DataClass.MyBeans();
        public static string ADDs = "";                   //存储添加或者修改的SQL语句
        public static string FindValue = "";              //存储查询条件
        public static string Address_ID = "";             //存储通讯录添加修改时的ID编号 
        public static string User_ID = "";                //存储用户的ID编号
        public static string User_Name = "";              //存储用户名
        #endregion

        /// <summary>
        /// 窗体的调用
        /// </summary>
        /// <param name="FrmName">调用窗体的Text属性值</param>
        /// <param name="n">标识</param>
        public void Show_From(string FrmName,int n) {
            if (n == 1) {
                if (FrmName == "人事档案官管理") {
                  
                }
            }
        }
    }
}
