using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_otomasyonu
{
    static class kontroller
    {
        
        public static bool  stringmi(string text)
        {
            foreach (char chr in text)
            {
                if (Char.IsNumber(chr)) return false;
            }
            return true;
        }
        public static bool uzunlukkontrol(string text,int x)
        {
            if (text.Length==x)
            {
                return true;
            }
            return false;
        }
        public static bool Email_Kontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool integermi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }

    }
}
