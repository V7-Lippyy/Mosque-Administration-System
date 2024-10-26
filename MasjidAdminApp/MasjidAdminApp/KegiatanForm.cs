using System;
using System.Linq;
using System.Windows.Forms;

namespace MasjidAdminApp
{
    public partial class KegiatanForm : Form
    {
        private string username; // Menyimpan username pengguna yang login
        private int currentUserId; // Simpan UserID pengguna yang login

        public KegiatanForm(string username, int userId) // Tambahkan username sebagai parameter
        {
            InitializeComponent();
            this.username = username; // Simpan username
            currentUserId = userId;

            // Pastikan event handler ditambahkan di constructor
            dgvKegiatan.CellContentClick += dgvKegiatan_CellContentClick;
        }

        private void KegiatanForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Load data kegiatan ke dalam DataGridView
                LoadKegiatanData(); // Memanggil metode untuk memuat data kegiatan
                AddButtonColumns(); // Tambahkan kolom edit dan delete
                UpdateTotalKegiatan(); // Tambahkan total kegiatan ke label
                dgvKegiatan.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddButtonColumns()
        {
            // Pastikan kolom Edit belum ada sebelum menambahkannya
            if (!dgvKegiatan.Columns.Contains("EditColumn"))
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                {
                    Name = "EditColumn",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dgvKegiatan.Columns.Add(editColumn);
            }

            // Pastikan kolom Delete belum ada sebelum menambahkannya
            if (!dgvKegiatan.Columns.Contains("DeleteColumn"))
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "DeleteColumn",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dgvKegiatan.Columns.Add(deleteColumn);
            }
        }

        private void LoadKegiatanData()
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                var kegiatanData = db.KegiatanTables
                                     .Where(k => k.UserID == currentUserId)
                                     .Select(k => new
                                     {
                                         k.IdKegiatan,
                                         k.UserID, // Tambahkan UserID ke dalam data
                                         k.NamaKegiatan,
                                         k.Deskripsi,
                                         k.PenanggungJawab,
                                         k.TanggalKegiatan
                                     })
                                     .ToList();

                // Tambahkan nomor urut secara manual setelah data diambil
                var kegiatanDataWithNo = kegiatanData
                                         .Select((k, index) => new
                                         {
                                             No = index + 1, // Nomor urut dinamis
                                             k.IdKegiatan,
                                             k.UserID, // Pastikan UserID tetap ada di sini
                                             k.NamaKegiatan,
                                             k.Deskripsi,
                                             k.PenanggungJawab,
                                             k.TanggalKegiatan
                                         })
                                         .ToList();

                dgvKegiatan.DataSource = kegiatanDataWithNo;

                // Tambahkan kolom nomor urut jika belum ada
                if (!dgvKegiatan.Columns.Contains("No"))
                {
                    DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        DataPropertyName = "No", // Properti dari objek data
                        HeaderText = "No.",
                        ReadOnly = true
                    };
                    dgvKegiatan.Columns.Insert(0, noColumn); // Tambahkan di kolom pertama
                }

                // Tambahkan kolom IdKegiatan tersembunyi jika belum ada
                if (!dgvKegiatan.Columns.Contains("IdKegiatan"))
                {
                    DataGridViewTextBoxColumn idKegiatanColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "IdKegiatan",
                        DataPropertyName = "IdKegiatan",
                        Visible = false, // Sembunyikan kolom dari tampilan
                        ReadOnly = true
                    };
                    dgvKegiatan.Columns.Add(idKegiatanColumn); // Tambahkan kolom di posisi akhir
                }

                // Tambahkan kolom UserID tersembunyi jika belum ada
                if (!dgvKegiatan.Columns.Contains("UserID"))
                {
                    DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "UserID",
                        DataPropertyName = "UserID",
                        Visible = false, // Sembunyikan kolom dari tampilan
                        ReadOnly = true
                    };
                    dgvKegiatan.Columns.Add(userIdColumn); // Tambahkan kolom di posisi akhir
                }
            }
        }

        private void UpdateTotalKegiatan()
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                // Hitung total kegiatan untuk pengguna yang login
                int totalKegiatan = db.KegiatanTables
                                      .Where(k => k.UserID == currentUserId)
                                      .Count();

                // Tampilkan total kegiatan di label
                lblTotalKegiatan.Text = $"Total Kegiatan: {totalKegiatan}";
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            InputKegiatanForm inputKegiatanForm = new InputKegiatanForm(currentUserId);
            inputKegiatanForm.FormClosed += (s, args) =>
            {
                LoadKegiatanData();  // Refresh data setelah form ditutup
                UpdateTotalKegiatan(); // Perbarui total kegiatan
            };
            inputKegiatanForm.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                string namaKegiatan = txtFilterNamaKegiatan.Text.Trim();
                var filteredData = db.KegiatanTables
                                     .Where(k => k.UserID == currentUserId && k.NamaKegiatan.Contains(namaKegiatan))
                                     .Select(k => new
                                     {
                                         k.NamaKegiatan,
                                         k.Deskripsi,
                                         k.PenanggungJawab,
                                         k.TanggalKegiatan
                                     })
                                     .ToList();

                dgvKegiatan.DataSource = filteredData;
            }
        }

        private void dgvKegiatan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Pastikan tidak klik header

            // Cek apakah kolom "IdKegiatan" ada
            if (dgvKegiatan.Columns["IdKegiatan"] == null)
            {
                MessageBox.Show("Kolom 'IdKegiatan' tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Edit Kegiatan
            if (e.ColumnIndex == dgvKegiatan.Columns["EditColumn"].Index)
            {
                int kegiatanId = Convert.ToInt32(dgvKegiatan.Rows[e.RowIndex].Cells["IdKegiatan"].Value);
                InputKegiatanForm inputKegiatanForm = new InputKegiatanForm(kegiatanId, currentUserId);
                inputKegiatanForm.FormClosed += (s, args) =>
                {
                    LoadKegiatanData();
                    UpdateTotalKegiatan();
                };
                inputKegiatanForm.Show();
            }
            // Delete Kegiatan
            else if (e.ColumnIndex == dgvKegiatan.Columns["DeleteColumn"].Index)
            {
                var result = MessageBox.Show("Apakah Anda yakin ingin menghapus kegiatan ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (MasjidDBDataContext db = new MasjidDBDataContext())
                    {
                        int kegiatanId = Convert.ToInt32(dgvKegiatan.Rows[e.RowIndex].Cells["IdKegiatan"].Value);
                        var kegiatan = db.KegiatanTables.FirstOrDefault(k => k.IdKegiatan == kegiatanId);
                        if (kegiatan != null)
                        {
                            db.KegiatanTables.DeleteOnSubmit(kegiatan);
                            db.SubmitChanges();
                            LoadKegiatanData();
                            UpdateTotalKegiatan();
                            MessageBox.Show("Data kegiatan berhasil dihapus.");
                        }
                    }
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            // Buat instance dari MainFeatureForm dan berikan argumen 'username' dan 'userID'
            MainFeatureForm mainFeatureForm = new MainFeatureForm(username, currentUserId); // Menggunakan currentUserId

            // Tampilkan MainFeatureForm
            mainFeatureForm.Show();

            // Tutup form saat ini (PengurusForm)
            this.Close();
        }
    }
}