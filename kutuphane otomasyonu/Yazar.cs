using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu
{
    internal class Yazar
    {

        public string _YazarAd;
        public string _YazarSoyad;
        public int no { get; set; }

        public string YazarAd
        {
            get { return _YazarAd; }
            set 
            {
                if (kontroller.stringmi(value) && value != "")
                {
                    _YazarAd = value;
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir isim giriniz");
                }
            
            }
        }
        public string YazarSoyad
        {
            get { return _YazarSoyad; }
            set
            {
                if (kontroller.stringmi(value) && value != "")
                {
                    _YazarSoyad = value;
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir isim giriniz");
                }

            }
        }




    }
}
