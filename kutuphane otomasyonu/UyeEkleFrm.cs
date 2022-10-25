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
    public partial class UyeEkleFrm : Form
    {
        UyeDal _uyeDal=new UyeDal();
        char _cinsiyet='E';
        public UyeEkleFrm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Uye uye = new Uye
            {
                UyeTcNo = txtTcNo.Text,
                UyeAd=txtAd.Text,
                UyeSoyad=txtSoyad.Text,
                UyeCinsiyet=_cinsiyet,
                UyeEmail=txtEmail.Text,
                UyeKitapSayisi=Convert.ToInt32(txtKitapSayisi.Text)
            };
            _uyeDal.Kaydet(uye);

        }

        private void rdoErkek_CheckedChanged(object sender, EventArgs e)
        {
            _cinsiyet = 'E';
        }

        private void rdoKadın_CheckedChanged(object sender, EventArgs e)
        {
            _cinsiyet = 'K';
        }
    }
}
