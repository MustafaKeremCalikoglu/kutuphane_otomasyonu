using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace kutuphane_otomasyonu
{
    internal class KitapDal
    {

        MySqlConnection _baglanti = new MySqlConnection("server=localhost;Database=kutuphanedb;uid=root;pwd='41abd271';");
        MySqlCommand _command;
        MySqlDataAdapter _adapter;
        DataTable _data;

        private void BaglantiKontrol()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
        }

        public DataTable Listele()
        {
            BaglantiKontrol();
            _data = new DataTable();
            string sql = "select k.KitapNo,k.IsbnNo,k.KitapAd, y.YazarAd,u.UyeAd from kitap  k left join yazar  y on k.YazarNoId=y.YazarNo left join uye u on k.TcnoId=u.UyeTcNo";
            _adapter = new MySqlDataAdapter(sql, _baglanti);
            _adapter.Fill(_data);
            return _data;

        }

        public void Kaydet(Kitap kitap)
        {
            try
            {
                BaglantiKontrol();
                _command = new MySqlCommand("insert into kitap(IsbnNo,KitapAd,YazarNoId) values(@ad,@soyad,@no)", _baglanti);
                _command.Parameters.AddWithValue("@ad", kitap.IsbnNo);
                _command.Parameters.AddWithValue("@soyad", kitap.KitapAd);
                _command.Parameters.AddWithValue("@no", kitap.YazarNoId);
                _command.ExecuteNonQuery();
                _baglanti.Close();
                MessageBox.Show("kayıt yapıldı");

            }
            catch (Exception ex)
            {

                Console.WriteLine("hata çıktı {0}", ex);
            }


        }

        public DataTable Combo_Doldur()
        {
            BaglantiKontrol();
            _data = new DataTable();
            string sql = "select * from yazar ";
            _adapter = new MySqlDataAdapter(sql, _baglanti);
            _adapter.Fill(_data);
            return _data;

        }

        public int Combo_Index(string text)
        {

            BaglantiKontrol();
            _command = new MySqlCommand("select YazarNo from yazar where YazarAd=@ad",_baglanti);
            _command.Parameters.AddWithValue("@ad", text);
            MySqlDataReader oku=_command.ExecuteReader();
            oku.Read();
            string sayi= oku.GetString(0);
            _baglanti.Close();
            return Convert.ToInt32(sayi);
            

        }

        public void Sil(int no)
        {
            BaglantiKontrol();
            _command = new MySqlCommand("delete from kitap where KitapNo=@no", _baglanti);
            _command.Parameters.AddWithValue("@no", no);
            _command.ExecuteNonQuery();
            _baglanti.Close();
            MessageBox.Show("kayıt silindi");

        }

        public void Guncelle(Kitap kitap,int no,int no2)
        {
            try
            {
                BaglantiKontrol();
                _command = new MySqlCommand("update kitap set  IsbnNo=@ısbnno,KitapAd=@ad,YazarNoId=@yazarid where KitapNo=@no", _baglanti);
                _command.Parameters.AddWithValue("@no", no);
                _command.Parameters.AddWithValue("@ısbnno", kitap.IsbnNo);
                _command.Parameters.AddWithValue("@ad", kitap.KitapAd);
                _command.Parameters.AddWithValue("@yazarid", no2);
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
