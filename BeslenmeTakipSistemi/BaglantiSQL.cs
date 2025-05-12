using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeslenmeTakipSistemi
{
    internal class BaglantiSQL
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection("Server=DESKTOP-VNC1G3P\\SQLEXPRESS01; Database=BeslenmeTakip; Uid=sa; Pwd=123456");
            baglanti.Open();
            SqlConnection.ClearPool(baglanti);
            return baglanti;


        }
    }
}
