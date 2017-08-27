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

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("要写入文件的内容不能为空");
            }
            else {
                saveFileDialog1.Filter = "二进制文件(*.dat)|*.dat";
                if (saveFileDialog1.ShowDialog()==DialogResult.OK) {
                    FileStream myStream = new FileStream(saveFileDialog1.FileName,FileMode.OpenOrCreate,FileAccess.ReadWrite);
                    BinaryWriter myWriter = new BinaryWriter(myStream);
                    myWriter.Write(textBox1.Text);
                    myStream.Close();
                    myStream.Close();
                    textBox1.Text = string.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "二进制文件(*.dat)|*.dat";
            if (openFileDialog1.ShowDialog()==DialogResult.OK) {
                textBox1.Text = string.Empty;
                FileStream myStream = new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
                BinaryReader myReader = new BinaryReader(myStream);
                if (myReader.PeekChar()!=-1) {
                    textBox1.Text = Convert.ToString(myReader.ReadInt32());
                }
                myReader.Close();
                myStream.Close();
            }
        }
    }
}
