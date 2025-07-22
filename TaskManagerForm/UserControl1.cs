using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerForm
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        UserDal _userDal = new UserDal();
        private void btn_add_user_Click(object sender, EventArgs e)
        {
            _userDal.AddUser(new User
            {
                name = tb_add_name.Text,
                email = tb_add_mail.Text,
                password = tb_add_pwd.Text,
                role = tb_add_role.Text
            });
            LoadUser();
            MessageBox.Show("User is added");
        }

      

        private void UserControl1_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void LoadUser()
        {
            dataGridView.DataSource = _userDal.GetUsers();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_name_update.Text= dataGridView.CurrentRow.Cells[1].Value.ToString();
            tb_mail_update.Text= dataGridView.CurrentRow.Cells[2].Value.ToString();
            tb_pwd_update.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            tb_role_update.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            _userDal.UpdateUser(new User
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value),
                name = tb_name_update.Text,
                email = tb_mail_update.Text,
                password = tb_pwd_update.Text,
                role = tb_role_update.Text
            });
            LoadUser();
            MessageBox.Show("User Updated");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value);
            _userDal.DeleteUser(id);
            LoadUser();
            MessageBox.Show("User deleted");
        }
    }
}
