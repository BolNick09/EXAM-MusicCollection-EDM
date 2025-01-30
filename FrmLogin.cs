using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAM_MusicCollection_EDM
{
    public partial class FrmLogin : Form
    {
        private Users user;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new MusicCollectionModel())
            {
                var user = context.Users
                    .FirstOrDefault(u => u.Username == tbLogin.Text && u.Password == tbPassword.Text);

                if (user == null)
                {
                    MessageBox.Show("Пользователь не найден");
                    return;
                }

                FrmMain mainForm = new FrmMain(user.AccessLevel == 1, this);
                mainForm.Show();

                this.Hide();
            }
        }
    }
}
