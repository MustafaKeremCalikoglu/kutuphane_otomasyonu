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
    public partial class işlemFrm : Form
    {
        IslemDal islemDal = new IslemDal();
        
        public işlemFrm()
        {
            InitializeComponent();
        }

        private void işlemFrm_Load(object sender, EventArgs e)
        {
            Listeleme();
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            Islem islem = new Islem
            {
                IslemTarih = dtTarih.Value
            };
            islemDal.Ekle(islem);
            Listeleme();

        }

        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            lblKitapSayisi.Text = islemDal.KitapSayisi(txtTcNo.Text);
        }

        private void txtKitapNo_TextChanged(object sender, EventArgs e)
        {
            lblKitapSahibi.Text = islemDal.KitapSahibi(txtKitapNo.Text);
        }

        public void Listeleme()
        {
            dgwListe.DataSource = islemDal.Listele();
        }

        private void btnİadeVer_Click(object sender, EventArgs e)
        {
            Islem islem = new Islem
            {
                IslemTarih = dtTarih.Value
            };
            islemDal.İadeEt(islem);
            Listeleme();
        }

        
    }
}
