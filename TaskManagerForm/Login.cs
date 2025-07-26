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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        UserDal _userDal = new UserDal();
        private void login_btn_Click(object sender, EventArgs e)
        {
            User user = _userDal.Login(tb_login_mail.Text, tb_login_pwd.Text);
            if (user != null)
            {
                Session.CurrentUser = user;
                MessageBox.Show("Giriş başarılı. Kullanıcı ID: " + user.Id);
                MainForm main = new MainForm(user);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş bilgileri hatalı");
            }
        }

        private void login_label_mail_Click(object sender, EventArgs e)
        {

        }

        private void label_login_pwd_Click(object sender, EventArgs e)
        {

        }

        private void tb_login_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_login_mail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
