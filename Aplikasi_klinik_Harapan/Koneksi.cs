using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;


namespace Aplikasi_klinik_Harapan
{
    class Koneksi
    {
       public SqlConnection GetConn()
        {
            SqlConnection Koneksi = new SqlConnection();
            Koneksi.ConnectionString = "Data source=NAMADEVICE; initial catalog=NAMADATABASE; integrated security= true; TrustServerCertificate=True"; 

            return Koneksi;
        }
    }
}
