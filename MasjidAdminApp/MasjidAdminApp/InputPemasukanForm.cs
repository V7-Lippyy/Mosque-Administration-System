using System;
using System.Linq;
using System.Windows.Forms;

namespace MasjidAdminApp
{
    public partial class InputPemasukanForm : Form
    {
        private int currentUserID; // Simpan UserID pengguna yang login
        private int? pemasukanId;   // Nullable int untuk menyimpan IdPemasukan jika dalam mode edit

        // Constructor untuk menambah pemasukan baru
        public InputPemasukanForm(int userID)
        {
            InitializeComponent();
            currentUserID = userID; // Set currentUserID dengan parameter yang diterima
            btnSimpan.Click += new EventHandler(btnSimpan_Click); // Pastikan event handler terhubung
        }

        // Constructor untuk mengedit pemasukan
        public InputPemasukanForm(int pemasukanId, int userID) : this(userID)
        {
            this.pemasukanId = pemasukanId; // Set pemasukanId untuk mode edit
            LoadPemasukanData(pemasukanId); // Panggil metode untuk memuat data pemasukan
        }

        // Method untuk memuat data pemasukan ke form
        private void LoadPemasukanData(int pemasukanId)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                var pemasukan = db.Pemasukans.FirstOrDefault(p => p.IdPemasukan == pemasukanId);
                if (pemasukan != null)
                {
                    // Isi kontrol dengan data pemasukan
                    txtSumberPemasukan.Text = pemasukan.SumberPemasukan;
                    txtNamaDonatur.Text = pemasukan.NamaDonatur;
                    txtJumlahPemasukan.Text = pemasukan.JumlahPemasukan.ToString();
                    txtKeteranganTambahan.Text = pemasukan.KeteranganTambahan;
                    dtpTanggalWaktuPemasukan.Value = pemasukan.TanggalWaktuPemasukan;
                }
            }
        }

        // Method untuk menyimpan atau memperbarui data pemasukan
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                decimal jumlahPemasukan;

                // Validasi input jumlah pemasukan
                if (!decimal.TryParse(txtJumlahPemasukan.Text, out jumlahPemasukan))
                {
                    MessageBox.Show("Jumlah pemasukan harus berupa angka yang valid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Jika pemasukanId ada (mode edit), update data pemasukan
                if (pemasukanId.HasValue)
                {
                    var pemasukan = db.Pemasukans.FirstOrDefault(p => p.IdPemasukan == pemasukanId.Value);
                    if (pemasukan != null)
                    {
                        // Update data pemasukan yang sudah ada
                        pemasukan.SumberPemasukan = txtSumberPemasukan.Text;
                        pemasukan.NamaDonatur = txtNamaDonatur.Text;
                        pemasukan.JumlahPemasukan = jumlahPemasukan;
                        pemasukan.KeteranganTambahan = txtKeteranganTambahan.Text;
                        pemasukan.TanggalWaktuPemasukan = dtpTanggalWaktuPemasukan.Value;
                    }
                }
                else
                {
                    // Tambah data pemasukan baru
                    Pemasukan pemasukanBaru = new Pemasukan
                    {
                        SumberPemasukan = txtSumberPemasukan.Text,
                        NamaDonatur = txtNamaDonatur.Text,
                        JumlahPemasukan = jumlahPemasukan,
                        KeteranganTambahan = txtKeteranganTambahan.Text,
                        TanggalWaktuPemasukan = dtpTanggalWaktuPemasukan.Value,
                        UserID = currentUserID // Simpan UserID pengguna yang melakukan input
                    };

                    db.Pemasukans.InsertOnSubmit(pemasukanBaru);
                }

                try
                {
                    // Simpan perubahan ke database
                    db.SubmitChanges();

                    // Tampilkan pesan sukses
                    MessageBox.Show("Data pemasukan berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tutup form setelah menyimpan data
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Tampilkan pesan error jika terjadi kesalahan
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler untuk input lainnya jika diperlukan
        private void lblSumberPemasukan_Click(object sender, EventArgs e) { }
        private void txtSumberPemasukan_TextChanged(object sender, EventArgs e) { }
        private void lblNamaDonatur_Click(object sender, EventArgs e) { }
        private void txtNamaDonatur_TextChanged(object sender, EventArgs e) { }
        private void txtJumlahPemasukan_TextChanged(object sender, EventArgs e) { }
        private void txtKeteranganTambahan_TextChanged(object sender, EventArgs e) { }
        private void dtpTanggalWaktuPemasukan_ValueChanged(object sender, EventArgs e) { }

        private void InputPemasukanForm_Load(object sender, EventArgs e)
        {

        }
    }
}