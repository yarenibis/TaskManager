namespace TaskManagerForm
{
    partial class Login
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_login_mail = new System.Windows.Forms.TextBox();
            this.tb_login_pwd = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_label_mail = new System.Windows.Forms.Label();
            this.label_login_pwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_login_mail
            // 
            this.tb_login_mail.Location = new System.Drawing.Point(315, 89);
            this.tb_login_mail.Name = "tb_login_mail";
            this.tb_login_mail.Size = new System.Drawing.Size(161, 22);
            this.tb_login_mail.TabIndex = 0;
            // 
            // tb_login_pwd
            // 
            this.tb_login_pwd.Location = new System.Drawing.Point(315, 149);
            this.tb_login_pwd.Name = "tb_login_pwd";
            this.tb_login_pwd.Size = new System.Drawing.Size(161, 22);
            this.tb_login_pwd.TabIndex = 1;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(358, 226);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_label_mail
            // 
            this.login_label_mail.AutoSize = true;
            this.login_label_mail.Location = new System.Drawing.Point(226, 95);
            this.login_label_mail.Name = "login_label_mail";
            this.login_label_mail.Size = new System.Drawing.Size(32, 16);
            this.login_label_mail.TabIndex = 3;
            this.login_label_mail.Text = "Mail";
            // 
            // label_login_pwd
            // 
            this.label_login_pwd.AutoSize = true;
            this.label_login_pwd.Location = new System.Drawing.Point(226, 155);
            this.label_login_pwd.Name = "label_login_pwd";
            this.label_login_pwd.Size = new System.Drawing.Size(66, 16);
            this.label_login_pwd.TabIndex = 4;
            this.label_login_pwd.Text = "password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_login_pwd);
            this.Controls.Add(this.login_label_mail);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.tb_login_pwd);
            this.Controls.Add(this.tb_login_mail);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(808, 396);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_login_mail;
        private System.Windows.Forms.TextBox tb_login_pwd;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label login_label_mail;
        private System.Windows.Forms.Label label_login_pwd;
    }
}
