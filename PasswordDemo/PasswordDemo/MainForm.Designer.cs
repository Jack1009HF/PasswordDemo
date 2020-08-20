namespace PasswordDemo
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.ckBoxPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(37, 52);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.Size = new System.Drawing.Size(127, 21);
            this.tBoxPassword.TabIndex = 0;
            // 
            // ckBoxPassword
            // 
            this.ckBoxPassword.AutoSize = true;
            this.ckBoxPassword.Location = new System.Drawing.Point(179, 54);
            this.ckBoxPassword.Name = "ckBoxPassword";
            this.ckBoxPassword.Size = new System.Drawing.Size(72, 16);
            this.ckBoxPassword.TabIndex = 1;
            this.ckBoxPassword.Text = "显示密码";
            this.ckBoxPassword.UseVisualStyleBackColor = true;
            this.ckBoxPassword.CheckedChanged += new System.EventHandler(this.ckBoxPassword_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 145);
            this.Controls.Add(this.ckBoxPassword);
            this.Controls.Add(this.tBoxPassword);
            this.Name = "MainForm";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.CheckBox ckBoxPassword;
    }
}

