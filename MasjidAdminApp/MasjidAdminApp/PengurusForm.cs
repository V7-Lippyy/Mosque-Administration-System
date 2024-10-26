using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MasjidAdminApp
{
    public partial class PengurusForm : Form
    {
        private int currentUserId; // Simpan userId pengguna yang login
        private string username;    // Menyimpan username

        public PengurusForm(string username, int userId)
        {
            InitializeComponent();
            this.username = username; // Menyimpan username
            this.currentUserId = userId; // Menyimpan userId
        }

        private void PengurusForm_Load(object sender, EventArgs e)
        {
            LoadPengurusData();
            AddButtonColumns(); // Tambahkan kolom edit dan delete
            dgvPengurus.RowHeadersVisible = false;
            dgvPengurus.Columns["IdPengurus"].Width = 1; // atau sesuai kebutuhan
        }

        private void AddButtonColumns()
        {
            if (!dgvPengurus.Columns.Contains("EditColumn"))
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                {
                    Name = "EditColumn",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dgvPengurus.Columns.Add(editColumn);
            }

            if (!dgvPengurus.Columns.Contains("DeleteColumn"))
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "DeleteColumn",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dgvPengurus.Columns.Add(deleteColumn);
            }
        }

        private void LoadPengurusData()
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                var pengurusData = db.PengurusTables
                                     .Where(p => p.UserID == currentUserId)
                                     .Select(p => new
                                     {
                                         p.IdPengurus,
                                         p.NamaPengurus,
                                         p.JabatanPengurus,
                                         p.KontakPengurus,
                                         p.AlamatPengurus,
                                         p.UserID
                                     })
                                     .ToList();

                var dataWithIndex = pengurusData.Select((p, index) => new
                {
                    No = index + 1,
                    p.IdPengurus,
                    p.NamaPengurus,
                    p.JabatanPengurus,
                    p.KontakPengurus,
                    p.AlamatPengurus,
                    p.UserID
                }).ToList();

                dgvPengurus.DataSource = null;

                if (dgvPengurus.Columns.Contains("No"))
                {
                    dgvPengurus.Columns.Remove("No");
                }

                dgvPengurus.DataSource = dataWithIndex;

                if (!dgvPengurus.Columns.Contains("No"))
                {
                    DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "No",
                        HeaderText = "No",
                        ReadOnly = true,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                        DataPropertyName = "No"
                    };
                    dgvPengurus.Columns.Insert(0, noColumn);
                }

                if (!dgvPengurus.Columns.Contains("IdPengurus"))
                {
                    dgvPengurus.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "IdPengurus",
                        DataPropertyName = "IdPengurus",
                        Visible = false
                    });
                }

                if (dgvPengurus.Columns.Contains("UserID"))
                {
                    dgvPengurus.Columns["UserID"].Visible = false;
                }
            }

            AddButtonColumns();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            InputPengurusForm inputPengurusForm = new InputPengurusForm(currentUserId);
            inputPengurusForm.FormClosed += (s, args) => LoadPengurusData();
            inputPengurusForm.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                string jabatan = txtFilterJabatan.Text.Trim();
                var filteredData = db.PengurusTables
                                     .Where(p => p.UserID == currentUserId && p.JabatanPengurus.Contains(jabatan))
                                     .ToList();
                dgvPengurus.DataSource = filteredData;
            }
        }

        private void dgvPengurus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPengurus.Columns["EditColumn"].Index && e.RowIndex >= 0)
            {
                int pengurusId = Convert.ToInt32(dgvPengurus.Rows[e.RowIndex].Cells["IdPengurus"].Value);
                InputPengurusForm inputPengurusForm = new InputPengurusForm(pengurusId, currentUserId);
                inputPengurusForm.FormClosed += (s, args) => LoadPengurusData();
                inputPengurusForm.Show();
            }
            else if (e.ColumnIndex == dgvPengurus.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Apakah Anda yakin ingin menghapus pengurus ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (MasjidDBDataContext db = new MasjidDBDataContext())
                    {
                        int pengurusId = Convert.ToInt32(dgvPengurus.Rows[e.RowIndex].Cells["IdPengurus"].Value);
                        var pengurus = db.PengurusTables.FirstOrDefault(p => p.IdPengurus == pengurusId);
                        if (pengurus != null)
                        {
                            db.PengurusTables.DeleteOnSubmit(pengurus);
                            db.SubmitChanges();
                            LoadPengurusData();
                            MessageBox.Show("Data pengurus berhasil dihapus.");
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