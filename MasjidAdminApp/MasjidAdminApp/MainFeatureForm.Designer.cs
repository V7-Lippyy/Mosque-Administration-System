namespace MasjidAdminApp
{
    partial class MainFeatureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFeatureForm));
            this.btnPengurus = new System.Windows.Forms.Button();
            this.btnKeuangan = new System.Windows.Forms.Button();
            this.btnInventaris = new System.Windows.Forms.Button();
            this.btnKegiatan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPengurus
            // 
            this.btnPengurus.BackColor = System.Drawing.Color.Transparent;
            this.btnPengurus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPengurus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengurus.Image = global::MasjidAdminApp.Properties.Resources.Pengurus;
            this.btnPengurus.Location = new System.Drawing.Point(402, 239);
            this.btnPengurus.Name = "btnPengurus";
            this.btnPengurus.Size = new System.Drawing.Size(152, 152);
            this.btnPengurus.TabIndex = 0;
            this.btnPengurus.UseVisualStyleBackColor = false;
            this.btnPengurus.Click += new System.EventHandler(this.btnPengurus_Click);
            // 
            // btnKeuangan
            // 
            this.btnKeuangan.BackColor = System.Drawing.Color.Transparent;
            this.btnKeuangan.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Keuangan;
            this.btnKeuangan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKeuangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeuangan.Location = new System.Drawing.Point(702, 239);
            this.btnKeuangan.Name = "btnKeuangan";
            this.btnKeuangan.Size = new System.Drawing.Size(152, 152);
            this.btnKeuangan.TabIndex = 1;
            this.btnKeuangan.UseVisualStyleBackColor = false;
            this.btnKeuangan.Click += new System.EventHandler(this.btnKeuangan_Click);
            // 
            // btnInventaris
            // 
            this.btnInventaris.BackgroundImage = global::MasjidAdminApp.Properties.Resources.Inventaris__1_;
            this.btnInventaris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInventaris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventaris.Location = new System.Drawing.Point(402, 454);
            this.btnInventaris.Name = "btnInventaris";
            this.btnInventaris.Size = new System.Drawing.Size(152, 152);
            this.btnInventaris.TabIndex = 2;
            this.btnInventaris.UseVisualStyleBackColor = true;
            this.btnInventaris.Click += new System.EventHandler(this.btnInventaris_Click);
            // 
            // btnKegiatan
            // 
            this.btnKegiatan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKegiatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKegiatan.Image = global::MasjidAdminApp.Properties.Resources.Kegiatan;
            this.btnKegiatan.Location = new System.Drawing.Point(702, 454);
            this.btnKegiatan.Name = "btnKegiatan";
            this.btnKegiatan.Size = new System.Drawing.Size(152, 152);
            this.btnKegiatan.TabIndex = 3;
            this.btnKegiatan.UseVisualStyleBackColor = true;
            this.btnKegiatan.Click += new System.EventHandler(this.btnKegiatan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(1098, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(154, 42);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MasjidAdminApp.Properties.Resources.dftr_pnggrs;
            this.pictureBox1.Location = new System.Drawing.Point(402, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 40);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::MasjidAdminApp.Properties.Resources.keungn;
            this.pictureBox2.Location = new System.Drawing.Point(702, 397);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 40);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::MasjidAdminApp.Properties.Resources.dftr_invn;
            this.pictureBox3.Location = new System.Drawing.Point(402, 612);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 40);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::MasjidAdminApp.Properties.Resources.dftr_ikgtn;
            this.pictureBox4.Location = new System.Drawing.Point(702, 612);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 40);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.Location = new System.Drawing.Point(402, 138);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(452, 33);
            this.lblCurrentUser.TabIndex = 9;
            this.lblCurrentUser.Click += new System.EventHandler(this.lblCurrentUser_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::MasjidAdminApp.Properties.Resources.welcome;
            this.pictureBox6.Location = new System.Drawing.Point(402, 33);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(452, 102);
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::MasjidAdminApp.Properties.Resources.mAINfEATURE1;
            this.pictureBox5.Location = new System.Drawing.Point(402, 189);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(452, 40);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // MainFeatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MasjidAdminApp.Properties.Resources.BackgroundApp;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblCurrentUser);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnKegiatan);
            this.Controls.Add(this.btnInventaris);
            this.Controls.Add(this.btnKeuangan);
            this.Controls.Add(this.btnPengurus);
            this.Name = "MainFeatureForm";
            this.Text = "MainFeaturForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPengurus;
        private System.Windows.Forms.Button btnKeuangan;
        private System.Windows.Forms.Button btnInventaris;
        private System.Windows.Forms.Button btnKegiatan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}