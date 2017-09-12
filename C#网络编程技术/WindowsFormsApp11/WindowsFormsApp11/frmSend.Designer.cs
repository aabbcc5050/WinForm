namespace WindowsFormsApp11
{
    partial class frmSend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSend = new System.Windows.Forms.Label();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.labelPwd = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSend
            // 
            this.labelSend.AutoSize = true;
            this.labelSend.Location = new System.Drawing.Point(81, 45);
            this.labelSend.Name = "labelSend";
            this.labelSend.Size = new System.Drawing.Size(60, 15);
            this.labelSend.TabIndex = 0;
            this.labelSend.Text = "发件人:";
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(154, 42);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(248, 25);
            this.txtSend.TabIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(84, 293);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(745, 135);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 25);
            this.txtName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(51, 100);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(90, 15);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "发件人姓名:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(154, 151);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(248, 25);
            this.txtServer.TabIndex = 7;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(81, 154);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(60, 15);
            this.labelServer.TabIndex = 6;
            this.labelServer.Text = "服务器:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(154, 207);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(248, 25);
            this.txtSubject.TabIndex = 9;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(66, 210);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(75, 15);
            this.labelSubject.TabIndex = 8;
            this.labelSubject.Text = "邮件主题:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(581, 45);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(248, 25);
            this.txtTo.TabIndex = 11;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(508, 48);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(60, 15);
            this.labelTo.TabIndex = 10;
            this.labelTo.Text = "收件人:";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(581, 97);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(248, 25);
            this.txtPwd.TabIndex = 13;
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Location = new System.Drawing.Point(478, 100);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(90, 15);
            this.labelPwd.TabIndex = 12;
            this.labelPwd.Text = "发件人密码:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(581, 154);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(248, 25);
            this.txtPort.TabIndex = 15;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(508, 157);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(60, 15);
            this.labelPort.TabIndex = 14;
            this.labelPort.Text = "端口号:";
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Location = new System.Drawing.Point(66, 258);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(75, 15);
            this.labelContent.TabIndex = 16;
            this.labelContent.Text = "邮件内容:";
            // 
            // frmSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 486);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.labelSend);
            this.Name = "frmSend";
            this.Text = "frmSend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label labelPwd;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelContent;
    }
}