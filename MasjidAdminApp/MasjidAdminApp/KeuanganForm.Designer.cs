namespace MasjidAdminApp
{
    partial class KeuanganForm
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
            this.btnPemasukan = new System.Windows.Forms.Button();
            this.btnPengeluaran = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.lblTotalSaldo = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPemasukan
            // 
            this.btnPemasukan.BackColor = System.Drawing.Color.Transparent;
            this.btnPemasukan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPemasukan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPemasukan.Image = global::MasjidAdminApp.Properties.Resources.pemasukan__3_;
            this.btnPemasukan.Location = new System.Drawing.Point(379, 277);
            this.btnPemasukan.Name = "btnPemasukan";
            this.btnPemasukan.Size = new System.Drawing.Size(152, 152);
            this.btnPemasukan.TabIndex = 1;
            this.btnPemasukan.UseVisualStyleBackColor = false;
            this.btnPemasukan.Click += new System.EventHandler(this.btnPemasukan_Click);
            // 
            // btnPengeluaran
            // 
            this.btnPengeluaran.BackColor = System.Drawing.Color.Transparent;
            this.btnPengeluaran.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPengeluaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengeluaran.Image = global::MasjidAdminApp.Properties.Resources.pemasukan__2_;
            this.btnPengeluaran.Location = new System.Drawing.Point(736, 277);
            this.btnPengeluaran.Name = "btnPengeluaran";
            this.btnPengeluaran.Size = new System.Drawing.Size(152, 152);
            this.btnPengeluaran.TabIndex = 2;
            this.btnPengeluaran.UseVisualStyleBackColor = false;
            this.btnPengeluaran.Click += new System.EventHandler(this.btnPengeluaran_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MasjidAdminApp.Properties.Resources.pmskn;
            this.pictureBox1.Location = new System.Drawing.Point(379, 435);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 40);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MasjidAdminApp.Properties.Resources.pnglrn;
            this.pictureBox2.Location = new System.Drawing.Point(736, 435);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 40);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::MasjidAdminApp.Properties.Resources.DUA_FITUR;
            this.pictureBox3.Location = new System.Drawing.Point(379, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(509, 143);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // btnKembali
            // 
            this.btnKembali.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Kembali;
            this.btnKembali.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Location = new System.Drawing.Point(12, 627);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(154, 42);
            this.btnKembali.TabIndex = 16;
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // lblTotalSaldo
            // 
            this.lblTotalSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSaldo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaldo.Location = new System.Drawing.Point(379, 513);
            this.lblTotalSaldo.Name = "lblTotalSaldo";
            this.lblTotalSaldo.Size = new System.Drawing.Size(509, 62);
            this.lblTotalSaldo.TabIndex = 21;
            this.lblTotalSaldo.Text = "label1";
            this.lblTotalSaldo.Click += new System.EventHandler(this.lblTotalSaldo_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Jelajahi_Fiturnya;
            this.pictureBox4.Location = new System.Drawing.Point(379, 212);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(402, 40);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // KeuanganForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MasjidAdminApp.Properties.Resources.BackgroundApp;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblTotalSaldo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnPengeluaran);
            this.Controls.Add(this.btnPemasukan);
            this.Name = "KeuanganForm";
            this.Text = "KeuanganForm";
            this.Load += new System.EventHandler(this.KeuanganForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPemasukan;
        private System.Windows.Forms.Button btnPengeluaran;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblTotalSaldo;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}