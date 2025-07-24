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
    public partial class MainForm : Form
    {
        private User _currentUser;

        public MainForm(User currentUser)
        {
            InitializeComponent();
            this._currentUser = currentUser;
        }


        

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Sekme başlıklarını ayarla
            tabPage1.Text = "Users";
            tabPage2.Text = "Notes";

            // Eğer kullanıcı admin değilse tabPage1'i (kullanıcılar) gizle
            if (_currentUser.role != "admin")
            {
                tabControl1.TabPages.Remove(tabPage1);
            }

            // Kullanıcı kontrolünü ekle (UserControl1)
            UserControl1 userControl = new UserControl1();
            userControl.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(userControl);

            // Not kontrolünü ekle (UserControl2)
            UserControl2 noteControl = new UserControl2(_currentUser);
            noteControl.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(noteControl);
        }

        
    }
}
