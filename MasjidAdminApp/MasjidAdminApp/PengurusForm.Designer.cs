namespace MasjidAdminApp
{
    partial class PengurusForm
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
            this.dgvPengurus = new System.Windows.Forms.DataGridView();
            this.idPengurusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPengurusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatanPengurusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontakPengurusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatPengurusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengurusTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masjidDBDataSet3 = new MasjidAdminApp.MasjidDBDataSet3();
            this.pengurusTableTableAdapter = new MasjidAdminApp.MasjidDBDataSet3TableAdapters.PengurusTableTableAdapter();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFilterJabatan = new System.Windows.Forms.TextBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengurus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengurusTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPengurus
            // 
            this.dgvPengurus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPengurus.AutoGenerateColumns = false;
            this.dgvPengurus.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPengurus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPengurus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengurus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPengurusDataGridViewTextBoxColumn,
            this.namaPengurusDataGridViewTextBoxColumn,
            this.jabatanPengurusDataGridViewTextBoxColumn,
            this.kontakPengurusDataGridViewTextBoxColumn,
            this.alamatPengurusDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dgvPengurus.DataSource = this.pengurusTableBindingSource;
            this.dgvPengurus.Location = new System.Drawing.Point(25, 134);
            this.dgvPengurus.Name = "dgvPengurus";
            this.dgvPengurus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPengurus.Size = new System.Drawing.Size(1209, 466);
            this.dgvPengurus.TabIndex = 0;
            this.dgvPengurus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPengurus_CellContentClick);
            // 
            // idPengurusDataGridViewTextBoxColumn
            // 
            this.idPengurusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idPengurusDataGridViewTextBoxColumn.DataPropertyName = "IdPengurus";
            this.idPengurusDataGridViewTextBoxColumn.HeaderText = "IdPengurus";
            this.idPengurusDataGridViewTextBoxColumn.Name = "idPengurusDataGridViewTextBoxColumn";
            this.idPengurusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaPengurusDataGridViewTextBoxColumn
            // 
            this.namaPengurusDataGridViewTextBoxColumn.DataPropertyName = "NamaPengurus";
            this.namaPengurusDataGridViewTextBoxColumn.HeaderText = "NamaPengurus";
            this.namaPengurusDataGridViewTextBoxColumn.Name = "namaPengurusDataGridViewTextBoxColumn";
            // 
            // jabatanPengurusDataGridViewTextBoxColumn
            // 
            this.jabatanPengurusDataGridViewTextBoxColumn.DataPropertyName = "JabatanPengurus";
            this.jabatanPengurusDataGridViewTextBoxColumn.HeaderText = "JabatanPengurus";
            this.jabatanPengurusDataGridViewTextBoxColumn.Name = "jabatanPengurusDataGridViewTextBoxColumn";
            // 
            // kontakPengurusDataGridViewTextBoxColumn
            // 
            this.kontakPengurusDataGridViewTextBoxColumn.DataPropertyName = "KontakPengurus";
            this.kontakPengurusDataGridViewTextBoxColumn.HeaderText = "KontakPengurus";
            this.kontakPengurusDataGridViewTextBoxColumn.Name = "kontakPengurusDataGridViewTextBoxColumn";
            // 
            // alamatPengurusDataGridViewTextBoxColumn
            // 
            this.alamatPengurusDataGridViewTextBoxColumn.DataPropertyName = "AlamatPengurus";
            this.alamatPengurusDataGridViewTextBoxColumn.HeaderText = "AlamatPengurus";
            this.alamatPengurusDataGridViewTextBoxColumn.Name = "alamatPengurusDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // pengurusTableBindingSource
            // 
            this.pengurusTableBindingSource.DataMember = "PengurusTable";
            this.pengurusTableBindingSource.DataSource = this.masjidDBDataSet3;
            // 
            // masjidDBDataSet3
            // 
            this.masjidDBDataSet3.DataSetName = "MasjidDBDataSet3";
            this.masjidDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pengurusTableTableAdapter
            // 
            this.pengurusTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(180, 108);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(77, 20);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Search";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterJabatan
            // 
            this.txtFilterJabatan.Location = new System.Drawing.Point(25, 108);
            this.txtFilterJabatan.Name = "txtFilterJabatan";
            this.txtFilterJabatan.Size = new System.Drawing.Size(149, 20);
            this.txtFilterJabatan.TabIndex = 3;
            // 
            // btnKembali
            // 
            this.btnKembali.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Kembali;
            this.btnKembali.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Location = new System.Drawing.Point(12, 627);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(154, 42);
            this.btnKembali.TabIndex = 15;
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Transparent;
            this.btnTambah.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Tmbh_Pengurus;
            this.btnTambah.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Location = new System.Drawing.Point(205, 626);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(154, 42);
            this.btnTambah.TabIndex = 1;
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MasjidAdminApp.Properties.Resources.TabelPengurus;
            this.pictureBox1.Location = new System.Drawing.Point(350, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 42);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // PengurusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MasjidAdminApp.Properties.Resources.BackgroundApp;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.txtFilterJabatan);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvPengurus);
            this.Name = "PengurusForm";
            this.Text = "PengurusForm";
            this.Load += new System.EventHandler(this.PengurusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengurus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengurusTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masjidDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPengurus;
        private MasjidDBDataSet3 masjidDBDataSet3;
        private System.Windows.Forms.BindingSource pengurusTableBindingSource;
        private MasjidDBDataSet3TableAdapters.PengurusTableTableAdapter pengurusTableTableAdapter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFilterJabatan;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPengurusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPengurusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatanPengurusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontakPengurusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatPengurusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}