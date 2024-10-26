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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                var user = db.UserTables.FirstOrDefault(u => u.Username == txtUsername.Text && u.Password == txtPassword.Text);

                if (user != null)
                {
                    // Panggil MainFeatureForm dengan username dan userId
                    MainFeatureForm mainFeatureForm = new MainFeatureForm(user.Username, user.UserID);
                    mainFeatureForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah.");
                }
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Membuat instance MainForm
            MainForm mainForm = new MainForm();
            // Menampilkan MainForm
            mainForm.Show();
            // Menutup form saat ini
            this.Close();
        }
    }
}
