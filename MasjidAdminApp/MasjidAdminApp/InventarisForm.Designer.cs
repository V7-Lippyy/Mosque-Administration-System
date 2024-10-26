namespace MasjidAdminApp
{
    partial class InventarisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.masjidDBDataSet7 = new MasjidAdminApp.MasjidDBDataSet7();
            this.inventarisTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarisTableTableAdapter = new MasjidAdminApp.MasjidDBDataSet7TableAdapters.InventarisTableTableAdapter();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtFilterNamaBarang = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvInventaris = new System.Windows.Forms.DataGridView();
            this.idBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalPembelianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalBarang = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarisTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventaris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // masjidDBDataSet7
            // 
            this.masjidDBDataSet7.DataSetName = "MasjidDBDataSet7";
            this.masjidDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarisTableBindingSource
            // 
            this.inventarisTableBindingSource.DataMember = "InventarisTable";
            this.inventarisTableBindingSource.DataSource = this.masjidDBDataSet7;
            // 
            // inventarisTableTableAdapter
            // 
            this.inventarisTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Transparent;
            this.btnTambah.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Tambah_Inventaris;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(205, 626);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(156, 44);
            this.btnTambah.TabIndex = 12;
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtFilterNamaBarang
            // 
            this.txtFilterNamaBarang.Location = new System.Drawing.Point(25, 108);
            this.txtFilterNamaBarang.Name = "txtFilterNamaBarang";
            this.txtFilterNamaBarang.Size = new System.Drawing.Size(149, 20);
            this.txtFilterNamaBarang.TabIndex = 11;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(180, 108);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(77, 20);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Search";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvInventaris
            // 
            this.dgvInventaris.AutoGenerateColumns = false;
            this.dgvInventaris.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventaris.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInventaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventaris.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.kategoriBarangDataGridViewTextBoxColumn,
            this.tanggalPembelianDataGridViewTextBoxColumn,
            this.jumlahDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dgvInventaris.DataSource = this.inventarisTableBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventaris.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventaris.Location = new System.Drawing.Point(25, 134);
            this.dgvInventaris.Name = "dgvInventaris";
            this.dgvInventaris.Size = new System.Drawing.Size(1209, 466);
            this.dgvInventaris.TabIndex = 9;
            // 
            // idBarangDataGridViewTextBoxColumn
            // 
            this.idBarangDataGridViewTextBoxColumn.DataPropertyName = "IdBarang";
            this.idBarangDataGridViewTextBoxColumn.HeaderText = "IdBarang";
            this.idBarangDataGridViewTextBoxColumn.Name = "idBarangDataGridViewTextBoxColumn";
            this.idBarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "NamaBarang";
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            // 
            // kategoriBarangDataGridViewTextBoxColumn
            // 
            this.kategoriBarangDataGridViewTextBoxColumn.DataPropertyName = "KategoriBarang";
            this.kategoriBarangDataGridViewTextBoxColumn.HeaderText = "KategoriBarang";
            this.kategoriBarangDataGridViewTextBoxColumn.Name = "kategoriBarangDataGridViewTextBoxColumn";
            // 
            // tanggalPembelianDataGridViewTextBoxColumn
            // 
            this.tanggalPembelianDataGridViewTextBoxColumn.DataPropertyName = "TanggalPembelian";
            this.tanggalPembelianDataGridViewTextBoxColumn.HeaderText = "TanggalPembelian";
            this.tanggalPembelianDataGridViewTextBoxColumn.Name = "tanggalPembelianDataGridViewTextBoxColumn";
            // 
            // jumlahDataGridViewTextBoxColumn
            // 
            this.jumlahDataGridViewTextBoxColumn.DataPropertyName = "Jumlah";
            this.jumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah";
            this.jumlahDataGridViewTextBoxColumn.Name = "jumlahDataGridViewTextBoxColumn";
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // lblTotalBarang
            // 
            this.lblTotalBarang.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBarang.Location = new System.Drawing.Point(384, 615);
            this.lblTotalBarang.Name = "lblTotalBarang";
            this.lblTotalBarang.Size = new System.Drawing.Size(496, 57);
            this.lblTotalBarang.TabIndex = 13;
            this.lblTotalBarang.Text = "label1";
            // 
            // btnKembali
            // 
            this.btnKembali.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Kembali;
            this.btnKembali.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Location = new System.Drawing.Point(12, 627);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(154, 42);
            this.btnKembali.TabIndex = 21;
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Tabel_Inventaris;
            this.pictureBox1.Location = new System.Drawing.Point(350, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 42);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // InventarisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MasjidAdminApp.Properties.Resources.BackgroundApp;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblTotalBarang);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtFilterNamaBarang);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvInventaris);
            this.Name = "InventarisForm";
            this.Text = "InventarisForm";
            this.Load += new System.EventHandler(this.InventarisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarisTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventaris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MasjidDBDataSet7 masjidDBDataSet7;
        private System.Windows.Forms.BindingSource inventarisTableBindingSource;
        private MasjidDBDataSet7TableAdapters.InventarisTableTableAdapter inventarisTableTableAdapter;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtFilterNamaBarang;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvInventaris;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalPembelianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTotalBarang;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}