using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerEF
{
    public partial class NoteForm : UserControl
    {
        private User _currentUser;
        public NoteForm(User currentUser)
        {
            InitializeComponent();
            try
            {
                var ctx = new TaskManagerContext();
                MessageBox.Show("Bağlantı: " + ctx.Database.Connection.ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }

            _currentUser = currentUser;
        }



        NoteDal _notedal=new NoteDal();
        private void NoteForm_Load(object sender, EventArgs e)
        {
            dataGridViewNote.DataSource = _notedal.GetAll();
        }

        private void btn_add_note_Click(object sender, EventArgs e)
        {
            _notedal.AddNote(new Note
            {
                title = tb_add_title.Text,
                content = tb_add_content.Text,
                UpdatedDate = DateTime.Now,
                CreatedDate = DateTime.Now,
                UserId = _currentUser.id
            });
            dataGridViewNote.DataSource= _notedal.GetAll();
            MessageBox.Show("Note added");
        }

        private void dataGridViewNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_update_title.Text = dataGridViewNote.CurrentRow.Cells[1].Value.ToString();
            tb_update_content.Text= dataGridViewNote.CurrentRow.Cells[2].Value.ToString();
            tb_update_cdate.Text= dataGridViewNote.CurrentRow.Cells[3].Value.ToString();
            tb_update_udate.Text= dataGridViewNote.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selected_note =Convert.ToInt32(dataGridViewNote.CurrentRow.Cells[0].Value);
            var old_note= _notedal.GetNoteById(selected_note);
            

            _notedal.UpdateNote(new Note
            {
                id = selected_note,
                title = tb_update_title.Text,
                content = tb_update_content.Text,
                UpdatedDate = DateTime.Now,
                CreatedDate = old_note.CreatedDate,
                UserId = _currentUser.id
            });
            dataGridViewNote.DataSource = _notedal.GetAll();
            MessageBox.Show("Note updated");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int selected_note = Convert.ToInt32(dataGridViewNote.CurrentRow.Cells[0].Value);
            _notedal.DeleteNote(new Note
            {
                id = Convert.ToInt32(dataGridViewNote.CurrentRow.Cells[0].Value)
            });
            dataGridViewNote.DataSource = _notedal.GetAll();
            MessageBox.Show("Note deleted");
        }
    }
}
