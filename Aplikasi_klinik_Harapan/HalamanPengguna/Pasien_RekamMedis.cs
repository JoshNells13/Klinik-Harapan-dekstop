using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Aplikasi_klinik_Harapan.HalamanPengguna
{
    public partial class Pasien_RekamMedis : Form
    {
        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;


        void loaddata()
        {

            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT RekamMedis.RekamMedisID  ,Pasien.Nama_Pasien,Dokter.Nama_Dokter,RekamMedis.Diagnosa,RekamMedis.Tindakan,RekamMedis.Tanggal,RekamMedis.CatatanTambahan " +
                "FROM RekamMedis " +
                "INNER JOIN Pasien ON RekamMedis.PasienID = Pasien.PasienID " +
                "INNER JOIN Dokter ON RekamMedis.DokterID = Dokter.DokterID " +
                "WHERE Nama_Pasien = @nama", con);
            cmd.Parameters.AddWithValue("@nama", lblNama.Text);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "RekamMedis");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RekamMedis";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }


        public string nama
        {
            get { return lblNama.Text; }
            set { lblNama.Text = value; }
        }
        public Pasien_RekamMedis()
        {
            InitializeComponent();
        }

        private void Pasien_RekamMedis_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection con = conn.GetConn();
            con.Open();
            cmd = new SqlCommand("SELECT RekamMedis.RekamMedisID  ,Pasien.Nama_Pasien,Dokter.Nama_Dokter,RekamMedis.Diagnosa,RekamMedis.Tindakan,RekamMedis.Tanggal,RekamMedis.CatatanTambahan " +
                  "FROM RekamMedis " +
                  "INNER JOIN Pasien ON RekamMedis.PasienID = Pasien.PasienID " +
                  "INNER JOIN Dokter ON RekamMedis.DokterID = Dokter.DokterID " +
                  "WHERE Nama_Pasien =@nama ", con);
            cmd.Parameters.AddWithValue("@nama", lblNama.Text);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                lblNama.Text = reader[1].ToString();
                reader.Close();
            }

            loaddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT RekamMedis.RekamMedisID, Pasien.Nama_Pasien, Dokter.Nama_Dokter, " +
                                 "RekamMedis.Diagnosa, RekamMedis.Tindakan, RekamMedis.Tanggal, RekamMedis.CatatanTambahan " +
                                 "FROM RekamMedis " +
                                 "INNER JOIN Pasien ON RekamMedis.PasienID = Pasien.PasienID " +
                                 "INNER JOIN Dokter ON RekamMedis.DokterID = Dokter.DokterID " +
                                 "WHERE Pasien.Nama_Pasien LIKE @search " +
                                 "OR Dokter.Nama_Dokter LIKE @search " +
                                 "OR RekamMedis.Diagnosa LIKE @search " +
                                 "OR RekamMedis.Tindakan LIKE @search " +
                                 "OR RekamMedis.Tanggal LIKE @search " +
                                 "OR RekamMedis.CatatanTambahan LIKE @search", con);

            cmd.Parameters.AddWithValue("@search", "%" + txtsearch.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "RekamMedis");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RekamMedis";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }
    }
}
