using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MasjidAdminApp
{
    public partial class PemasukanForm : Form
    {
        private string username; // Simpan username pengguna yang login
        private int currentUserId; // Simpan userId pengguna yang login

        public PemasukanForm(int userId)
        {
            InitializeComponent();
            this.username = username; // Simpan username
            currentUserId = userId;
        }

        private void PemasukanForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Isi ComboBox dengan nama bulan
                cmbFilterBulan.Items.AddRange(new string[] {
            "Semua Bulan", "Januari", "Februari", "Maret", "April", "Mei", "Juni",
            "Juli", "Agustus", "September", "Oktober", "November", "Desember"
        });
                cmbFilterBulan.SelectedIndex = 0; // Set default ke 'Semua Bulan'

                // Load data pemasukan ke dalam DataGridView
                LoadPemasukanData(); // Memanggil metode untuk memuat data pemasukan
                AddButtonColumns(); // Tambahkan kolom edit dan delete
                UpdateTotalPemasukan(); // Tambahkan total pemasukan ke label
                dgvPemasukan.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddButtonColumns()
        {
            // Pastikan kolom Edit belum ada sebelum menambahkannya
            if (!dgvPemasukan.Columns.Contains("EditColumn"))
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                {
                    Name = "EditColumn",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dgvPemasukan.Columns.Add(editColumn);
            }

            // Pastikan kolom Delete belum ada sebelum menambahkannya
            if (!dgvPemasukan.Columns.Contains("DeleteColumn"))
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "DeleteColumn",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dgvPemasukan.Columns.Add(deleteColumn);
            }
        }

        private void LoadPemasukanData()
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                // Ambil data pemasukan dari database
                var pemasukanData = db.Pemasukans
                                      .Where(p => p.UserID == currentUserId)
                                      .Select(p => new
                                      {
                                          p.IdPemasukan,
                                          p.TanggalWaktuPemasukan,
                                          p.SumberPemasukan,
                                          p.NamaDonatur,
                                          JumlahPemasukan = (decimal?)p.JumlahPemasukan ?? 0m, // Ubah ke nullable
                                          p.KeteranganTambahan,
                                          p.UserID // Ambil UserID tetapi akan disembunyikan
                                      })
                                      .ToList();

                // Tambahkan nomor urut secara manual setelah data diambil
                var dataWithIndex = pemasukanData.Select((p, index) => new
                {
                    No = index + 1,  // Tambahkan nomor urut manual
                    p.IdPemasukan,
                    p.TanggalWaktuPemasukan,
                    p.SumberPemasukan,
                    p.NamaDonatur,
                    p.JumlahPemasukan,
                    p.KeteranganTambahan,
                    p.UserID // Masukkan UserID di sini
                }).ToList();

                // Clear DataSource sebelum binding baru
                dgvPemasukan.DataSource = null;

                // Hapus kolom "No" jika sudah ada sebelumnya untuk menghindari duplikasi
                if (dgvPemasukan.Columns.Contains("No"))
                {
                    dgvPemasukan.Columns.Remove("No");
                }

                // Set DataSource ke DataGridView setelah kolom No sudah diatur
                dgvPemasukan.DataSource = dataWithIndex;

                // Tambahkan kolom "No" jika belum ada
                if (!dgvPemasukan.Columns.Contains("No"))
                {
                    DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        HeaderText = "No",
                        ReadOnly = true,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                        DataPropertyName = "No"  // Pastikan DataPropertyName diatur ke "No"
                    };
                    dgvPemasukan.Columns.Insert(0, noColumn); // Tambahkan di posisi pertama (ujung kiri)
                }

                // Pastikan kolom IdPemasukan ada di DataGridView
                if (!dgvPemasukan.Columns.Contains("IdPemasukan"))
                {
                    DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "IdPemasukan",
                        DataPropertyName = "IdPemasukan",
                        HeaderText = "ID Pemasukan",
                        Visible = false // Sembunyikan kolom IdPemasukan
                    };
                    dgvPemasukan.Columns.Add(idColumn);
                }

                // Tambahkan kolom UserID dan sembunyikan datanya
                if (!dgvPemasukan.Columns.Contains("UserID"))
                {
                    DataGridViewTextBoxColumn userIdColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "UserID",
                        DataPropertyName = "UserID",
                        HeaderText = "User ID",
                        Visible = true // Tampilkan kolom UserID
                    };
                    dgvPemasukan.Columns.Add(userIdColumn);
                    dgvPemasukan.Columns["UserID"].Visible = false; // Sembunyikan datanya
                }
            }

            AddButtonColumns(); // Tambahkan kolom edit dan delete setelah data di-load
        }

        private void UpdateTotalPemasukan()
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                string bulanTerpilih = cmbFilterBulan.SelectedItem.ToString();
                var pemasukanQuery = db.Pemasukans.Where(p => p.UserID == currentUserId);

                if (bulanTerpilih != "Semua Bulan")
                {
                    int bulan = cmbFilterBulan.SelectedIndex; // Ambil indeks bulan
                    pemasukanQuery = pemasukanQuery.Where(p => p.TanggalWaktuPemasukan.Month == bulan);
                }

                decimal totalPemasukan = pemasukanQuery.Sum(p => (decimal?)p.JumlahPemasukan) ?? 0m;
                lblTotalPemasukan.Text = $"Total Pemasukan: Rp {totalPemasukan:N0}";
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            InputPemasukanForm inputPemasukanForm = new InputPemasukanForm(currentUserId);
            inputPemasukanForm.FormClosed += (s, args) =>
            {
                LoadPemasukanData();  // Refresh data setelah form ditutup
                UpdateTotalPemasukan(); // Perbarui total pemasukan
            };
            inputPemasukanForm.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                string sumber = txtFilterSumber.Text.Trim();
                string bulanTerpilih = cmbFilterBulan.SelectedItem.ToString();

                // Filter data berdasarkan nama dan bulan
                var filteredData = db.Pemasukans
                                     .Where(p => p.UserID == currentUserId &&
                                                 p.SumberPemasukan.Contains(sumber));

                if (bulanTerpilih != "Semua Bulan")
                {
                    int bulan = cmbFilterBulan.SelectedIndex; // Dapatkan indeks bulan yang dipilih (1 = Januari, 2 = Februari, dst.)
                    filteredData = filteredData.Where(p => p.TanggalWaktuPemasukan.Month == bulan);
                }

                // Projeksi hasil ke DataGridView
                var result = filteredData.Select(p => new
                {
                    p.IdPemasukan,
                    p.TanggalWaktuPemasukan,
                    p.SumberPemasukan,
                    p.NamaDonatur,
                    JumlahPemasukan = (decimal?)p.JumlahPemasukan ?? 0m, // Ubah ke nullable
                    p.KeteranganTambahan
                }).ToList();

                dgvPemasukan.DataSource = result;

                // Perbarui total pemasukan sesuai filter
                UpdateTotalPemasukan();
            }
        }

        private void dgvPemasukan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPemasukan.Columns["EditColumn"].Index && e.RowIndex >= 0)
            {
                int pemasukanId = Convert.ToInt32(dgvPemasukan.Rows[e.RowIndex].Cells["IdPemasukan"].Value);
                InputPemasukanForm inputPemasukanForm = new InputPemasukanForm(pemasukanId, currentUserId);
                inputPemasukanForm.FormClosed += (s, args) =>
                {
                    LoadPemasukanData();  // Refresh data setelah form ditutup
                    UpdateTotalPemasukan(); // Perbarui total pemasukan
                };
                inputPemasukanForm.Show();
            }
            else if (e.ColumnIndex == dgvPemasukan.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int pemasukanId = Convert.ToInt32(dgvPemasukan.Rows[e.RowIndex].Cells["IdPemasukan"].Value);
                    using (MasjidDBDataContext db = new MasjidDBDataContext())
                    {
                        var pemasukanToDelete = db.Pemasukans.SingleOrDefault(p => p.IdPemasukan == pemasukanId);
                        if (pemasukanToDelete != null)
                        {
                            db.Pemasukans.DeleteOnSubmit(pemasukanToDelete);
                            db.SubmitChanges();
                            LoadPemasukanData();  // Refresh data setelah penghapusan
                            UpdateTotalPemasukan(); // Perbarui total pemasukan
                        }
                    }
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            KeuanganForm keuanganForm = new KeuanganForm(username, currentUserId);
            keuanganForm.Show();
        }

        private void txtFilterSumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}