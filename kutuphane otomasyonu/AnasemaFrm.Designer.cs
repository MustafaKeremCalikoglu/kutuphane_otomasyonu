namespace kutuphane_otomasyonu
{
    partial class AnasemaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnasemaFrm));
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnYazarEkleListele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnkitapEkle = new System.Windows.Forms.Button();
            this.btnIslem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Technic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(71, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Üye ekle";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "uyeekle.png");
            this.ımageList1.Images.SetKeyName(1, "listele.jpg");
            this.ımageList1.Images.SetKeyName(2, "ok.png");
            this.ımageList1.Images.SetKeyName(3, "sil.png");
            this.ımageList1.Images.SetKeyName(4, "ekle_kitap.png");
            this.ımageList1.Images.SetKeyName(5, "iade_al_ver.png");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(119, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "üye işlemleri";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Technic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(71, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(334, 83);
            this.button2.TabIndex = 1;
            this.button2.Text = "Üye Listele";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnYazarEkleListele
            // 
            this.btnYazarEkleListele.Font = new System.Drawing.Font("Technic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnYazarEkleListele.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnYazarEkleListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazarEkleListele.ImageIndex = 1;
            this.btnYazarEkleListele.ImageList = this.ımageList1;
            this.btnYazarEkleListele.Location = new System.Drawing.Point(71, 29);
            this.btnYazarEkleListele.Name = "btnYazarEkleListele";
            this.btnYazarEkleListele.Size = new System.Drawing.Size(334, 75);
            this.btnYazarEkleListele.TabIndex = 2;
            this.btnYazarEkleListele.Text = "Yazar Ekle Listele";
            this.btnYazarEkleListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYazarEkleListele.UseVisualStyleBackColor = true;
            this.btnYazarEkleListele.Click += new System.EventHandler(this.btnYazarEkleListele_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnkitapEkle);
            this.groupBox2.Controls.Add(this.btnYazarEkleListele);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(119, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 235);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnkitapEkle
            // 
            this.btnkitapEkle.Font = new System.Drawing.Font("Technic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnkitapEkle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnkitapEkle.ImageKey = "ekle_kitap.png";
            this.btnkitapEkle.ImageList = this.ımageList1;
            this.btnkitapEkle.Location = new System.Drawing.Point(71, 122);
            this.btnkitapEkle.Name = "btnkitapEkle";
            this.btnkitapEkle.Size = new System.Drawing.Size(334, 77);
            this.btnkitapEkle.TabIndex = 3;
            this.btnkitapEkle.Text = "Kitap Ekle / Listele/sil";
            this.btnkitapEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnkitapEkle.UseVisualStyleBackColor = true;
            this.btnkitapEkle.Click += new System.EventHandler(this.btnkitapEkle_Click);
            // 
            // btnIslem
            // 
            this.btnIslem.Font = new System.Drawing.Font("Technic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnIslem.ImageIndex = 5;
            this.btnIslem.ImageList = this.ımageList1;
            this.btnIslem.Location = new System.Drawing.Point(784, 297);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(322, 84);
            this.btnIslem.TabIndex = 4;
            this.btnIslem.Text = "Iade Al - Ver Islemleri";
            this.btnIslem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.btnIslem_Click);
            // 
            // AnasemaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::kutuphane_otomasyonu.Properties.Resources.ana_ekranım;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1273, 688);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1594, 783);
            this.Name = "AnasemaFrm";
            this.Text = "Kütüphane uygulaması";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnYazarEkleListele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnkitapEkle;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

