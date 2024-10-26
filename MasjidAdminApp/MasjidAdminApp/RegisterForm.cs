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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtFullName.Text) ||
                string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtRePassword.Text) ||
                string.IsNullOrEmpty(txtUniqueCode.Text))
            {
                MessageBox.Show("Semua field harus diisi.");
                return;
            }

            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Password tidak sesuai.");
                return;
            }

            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password harus minimal 8 karakter.");
                return;
            }

            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                // Cek username unik
                if (db.UserTables.Any(u => u.Username == txtUsername.Text))
                {
                    MessageBox.Show("Username sudah digunakan.");
                    return;
                }

                // Simpan user baru
                UserTable newUser = new UserTable
                {
                    Username = txtUsername.Text,
                    FullName = txtFullName.Text,
                    Password = txtPassword.Text,
                    UniqueCode = txtUniqueCode.Text
                };

                db.UserTables.InsertOnSubmit(newUser);
                db.SubmitChanges();

                MessageBox.Show("Registrasi berhasil.");

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Membuat instance LoginForm
            LoginForm loginForm = new LoginForm();
            // Menampilkan LoginForm
            loginForm.Show();
            // Menyembunyikan MainForm (opsional)
            this.Hide();
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
