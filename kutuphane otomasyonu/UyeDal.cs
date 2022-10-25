using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu
{
    internal class UyeDal
    {
        MySqlConnection _baglanti = new MySqlConnection("server=localhost;Database=kutuphanedb;uid=root;pwd='41abd271';");
        MySqlCommand _command;
        MySqlDataAdapter _adapter;
        DataTable _data;
        
        
        public void Kaydet(Uye uye)
        {
            try
            {
                BaglantiKontrol();
                _command=new MySqlCommand("insert into uye(UyeTcNo,UyeAd,UyeSoyad,UyeEmail,UyeCinsiyet,UyeKitapSayisi) values(@tc,@ad,@soyad,@email,@cinsiyet,@kitapsayisi)",_baglanti);
                _command.Parameters.AddWithValue("@tc",uye.UyeTcNo);
                _command.Parameters.AddWithValue("@ad",uye.UyeAd);
                _command.Parameters.AddWithValue("@soyad",uye.UyeSoyad);
                _command.Parameters.AddWithValue("@email",uye.UyeEmail);
                _command.Parameters.AddWithValue("@cinsiyet",uye.UyeCinsiyet);
                _command.Parameters.AddWithValue("@kitapsayisi",uye.UyeKitapSayisi);
                _command.ExecuteNonQuery();
                _baglanti.Close();
                MessageBox.Show("kayıt yapıldı");

            }
            catch (Exception ex)
            {

                Console.WriteLine("hata çıktı {0}",ex);
            }


        }
        
        public DataTable Listele()
        {
            BaglantiKontrol();
            _data = new DataTable();
            _adapter = new MySqlDataAdapter("select * from uye ",_baglanti);
            _adapter.Fill(_data);
            return _data;


        }

        public void Guncelle(Uye uye)
        {
            try
            {
                BaglantiKontrol();
                _command = new MySqlCommand("update uye set  UyeTcNo=@tc,UyeAd=@ad,UyeSoyad=@soyad,UyeEmail=@email,UyeCinsiyet=@cinsiyet,UyeKitapSayisi=@kitapsayisi where UyeTcNo=@tcno", _baglanti);
                _command.Parameters.AddWithValue("@tc", uye.UyeTcNo);
                _command.Parameters.AddWithValue("@ad", uye.UyeAd);
                _command.Parameters.AddWithValue("@soyad", uye.UyeSoyad);
                _command.Parameters.AddWithValue("@email", uye.UyeEmail);
                _command.Parameters.AddWithValue("@cinsiyet", uye.UyeCinsiyet);
                _command.Parameters.AddWithValue("@kitapsayisi", uye.UyeKitapSayisi);
                _command.Parameters.AddWithValue("@tcno", uye.tcno);
                _command.ExecuteNonQuery();
                _baglanti.Close();
                MessageBox.Show("güncellendi");

            }
            catch (Exception ex)
            {

                Console.WriteLine("hata burada {0}",ex);
            }



        }
        
        public void Sil(Uye uye)
        {
            BaglantiKontrol();
            
            _command = new MySqlCommand("delete from uye where UyeTcNo=@tc", _baglanti);
            _command.Parameters.AddWithValue("@tc", uye.UyeTcNo);
            _command.ExecuteNonQuery();
            _baglanti.Close();
            MessageBox.Show("kayıt silindi");

        }



        private void BaglantiKontrol()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
        }



    }



}
