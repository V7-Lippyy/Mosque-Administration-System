namespace MasjidAdminApp
{
    partial class PengeluaranForm
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
            this.pengeluaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masjidDBDataSet5 = new MasjidAdminApp.MasjidDBDataSet5();
            this.pengeluaranTableAdapter = new MasjidAdminApp.MasjidDBDataSet5TableAdapters.PengeluaranTableAdapter();
            this.txtFilterSumber = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblTotalPengeluaran = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvPengeluaran = new System.Windows.Forms.DataGridView();
            this.idPengeluaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalWaktuPengeluaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriPengeluaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahPengeluaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganTambahanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengeluaranBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.masjidDBDataSet6 = new MasjidAdminApp.MasjidDBDataSet6();
            this.pengeluaranTableAdapter1 = new MasjidAdminApp.MasjidDBDataSet6TableAdapters.PengeluaranTableAdapter();
            this.btnKembali = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbFilterBulan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pengeluaranBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengeluaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengeluaranBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pengeluaranBindingSource
            // 
            this.pengeluaranBindingSource.DataMember = "Pengeluaran";
            this.pengeluaranBindingSource.DataSource = this.masjidDBDataSet5;
            // 
            // masjidDBDataSet5
            // 
            this.masjidDBDataSet5.DataSetName = "MasjidDBDataSet5";
            this.masjidDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pengeluaranTableAdapter
            // 
            this.pengeluaranTableAdapter.ClearBeforeFill = true;
            // 
            // txtFilterSumber
            // 
            this.txtFilterSumber.Location = new System.Drawing.Point(25, 108);
            this.txtFilterSumber.Name = "txtFilterSumber";
            this.txtFilterSumber.Size = new System.Drawing.Size(116, 20);
            this.txtFilterSumber.TabIndex = 7;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(255, 108);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(77, 20);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Search";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // lblTotalPengeluaran
            // 
            this.lblTotalPengeluaran.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPengeluaran.Location = new System.Drawing.Point(384, 631);
            this.lblTotalPengeluaran.Name = "lblTotalPengeluaran";
            this.lblTotalPengeluaran.Size = new System.Drawing.Size(458, 27);
            this.lblTotalPengeluaran.TabIndex = 9;
            this.lblTotalPengeluaran.Text = "label1";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Transparent;
            this.btnTambah.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Tambah_Pengeluaran__154_x_42_piksel_;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(205, 626);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(156, 44);
            this.btnTambah.TabIndex = 8;
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // dgvPengeluaran
            // 
            this.dgvPengeluaran.AutoGenerateColumns = false;
            this.dgvPengeluaran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPengeluaran.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPengeluaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengeluaran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPengeluaranDataGridViewTextBoxColumn,
            this.tanggalWaktuPengeluaranDataGridViewTextBoxColumn,
            this.kategoriPengeluaranDataGridViewTextBoxColumn,
            this.jumlahPengeluaranDataGridViewTextBoxColumn,
            this.keteranganTambahanDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dgvPengeluaran.DataSource = this.pengeluaranBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPengeluaran.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPengeluaran.Location = new System.Drawing.Point(25, 134);
            this.dgvPengeluaran.Name = "dgvPengeluaran";
            this.dgvPengeluaran.Size = new System.Drawing.Size(1209, 466);
            this.dgvPengeluaran.TabIndex = 10;
            // 
            // idPengeluaranDataGridViewTextBoxColumn
            // 
            this.idPengeluaranDataGridViewTextBoxColumn.DataPropertyName = "IdPengeluaran";
            this.idPengeluaranDataGridViewTextBoxColumn.HeaderText = "IdPengeluaran";
            this.idPengeluaranDataGridViewTextBoxColumn.Name = "idPengeluaranDataGridViewTextBoxColumn";
            this.idPengeluaranDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanggalWaktuPengeluaranDataGridViewTextBoxColumn
            // 
            this.tanggalWaktuPengeluaranDataGridViewTextBoxColumn.DataPropertyName = "TanggalWaktuPengeluaran";
            this.tanggalWaktuPengeluaranDataGridViewTextBoxColumn.HeaderText = "TanggalWaktuPengeluaran";
            this.tanggalWaktuPengeluaranDataGridViewTextBoxColumn.Name = "tanggalWaktuPengeluaranDataGridViewTextBoxColumn";
            // 
            // kategoriPengeluaranDataGridViewTextBoxColumn
            // 
            this.kategoriPengeluaranDataGridViewTextBoxColumn.DataPropertyName = "KategoriPengeluaran";
            this.kategoriPengeluaranDataGridViewTextBoxColumn.HeaderText = "KategoriPengeluaran";
            this.kategoriPengeluaranDataGridViewTextBoxColumn.Name = "kategoriPengeluaranDataGridViewTextBoxColumn";
            // 
            // jumlahPengeluaranDataGridViewTextBoxColumn
            // 
            this.jumlahPengeluaranDataGridViewTextBoxColumn.DataPropertyName = "JumlahPengeluaran";
            this.jumlahPengeluaranDataGridViewTextBoxColumn.HeaderText = "JumlahPengeluaran";
            this.jumlahPengeluaranDataGridViewTextBoxColumn.Name = "jumlahPengeluaranDataGridViewTextBoxColumn";
            // 
            // keteranganTambahanDataGridViewTextBoxColumn
            // 
            this.keteranganTambahanDataGridViewTextBoxColumn.DataPropertyName = "KeteranganTambahan";
            this.keteranganTambahanDataGridViewTextBoxColumn.HeaderText = "KeteranganTambahan";
            this.keteranganTambahanDataGridViewTextBoxColumn.Name = "keteranganTambahanDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // pengeluaranBindingSource1
            // 
            this.pengeluaranBindingSource1.DataMember = "Pengeluaran";
            this.pengeluaranBindingSource1.DataSource = this.masjidDBDataSet6;
            // 
            // masjidDBDataSet6
            // 
            this.masjidDBDataSet6.DataSetName = "MasjidDBDataSet6";
            this.masjidDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pengeluaranTableAdapter1
            // 
            this.pengeluaranTableAdapter1.ClearBeforeFill = true;
            // 
            // btnKembali
            // 
            this.btnKembali.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Kembali;
            this.btnKembali.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Location = new System.Drawing.Point(25, 627);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(154, 42);
            this.btnKembali.TabIndex = 19;
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Tabel_Pengeluaran;
            this.pictureBox1.Location = new System.Drawing.Point(350, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 42);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // cmbFilterBulan
            // 
            this.cmbFilterBulan.FormattingEnabled = true;
            this.cmbFilterBulan.Location = new System.Drawing.Point(147, 107);
            this.cmbFilterBulan.Name = "cmbFilterBulan";
            this.cmbFilterBulan.Size = new System.Drawing.Size(92, 21);
            this.cmbFilterBulan.TabIndex = 21;
            this.cmbFilterBulan.SelectedIndexChanged += new System.EventHandler(this.cmbFilterBulan_SelectedIndexChanged);
            // 
            // PengeluaranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MasjidAdminApp.Properties.Resources.BackgroundApp;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.cmbFilterBulan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.dgvPengeluaran);
            this.Controls.Add(this.lblTotalPengeluaran);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtFilterSumber);
            this.Controls.Add(this.btnFilter);
            this.Name = "PengeluaranForm";
            this.Text = "PengeluaranForm";
            this.Load += new System.EventHandler(this.PengeluaranForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pengeluaranBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengeluaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengeluaranBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MasjidDBDataSet5 masjidDBDataSet5;
        private System.Windows.Forms.BindingSource pengeluaranBindingSource;
        private MasjidDBDataSet5TableAdapters.PengeluaranTableAdapter pengeluaranTableAdapter;
        private System.Windows.Forms.TextBox txtFilterSumber;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblTotalPengeluaran;
        private System.Windows.Forms.Button btnTambah;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvPengeluaran;
        private MasjidDBDataSet6 masjidDBDataSet6;
        private System.Windows.Forms.BindingSource pengeluaranBindingSource1;
        private MasjidDBDataSet6TableAdapters.PengeluaranTableAdapter pengeluaranTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPengeluaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalWaktuPengeluaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriPengeluaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahPengeluaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganTambahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbFilterBulan;
    }
}