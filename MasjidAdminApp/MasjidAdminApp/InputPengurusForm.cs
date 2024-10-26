using System;
using System.Linq;
using System.Windows.Forms;

namespace MasjidAdminApp
{
    public partial class InputPengurusForm : Form
    {
        private int? pengurusId; // ID pengurus (nullable) untuk edit, null jika baru
        private int currentUserId; // UserID yang login

        // Konstruktor untuk tambah pengurus baru
        public InputPengurusForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId; // Simpan userId dari pengguna yang login
        }

        // Konstruktor untuk edit pengurus yang sudah ada
        public InputPengurusForm(int pengurusId, int userId)
        {
            InitializeComponent();
            this.pengurusId = pengurusId;
            currentUserId = userId; // Simpan userId dari pengguna yang login
            LoadPengurusData(pengurusId); // Muat data pengurus
        }

        private void InputPengurusForm_Load(object sender, EventArgs e)
        {
        }

        // Method untuk memuat data pengurus berdasarkan ID
        private void LoadPengurusData(int pengurusId)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                var pengurus = db.PengurusTables.FirstOrDefault(p => p.IdPengurus == pengurusId);
                if (pengurus != null)
                {
                    txtNamaPengurus.Text = pengurus.NamaPengurus;
                    txtJabatanPengurus.Text = pengurus.JabatanPengurus;
                    txtKontakPengurus.Text = pengurus.KontakPengurus;
                    txtAlamatPengurus.Text = pengurus.AlamatPengurus;
                }
            }
        }

        // Validasi input: pastikan semua field diisi
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtNamaPengurus.Text) ||
                string.IsNullOrWhiteSpace(txtJabatanPengurus.Text) ||
                string.IsNullOrWhiteSpace(txtKontakPengurus.Text) ||
                string.IsNullOrWhiteSpace(txtAlamatPengurus.Text))
            {
                MessageBox.Show("Semua field harus diisi.", "Validasi Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Event handler untuk btnSimpan
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Cek validasi input sebelum menyimpan data
            if (!ValidateInput())
            {
                return; // Jika tidak valid, batalkan proses simpan
            }

            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                if (pengurusId == null) // Tambah pengurus baru
                {
                    PengurusTable pengurusBaru = new PengurusTable
                    {
                        NamaPengurus = txtNamaPengurus.Text.Trim(),
                        JabatanPengurus = txtJabatanPengurus.Text.Trim(),
                        KontakPengurus = txtKontakPengurus.Text.Trim(),
                        AlamatPengurus = txtAlamatPengurus.Text.Trim(),
                        UserID = currentUserId // Isi UserID otomatis dari pengguna yang login
                    };

                    db.PengurusTables.InsertOnSubmit(pengurusBaru);
                    db.SubmitChanges();
                    MessageBox.Show("Pengurus baru berhasil ditambahkan.");
                }
                else // Edit pengurus yang sudah ada
                {
                    var pengurus = db.PengurusTables.FirstOrDefault(p => p.IdPengurus == pengurusId);
                    if (pengurus != null)
                    {
                        pengurus.NamaPengurus = txtNamaPengurus.Text.Trim();
                        pengurus.JabatanPengurus = txtJabatanPengurus.Text.Trim();
                        pengurus.KontakPengurus = txtKontakPengurus.Text.Trim();
                        pengurus.AlamatPengurus = txtAlamatPengurus.Text.Trim();
                        pengurus.UserID = currentUserId; // Pastikan UserID tetap sama
                        db.SubmitChanges();
                        MessageBox.Show("Data pengurus berhasil diperbarui.");
                    }
                }

                // Tutup form setelah menyimpan
                this.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

        }
    }
}