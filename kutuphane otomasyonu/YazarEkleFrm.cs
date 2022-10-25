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
    public partial class YazarEkleFrm : Form
    {   

        YazarDal _yazarDal=new YazarDal();
        public YazarEkleFrm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Yazar yazar = new Yazar 
            {
                YazarAd=txtYazarAd.Text,
                YazarSoyad=txtYazarSoyad.Text,
            };
            _yazarDal.Kaydet(yazar);
            Listele();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {



            Yazar yazar = new Yazar
            {

                no = Convert.ToInt32(dgwYazarListe.CurrentRow.Cells[0].Value)

            };
            _yazarDal.Sil(yazar);
            Listele();


        }    
           

        

        private void dgwYazarListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtYazarAd.Text = dgwYazarListe.CurrentRow.Cells[1].Value.ToString();
            txtYazarSoyad.Text = dgwYazarListe.CurrentRow.Cells[2].Value.ToString();
        }

        private void YazarEkleFrm_Load(object sender, EventArgs e)
        {
            Listele();
        }
    
        private void Listele()
        {

            dgwYazarListe.DataSource = _yazarDal.Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Yazar yazar = new Yazar
            {

                no = Convert.ToInt32(dgwYazarListe.CurrentRow.Cells[0].Value),
                YazarAd = txtYazarAd.Text,
                YazarSoyad=txtYazarSoyad.Text

            };

            _yazarDal.Guncelle(yazar);
            Listele();
        
        }
    }
}
