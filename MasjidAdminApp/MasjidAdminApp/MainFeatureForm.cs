using System;
using System.Drawing;
using System.Windows.Forms;

namespace MasjidAdminApp
{
    public partial class MainFeatureForm : Form
    {
        private string username; // Simpan username pengguna yang login
        private int currentUserId; // Simpan userId pengguna yang login

        // Konstruktor yang menerima username dan userId
        public MainFeatureForm(string username, int userId)
        {
            InitializeComponent();
            this.username = username;
            this.currentUserId = userId;
            // Langsung set teks ke lblCurrentUser yang ada di designer
            lblCurrentUser.Text = $"Selamat datang di aplikasi kami"; // Menampilkan pesan selamat datang
        }

        // Event handler untuk tombol Pengurus
        private void btnPengurus_Click(object sender, EventArgs e)
        {
            // Buat instance PengurusForm
            PengurusForm pengurusForm = new PengurusForm(username, currentUserId); // Kirimkan username dan userId ke PengurusForm
            // Tampilkan PengurusForm
            pengurusForm.Show();
            // Sembunyikan MainFeatureForm (opsional)
            this.Hide();
        }

        // Event handler untuk tombol Keuangan
        private void btnKeuangan_Click(object sender, EventArgs e)
        {
            // Buat instance KeuanganForm dengan mengirimkan username dan currentUserId
            KeuanganForm keuanganForm = new KeuanganForm(username, currentUserId); // Kirimkan username dan userId ke KeuanganForm
            keuanganForm.Show();
            this.Hide();
        }

        // Event handler untuk tombol Inventaris
        private void btnInventaris_Click(object sender, EventArgs e)
        {
            // Pass currentUserId dan username ke InventarisForm
            InventarisForm inventarisForm = new InventarisForm(username, currentUserId); // Kirimkan username dan userId
            inventarisForm.Show();
            this.Hide();
        }

        // Event handler untuk tombol Kegiatan
        private void btnKegiatan_Click(object sender, EventArgs e)
        {
            // Pass currentUserId dan username ke KegiatanForm
            KegiatanForm kegiatanForm = new KegiatanForm(username, currentUserId); // Kirimkan username dan userId
            kegiatanForm.Show();
            this.Hide();
        }

        // Event handler untuk tombol Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Kembali ke MainForm
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close(); // Tutup MainFeatureForm
        }

        // Event handler untuk label current user (jika diperlukan)
        private void lblCurrentUser_Click(object sender, EventArgs e)
        {
            // Dapat diisi dengan logika tambahan jika diperlukan saat label di-klik
        }
    }
}