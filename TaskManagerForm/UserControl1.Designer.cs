namespace TaskManagerForm
{
    partial class UserControl1
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
            this.label_add_name = new System.Windows.Forms.Label();
            this.tb_add_name = new System.Windows.Forms.TextBox();
            this.groupBoxAddUser = new System.Windows.Forms.GroupBox();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.tb_add_role = new System.Windows.Forms.TextBox();
            this.label_add_role = new System.Windows.Forms.Label();
            this.tb_add_pwd = new System.Windows.Forms.TextBox();
            this.label_add_pwd = new System.Windows.Forms.Label();
            this.tb_add_mail = new System.Windows.Forms.TextBox();
            this.label_add_mail = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_role_update = new System.Windows.Forms.TextBox();
            this.label_role_update = new System.Windows.Forms.Label();
            this.tb_pwd_update = new System.Windows.Forms.TextBox();
            this.label_pwd_update = new System.Windows.Forms.Label();
            this.tb_mail_update = new System.Windows.Forms.TextBox();
            this.label_email_update = new System.Windows.Forms.Label();
            this.tb_name_update = new System.Windows.Forms.TextBox();
            this.label_update_name = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBoxAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_add_name
            // 
            this.label_add_name.AutoSize = true;
            this.label_add_name.Location = new System.Drawing.Point(8, 21);
            this.label_add_name.Name = "label_add_name";
            this.label_add_name.Size = new System.Drawing.Size(44, 16);
            this.label_add_name.TabIndex = 1;
            this.label_add_name.Text = "Name";
            // 
            // tb_add_name
            // 
            this.tb_add_name.Location = new System.Drawing.Point(83, 18);
            this.tb_add_name.Name = "tb_add_name";
            this.tb_add_name.Size = new System.Drawing.Size(111, 22);
            this.tb_add_name.TabIndex = 2;
            // 
            // groupBoxAddUser
            // 
            this.groupBoxAddUser.Controls.Add(this.btn_add_user);
            this.groupBoxAddUser.Controls.Add(this.tb_add_role);
            this.groupBoxAddUser.Controls.Add(this.label_add_role);
            this.groupBoxAddUser.Controls.Add(this.tb_add_pwd);
            this.groupBoxAddUser.Controls.Add(this.label_add_pwd);
            this.groupBoxAddUser.Controls.Add(this.tb_add_mail);
            this.groupBoxAddUser.Controls.Add(this.label_add_mail);
            this.groupBoxAddUser.Controls.Add(this.tb_add_name);
            this.groupBoxAddUser.Controls.Add(this.label_add_name);
            this.groupBoxAddUser.Location = new System.Drawing.Point(42, 203);
            this.groupBoxAddUser.Name = "groupBoxAddUser";
            this.groupBoxAddUser.Size = new System.Drawing.Size(233, 237);
            this.groupBoxAddUser.TabIndex = 3;
            this.groupBoxAddUser.TabStop = false;
            this.groupBoxAddUser.Text = "Add User ";
            // 
            // btn_add_user
            // 
            this.btn_add_user.Location = new System.Drawing.Point(83, 207);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(75, 23);
            this.btn_add_user.TabIndex = 9;
            this.btn_add_user.Text = "Add User";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // tb_add_role
            // 
            this.tb_add_role.Location = new System.Drawing.Point(83, 149);
            this.tb_add_role.Name = "tb_add_role";
            this.tb_add_role.Size = new System.Drawing.Size(111, 22);
            this.tb_add_role.TabIndex = 8;
            // 
            // label_add_role
            // 
            this.label_add_role.AutoSize = true;
            this.label_add_role.Location = new System.Drawing.Point(8, 152);
            this.label_add_role.Name = "label_add_role";
            this.label_add_role.Size = new System.Drawing.Size(36, 16);
            this.label_add_role.TabIndex = 7;
            this.label_add_role.Text = "Role";
            // 
            // tb_add_pwd
            // 
            this.tb_add_pwd.Location = new System.Drawing.Point(83, 105);
            this.tb_add_pwd.Name = "tb_add_pwd";
            this.tb_add_pwd.Size = new System.Drawing.Size(111, 22);
            this.tb_add_pwd.TabIndex = 6;
            // 
            // label_add_pwd
            // 
            this.label_add_pwd.AutoSize = true;
            this.label_add_pwd.Location = new System.Drawing.Point(8, 108);
            this.label_add_pwd.Name = "label_add_pwd";
            this.label_add_pwd.Size = new System.Drawing.Size(67, 16);
            this.label_add_pwd.TabIndex = 5;
            this.label_add_pwd.Text = "Password";
            // 
            // tb_add_mail
            // 
            this.tb_add_mail.Location = new System.Drawing.Point(83, 62);
            this.tb_add_mail.Name = "tb_add_mail";
            this.tb_add_mail.Size = new System.Drawing.Size(111, 22);
            this.tb_add_mail.TabIndex = 4;
            // 
            // label_add_mail
            // 
            this.label_add_mail.AutoSize = true;
            this.label_add_mail.Location = new System.Drawing.Point(8, 65);
            this.label_add_mail.Name = "label_add_mail";
            this.label_add_mail.Size = new System.Drawing.Size(41, 16);
            this.label_add_mail.TabIndex = 3;
            this.label_add_mail.Text = "Email";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(42, 38);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(696, 150);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.btn_update);
            this.gbUpdate.Controls.Add(this.tb_role_update);
            this.gbUpdate.Controls.Add(this.label_role_update);
            this.gbUpdate.Controls.Add(this.tb_pwd_update);
            this.gbUpdate.Controls.Add(this.label_pwd_update);
            this.gbUpdate.Controls.Add(this.tb_mail_update);
            this.gbUpdate.Controls.Add(this.label_email_update);
            this.gbUpdate.Controls.Add(this.tb_name_update);
            this.gbUpdate.Controls.Add(this.label_update_name);
            this.gbUpdate.Location = new System.Drawing.Point(341, 203);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(233, 237);
            this.gbUpdate.TabIndex = 10;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update User";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(83, 207);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // tb_role_update
            // 
            this.tb_role_update.Location = new System.Drawing.Point(83, 149);
            this.tb_role_update.Name = "tb_role_update";
            this.tb_role_update.Size = new System.Drawing.Size(111, 22);
            this.tb_role_update.TabIndex = 8;
            // 
            // label_role_update
            // 
            this.label_role_update.AutoSize = true;
            this.label_role_update.Location = new System.Drawing.Point(8, 152);
            this.label_role_update.Name = "label_role_update";
            this.label_role_update.Size = new System.Drawing.Size(36, 16);
            this.label_role_update.TabIndex = 7;
            this.label_role_update.Text = "Role";
            // 
            // tb_pwd_update
            // 
            this.tb_pwd_update.Location = new System.Drawing.Point(83, 105);
            this.tb_pwd_update.Name = "tb_pwd_update";
            this.tb_pwd_update.Size = new System.Drawing.Size(111, 22);
            this.tb_pwd_update.TabIndex = 6;
            // 
            // label_pwd_update
            // 
            this.label_pwd_update.AutoSize = true;
            this.label_pwd_update.Location = new System.Drawing.Point(8, 108);
            this.label_pwd_update.Name = "label_pwd_update";
            this.label_pwd_update.Size = new System.Drawing.Size(67, 16);
            this.label_pwd_update.TabIndex = 5;
            this.label_pwd_update.Text = "Password";
            // 
            // tb_mail_update
            // 
            this.tb_mail_update.Location = new System.Drawing.Point(83, 62);
            this.tb_mail_update.Name = "tb_mail_update";
            this.tb_mail_update.Size = new System.Drawing.Size(111, 22);
            this.tb_mail_update.TabIndex = 4;
            // 
            // label_email_update
            // 
            this.label_email_update.AutoSize = true;
            this.label_email_update.Location = new System.Drawing.Point(8, 65);
            this.label_email_update.Name = "label_email_update";
            this.label_email_update.Size = new System.Drawing.Size(41, 16);
            this.label_email_update.TabIndex = 3;
            this.label_email_update.Text = "Email";
            // 
            // tb_name_update
            // 
            this.tb_name_update.Location = new System.Drawing.Point(83, 18);
            this.tb_name_update.Name = "tb_name_update";
            this.tb_name_update.Size = new System.Drawing.Size(111, 22);
            this.tb_name_update.TabIndex = 2;
            // 
            // label_update_name
            // 
            this.label_update_name.AutoSize = true;
            this.label_update_name.Location = new System.Drawing.Point(8, 21);
            this.label_update_name.Name = "label_update_name";
            this.label_update_name.Size = new System.Drawing.Size(44, 16);
            this.label_update_name.TabIndex = 1;
            this.label_update_name.Text = "Name";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(626, 217);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBoxAddUser);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.groupBoxAddUser.ResumeLayout(false);
            this.groupBoxAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_add_name;
        private System.Windows.Forms.TextBox tb_add_name;
        private System.Windows.Forms.GroupBox groupBoxAddUser;
        private System.Windows.Forms.TextBox tb_add_pwd;
        private System.Windows.Forms.Label label_add_pwd;
        private System.Windows.Forms.TextBox tb_add_mail;
        private System.Windows.Forms.Label label_add_mail;
        private System.Windows.Forms.TextBox tb_add_role;
        private System.Windows.Forms.Label label_add_role;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_role_update;
        private System.Windows.Forms.Label label_role_update;
        private System.Windows.Forms.TextBox tb_pwd_update;
        private System.Windows.Forms.Label label_pwd_update;
        private System.Windows.Forms.TextBox tb_mail_update;
        private System.Windows.Forms.Label label_email_update;
        private System.Windows.Forms.TextBox tb_name_update;
        private System.Windows.Forms.Label label_update_name;
        private System.Windows.Forms.Button btn_delete;
    }
}
