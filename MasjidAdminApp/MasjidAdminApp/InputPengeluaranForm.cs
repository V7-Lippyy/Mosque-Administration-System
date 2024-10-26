using System;
using System.Linq;
using System.Windows.Forms;

namespace MasjidAdminApp
{
    public partial class InputPengeluaranForm : Form
    {
        private int currentUserID;
        private int? pengeluaranId = null;

        // Constructor untuk tambah pengeluaran
        public InputPengeluaranForm(int userID)
        {
            InitializeComponent();
            currentUserID = userID;
            btnSimpan.Click += new EventHandler(btnSimpan_Click);
        }

        // Constructor untuk edit pengeluaran
        public InputPengeluaranForm(int pengeluaranId, int userID) : this(userID)
        {
            this.pengeluaranId = pengeluaranId;
            LoadPengeluaranData(pengeluaranId);
        }

        private void LoadPengeluaranData(int pengeluaranId)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                var pengeluaran = db.Pengeluarans.FirstOrDefault(p => p.IdPengeluaran == pengeluaranId);
                if (pengeluaran != null)
                {
                    txtKategoriPengeluaran.Text = pengeluaran.KategoriPengeluaran;
                    txtJumlahPengeluaran.Text = pengeluaran.JumlahPengeluaran.ToString();
                    txtKeteranganTambahan.Text = pengeluaran.KeteranganTambahan;
                    dtpTanggalWaktuPengeluaran.Value = pengeluaran.TanggalWaktuPengeluaran;
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                decimal jumlahPengeluaran;

                if (!decimal.TryParse(txtJumlahPengeluaran.Text, out jumlahPengeluaran))
                {
                    MessageBox.Show("Jumlah pengeluaran harus berupa angka yang valid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (pengeluaranId.HasValue)
                {
                    // Update data pengeluaran
                    var pengeluaran = db.Pengeluarans.FirstOrDefault(p => p.IdPengeluaran == pengeluaranId.Value);
                    if (pengeluaran != null)
                    {
                        pengeluaran.KategoriPengeluaran = txtKategoriPengeluaran.Text;
                        pengeluaran.JumlahPengeluaran = jumlahPengeluaran;
                        pengeluaran.KeteranganTambahan = txtKeteranganTambahan.Text;
                        pengeluaran.TanggalWaktuPengeluaran = dtpTanggalWaktuPengeluaran.Value;
                    }
                }
                else
                {
                    // Tambah data pengeluaran baru
                    Pengeluaran pengeluaranBaru = new Pengeluaran
                    {
                        KategoriPengeluaran = txtKategoriPengeluaran.Text,
                        JumlahPengeluaran = jumlahPengeluaran,
                        KeteranganTambahan = txtKeteranganTambahan.Text,
                        TanggalWaktuPengeluaran = dtpTanggalWaktuPengeluaran.Value,
                        UserID = currentUserID
                    };

                    db.Pengeluarans.InsertOnSubmit(pengeluaranBaru);
                }

                try
                {
                    db.SubmitChanges();

                    DialogResult result = MessageBox.Show("Data pengeluaran berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InputPengeluaranForm_Load(object sender, EventArgs e)
        {

        }

        private void txtJumlahPengeluaran_TextChanged(object sender, EventArgs e)
        {

        }
    }
}