namespace kutuphane_otomasyonu
{
    partial class işlemFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(işlemFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtKitapNo = new System.Windows.Forms.TextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.btnAl = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnİadeVer = new System.Windows.Forms.Button();
            this.lblKitapSayisi = new System.Windows.Forms.Label();
            this.lblKitapSahibi = new System.Windows.Forms.Label();
            this.dgwListe = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(54, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(54, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(54, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(163, 94);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(150, 22);
            this.txtTcNo.TabIndex = 3;
            this.txtTcNo.TextChanged += new System.EventHandler(this.txtTcNo_TextChanged);
            // 
            // txtKitapNo
            // 
            this.txtKitapNo.Location = new System.Drawing.Point(163, 174);
            this.txtKitapNo.Name = "txtKitapNo";
            this.txtKitapNo.Size = new System.Drawing.Size(150, 22);
            this.txtKitapNo.TabIndex = 4;
            this.txtKitapNo.TextChanged += new System.EventHandler(this.txtKitapNo_TextChanged);
            // 
            // dtTarih
            // 
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(163, 262);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(150, 22);
            this.dtTarih.TabIndex = 5;
            // 
            // btnAl
            // 
            this.btnAl.ImageIndex = 0;
            this.btnAl.ImageList = this.ımageList1;
            this.btnAl.Location = new System.Drawing.Point(39, 335);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(121, 58);
            this.btnAl.TabIndex = 6;
            this.btnAl.Text = "AL";
            this.btnAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ok.png");
            this.ımageList1.Images.SetKeyName(1, "sil.png");
            // 
            // btnİadeVer
            // 
            this.btnİadeVer.ImageIndex = 1;
            this.btnİadeVer.ImageList = this.ımageList1;
            this.btnİadeVer.Location = new System.Drawing.Point(184, 335);
            this.btnİadeVer.Name = "btnİadeVer";
            this.btnİadeVer.Size = new System.Drawing.Size(129, 58);
            this.btnİadeVer.TabIndex = 7;
            this.btnİadeVer.Text = "İADE VER";
            this.btnİadeVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnİadeVer.UseVisualStyleBackColor = true;
            this.btnİadeVer.Click += new System.EventHandler(this.btnİadeVer_Click);
            // 
            // lblKitapSayisi
            // 
            this.lblKitapSayisi.AutoSize = true;
            this.lblKitapSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblKitapSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapSayisi.ForeColor = System.Drawing.Color.Brown;
            this.lblKitapSayisi.Location = new System.Drawing.Point(160, 134);
            this.lblKitapSayisi.Name = "lblKitapSayisi";
            this.lblKitapSayisi.Size = new System.Drawing.Size(0, 16);
            this.lblKitapSayisi.TabIndex = 8;
            // 
            // lblKitapSahibi
            // 
            this.lblKitapSahibi.AutoSize = true;
            this.lblKitapSahibi.BackColor = System.Drawing.Color.Transparent;
            this.lblKitapSahibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapSahibi.ForeColor = System.Drawing.Color.Brown;
            this.lblKitapSahibi.Location = new System.Drawing.Point(156, 216);
            this.lblKitapSahibi.Name = "lblKitapSahibi";
            this.lblKitapSahibi.Size = new System.Drawing.Size(0, 16);
            this.lblKitapSahibi.TabIndex = 9;
            // 
            // dgwListe
            // 
            this.dgwListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListe.Location = new System.Drawing.Point(342, 94);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.ReadOnly = true;
            this.dgwListe.RowHeadersWidth = 51;
            this.dgwListe.RowTemplate.Height = 24;
            this.dgwListe.Size = new System.Drawing.Size(677, 299);
            this.dgwListe.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(72, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "üye sahibi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(72, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "kitap sahibi:";
            // 
            // işlemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kutuphane_otomasyonu.Properties.Resources.islem_ekran;
            this.ClientSize = new System.Drawing.Size(1084, 486);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgwListe);
            this.Controls.Add(this.lblKitapSahibi);
            this.Controls.Add(this.lblKitapSayisi);
            this.Controls.Add(this.btnİadeVer);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.txtKitapNo);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "işlemFrm";
            this.Text = "işlem";
            this.Load += new System.EventHandler(this.işlemFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtKitapNo;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.Button btnİadeVer;
        private System.Windows.Forms.Label lblKitapSayisi;
        private System.Windows.Forms.Label lblKitapSahibi;
        private System.Windows.Forms.DataGridView dgwListe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList ımageList1;
    }
}