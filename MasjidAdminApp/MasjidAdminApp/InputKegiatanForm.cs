using System;
using System.Linq;
using System.Windows.Forms;

namespace MasjidAdminApp
{
    public partial class InputKegiatanForm : Form
    {
        private int currentUserID; // Simpan UserID pengguna yang login
        private int? kegiatanId;   // Nullable int untuk menyimpan IdKegiatan jika dalam mode edit

        // Constructor untuk menambah kegiatan baru
        public InputKegiatanForm(int userID)
        {
            InitializeComponent();
            currentUserID = userID;
            btnSimpan.Click -= new EventHandler(btnSimpan_Click); // Unregister untuk mencegah duplikasi
            btnSimpan.Click += new EventHandler(btnSimpan_Click);
        }

        // Constructor untuk mengedit kegiatan
        public InputKegiatanForm(int kegiatanId, int userID) : this(userID)
        {
            this.kegiatanId = kegiatanId;
            LoadKegiatanData(kegiatanId);
        }

        // Method untuk memuat data kegiatan ke form (mode edit)
        private void LoadKegiatanData(int kegiatanId)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                var kegiatan = db.KegiatanTables.FirstOrDefault(k => k.IdKegiatan == kegiatanId);
                if (kegiatan != null)
                {
                    // Isi kontrol dengan data kegiatan yang diambil dari database
                    txtNamaKegiatan.Text = kegiatan.NamaKegiatan;
                    txtDeskripsiKegiatan.Text = kegiatan.Deskripsi; // Pastikan ini sesuai dengan database
                    txtPenanggungJawab.Text = kegiatan.PenanggungJawab;
                    dtpTanggalKegiatan.Value = kegiatan.TanggalKegiatan;
                }
            }
        }

        // Method untuk menyimpan atau memperbarui data kegiatan
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi input
     

            if (string.IsNullOrEmpty(txtDeskripsiKegiatan.Text))
            {
                MessageBox.Show("Deskripsi kegiatan tidak boleh kosong.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtPenanggungJawab.Text))
            {
                MessageBox.Show("Penanggung jawab tidak boleh kosong.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtNamaKegiatan.Text))
            {
                MessageBox.Show("Nama kegiatan tidak boleh kosong.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Jika semua input valid, simpan ke database
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                if (kegiatanId.HasValue) // Jika kegiatanId ada, artinya mode edit
                {
                    var kegiatan = db.KegiatanTables.FirstOrDefault(k => k.IdKegiatan == kegiatanId.Value);
                    if (kegiatan != null)
                    {
                        // Update data kegiatan yang ada
                        kegiatan.NamaKegiatan = txtNamaKegiatan.Text;
                        kegiatan.Deskripsi = txtDeskripsiKegiatan.Text;
                        kegiatan.PenanggungJawab = txtPenanggungJawab.Text;
                        kegiatan.TanggalKegiatan = dtpTanggalKegiatan.Value;
                    }
                }
                else // Jika kegiatanId tidak ada, mode tambah kegiatan baru
                {
                    KegiatanTable newKegiatan = new KegiatanTable
                    {
                        NamaKegiatan = txtNamaKegiatan.Text,
                        Deskripsi = txtDeskripsiKegiatan.Text,
                        PenanggungJawab = txtPenanggungJawab.Text,
                        TanggalKegiatan = dtpTanggalKegiatan.Value,
                        UserID = currentUserID // Gunakan currentUserID yang sudah disimpan di konstruktor
                    };
                    db.KegiatanTables.InsertOnSubmit(newKegiatan);
                }

                // Simpan perubahan ke database
                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Data kegiatan berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Tutup form setelah data disimpan
                }
                catch (Exception ex)
                {
                    // Tangani jika terjadi error saat menyimpan
                    MessageBox.Show($"Terjadi kesalahan saat menyimpan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}