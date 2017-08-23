using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                textBox1.Text = openFileDialog1.FileName;
                FileInfo finfo = new FileInfo(textBox1.Text);
                string strCTime = finfo.CreationTime.ToShortDateString();
                string strLATime = finfo.LastAccessTime.ToShortDateString();
                string strLWTime = finfo.LastWriteTime.ToShortDateString();
                string strName = finfo.Name;
                string strFName = finfo.FullName;
                string strDName = finfo.DirectoryName;
                string strSRead = finfo.IsReadOnly.ToString();
                long lgLength = finfo.Length;
                MessageBox.Show("文件信息:\n创建时间"+strCTime+"上次访问时间:"+strLATime+"\n上方写入时间:"+
                    strLWTime+"文件名称:"+strName+"\n完整目录:"+strFName+"\n完整路径:"+strDName+"\n是否只读:"+
                    strSRead+"文件长度"+lgLength);
            }
        }
    }
}
