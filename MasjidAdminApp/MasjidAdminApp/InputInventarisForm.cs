using System;
using System.Linq;
using System.Windows.Forms;

namespace MasjidAdminApp
{
    public partial class InputInventarisForm : Form
    {
        private int currentUserID;
        private int? inventarisId;

        public InputInventarisForm(int userID)
        {
            InitializeComponent();
            currentUserID = userID;
            btnSimpans.Click += new EventHandler(btnSimpans_Click);
        }

        public InputInventarisForm(int inventarisId, int userID) : this(userID)
        {
            this.inventarisId = inventarisId;
            LoadInventarisData(inventarisId);
        }

        private void LoadInventarisData(int inventarisId)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                var inventaris = db.InventarisTables.FirstOrDefault(i => i.IdBarang == inventarisId);
                if (inventaris != null)
                {
                    txtNamaBarangs.Text = inventaris.NamaBarang;
                    txtKategoriBarangs.Text = inventaris.KategoriBarang;
                    txtJumlahBarangs.Text = inventaris.Jumlah.ToString();
                    txtKeteranganTambahans.Text = inventaris.Keterangan;
                    dtpTanggalWaktuPembelians.Value = inventaris.TanggalPembelian;
                }
            }
        }

        private void btnSimpans_Click(object sender, EventArgs e)
        {
            using (MasjidDBDataContext db = new MasjidDBDataContext())
            {
                int jumlahBarang;

                // Bersihkan input dari karakter yang bukan angka
                string jumlahBarangText = new string(txtJumlahBarangs.Text.Where(c => char.IsDigit(c)).ToArray());

                // Menggunakan int.TryParse setelah membersihkan input
                if (!int.TryParse(jumlahBarangText, out jumlahBarang))
                {
                    // Jika parsing gagal, jumlahBarang di-set ke 0, atau berikan notifikasi ke pengguna
                    
                    return; // Keluar dari metode jika parsing gagal
                }

                if (inventarisId.HasValue)
                {
                    var inventaris = db.InventarisTables.FirstOrDefault(i => i.IdBarang == inventarisId.Value);
                    if (inventaris != null)
                    {
                        inventaris.NamaBarang = txtNamaBarangs.Text;
                        inventaris.KategoriBarang = txtKategoriBarangs.Text;
                        inventaris.Jumlah = jumlahBarang;
                        inventaris.TanggalPembelian = dtpTanggalWaktuPembelians.Value;
                        inventaris.Keterangan = txtKeteranganTambahans.Text;
                    }
                }
                else
                {
                    InventarisTable inventarisBaru = new InventarisTable
                    {
                        NamaBarang = txtNamaBarangs.Text,
                        KategoriBarang = txtKategoriBarangs.Text,
                        Jumlah = jumlahBarang,
                        TanggalPembelian = dtpTanggalWaktuPembelians.Value,
                        Keterangan = txtKeteranganTambahans.Text,
                        UserID = currentUserID
                    };

                    db.InventarisTables.InsertOnSubmit(inventarisBaru);
                }

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Data inventaris berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void InputInventarisForm_Load(object sender, EventArgs e) { }

        private void txtNamaBarangs_TextChanged(object sender, EventArgs e) { }

        private void txtKategoriBarangs_TextChanged(object sender, EventArgs e) { }

        private void txtJumlahBarangs_TextChanged(object sender, EventArgs e) { }

        private void txtKeteranganTambahans_TextChanged(object sender, EventArgs e) { }

        private void dtpTanggalWaktuPembelians_ValueChanged(object sender, EventArgs e) { }
    }
}