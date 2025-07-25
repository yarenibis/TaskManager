using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerEF
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        UserDal _userdal = new UserDal();
        private void UserControl1_Load(object sender, EventArgs e)
        {
         dataGridView.DataSource= _userdal.GetAll();   
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            try
            {
                _userdal.Add(new User
                {
                    name = tb_add_name.Text,
                    email = tb_add_mail.Text,
                    password = tb_add_pwd.Text,
                    role = tb_add_role.Text
                });

                dataGridView.DataSource = _userdal.GetAll();
                MessageBox.Show("Kullanıcı eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_name_update.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            tb_mail_update.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            tb_pwd_update.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            tb_role_update.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            _userdal.Update(new User
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value),
                name = tb_name_update.Text,
                email = tb_mail_update.Text,
                password = tb_pwd_update.Text,
                role = tb_role_update.Text
                
            });
            dataGridView.DataSource = _userdal.GetAll();
            MessageBox.Show("User updated");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            _userdal.Delete(new User
            {
                id= Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value)
            });
            dataGridView.DataSource = _userdal.GetAll();
            MessageBox.Show("User deleted");
        }

        private void Search(string query)
        {
            //_userdal.getAll().where(p => ....).tolist()//listedeki veriler üzerinden arama yapar
            var result=_userdal.GetByName(query); //veritabanındaki veriler üzerinden
            dataGridView.DataSource = result;
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Search(tbSearch.Text);
        }
    }
}
