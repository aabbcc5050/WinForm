namespace WindowsFormsApp11
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.邮件发送ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.邮件接收ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.邮件发送ToolStripMenuItem,
            this.邮件接收ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 邮件发送ToolStripMenuItem
            // 
            this.邮件发送ToolStripMenuItem.Name = "邮件发送ToolStripMenuItem";
            this.邮件发送ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.邮件发送ToolStripMenuItem.Text = "邮件发送";
            this.邮件发送ToolStripMenuItem.Click += new System.EventHandler(this.邮件发送ToolStripMenuItem_Click);
            // 
            // 邮件接收ToolStripMenuItem
            // 
            this.邮件接收ToolStripMenuItem.Name = "邮件接收ToolStripMenuItem";
            this.邮件接收ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.邮件接收ToolStripMenuItem.Text = "邮件接收";
            this.邮件接收ToolStripMenuItem.Click += new System.EventHandler(this.邮件接收ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp11.Properties.Resources.mylove;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 548);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 邮件发送ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 邮件接收ToolStripMenuItem;
    }
}

