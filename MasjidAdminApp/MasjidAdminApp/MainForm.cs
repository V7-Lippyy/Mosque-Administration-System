using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MasjidAdminApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Membuka LoginForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show(); // Menampilkan form login
            this.Hide(); // Menyembunyikan MainForm
        }

        private void Register_Click(object sender, EventArgs e)
        {
            // Membuka RegisterForm
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show(); // Menampilkan form register
            this.Hide(); // Menyembunyikan MainForm
        }
    }
}