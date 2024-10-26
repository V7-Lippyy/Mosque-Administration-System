namespace MasjidAdminApp
{
    partial class KegiatanForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotalKegiatan = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtFilterNamaKegiatan = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.kegiatanTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masjidDBDataSet9 = new MasjidAdminApp.MasjidDBDataSet9();
            this.kegiatanTableTableAdapter = new MasjidAdminApp.MasjidDBDataSet9TableAdapters.KegiatanTableTableAdapter();
            this.dgvKegiatan = new System.Windows.Forms.DataGridView();
            this.idKegiatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKegiatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalKegiatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penanggungJawabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kegiatanTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.masjidDBDataSet10 = new MasjidAdminApp.MasjidDBDataSet10();
            this.kegiatanTableTableAdapter1 = new MasjidAdminApp.MasjidDBDataSet10TableAdapters.KegiatanTableTableAdapter();
            this.btnKembali = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kegiatanTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKegiatan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kegiatanTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalKegiatan
            // 
            this.lblTotalKegiatan.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKegiatan.Location = new System.Drawing.Point(384, 631);
            this.lblTotalKegiatan.Name = "lblTotalKegiatan";
            this.lblTotalKegiatan.Size = new System.Drawing.Size(458, 38);
            this.lblTotalKegiatan.TabIndex = 18;
            this.lblTotalKegiatan.Text = "label1";
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Transparent;
            this.btnTambah.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Tambah_Kegiatan;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(205, 626);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(156, 44);
            this.btnTambah.TabIndex = 17;
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtFilterNamaKegiatan
            // 
            this.txtFilterNamaKegiatan.Location = new System.Drawing.Point(25, 108);
            this.txtFilterNamaKegiatan.Name = "txtFilterNamaKegiatan";
            this.txtFilterNamaKegiatan.Size = new System.Drawing.Size(149, 20);
            this.txtFilterNamaKegiatan.TabIndex = 16;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(180, 108);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(77, 20);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "Search";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // kegiatanTableBindingSource
            // 
            this.kegiatanTableBindingSource.DataMember = "KegiatanTable";
            this.kegiatanTableBindingSource.DataSource = this.masjidDBDataSet9;
            // 
            // masjidDBDataSet9
            // 
            this.masjidDBDataSet9.DataSetName = "MasjidDBDataSet9";
            this.masjidDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kegiatanTableTableAdapter
            // 
            this.kegiatanTableTableAdapter.ClearBeforeFill = true;
            // 
            // dgvKegiatan
            // 
            this.dgvKegiatan.AutoGenerateColumns = false;
            this.dgvKegiatan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKegiatan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKegiatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKegiatan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKegiatanDataGridViewTextBoxColumn,
            this.namaKegiatanDataGridViewTextBoxColumn,
            this.tanggalKegiatanDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn,
            this.penanggungJawabDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dgvKegiatan.DataSource = this.kegiatanTableBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKegiatan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKegiatan.Location = new System.Drawing.Point(25, 134);
            this.dgvKegiatan.Name = "dgvKegiatan";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKegiatan.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKegiatan.Size = new System.Drawing.Size(1209, 466);
            this.dgvKegiatan.TabIndex = 19;
            // 
            // idKegiatanDataGridViewTextBoxColumn
            // 
            this.idKegiatanDataGridViewTextBoxColumn.DataPropertyName = "IdKegiatan";
            this.idKegiatanDataGridViewTextBoxColumn.HeaderText = "IdKegiatan";
            this.idKegiatanDataGridViewTextBoxColumn.Name = "idKegiatanDataGridViewTextBoxColumn";
            this.idKegiatanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaKegiatanDataGridViewTextBoxColumn
            // 
            this.namaKegiatanDataGridViewTextBoxColumn.DataPropertyName = "NamaKegiatan";
            this.namaKegiatanDataGridViewTextBoxColumn.HeaderText = "NamaKegiatan";
            this.namaKegiatanDataGridViewTextBoxColumn.Name = "namaKegiatanDataGridViewTextBoxColumn";
            // 
            // tanggalKegiatanDataGridViewTextBoxColumn
            // 
            this.tanggalKegiatanDataGridViewTextBoxColumn.DataPropertyName = "TanggalKegiatan";
            this.tanggalKegiatanDataGridViewTextBoxColumn.HeaderText = "TanggalKegiatan";
            this.tanggalKegiatanDataGridViewTextBoxColumn.Name = "tanggalKegiatanDataGridViewTextBoxColumn";
            // 
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            // 
            // penanggungJawabDataGridViewTextBoxColumn
            // 
            this.penanggungJawabDataGridViewTextBoxColumn.DataPropertyName = "PenanggungJawab";
            this.penanggungJawabDataGridViewTextBoxColumn.HeaderText = "PenanggungJawab";
            this.penanggungJawabDataGridViewTextBoxColumn.Name = "penanggungJawabDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // kegiatanTableBindingSource1
            // 
            this.kegiatanTableBindingSource1.DataMember = "KegiatanTable";
            this.kegiatanTableBindingSource1.DataSource = this.masjidDBDataSet10;
            // 
            // masjidDBDataSet10
            // 
            this.masjidDBDataSet10.DataSetName = "MasjidDBDataSet10";
            this.masjidDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kegiatanTableTableAdapter1
            // 
            this.kegiatanTableTableAdapter1.ClearBeforeFill = true;
            // 
            // btnKembali
            // 
            this.btnKembali.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Kembali;
            this.btnKembali.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Location = new System.Drawing.Point(12, 627);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(154, 42);
            this.btnKembali.TabIndex = 20;
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Tabel_Kegiatan_Masjid;
            this.pictureBox1.Location = new System.Drawing.Point(350, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 42);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // KegiatanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MasjidAdminApp.Properties.Resources.BackgroundApp;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.dgvKegiatan);
            this.Controls.Add(this.lblTotalKegiatan);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtFilterNamaKegiatan);
            this.Controls.Add(this.btnFilter);
            this.Name = "KegiatanForm";
            this.Text = "KegiatanForm";
            this.Load += new System.EventHandler(this.KegiatanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kegiatanTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKegiatan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kegiatanTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalKegiatan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtFilterNamaKegiatan;
        private System.Windows.Forms.Button btnFilter;
        private MasjidDBDataSet9 masjidDBDataSet9;
        private System.Windows.Forms.BindingSource kegiatanTableBindingSource;
        private MasjidDBDataSet9TableAdapters.KegiatanTableTableAdapter kegiatanTableTableAdapter;
        private System.Windows.Forms.DataGridView dgvKegiatan;
        private MasjidDBDataSet10 masjidDBDataSet10;
        private System.Windows.Forms.BindingSource kegiatanTableBindingSource1;
        private MasjidDBDataSet10TableAdapters.KegiatanTableTableAdapter kegiatanTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKegiatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKegiatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalKegiatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penanggungJawabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}