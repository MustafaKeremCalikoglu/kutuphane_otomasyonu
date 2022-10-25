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
    public partial class AnasemaFrm : Form
    {
        public AnasemaFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkleFrm uyeEkleFrm = new UyeEkleFrm();
            uyeEkleFrm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeListeleFrm uyeListeleFrm=new UyeListeleFrm();
            uyeListeleFrm.ShowDialog();
        }

        private void btnYazarEkleListele_Click(object sender, EventArgs e)
        {
            YazarEkleFrm yazarEkleFrm = new YazarEkleFrm();
            yazarEkleFrm.ShowDialog();
        }

        private void btnkitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkleFrm kitapEkleFrm = new KitapEkleFrm();
            kitapEkleFrm.ShowDialog();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            işlemFrm işlem = new işlemFrm();
            işlem.ShowDialog();
        }
    }
}
