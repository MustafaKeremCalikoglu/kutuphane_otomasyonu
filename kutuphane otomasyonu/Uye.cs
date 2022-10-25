using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu
{
    internal class Uye
    {
        public string _UyeTcNo;
        public string _UyeAd;
        public string _UyeSoyad;
        public string _UyeEmail;
        public string tcno { get; set; }
        public string UyeTcNo 
        { 
            get { return _UyeTcNo; }



            set
            {
                if (kontroller.integermi(value) && kontroller.uzunlukkontrol(value,11))
                {
                    _UyeTcNo = value;
                }
                else
                {
                    MessageBox.Show("Uye TC NO 11 haneli ve rakamlardan oluşmalıdır");
                }
            } 
        
        
        }
        public string UyeAd
        {
            get { return _UyeAd; }

            set 
            {
                if (kontroller.stringmi(value) && value!="")
                {
                    _UyeAd = value;
                }
                else
                {

                    MessageBox.Show("Uye Adı rakam içermemelidir");
                }
            } 
        
        }
        public string UyeSoyad
        {

            get { return _UyeSoyad; }



            set 
            
            {
                if (kontroller.stringmi(value) && value!="")
                {
                    _UyeSoyad = value;
                }
                else
                {

                    MessageBox.Show("Uye Soyadı rakam içermemelidir");
                }


            } 
        
        
        }
        public string UyeEmail
        {
            get { return _UyeEmail; }


            set 
            {

                if (kontroller.Email_Kontrol(value))
                {
                    _UyeEmail = value;
                }
                else
                {
                    MessageBox.Show("geçerli bir email giriniz");
                }
            
            } 
                
        }
        public char UyeCinsiyet { get; set; } 
        public int UyeKitapSayisi { get; set; }




    }
}
