namespace MasjidAdminApp
{
    partial class PemasukanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PemasukanForm));
            this.dgvPemasukan = new System.Windows.Forms.DataGridView();
            this.idPemasukanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalWaktuPemasukanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumberPemasukanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDonaturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahPemasukanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganTambahanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pemasukanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masjidDBDataSet4 = new MasjidAdminApp.MasjidDBDataSet4();
            this.pemasukanTableAdapter = new MasjidAdminApp.MasjidDBDataSet4TableAdapters.PemasukanTableAdapter();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilterSumber = new System.Windows.Forms.TextBox();
            this.lblTotalPemasukan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.cmbFilterBulan = new System.Windows.Forms.ComboBox();
            this.masjidDBDataSet11 = new MasjidAdminApp.MasjidDBDataSet11();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableTableAdapter = new MasjidAdminApp.MasjidDBDataSet11TableAdapters.UserTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPemasukan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemasukanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPemasukan
            // 
            this.dgvPemasukan.AutoGenerateColumns = false;
            this.dgvPemasukan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPemasukan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPemasukan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPemasukan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPemasukanDataGridViewTextBoxColumn,
            this.tanggalWaktuPemasukanDataGridViewTextBoxColumn,
            this.sumberPemasukanDataGridViewTextBoxColumn,
            this.namaDonaturDataGridViewTextBoxColumn,
            this.jumlahPemasukanDataGridViewTextBoxColumn,
            this.keteranganTambahanDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dgvPemasukan.DataSource = this.pemasukanBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPemasukan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPemasukan.Location = new System.Drawing.Point(25, 134);
            this.dgvPemasukan.Name = "dgvPemasukan";
            this.dgvPemasukan.Size = new System.Drawing.Size(1209, 466);
            this.dgvPemasukan.TabIndex = 0;
            this.dgvPemasukan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPemasukan_CellContentClick);
            // 
            // idPemasukanDataGridViewTextBoxColumn
            // 
            this.idPemasukanDataGridViewTextBoxColumn.DataPropertyName = "IdPemasukan";
            this.idPemasukanDataGridViewTextBoxColumn.FillWeight = 60.03431F;
            this.idPemasukanDataGridViewTextBoxColumn.HeaderText = "IdPemasukan";
            this.idPemasukanDataGridViewTextBoxColumn.Name = "idPemasukanDataGridViewTextBoxColumn";
            this.idPemasukanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanggalWaktuPemasukanDataGridViewTextBoxColumn
            // 
            this.tanggalWaktuPemasukanDataGridViewTextBoxColumn.DataPropertyName = "TanggalWaktuPemasukan";
            this.tanggalWaktuPemasukanDataGridViewTextBoxColumn.FillWeight = 75.36962F;
            this.tanggalWaktuPemasukanDataGridViewTextBoxColumn.HeaderText = "TanggalWaktuPemasukan";
            this.tanggalWaktuPemasukanDataGridViewTextBoxColumn.Name = "tanggalWaktuPemasukanDataGridViewTextBoxColumn";
            // 
            // sumberPemasukanDataGridViewTextBoxColumn
            // 
            this.sumberPemasukanDataGridViewTextBoxColumn.DataPropertyName = "SumberPemasukan";
            this.sumberPemasukanDataGridViewTextBoxColumn.FillWeight = 89.38973F;
            this.sumberPemasukanDataGridViewTextBoxColumn.HeaderText = "SumberPemasukan";
            this.sumberPemasukanDataGridViewTextBoxColumn.Name = "sumberPemasukanDataGridViewTextBoxColumn";
            // 
            // namaDonaturDataGridViewTextBoxColumn
            // 
            this.namaDonaturDataGridViewTextBoxColumn.DataPropertyName = "NamaDonatur";
            this.namaDonaturDataGridViewTextBoxColumn.FillWeight = 102.2074F;
            this.namaDonaturDataGridViewTextBoxColumn.HeaderText = "NamaDonatur";
            this.namaDonaturDataGridViewTextBoxColumn.Name = "namaDonaturDataGridViewTextBoxColumn";
            // 
            // jumlahPemasukanDataGridViewTextBoxColumn
            // 
            this.jumlahPemasukanDataGridViewTextBoxColumn.DataPropertyName = "JumlahPemasukan";
            this.jumlahPemasukanDataGridViewTextBoxColumn.FillWeight = 113.9258F;
            this.jumlahPemasukanDataGridViewTextBoxColumn.HeaderText = "JumlahPemasukan";
            this.jumlahPemasukanDataGridViewTextBoxColumn.Name = "jumlahPemasukanDataGridViewTextBoxColumn";
            // 
            // keteranganTambahanDataGridViewTextBoxColumn
            // 
            this.keteranganTambahanDataGridViewTextBoxColumn.DataPropertyName = "KeteranganTambahan";
            this.keteranganTambahanDataGridViewTextBoxColumn.FillWeight = 124.6393F;
            this.keteranganTambahanDataGridViewTextBoxColumn.HeaderText = "KeteranganTambahan";
            this.keteranganTambahanDataGridViewTextBoxColumn.Name = "keteranganTambahanDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.FillWeight = 134.4338F;
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // pemasukanBindingSource
            // 
            this.pemasukanBindingSource.DataMember = "Pemasukan";
            this.pemasukanBindingSource.DataSource = this.masjidDBDataSet4;
            // 
            // masjidDBDataSet4
            // 
            this.masjidDBDataSet4.DataSetName = "MasjidDBDataSet4";
            this.masjidDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pemasukanTableAdapter
            // 
            this.pemasukanTableAdapter.ClearBeforeFill = true;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.White;
            this.btnTambah.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Tambah_Pemasukan;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(205, 626);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(154, 42);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(255, 108);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(77, 20);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Search";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterSumber
            // 
            this.txtFilterSumber.Location = new System.Drawing.Point(25, 108);
            this.txtFilterSumber.Name = "txtFilterSumber";
            this.txtFilterSumber.Size = new System.Drawing.Size(116, 20);
            this.txtFilterSumber.TabIndex = 5;
            // 
            // lblTotalPemasukan
            // 
            this.lblTotalPemasukan.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPemasukan.Location = new System.Drawing.Point(384, 631);
            this.lblTotalPemasukan.Name = "lblTotalPemasukan";
            this.lblTotalPemasukan.Size = new System.Drawing.Size(458, 27);
            this.lblTotalPemasukan.TabIndex = 6;
            this.lblTotalPemasukan.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Table_Pemasukan;
            this.pictureBox1.Location = new System.Drawing.Point(350, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 42);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnKembali
            // 
            this.btnKembali.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Kembali;
            this.btnKembali.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Location = new System.Drawing.Point(25, 627);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(154, 42);
            this.btnKembali.TabIndex = 18;
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // cmbFilterBulan
            // 
            this.cmbFilterBulan.FormattingEnabled = true;
            this.cmbFilterBulan.Location = new System.Drawing.Point(147, 107);
            this.cmbFilterBulan.Name = "cmbFilterBulan";
            this.cmbFilterBulan.Size = new System.Drawing.Size(92, 21);
            this.cmbFilterBulan.TabIndex = 19;
            // 
            // masjidDBDataSet11
            // 
            this.masjidDBDataSet11.DataSetName = "MasjidDBDataSet11";
            this.masjidDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "UserTable";
            this.userTableBindingSource.DataSource = this.masjidDBDataSet11;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // PemasukanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.cmbFilterBulan);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotalPemasukan);
            this.Controls.Add(this.txtFilterSumber);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvPemasukan);
            this.Name = "PemasukanForm";
            this.Text = "PemasukanForm";
            this.Load += new System.EventHandler(this.PemasukanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPemasukan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemasukanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPemasukan;
        private MasjidDBDataSet4 masjidDBDataSet4;
        private System.Windows.Forms.BindingSource pemasukanBindingSource;
        private MasjidDBDataSet4TableAdapters.PemasukanTableAdapter pemasukanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPemasukanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalWaktuPemasukanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumberPemasukanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDonaturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahPemasukanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganTambahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilterSumber;
        private System.Windows.Forms.Label lblTotalPemasukan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.ComboBox cmbFilterBulan;
        private MasjidDBDataSet11 masjidDBDataSet11;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private MasjidDBDataSet11TableAdapters.UserTableTableAdapter userTableTableAdapter;
    }
}