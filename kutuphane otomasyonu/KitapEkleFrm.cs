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
    public partial class KitapEkleFrm : Form
    {
        public int _yazarno;
        KitapDal _kitapDal = new KitapDal();
        public KitapEkleFrm()
        {
            InitializeComponent();
        }

        private void KitapEkleFrm_Load(object sender, EventArgs e)
        {
            Listele();
            cmbYazar.Items.Clear();
            foreach (DataRow dr in _kitapDal.Combo_Doldur().Rows)
            {
                cmbYazar.Items.Add(dr["YazarAd"].ToString());

            }


        }
        public void Listele()
        {
            dgwKitapListele.DataSource = _kitapDal.Listele();

        }

        private void cmbYazar_SelectedIndexChanged(object sender, EventArgs e)
        {

            _yazarno = _kitapDal.Combo_Index(cmbYazar.Text);
            

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap
            {


                IsbnNo = txtIsbnNo.Text,
                KitapAd = txtKitapAdı.Text,
                YazarNoId = _yazarno

            };
            _kitapDal.Kaydet(kitap);
            Listele();

        }

        private void dgwKitapListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIsbnNo.Text = dgwKitapListele.CurrentRow.Cells[1].Value.ToString();
            txtKitapAdı.Text = dgwKitapListele.CurrentRow.Cells[2].Value.ToString();
            cmbYazar.Text = dgwKitapListele.CurrentRow.Cells[3].Value.ToString();
        
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgwKitapListele.CurrentRow.Cells[0].Value.ToString() == null)
            {
                _kitapDal.Sil(Convert.ToInt32(dgwKitapListele.CurrentRow.Cells[0].Value));
                Listele();
            }
            
            
        
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap { 
            
                IsbnNo=txtIsbnNo.Text,
                KitapAd=txtKitapAdı.Text
            };

            int kitapno = Convert.ToInt32(dgwKitapListele.CurrentRow.Cells[0].Value);
            _kitapDal.Guncelle(kitap, kitapno, _yazarno);
            Listele();

        }
    }
}
