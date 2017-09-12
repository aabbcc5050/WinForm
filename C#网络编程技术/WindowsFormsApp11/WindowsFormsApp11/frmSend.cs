using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class frmSend : Form
    {
        public frmSend()
        {
            InitializeComponent();
        }

        public static string Base64String(String str) {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailAddress from = new MailAddress(txtSend.Text);
                MailAddress to = new MailAddress(txtTo.Text);
                MailMessage message = new MailMessage(from, to);
                message.Subject = Base64String(txtSubject.Text);
                message.Body = Base64String(txtContent.Text);
                SmtpClient client = new SmtpClient(txtServer.Text, Convert.ToInt32(txtPort.Text));
                client.Credentials = new System.Net.NetworkCredential(txtName.Text, txtPort.Text);
                client.Send(message);
                MessageBox.Show("发送成功!");
            }
            catch {
                MessageBox.Show("发送失败!");
            }
        }
    }
}
