using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu
{
    public partial class UyeListeleFrm : Form
    {
        char _cinsiyet='E';
        UyeDal uyeDal= new UyeDal();
        public UyeListeleFrm()
        {
            InitializeComponent();
        }

        private void UyeListeleFrm_Load(object sender, EventArgs e)
        {
            Listeleme();
        }
        
        public void Listeleme()
        {
            dgwUyeListe.DataSource = uyeDal.Listele();
        }

        private void dgwUyeListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTcNo.Text = dgwUyeListe.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dgwUyeListe.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgwUyeListe.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgwUyeListe.CurrentRow.Cells[3].Value.ToString();
            string cinsiyet=dgwUyeListe.CurrentRow.Cells[4].Value.ToString();
            try
            {
                if (cinsiyet[0] == 'E')
                {
                    rdoErkek.Checked = true;
                }
                else
                {
                    rdoKadın.Checked = true;
                }
            }
            catch (Exception)
            {

            }
           
            
            txtKitapSayisi.Text = dgwUyeListe.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Uye uye= new Uye
            {
                tcno= dgwUyeListe.CurrentRow.Cells[0].Value.ToString(),
                UyeTcNo = txtTcNo.Text,
                UyeAd = txtAd.Text,
                UyeSoyad = txtSoyad.Text,
                UyeCinsiyet = _cinsiyet,
                UyeEmail = txtEmail.Text,
                UyeKitapSayisi = Convert.ToInt32(txtKitapSayisi.Text)

            };
            uyeDal.Guncelle(uye);
            Listeleme();

        }

        private void rdoErkek_CheckedChanged(object sender, EventArgs e)
        {
            _cinsiyet = 'E';

        }

        private void rdoKadın_CheckedChanged(object sender, EventArgs e)
        {
            _cinsiyet = 'K';
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(dgwUyeListe.CurrentRow.Cells[5].Value) ==0)
            {
                Uye uye = new Uye
                {
                    UyeTcNo = dgwUyeListe.CurrentRow.Cells[0].Value.ToString()


                };

                uyeDal.Sil(uye);
                Listeleme();
            }
           
        }


    }
}
