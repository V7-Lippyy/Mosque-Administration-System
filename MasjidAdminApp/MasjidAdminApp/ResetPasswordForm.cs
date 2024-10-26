using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasjidAdminApp
{
    public partial class ResetPasswordForm : Form
    {
        private UserTable currentUser;

        public ResetPasswordForm(UserTable user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {
            // Anda dapat menambahkan kode yang ingin dieksekusi saat form dimuat
            // Misalnya, mengosongkan field password
            txtNewPassword.Clear();
            txtConfirmNewPassword.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                MessageBox.Show("Password tidak sesuai.");
                return;
            }

            if (txtNewPassword.Text.Length < 8)
            {
                MessageBox.Show("Password harus minimal 8 karakter.");
                return;
            }

            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                var user = db.UserTables.FirstOrDefault(u => u.UserID == currentUser.UserID);
                if (user != null)
                {
                    user.Password = txtNewPassword.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Password berhasil direset.");
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}