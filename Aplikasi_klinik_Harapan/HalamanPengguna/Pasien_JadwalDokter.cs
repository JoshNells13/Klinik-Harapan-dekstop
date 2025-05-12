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

namespace Aplikasi_klinik_Harapan.HalamanPengguna
{
    public partial class Pasien_JadwalDokter : Form
    {

        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        void loaddata()
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT JadwalDokter.JadwalID ,Dokter.Nama_Dokter,JadwalDokter.Hari,JadwalDokter.JamMulai,JadwalDokter.JamSelesai " +
                "FROM JadwalDokter " +
                "INNER JOIN Dokter ON JadwalDokter.DokterID = Dokter.DokterID", con);

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "JadwalDokter");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "JadwalDokter";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        public Pasien_JadwalDokter()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pasien_JadwalDokter_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT JadwalDokter.JadwalID, Dokter.Nama_Dokter, JadwalDokter.Hari, " +
                                 "JadwalDokter.JamMulai, JadwalDokter.JamSelesai " +
                                 "FROM JadwalDokter " +
                                 "INNER JOIN Dokter ON JadwalDokter.DokterID = Dokter.DokterID " +
                                 "WHERE Dokter.Nama_Dokter LIKE @search " +
                                 "OR JadwalDokter.Hari LIKE @search " +
                                 "OR JadwalDokter.JamMulai LIKE @search " +
                                 "OR JadwalDokter.JamSelesai LIKE @search", con);

            cmd.Parameters.AddWithValue("@search", "%" + txtCari.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "JadwalDokter");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "JadwalDokter";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }
    }
}
