using System;
using System.Linq;
using System.Windows.Forms;

namespace MasjidAdminApp
{
    public partial class KeuanganForm : Form
    {
        private string username; // Menyimpan username pengguna yang login
        private int currentUserId; // Simpan UserID pengguna yang login

        // Konstruktor
        public KeuanganForm(string username, int userId) // Tambahkan username sebagai parameter
        {
            InitializeComponent();
            this.username = username; // Simpan username
            currentUserId = userId;
        }

        private void KeuanganForm_Load(object sender, EventArgs e)
        {
            // Update saldo total saat form di-load
            UpdateTotalSaldo();
        }

        private void UpdateTotalSaldo()
        {
            decimal totalPemasukan = 0;
            decimal totalPengeluaran = 0;

            // Ambil data pemasukan dan pengeluaran dari database
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                // Hitung total pemasukan
                totalPemasukan = db.Pemasukans
                                  .Where(p => p.UserID == currentUserId)
                                  .Sum(p => (decimal?)p.JumlahPemasukan) ?? 0;

                // Hitung total pengeluaran
                totalPengeluaran = db.Pengeluarans
                                    .Where(p => p.UserID == currentUserId)
                                    .Sum(p => (decimal?)p.JumlahPengeluaran) ?? 0;
            }

            // Hitung total saldo
            decimal totalSaldo = totalPemasukan - totalPengeluaran;

            // Tampilkan total saldo di label
            lblTotalSaldo.Text = $"Total Saldo: Rp {totalSaldo:N0}";
        }

        private void btnPemasukan_Click(object sender, EventArgs e)
        {
            // Buka form PemasukanForm dengan UserID yang sedang login
            PemasukanForm pemasukanForm = new PemasukanForm(currentUserId);
            pemasukanForm.FormClosed += (s, args) =>
            {
                UpdateTotalSaldo(); // Update saldo setelah pemasukan form ditutup
            };
            pemasukanForm.Show();
            this.Hide();
        }

        private void btnPengeluaran_Click(object sender, EventArgs e)
        {
            // Buka form PengeluaranForm dengan UserID yang sedang login
            PengeluaranForm pengeluaranForm = new PengeluaranForm(currentUserId);
            pengeluaranForm.FormClosed += (s, args) =>
            {
                UpdateTotalSaldo(); // Update saldo setelah pengeluaran form ditutup
            };
            pengeluaranForm.Show();
            this.Hide();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Buat instance dari MainFeatureForm dan berikan argumen 'username' dan 'userID'
            MainFeatureForm mainFeatureForm = new MainFeatureForm(username, currentUserId); // Menggunakan currentUserId

            // Tampilkan MainFeatureForm
            mainFeatureForm.Show();

            // Tutup form saat ini (KeuanganForm)
            this.Close();
        }

        private void lblTotalSaldo_Click(object sender, EventArgs e)
        {
            // Event handler untuk label saldo (jika diperlukan)
        }

        private void cmbFilterBulan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}