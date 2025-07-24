using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerForm
{
    public partial class UserControl2 : UserControl
    {
        private User _currentUser;
        public UserControl2(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        NoteDal _noteDal = new NoteDal();
        private void UserControl2_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser.role == "admin")
            {
                dataGridViewNote.DataSource = _noteDal.GetAll(); // tüm notlar
            }
            else
            {
                dataGridViewNote.DataSource = _noteDal.GetNotesForUsers(Session.CurrentUser.Id); // sadece kendi notları
            }
        }

        private void btn_add_note_Click(object sender, EventArgs e)
        {
            _noteDal.AddNote(new Note
            {
                title = tb_add_title.Text,
                content = tb_add_content.Text,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Userid = Session.CurrentUser.Id // ❗ Doğrudan Session'dan al
            });
            dataGridViewNote.DataSource = _noteDal.GetNotesForUsers(Session.CurrentUser.Id);
            MessageBox.Show("Note added");
        }

        private void dataGridViewNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_update_title.Text = dataGridViewNote.CurrentRow.Cells[1].Value.ToString();
            tb_update_content.Text= dataGridViewNote.CurrentRow.Cells[2].Value.ToString();
            tb_update_cdate.Text = dataGridViewNote.CurrentRow.Cells[3].Value.ToString();
            tb_update_udate.Text= dataGridViewNote.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var currentNote = (Note)dataGridViewNote.CurrentRow.DataBoundItem;
            _noteDal.UpdateNote(new Note
            {
                id = Convert.ToInt32(dataGridViewNote.CurrentRow.Cells[0].Value),
                title = tb_update_title.Text,
                content = tb_update_content.Text,
                CreatedDate =currentNote.CreatedDate,
                UpdatedDate = DateTime.Now,
                Userid = Session.CurrentUser.Id


            });
            dataGridViewNote.DataSource = _noteDal.GetAll();
            MessageBox.Show("Note updated");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewNote.CurrentRow.Cells[0].Value);
            _noteDal.DeleteNote(id);
            dataGridViewNote.DataSource = _noteDal.GetAll();
            MessageBox.Show("Note deleted");
        }
    }
}
