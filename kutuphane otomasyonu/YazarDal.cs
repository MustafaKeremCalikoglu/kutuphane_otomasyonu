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
    internal class YazarDal
    {

        MySqlConnection _baglanti = new MySqlConnection("server=localhost;Database=kutuphanedb;uid=root;pwd='41abd271';");
        MySqlCommand _command;
        MySqlDataAdapter _adapter;
        DataTable _data;


        public void Kaydet(Yazar yazar)
        {
            try
            {
                BaglantiKontrol();
                _command = new MySqlCommand("insert into yazar(YazarAd,YazarSoyad) values(@ad,@soyad)", _baglanti);
                _command.Parameters.AddWithValue("@ad", yazar.YazarAd);
                _command.Parameters.AddWithValue("@soyad", yazar.YazarSoyad);
                _command.ExecuteNonQuery();
                _baglanti.Close();
                MessageBox.Show("kayıt yapıldı");

            }
            catch (Exception ex)
            {

                Console.WriteLine("hata çıktı {0}", ex);
            }


        }
        private void BaglantiKontrol()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
        }

        public void Sil(Yazar yazar)
        {
            BaglantiKontrol();
            _command = new MySqlCommand("delete from yazar where YazarNo=@no", _baglanti);
            _command.Parameters.AddWithValue("@no", yazar.no);
            _command.ExecuteNonQuery();
            _baglanti.Close();
            MessageBox.Show("kayıt silindi");

        }
        public DataTable Listele()
        {
            BaglantiKontrol();
            _data = new DataTable();
            _adapter = new MySqlDataAdapter("select * from yazar ", _baglanti);
            _adapter.Fill(_data);
            return _data;


        }
        public void Guncelle(Yazar yazar)
        {
            try
            {
                BaglantiKontrol();
                _command = new MySqlCommand("update yazar set  YazarAd=@ad,YazarSoyad=@soyad where YazarNo=@no", _baglanti);
                _command.Parameters.AddWithValue("@no", yazar.no);
                _command.Parameters.AddWithValue("@ad", yazar.YazarAd);
                _command.Parameters.AddWithValue("@soyad", yazar.YazarSoyad);
                _command.ExecuteNonQuery();
                _baglanti.Close();
                MessageBox.Show("güncellendi");

            }
            catch (Exception ex)
            {

                Console.WriteLine("hata burada {0}", ex);
            }

        }
    }
}
    
