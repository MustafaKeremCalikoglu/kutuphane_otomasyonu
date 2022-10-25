namespace kutuphane_otomasyonu
{
    partial class YazarEkleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YazarEkleFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYazarAd = new System.Windows.Forms.TextBox();
            this.txtYazarSoyad = new System.Windows.Forms.TextBox();
            this.dgwYazarListe = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYazarListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TechnicBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(38, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazar Adi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TechnicBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(38, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar Soyadi";
            // 
            // txtYazarAd
            // 
            this.txtYazarAd.Location = new System.Drawing.Point(200, 279);
            this.txtYazarAd.Name = "txtYazarAd";
            this.txtYazarAd.Size = new System.Drawing.Size(208, 22);
            this.txtYazarAd.TabIndex = 2;
            // 
            // txtYazarSoyad
            // 
            this.txtYazarSoyad.Location = new System.Drawing.Point(200, 323);
            this.txtYazarSoyad.Name = "txtYazarSoyad";
            this.txtYazarSoyad.Size = new System.Drawing.Size(208, 22);
            this.txtYazarSoyad.TabIndex = 3;
            // 
            // dgwYazarListe
            // 
            this.dgwYazarListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwYazarListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwYazarListe.Location = new System.Drawing.Point(42, 25);
            this.dgwYazarListe.Name = "dgwYazarListe";
            this.dgwYazarListe.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgwYazarListe.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwYazarListe.RowTemplate.Height = 24;
            this.dgwYazarListe.Size = new System.Drawing.Size(676, 221);
            this.dgwYazarListe.TabIndex = 4;
            this.dgwYazarListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwYazarListe_CellClick);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LightCyan;
            this.btnEkle.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ImageIndex = 0;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(543, 371);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(197, 76);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
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
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LightCyan;
            this.btnGuncelle.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ImageIndex = 2;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(302, 371);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(197, 76);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightCyan;
            this.btnSil.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ImageIndex = 1;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(42, 371);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(197, 76);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // YazarEkleFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphane_otomasyonu.Properties.Resources.yazar_listele;
            this.ClientSize = new System.Drawing.Size(765, 502);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgwYazarListe);
            this.Controls.Add(this.txtYazarSoyad);
            this.Controls.Add(this.txtYazarAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YazarEkleFrm";
            this.Text = "YazarEkleFrm";
            this.Load += new System.EventHandler(this.YazarEkleFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwYazarListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYazarAd;
        private System.Windows.Forms.TextBox txtYazarSoyad;
        private System.Windows.Forms.DataGridView dgwYazarListe;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ImageList ımageList1;
    }
}