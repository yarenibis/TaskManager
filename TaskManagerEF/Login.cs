using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagerFormEF;

namespace TaskManagerEF
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        UserDal userDal = new UserDal();
        private void login_btn_Click(object sender, EventArgs e)
        {
            User user=userDal.Login(tb_login_mail.Text, tb_login_pwd.Text);
            if (user != null)
            {
                Session.CurrentUser = user;
                MessageBox.Show("Giriş başarılı. Kullanıcı ID: " + user.id);
                MainForm main = new MainForm(user);
                main.Show();
                this.Hide();
            }
        }

     
    }
}
