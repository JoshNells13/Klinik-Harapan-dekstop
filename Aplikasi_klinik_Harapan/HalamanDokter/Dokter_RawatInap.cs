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

namespace Aplikasi_klinik_Harapan.HalamanDokter
{
    public partial class Dokter_RawatInap : Form
    {
        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public Dokter_RawatInap()
        {
            InitializeComponent();
        }

        public string nama
        {
            get { return lblNama.Text; }
            set { lblNama.Text = value; }
        }

        void loaddata()
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT RawatInap.RawatInapID,Pasien.Nama_Pasien,Dokter.Nama_Dokter,Kamar.NomorKamar,RawatInap.TanggalMasuk,RawatInap.TanggalKeluar,RawatInap.Diagnosa,RawatInap.Status " +
                "From RawatInap " +
                "INNER JOIN Kamar ON RawatInap.KamarID = Kamar.KamarID " +
                "INNER JOIN Dokter ON RawatInap.DokterID = Dokter.DokterID " +
                "INNER JOIN Pasien ON RawatInap.PasienID = Pasien.PasienID " +
                "WHERE Dokter.Nama_Dokter = @dokter", con);
            cmd.Parameters.AddWithValue("@dokter", lblNama.Text);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "RawatInap");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RawatInap";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        private void Dokter_RawatInap_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();
            string query = "SELECT RawatInap.RawatInapID, Pasien.Nama_Pasien, Dokter.Nama_Dokter, " +
                "Kamar.NomorKamar, RawatInap.TanggalMasuk, RawatInap.TanggalKeluar, " +
                "RawatInap.Diagnosa, RawatInap.Status " +
                "FROM RawatInap " +
                "INNER JOIN Kamar ON RawatInap.KamarID = Kamar.KamarID " +
                "INNER JOIN Dokter ON RawatInap.DokterID = Dokter.DokterID " +
                "INNER JOIN Pasien ON RawatInap.PasienID = Pasien.PasienID " +
                "WHERE Dokter.Nama_Dokter = @dokter ";

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                query += "AND (Pasien.Nama_Pasien LIKE @search " +
                         "OR Kamar.NomorKamar LIKE @search " +
                         "OR RawatInap.TanggalMasuk LIKE @search " +
                         "OR RawatInap.TanggalKeluar LIKE @search " +
                         "OR RawatInap.Diagnosa LIKE @search " +
                         "OR RawatInap.Status LIKE @search) ";
            }

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@dokter", lblNama.Text);

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");
            }

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "RawatInap");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RawatInap";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();


        }
    }
}
