using System;
using System.Linq;
using System.Windows.Forms;

namespace MasjidAdminApp
{
    public partial class PengeluaranForm : Form
    {
        private string username; // Menyimpan username pengguna yang login
        private int currentUserId; // Simpan UserID pengguna yang login

        public PengeluaranForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;

            // Mendaftarkan event handler untuk tombol
            btnTambah.Click += btnTambah_Click;
            btnFilter.Click += btnFilter_Click;
            this.Load += PengeluaranForm_Load;

            // Daftarkan event handler untuk DataGridView dan ComboBox
            dgvPengeluaran.CellContentClick += dgvPengeluaran_CellContentClick;
            cmbFilterBulan.SelectedIndexChanged += cmbFilterBulan_SelectedIndexChanged;

            // Atur EditMode untuk DataGridView
            dgvPengeluaran.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void PengeluaranForm_Load(object sender, EventArgs e)
        {
            if (cmbFilterBulan.Items.Count == 0)
            {
                // Tambahkan opsi bulan ke ComboBox
                cmbFilterBulan.Items.Add("Semua");
                cmbFilterBulan.Items.AddRange(new string[] {
                    "Januari", "Februari", "Maret", "April", "Mei", "Juni",
                    "Juli", "Agustus", "September", "Oktober", "November", "Desember"
                });
                cmbFilterBulan.SelectedIndex = 0; // Pilih "Semua" secara default
            }

            LoadPengeluaranData();
            AddButtonColumns();
            UpdateTotalPengeluaran();
            dgvPengeluaran.RowHeadersVisible = false;
        }

        private void AddButtonColumns()
        {
            // Kolom Edit
            if (!dgvPengeluaran.Columns.Contains("EditColumn"))
            {
                dgvPengeluaran.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "EditColumn",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                });
            }

            // Kolom Delete
            if (!dgvPengeluaran.Columns.Contains("DeleteColumn"))
            {
                dgvPengeluaran.Columns.Add(new DataGridViewButtonColumn
                {
                    Name = "DeleteColumn",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                });
            }
        }

        private void LoadPengeluaranData()
        {
            using (var db = new MasjidDBDataContext())
            {
                var pengeluaranData = db.Pengeluarans
                                        .Where(p => p.UserID == currentUserId)
                                        .Select(p => new
                                        {
                                            p.IdPengeluaran,  // Pastikan kolom ini ada
                                            p.TanggalWaktuPengeluaran,
                                            p.KategoriPengeluaran,
                                            p.JumlahPengeluaran,
                                            p.KeteranganTambahan
                                        })
                                        .ToList();

                var dataWithIndex = pengeluaranData.Select((p, index) => new
                {
                    No = index + 1,
                    p.IdPengeluaran,
                    p.TanggalWaktuPengeluaran,
                    p.KategoriPengeluaran,
                    p.JumlahPengeluaran,
                    p.KeteranganTambahan
                }).ToList();

                dgvPengeluaran.DataSource = dataWithIndex;

                // Tambahkan kolom No jika belum ada
                if (!dgvPengeluaran.Columns.Contains("No"))
                {
                    dgvPengeluaran.Columns.Insert(0, new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        HeaderText = "No",
                        ReadOnly = true,
                        DataPropertyName = "No"
                    });
                }

                // Pastikan kolom IdPengeluaran ada
                if (!dgvPengeluaran.Columns.Contains("IdPengeluaran"))
                {
                    DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "IdPengeluaran",
                        HeaderText = "Id Pengeluaran",
                        DataPropertyName = "IdPengeluaran",
                        Visible = false // Sembunyikan jika tidak perlu ditampilkan
                    };
                    dgvPengeluaran.Columns.Add(idColumn);
                }

                // Sembunyikan kolom UserID jika ada
                if (dgvPengeluaran.Columns.Contains("UserID"))
                {
                    dgvPengeluaran.Columns["UserID"].Visible = false;
                }
            }

            AddButtonColumns(); // Tambahkan tombol Edit dan Delete
        }


        private void UpdateTotalPengeluaran()
        {
            using (var db = new MasjidDBDataContext())
            {
                decimal totalPengeluaran = db.Pengeluarans
                                              .Where(p => p.UserID == currentUserId)
                                              .Sum(p => (decimal?)p.JumlahPengeluaran) ?? 0;

                lblTotalPengeluaran.Text = $"Total Pengeluaran: Rp {totalPengeluaran:N0}";
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var inputPengeluaranForm = new InputPengeluaranForm(currentUserId);
            inputPengeluaranForm.FormClosed += (s, args) =>
            {
                LoadPengeluaranData();
                UpdateTotalPengeluaran();
            };
            inputPengeluaranForm.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ApplyFilters(); // Gabungkan pencarian teks dan filter bulan
        }

        private void ApplyFilters()
        {
            using (var db = new MasjidDBDataContext())
            {
                string kategori = txtFilterSumber.Text.Trim();
                int selectedMonth = cmbFilterBulan.SelectedIndex; // Dapatkan bulan terpilih

                var filteredData = db.Pengeluarans
                                     .Where(p => p.UserID == currentUserId);

                // Jika teks filter tidak kosong, cari yang sesuai kategori
                if (!string.IsNullOrEmpty(kategori))
                {
                    filteredData = filteredData.Where(p => p.KategoriPengeluaran.Contains(kategori));
                }

                // Jika bulan selain "Semua" dipilih
                if (selectedMonth > 0 && selectedMonth <= 12)
                {
                    filteredData = filteredData.Where(p => p.TanggalWaktuPengeluaran.Month == selectedMonth);
                }

                var dataToDisplay = filteredData.Select(p => new
                {
                    p.IdPengeluaran,
                    p.TanggalWaktuPengeluaran,
                    p.KategoriPengeluaran,
                    p.JumlahPengeluaran,
                    p.KeteranganTambahan
                }).ToList();

                dgvPengeluaran.DataSource = dataToDisplay;

                AddButtonColumns(); // Tambahkan kolom Edit dan Delete

                // Update total pengeluaran sesuai filter
                decimal totalPengeluaran = filteredData.Sum(p => (decimal?)p.JumlahPengeluaran) ?? 0;
                lblTotalPengeluaran.Text = $"Total Pengeluaran: Rp {totalPengeluaran:N0}";
            }
        }

        private void dgvPengeluaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Kolom Edit
                if (dgvPengeluaran.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    int pengeluaranId = Convert.ToInt32(dgvPengeluaran.Rows[e.RowIndex].Cells["IdPengeluaran"].Value);
                    var inputPengeluaranForm = new InputPengeluaranForm(pengeluaranId, currentUserId);
                    inputPengeluaranForm.FormClosed += (s, args) =>
                    {
                        LoadPengeluaranData();
                        UpdateTotalPengeluaran();
                    };
                    inputPengeluaranForm.Show();
                }

                // Kolom Delete
                else if (dgvPengeluaran.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    var result = MessageBox.Show("Apakah Anda yakin ingin menghapus pengeluaran ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (var db = new MasjidDBDataContext())
                            {
                                int pengeluaranId = Convert.ToInt32(dgvPengeluaran.Rows[e.RowIndex].Cells["IdPengeluaran"].Value);
                                var pengeluaran = db.Pengeluarans.FirstOrDefault(p => p.IdPengeluaran == pengeluaranId);
                                if (pengeluaran != null)
                                {
                                    db.Pengeluarans.DeleteOnSubmit(pengeluaran);
                                    db.SubmitChanges();
                                    MessageBox.Show("Pengeluaran berhasil dihapus.");
                                    LoadPengeluaranData();
                                    UpdateTotalPengeluaran();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Terjadi kesalahan saat menghapus pengeluaran: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void cmbFilterBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tidak langsung menerapkan filter di sini, karena filter diterapkan saat tombol Search ditekan
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
            var keuanganForm = new KeuanganForm(username, currentUserId);
            keuanganForm.Show();
        }
    }
}