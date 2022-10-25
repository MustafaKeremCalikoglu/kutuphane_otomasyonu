namespace kutuphane_otomasyonu
{
    partial class KitapEkleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkleFrm));
            this.dgwKitapListele = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIsbnNo = new System.Windows.Forms.TextBox();
            this.txtKitapAdı = new System.Windows.Forms.TextBox();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitapListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwKitapListele
            // 
            this.dgwKitapListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwKitapListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitapListele.Location = new System.Drawing.Point(60, 12);
            this.dgwKitapListele.Name = "dgwKitapListele";
            this.dgwKitapListele.RowHeadersWidth = 51;
            this.dgwKitapListele.RowTemplate.Height = 24;
            this.dgwKitapListele.Size = new System.Drawing.Size(730, 304);
            this.dgwKitapListele.TabIndex = 0;
            this.dgwKitapListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKitapListele_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Isbn No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(56, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yazar:";
            // 
            // txtIsbnNo
            // 
            this.txtIsbnNo.Location = new System.Drawing.Point(171, 356);
            this.txtIsbnNo.Name = "txtIsbnNo";
            this.txtIsbnNo.Size = new System.Drawing.Size(177, 22);
            this.txtIsbnNo.TabIndex = 4;
            // 
            // txtKitapAdı
            // 
            this.txtKitapAdı.Location = new System.Drawing.Point(171, 403);
            this.txtKitapAdı.Name = "txtKitapAdı";
            this.txtKitapAdı.Size = new System.Drawing.Size(177, 22);
            this.txtKitapAdı.TabIndex = 5;
            // 
            // cmbYazar
            // 
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(171, 447);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(177, 24);
            this.cmbYazar.TabIndex = 6;
            this.cmbYazar.SelectedIndexChanged += new System.EventHandler(this.cmbYazar_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(415, 356);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(162, 63);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "ekle";
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ok.png");
            this.ımageList1.Images.SetKeyName(1, "sil.png");
            this.ımageList1.Images.SetKeyName(2, "guncelle.png");
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSil.ImageIndex = 1;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(517, 447);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(160, 60);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuncelle.ImageIndex = 2;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(628, 356);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(162, 63);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "güncelle";
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // KitapEkleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphane_otomasyonu.Properties.Resources.kitap_ekle;
            this.ClientSize = new System.Drawing.Size(871, 559);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbYazar);
            this.Controls.Add(this.txtKitapAdı);
            this.Controls.Add(this.txtIsbnNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwKitapListele);
            this.Name = "KitapEkleFrm";
            this.Text = "KitapEkleFrm";
            this.Load += new System.EventHandler(this.KitapEkleFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitapListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKitapListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIsbnNo;
        private System.Windows.Forms.TextBox txtKitapAdı;
        private System.Windows.Forms.ComboBox cmbYazar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}