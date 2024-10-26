namespace MasjidAdminApp
{
    partial class InputPemasukanForm
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
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtKeteranganTambahan = new System.Windows.Forms.TextBox();
            this.txtJumlahPemasukan = new System.Windows.Forms.TextBox();
            this.txtNamaDonatur = new System.Windows.Forms.TextBox();
            this.dtpTanggalWaktuPemasukan = new System.Windows.Forms.DateTimePicker();
            this.txtSumberPemasukan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.Transparent;
            this.btnSimpan.BackgroundImage = global::MasjidAdminApp.Properties.Resources.SimpanJir;
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.Transparent;
            this.btnSimpan.Location = new System.Drawing.Point(439, 499);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(154, 44);
            this.btnSimpan.TabIndex = 17;
            this.btnSimpan.UseVisualStyleBackColor = false;
            // 
            // txtKeteranganTambahan
            // 
            this.txtKeteranganTambahan.Location = new System.Drawing.Point(439, 378);
            this.txtKeteranganTambahan.Multiline = true;
            this.txtKeteranganTambahan.Name = "txtKeteranganTambahan";
            this.txtKeteranganTambahan.Size = new System.Drawing.Size(402, 34);
            this.txtKeteranganTambahan.TabIndex = 16;
            this.txtKeteranganTambahan.TextChanged += new System.EventHandler(this.txtKeteranganTambahan_TextChanged);
            // 
            // txtJumlahPemasukan
            // 
            this.txtJumlahPemasukan.Location = new System.Drawing.Point(439, 310);
            this.txtJumlahPemasukan.Multiline = true;
            this.txtJumlahPemasukan.Name = "txtJumlahPemasukan";
            this.txtJumlahPemasukan.Size = new System.Drawing.Size(402, 34);
            this.txtJumlahPemasukan.TabIndex = 15;
            this.txtJumlahPemasukan.TextChanged += new System.EventHandler(this.txtJumlahPemasukan_TextChanged);
            // 
            // txtNamaDonatur
            // 
            this.txtNamaDonatur.Location = new System.Drawing.Point(439, 245);
            this.txtNamaDonatur.Multiline = true;
            this.txtNamaDonatur.Name = "txtNamaDonatur";
            this.txtNamaDonatur.Size = new System.Drawing.Size(402, 34);
            this.txtNamaDonatur.TabIndex = 14;
            this.txtNamaDonatur.TextChanged += new System.EventHandler(this.txtNamaDonatur_TextChanged);
            // 
            // dtpTanggalWaktuPemasukan
            // 
            this.dtpTanggalWaktuPemasukan.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalWaktuPemasukan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalWaktuPemasukan.Location = new System.Drawing.Point(439, 446);
            this.dtpTanggalWaktuPemasukan.Name = "dtpTanggalWaktuPemasukan";
            this.dtpTanggalWaktuPemasukan.Size = new System.Drawing.Size(402, 31);
            this.dtpTanggalWaktuPemasukan.TabIndex = 23;
            this.dtpTanggalWaktuPemasukan.ValueChanged += new System.EventHandler(this.dtpTanggalWaktuPemasukan_ValueChanged);
            // 
            // txtSumberPemasukan
            // 
            this.txtSumberPemasukan.Location = new System.Drawing.Point(439, 177);
            this.txtSumberPemasukan.Multiline = true;
            this.txtSumberPemasukan.Name = "txtSumberPemasukan";
            this.txtSumberPemasukan.Size = new System.Drawing.Size(402, 34);
            this.txtSumberPemasukan.TabIndex = 13;
            this.txtSumberPemasukan.TextChanged += new System.EventHandler(this.txtSumberPemasukan_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Sumber_Pemasukan;
            this.pictureBox1.Location = new System.Drawing.Point(439, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 40);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Nama_Donatur;
            this.pictureBox2.Location = new System.Drawing.Point(439, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(402, 40);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Jumlah_Pemasukan;
            this.pictureBox3.Location = new System.Drawing.Point(439, 274);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(402, 40);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Keterangan_Tambahan;
            this.pictureBox4.Location = new System.Drawing.Point(439, 341);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(402, 40);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BackgroundImage = global::MasjidAdminApp.Properties.Resources.TanggalWaktu;
            this.pictureBox5.Location = new System.Drawing.Point(439, 409);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(402, 40);
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // InputPemasukanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MasjidAdminApp.Properties.Resources.BackgroundApp;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dtpTanggalWaktuPemasukan);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtKeteranganTambahan);
            this.Controls.Add(this.txtJumlahPemasukan);
            this.Controls.Add(this.txtNamaDonatur);
            this.Controls.Add(this.txtSumberPemasukan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Name = "InputPemasukanForm";
            this.Text = "InputPemasukanForm";
            this.Load += new System.EventHandler(this.InputPemasukanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtKeteranganTambahan;
        private System.Windows.Forms.TextBox txtJumlahPemasukan;
        private System.Windows.Forms.TextBox txtNamaDonatur;
        private System.Windows.Forms.DateTimePicker dtpTanggalWaktuPemasukan;
        private System.Windows.Forms.TextBox txtSumberPemasukan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}