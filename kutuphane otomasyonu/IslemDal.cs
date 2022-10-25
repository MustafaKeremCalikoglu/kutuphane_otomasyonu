using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.Qualified;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Ubiety.Dns.Core.Common;
using Ubiety.Dns.Core.Records.NotUsed;
using static System.Net.Mime.MediaTypeNames;

namespace kutuphane_otomasyonu
{
    internal class IslemDal
    {
        MySqlConnection _baglanti = new MySqlConnection("server=localhost;Database=kutuphanedb;uid=root;pwd='41abd271';");
        MySqlCommand _command;
        MySqlCommand _command2;
        MySqlCommand _command3;
        MySqlDataAdapter _adapter;
        DataTable _data;
        int _kitapsayisi;
        bool _kitapsahibivarmı;
        string _sahip_no;
        string _girilen_no;
        string _girilen_kitap_no;
        
        
        
        public string KitapSayisi(string text)
        {

            if (uyeicerirmi(text))
            {
                BaglantiKontrol();
                _girilen_no = text;
                _command = new MySqlCommand("select UyeKitapSayisi from uye where UyeTcNo=@no ", _baglanti);
                _command.Parameters.AddWithValue("@no", text);
                MySqlDataReader oku = _command.ExecuteReader();
                oku.Read();
                string sayi = oku.GetString(0);
                _baglanti.Close();
                oku.Close();
                _kitapsayisi = Convert.ToInt32(sayi);
                return sayi;
            }
            else
            {
                _kitapsayisi = 10;
                return "bulunamadı";
            }
            
        }
        public string KitapSahibi(string text)
        {
            _girilen_kitap_no = text;
            if (kitapvarmı(text))
            {
                BaglantiKontrol();
                _command = new MySqlCommand("select TcNoId from kitap where KitapNo=@no",_baglanti);
                _command.Parameters.AddWithValue("@no", text);
                _adapter = new MySqlDataAdapter();
                _adapter.SelectCommand= _command;
                _data = new DataTable();
                _adapter.Fill(_data);
                _sahip_no= _data.Rows[0][0].ToString();
                string mesaj;
                if (_sahip_no=="")
                {
                    _kitapsahibivarmı = false;
                    mesaj = "sahibi yok";    
                }
                else
                {
                    _kitapsahibivarmı = true;
                    mesaj = _sahip_no;
                }
                

                return mesaj;                
            }
               
            else
            {
                return "bulunamadı";
            }

        }

        public void BaglantiKontrol()
        {
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
        }

        public bool uyeicerirmi(string text)
        {

            List<string> nolistesi = new List<string>();
            BaglantiKontrol();
            _command = new MySqlCommand("select UyeTcNo from uye ", _baglanti);
            MySqlDataReader oku = _command.ExecuteReader();
            while (oku.Read())
            {
                nolistesi.Add(oku.GetString(0));
            }
            
            _baglanti.Close();
            oku.Close();
            
            
            bool cevap = false;
            foreach (var item in nolistesi)
            {
                if (text==item)
                {
                    
                    cevap = true;
                }
                
            }

            return cevap;
        }

        public bool kitapvarmı(string text)
        {
            List<string> nolistesi = new List<string>();
            BaglantiKontrol();
            _command = new MySqlCommand("select KitapNo from kitap", _baglanti);
            MySqlDataReader oku = _command.ExecuteReader();
            while (oku.Read())
            {
                nolistesi.Add(oku.GetString(0));
            }

            _baglanti.Close();
            oku.Close();

            bool cevap = false;
            foreach (var item in nolistesi)
            {
                if (text == item)
                {
                    cevap = true;
                }

            }

            return cevap;
        }

        public void Ekle(Islem islem)
        {

            if(_kitapsayisi<=3 && !_kitapsahibivarmı && uyeicerirmi(_girilen_no) && kitapvarmı(_girilen_kitap_no))
            {
                try
                {
                    BaglantiKontrol();
                    _command = new MySqlCommand("insert into islem(TcNo,KitapNo,IslemTarih,IslemTuru) values(@no,@kitapno,@tarih,@islemturu)", _baglanti);
                    _command.Parameters.AddWithValue("@no", _girilen_no);
                    _command.Parameters.AddWithValue("@kitapno",_girilen_kitap_no);
                    _command.Parameters.AddWithValue("@tarih", islem.IslemTarih);
                    _command.Parameters.AddWithValue("@islemturu", "alındı");
                    _command.ExecuteNonQuery();
                  


                    _command2 = new MySqlCommand("update kitap set TcNoId=@no where KitapNo=@kitapno", _baglanti);
                    _command2.Parameters.AddWithValue("@no",_girilen_no);
                    _command2.Parameters.AddWithValue("@kitapno", _girilen_kitap_no);
                    _command2.ExecuteNonQuery();
                    
                    _command3 = new MySqlCommand("update uye set UyeKitapSayisi=@sayi where UyeTcNo=@no", _baglanti);

                    _kitapsayisi = _kitapsayisi + 1;
                    _command3.Parameters.AddWithValue("@no", _girilen_no);
                    _command3.Parameters.AddWithValue("@sayi",Convert.ToInt32(_kitapsayisi) );
                    _command3.ExecuteNonQuery();
                    
                                       
                    _baglanti.Close();

                    MessageBox.Show("kayıt yapıldı");

                }
                catch (Exception ex)
                {

                    Console.WriteLine("hata çıktı {0}", ex);
                }


            }


        }

        public void İadeEt(Islem islem)
        {

            if (_kitapsayisi >0 && _sahip_no==_girilen_no && uyeicerirmi(_girilen_no) && kitapvarmı(_girilen_kitap_no))
            {
                try
                {
                    BaglantiKontrol();
                    _command = new MySqlCommand("insert into islem(TcNo,KitapNo,IslemTarih,IslemTuru) values(@no,@kitapno,@tarih,@islemturu)", _baglanti);
                    _command.Parameters.AddWithValue("@no", _girilen_no);
                    _command.Parameters.AddWithValue("@kitapno", _girilen_kitap_no);
                    _command.Parameters.AddWithValue("@tarih", islem.IslemTarih);
                    _command.Parameters.AddWithValue("@islemturu", "iade edildi");
                    _command.ExecuteNonQuery();



                    _command2 = new MySqlCommand("update kitap set TcNoId=@no where KitapNo=@kitapno", _baglanti);
                    _command2.Parameters.AddWithValue("@no", null);
                    _command2.Parameters.AddWithValue("@kitapno", _girilen_kitap_no);
                    _command2.ExecuteNonQuery();

                    _command3 = new MySqlCommand("update uye set UyeKitapSayisi=@sayi where UyeTcNo=@no", _baglanti);

                    _kitapsayisi = _kitapsayisi - 1;
                    _command3.Parameters.AddWithValue("@no", _girilen_no);
                    _command3.Parameters.AddWithValue("@sayi", Convert.ToInt32(_kitapsayisi));
                    _command3.ExecuteNonQuery();


                    _baglanti.Close();

                    MessageBox.Show("iade işlemi yapıldı");

                }
                catch (Exception ex)
                {

                    Console.WriteLine("hata çıktı {0}", ex);
                }


            }


        }

        public DataTable Listele()
        {
            BaglantiKontrol();
            _data = new DataTable();
            string sql = "select i.IslemId,k.KitapAd,u.UyeAd,u.UyeSoyad,i.IslemTarih,i.IslemTuru   from islem  i left join kitap  k on i.KitapNo=k.KitapNo left join uye u on i.TcNo=u.UyeTcNo";
            _adapter = new MySqlDataAdapter(sql, _baglanti);
            _adapter.Fill(_data);
            return _data;

        }
    }
          
}
