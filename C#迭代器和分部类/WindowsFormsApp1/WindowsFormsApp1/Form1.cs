using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Family : System.Collections.IEnumerable
        {
            string[] MyFamily = { "父亲","母亲","弟弟","妹妹"};
            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < MyFamily.Length; i++){
                    yield return MyFamily[i]; //使用yield return语句依次返回每个元素
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Family myfamily = new Family();
            foreach (string str in myfamily) {
                richTextBox1.Text += str + "\n";
            }
        }
    }
}
