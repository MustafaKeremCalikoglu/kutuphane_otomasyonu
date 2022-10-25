namespace kutuphane_otomasyonu
{
    partial class UyeListeleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeListeleFrm));
            this.dgwUyeListe = new System.Windows.Forms.DataGridView();
            this.rdoKadın = new System.Windows.Forms.RadioButton();
            this.rdoErkek = new System.Windows.Forms.RadioButton();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtKitapSayisi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUyeListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUyeListe
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgwUyeListe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwUyeListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUyeListe.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwUyeListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUyeListe.Location = new System.Drawing.Point(351, 53);
            this.dgwUyeListe.Name = "dgwUyeListe";
            this.dgwUyeListe.ReadOnly = true;
            this.dgwUyeListe.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgwUyeListe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwUyeListe.RowTemplate.Height = 24;
            this.dgwUyeListe.Size = new System.Drawing.Size(783, 427);
            this.dgwUyeListe.TabIndex = 0;
            this.dgwUyeListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUyeListe_CellClick);
            // 
            // rdoKadın
            // 
            this.rdoKadın.AutoSize = true;
            this.rdoKadın.BackColor = System.Drawing.Color.Transparent;
            this.rdoKadın.Location = new System.Drawing.Point(261, 245);
            this.rdoKadın.Name = "rdoKadın";
            this.rdoKadın.Size = new System.Drawing.Size(62, 20);
            this.rdoKadın.TabIndex = 28;
            this.rdoKadın.Text = "Kadın";
            this.rdoKadın.UseVisualStyleBackColor = false;
            this.rdoKadın.CheckedChanged += new System.EventHandler(this.rdoKadın_CheckedChanged);
            // 
            // rdoErkek
            // 
            this.rdoErkek.AutoSize = true;
            this.rdoErkek.BackColor = System.Drawing.Color.Transparent;
            this.rdoErkek.Location = new System.Drawing.Point(138, 245);
            this.rdoErkek.Name = "rdoErkek";
            this.rdoErkek.Size = new System.Drawing.Size(63, 20);
            this.rdoErkek.TabIndex = 27;
            this.rdoErkek.Text = "Erkek";
            this.rdoErkek.UseVisualStyleBackColor = false;
            this.rdoErkek.CheckedChanged += new System.EventHandler(this.rdoErkek_CheckedChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Font = new System.Drawing.Font("Technic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnGuncelle.ImageIndex = 1;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(138, 329);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(185, 69);
            this.btnGuncelle.TabIndex = 26;
            this.btnGuncelle.Text = "güncelle";
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "sil.png");
            this.ımageList1.Images.SetKeyName(1, "guncelle.png");
            // 
            // txtKitapSayisi
            // 
            this.txtKitapSayisi.Location = new System.Drawing.Point(138, 285);
            this.txtKitapSayisi.Name = "txtKitapSayisi";
            this.txtKitapSayisi.Size = new System.Drawing.Size(185, 22);
            this.txtKitapSayisi.TabIndex = 25;
            this.txtKitapSayisi.Text = "0";
            this.txtKitapSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 200);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 22);
            this.txtEmail.TabIndex = 24;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(138, 149);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(185, 22);
            this.txtSoyad.TabIndex = 23;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(138, 102);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(185, 22);
            this.txtAd.TabIndex = 22;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(138, 53);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(185, 22);
            this.txtTcNo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(7, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Kitap Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(30, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(43, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(37, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(60, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "TcNo:";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.Font = new System.Drawing.Font("Technic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSil.ImageIndex = 0;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(138, 404);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(185, 76);
            this.btnSil.TabIndex = 29;
            this.btnSil.Text = "sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UyeListeleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphane_otomasyonu.Properties.Resources.uye_listele;
            this.ClientSize = new System.Drawing.Size(1212, 559);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.rdoKadın);
            this.Controls.Add(this.rdoErkek);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtKitapSayisi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwUyeListe);
            this.Name = "UyeListeleFrm";
            this.Text = "UyeListeleFrm";
            this.Load += new System.EventHandler(this.UyeListeleFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUyeListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUyeListe;
        private System.Windows.Forms.RadioButton rdoKadın;
        private System.Windows.Forms.RadioButton rdoErkek;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtKitapSayisi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}