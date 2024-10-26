using System;
using System.Linq;
using System.Windows.Forms;

namespace MasjidAdminApp
{
    public partial class InventarisForm : Form
    {
        private int currentUserId;
        private string username; // Menyimpan username pengguna yang login

        public InventarisForm(string username, int userId) // Tambahkan username sebagai parameter
        {
            InitializeComponent();
            this.username = username; // Simpan username
            currentUserId = userId;
        }

        private void InventarisForm_Load(object sender, EventArgs e)
        {
            LoadInventarisData();
            UpdateTotalBarang();
            dgvInventaris.RowHeadersVisible = false;

            // Tambahkan event handler untuk tombol Edit dan Delete
            dgvInventaris.CellClick += dgvInventaris_CellClick;
        }

        private void LoadInventarisData()
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                var inventarisData = db.InventarisTables
                                       .Where(i => i.UserID == currentUserId)
                                       .Select(i => new
                                       {
                                           i.IdBarang,
                                           i.NamaBarang,
                                           i.KategoriBarang,
                                           i.Jumlah,
                                           i.TanggalPembelian,
                                           i.Keterangan,
                                           i.UserID
                                       })
                                       .ToList();

                var dataWithIndex = inventarisData.Select((i, index) => new
                {
                    No = index + 1,
                    i.IdBarang,
                    i.NamaBarang,
                    i.KategoriBarang,
                    i.Jumlah,
                    i.TanggalPembelian,
                    i.Keterangan,
                    i.UserID
                }).ToList();

                dgvInventaris.DataSource = null; // Reset DataGridView
                dgvInventaris.DataSource = dataWithIndex;

                // Pastikan kolom No hanya ditambahkan sekali
                if (!dgvInventaris.Columns.Contains("No"))
                {
                    DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        HeaderText = "No",
                        ReadOnly = true,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                        DataPropertyName = "No"
                    };
                    dgvInventaris.Columns.Insert(0, noColumn); // Tambahkan kolom di urutan pertama
                }

                // Pastikan kolom IdBarang tidak ditampilkan (disembunyikan)
                if (!dgvInventaris.Columns.Contains("IdBarang"))
                {
                    DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "IdBarang",
                        DataPropertyName = "IdBarang",
                        HeaderText = "ID Barang",
                        Visible = false
                    };
                    dgvInventaris.Columns.Add(idColumn);
                }

                // Tidak perlu menambahkan kolom UserID lagi karena sudah ada

                // Tambah kolom tombol Edit dan Delete hanya jika belum ada
                AddButtonColumns();
            }
        }

        private void AddButtonColumns()
        {
            if (!dgvInventaris.Columns.Contains("EditColumn"))
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                {
                    Name = "EditColumn",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dgvInventaris.Columns.Add(editColumn);
            }

            if (!dgvInventaris.Columns.Contains("DeleteColumn"))
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "DeleteColumn",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dgvInventaris.Columns.Add(deleteColumn);
            }
        }

        private void UpdateTotalBarang()
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                var totalBarang = db.InventarisTables
                                    .Where(i => i.UserID == currentUserId)
                                    .GroupBy(i => i.NamaBarang)
                                    .Select(g => new
                                    {
                                        NamaBarang = g.Key,
                                        Total = g.Sum(i => i.Jumlah)
                                    }).ToList();

                lblTotalBarang.Text = "Total Barang:\n" +
                                      string.Join("\n", totalBarang.Select(b => $"{b.NamaBarang}: {b.Total}"));
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            InputInventarisForm inputInventarisForm = new InputInventarisForm(currentUserId);
            inputInventarisForm.FormClosed += (s, args) =>
            {
                LoadInventarisData();
                UpdateTotalBarang();
            };
            inputInventarisForm.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                string namaBarang = txtFilterNamaBarang.Text.Trim();
                var filteredData = db.InventarisTables
                                     .Where(i => i.UserID == currentUserId && i.NamaBarang.Contains(namaBarang))
                                     .Select(i => new
                                     {
                                         i.IdBarang,
                                         i.NamaBarang,
                                         i.KategoriBarang,
                                         i.Jumlah,
                                         i.TanggalPembelian,
                                         i.Keterangan
                                     })
                                     .ToList();

                dgvInventaris.DataSource = filteredData;
            }
        }

        private void dgvInventaris_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idBarang = (int)dgvInventaris.Rows[e.RowIndex].Cells["IdBarang"].Value;

                // Jika tombol "Edit" diklik
                if (e.ColumnIndex == dgvInventaris.Columns["EditColumn"].Index)
                {
                    InputInventarisForm editForm = new InputInventarisForm(idBarang, currentUserId);
                    editForm.FormClosed += (s, args) =>
                    {
                        LoadInventarisData();
                        UpdateTotalBarang();
                    };
                    editForm.Show();
                }

                // Jika tombol "Delete" diklik
                if (e.ColumnIndex == dgvInventaris.Columns["DeleteColumn"].Index)
                {
                    var result = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (MasjidDBDataContext db = new MasjidDBDataContext())
                        {
                            var inventaris = db.InventarisTables.FirstOrDefault(i => i.IdBarang == idBarang);
                            if (inventaris != null)
                            {
                                db.InventarisTables.DeleteOnSubmit(inventaris);
                                db.SubmitChanges();
                                LoadInventarisData();
                                UpdateTotalBarang();
                            }
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