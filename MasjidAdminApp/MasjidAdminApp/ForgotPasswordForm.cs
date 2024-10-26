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
    public partial class ForgotPasswordForm : Form
    {
        // Variabel untuk menyimpan user yang terverifikasi
        private UserTable currentUser;

        public ForgotPasswordForm()
        {
            InitializeComponent();
            // Pastikan tombol Reset Password dinonaktifkan saat form pertama kali dibuka
            btnResetPassword.Enabled = false;
        }

        // Event handler untuk tombol Verifikasi
        private void btnVerify_Click(object sender, EventArgs e)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                // Mencari user berdasarkan kode unik
                currentUser = db.UserTables.FirstOrDefault(u => u.UniqueCode == txtUniqueCode.Text);

                if (currentUser != null)
                {
                    // Menampilkan username yang sesuai dengan kode unik
                    lblUsername.Text = "Username Anda: " + currentUser.Username;

                    // Mengaktifkan tombol reset password
                    btnResetPassword.Enabled = true;
                }
                else
                {
                    // Menampilkan pesan error jika kode unik tidak ditemukan
                    MessageBox.Show("Kode unik salah.");

                    // Menonaktifkan tombol reset password jika kode unik salah
                    btnResetPassword.Enabled = false;
                }
            }
        }

        // Event handler untuk tombol Reset Password
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            // Memeriksa apakah currentUser null, yaitu apakah user sudah terverifikasi
            if (currentUser != null)
            {
                // Membuka form ResetPasswordForm dengan user yang terverifikasi
                ResetPasswordForm resetPasswordForm = new ResetPasswordForm(currentUser);
                resetPasswordForm.Show();

                // Menyembunyikan form ForgotPasswordForm
                this.Hide();
            }
            else
            {
                // Menampilkan pesan peringatan jika user belum terverifikasi
                MessageBox.Show("Masukkan kode unik terlebih dahulu untuk verifikasi.");
            }
        }

        // Event handler untuk tombol Kembali ke Login
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            // Membuka form Login dan menutup form ForgotPasswordForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Membuat instance LoginForm
            LoginForm loginForm = new LoginForm();
            // Menampilkan LoginForm
            loginForm.Show();
            // Menutup form saat ini
            this.Close();
        }
    }
}