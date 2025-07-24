namespace TaskManagerForm
{
    partial class UserControl2
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.dataGridViewNote = new System.Windows.Forms.DataGridView();
            this.groupBoxAddNote = new System.Windows.Forms.GroupBox();
            this.btn_add_note = new System.Windows.Forms.Button();
            this.tb_add_u_date = new System.Windows.Forms.TextBox();
            this.label_add_u_date = new System.Windows.Forms.Label();
            this.tb_add_c_date = new System.Windows.Forms.TextBox();
            this.label_add_c_date = new System.Windows.Forms.Label();
            this.tb_add_content = new System.Windows.Forms.TextBox();
            this.label_add_content = new System.Windows.Forms.Label();
            this.tb_add_title = new System.Windows.Forms.TextBox();
            this.label_add_title = new System.Windows.Forms.Label();
            this.groupBoxupdate = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tb_update_udate = new System.Windows.Forms.TextBox();
            this.label_update_u_date = new System.Windows.Forms.Label();
            this.tb_update_cdate = new System.Windows.Forms.TextBox();
            this.label_update_c_date = new System.Windows.Forms.Label();
            this.tb_update_content = new System.Windows.Forms.TextBox();
            this.label_update_content = new System.Windows.Forms.Label();
            this.tb_update_title = new System.Windows.Forms.TextBox();
            this.label_update_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNote)).BeginInit();
            this.groupBoxAddNote.SuspendLayout();
            this.groupBoxupdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(665, 201);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dataGridViewNote
            // 
            this.dataGridViewNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNote.Location = new System.Drawing.Point(81, 14);
            this.dataGridViewNote.Name = "dataGridViewNote";
            this.dataGridViewNote.RowHeadersWidth = 51;
            this.dataGridViewNote.RowTemplate.Height = 24;
            this.dataGridViewNote.Size = new System.Drawing.Size(696, 150);
            this.dataGridViewNote.TabIndex = 13;
            this.dataGridViewNote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNote_CellClick);
            // 
            // groupBoxAddNote
            // 
            this.groupBoxAddNote.Controls.Add(this.btn_add_note);
            this.groupBoxAddNote.Controls.Add(this.tb_add_u_date);
            this.groupBoxAddNote.Controls.Add(this.label_add_u_date);
            this.groupBoxAddNote.Controls.Add(this.tb_add_c_date);
            this.groupBoxAddNote.Controls.Add(this.label_add_c_date);
            this.groupBoxAddNote.Controls.Add(this.tb_add_content);
            this.groupBoxAddNote.Controls.Add(this.label_add_content);
            this.groupBoxAddNote.Controls.Add(this.tb_add_title);
            this.groupBoxAddNote.Controls.Add(this.label_add_title);
            this.groupBoxAddNote.Location = new System.Drawing.Point(81, 170);
            this.groupBoxAddNote.Name = "groupBoxAddNote";
            this.groupBoxAddNote.Size = new System.Drawing.Size(233, 237);
            this.groupBoxAddNote.TabIndex = 12;
            this.groupBoxAddNote.TabStop = false;
            this.groupBoxAddNote.Text = "Add Note ";
            // 
            // btn_add_note
            // 
            this.btn_add_note.Location = new System.Drawing.Point(83, 207);
            this.btn_add_note.Name = "btn_add_note";
            this.btn_add_note.Size = new System.Drawing.Size(75, 23);
            this.btn_add_note.TabIndex = 9;
            this.btn_add_note.Text = "Add ";
            this.btn_add_note.UseVisualStyleBackColor = true;
            this.btn_add_note.Click += new System.EventHandler(this.btn_add_note_Click);
            // 
            // tb_add_u_date
            // 
            this.tb_add_u_date.Location = new System.Drawing.Point(106, 149);
            this.tb_add_u_date.Name = "tb_add_u_date";
            this.tb_add_u_date.Size = new System.Drawing.Size(111, 22);
            this.tb_add_u_date.TabIndex = 8;
            // 
            // label_add_u_date
            // 
            this.label_add_u_date.AutoSize = true;
            this.label_add_u_date.Location = new System.Drawing.Point(8, 152);
            this.label_add_u_date.Name = "label_add_u_date";
            this.label_add_u_date.Size = new System.Drawing.Size(92, 16);
            this.label_add_u_date.TabIndex = 7;
            this.label_add_u_date.Text = "Updated Date";
            // 
            // tb_add_c_date
            // 
            this.tb_add_c_date.Location = new System.Drawing.Point(106, 108);
            this.tb_add_c_date.Name = "tb_add_c_date";
            this.tb_add_c_date.Size = new System.Drawing.Size(111, 22);
            this.tb_add_c_date.TabIndex = 6;
            // 
            // label_add_c_date
            // 
            this.label_add_c_date.AutoSize = true;
            this.label_add_c_date.Location = new System.Drawing.Point(8, 108);
            this.label_add_c_date.Name = "label_add_c_date";
            this.label_add_c_date.Size = new System.Drawing.Size(87, 16);
            this.label_add_c_date.TabIndex = 5;
            this.label_add_c_date.Text = "Created Date";
            // 
            // tb_add_content
            // 
            this.tb_add_content.Location = new System.Drawing.Point(106, 62);
            this.tb_add_content.Name = "tb_add_content";
            this.tb_add_content.Size = new System.Drawing.Size(111, 22);
            this.tb_add_content.TabIndex = 4;
            // 
            // label_add_content
            // 
            this.label_add_content.AutoSize = true;
            this.label_add_content.Location = new System.Drawing.Point(8, 65);
            this.label_add_content.Name = "label_add_content";
            this.label_add_content.Size = new System.Drawing.Size(52, 16);
            this.label_add_content.TabIndex = 3;
            this.label_add_content.Text = "Content";
            // 
            // tb_add_title
            // 
            this.tb_add_title.Location = new System.Drawing.Point(106, 15);
            this.tb_add_title.Name = "tb_add_title";
            this.tb_add_title.Size = new System.Drawing.Size(111, 22);
            this.tb_add_title.TabIndex = 2;
            // 
            // label_add_title
            // 
            this.label_add_title.AutoSize = true;
            this.label_add_title.Location = new System.Drawing.Point(8, 21);
            this.label_add_title.Name = "label_add_title";
            this.label_add_title.Size = new System.Drawing.Size(33, 16);
            this.label_add_title.TabIndex = 1;
            this.label_add_title.Text = "Title";
            // 
            // groupBoxupdate
            // 
            this.groupBoxupdate.Controls.Add(this.buttonUpdate);
            this.groupBoxupdate.Controls.Add(this.tb_update_udate);
            this.groupBoxupdate.Controls.Add(this.label_update_u_date);
            this.groupBoxupdate.Controls.Add(this.tb_update_cdate);
            this.groupBoxupdate.Controls.Add(this.label_update_c_date);
            this.groupBoxupdate.Controls.Add(this.tb_update_content);
            this.groupBoxupdate.Controls.Add(this.label_update_content);
            this.groupBoxupdate.Controls.Add(this.tb_update_title);
            this.groupBoxupdate.Controls.Add(this.label_update_title);
            this.groupBoxupdate.Location = new System.Drawing.Point(357, 170);
            this.groupBoxupdate.Name = "groupBoxupdate";
            this.groupBoxupdate.Size = new System.Drawing.Size(233, 237);
            this.groupBoxupdate.TabIndex = 13;
            this.groupBoxupdate.TabStop = false;
            this.groupBoxupdate.Text = "Update Note";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(83, 207);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tb_update_udate
            // 
            this.tb_update_udate.Location = new System.Drawing.Point(106, 149);
            this.tb_update_udate.Name = "tb_update_udate";
            this.tb_update_udate.Size = new System.Drawing.Size(111, 22);
            this.tb_update_udate.TabIndex = 8;
            // 
            // label_update_u_date
            // 
            this.label_update_u_date.AutoSize = true;
            this.label_update_u_date.Location = new System.Drawing.Point(8, 152);
            this.label_update_u_date.Name = "label_update_u_date";
            this.label_update_u_date.Size = new System.Drawing.Size(92, 16);
            this.label_update_u_date.TabIndex = 7;
            this.label_update_u_date.Text = "Updated Date";
            // 
            // tb_update_cdate
            // 
            this.tb_update_cdate.Location = new System.Drawing.Point(106, 108);
            this.tb_update_cdate.Name = "tb_update_cdate";
            this.tb_update_cdate.Size = new System.Drawing.Size(111, 22);
            this.tb_update_cdate.TabIndex = 6;
            // 
            // label_update_c_date
            // 
            this.label_update_c_date.AutoSize = true;
            this.label_update_c_date.Location = new System.Drawing.Point(8, 108);
            this.label_update_c_date.Name = "label_update_c_date";
            this.label_update_c_date.Size = new System.Drawing.Size(87, 16);
            this.label_update_c_date.TabIndex = 5;
            this.label_update_c_date.Text = "Created Date";
            // 
            // tb_update_content
            // 
            this.tb_update_content.Location = new System.Drawing.Point(106, 62);
            this.tb_update_content.Name = "tb_update_content";
            this.tb_update_content.Size = new System.Drawing.Size(111, 22);
            this.tb_update_content.TabIndex = 4;
            // 
            // label_update_content
            // 
            this.label_update_content.AutoSize = true;
            this.label_update_content.Location = new System.Drawing.Point(8, 65);
            this.label_update_content.Name = "label_update_content";
            this.label_update_content.Size = new System.Drawing.Size(52, 16);
            this.label_update_content.TabIndex = 3;
            this.label_update_content.Text = "Content";
            // 
            // tb_update_title
            // 
            this.tb_update_title.Location = new System.Drawing.Point(106, 15);
            this.tb_update_title.Name = "tb_update_title";
            this.tb_update_title.Size = new System.Drawing.Size(111, 22);
            this.tb_update_title.TabIndex = 2;
            // 
            // label_update_title
            // 
            this.label_update_title.AutoSize = true;
            this.label_update_title.Location = new System.Drawing.Point(8, 21);
            this.label_update_title.Name = "label_update_title";
            this.label_update_title.Size = new System.Drawing.Size(33, 16);
            this.label_update_title.TabIndex = 1;
            this.label_update_title.Text = "Title";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxupdate);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dataGridViewNote);
            this.Controls.Add(this.groupBoxAddNote);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(805, 419);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNote)).EndInit();
            this.groupBoxAddNote.ResumeLayout(false);
            this.groupBoxAddNote.PerformLayout();
            this.groupBoxupdate.ResumeLayout(false);
            this.groupBoxupdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView dataGridViewNote;
        private System.Windows.Forms.GroupBox groupBoxAddNote;
        private System.Windows.Forms.Button btn_add_note;
        private System.Windows.Forms.TextBox tb_add_u_date;
        private System.Windows.Forms.Label label_add_u_date;
        private System.Windows.Forms.TextBox tb_add_c_date;
        private System.Windows.Forms.Label label_add_c_date;
        private System.Windows.Forms.TextBox tb_add_content;
        private System.Windows.Forms.Label label_add_content;
        private System.Windows.Forms.TextBox tb_add_title;
        private System.Windows.Forms.Label label_add_title;
        private System.Windows.Forms.GroupBox groupBoxupdate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox tb_update_udate;
        private System.Windows.Forms.Label label_update_u_date;
        private System.Windows.Forms.TextBox tb_update_cdate;
        private System.Windows.Forms.Label label_update_c_date;
        private System.Windows.Forms.TextBox tb_update_content;
        private System.Windows.Forms.Label label_update_content;
        private System.Windows.Forms.TextBox tb_update_title;
        private System.Windows.Forms.Label label_update_title;
    }
}
