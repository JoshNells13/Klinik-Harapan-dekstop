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

namespace Aplikasi_klinik_Harapan.HalamanDokter
{
    public partial class Dokter_JadwaAntrian : Form
    {
        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        void load_antrian()
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT Antrian.AntrianID, Pasien.Nama_Pasien,Dokter.Nama_Dokter,Antrian.NomorAntrian,Antrian.Status,Antrian.WaktuPendaftaran,Antrian.WaktuPanggil " +
                "FROM Antrian " +
                "INNER JOIN Dokter ON Antrian.DokterID = Dokter.DokterID " +
                "INNER JOIN Pasien ON Antrian.PasienID = Pasien.PasienID " +
                "WHERE Dokter.Nama_Dokter = @dokter", con);
            cmd.Parameters.AddWithValue("@dokter",lblNama.Text);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Antrian");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Antrian";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }
        public Dokter_JadwaAntrian()
        {
            InitializeComponent();
        }

        public string nama
        {
            get { return lblNama.Text; }
            set { lblNama.Text = value; }
        }

        private void Dokter_JadwaAntrian_Load(object sender, EventArgs e)
        {
            load_antrian();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();

            string query = "SELECT Antrian.AntrianID, Pasien.Nama_Pasien, Dokter.Nama_Dokter, " +
                "Antrian.NomorAntrian, Antrian.Status, Antrian.WaktuPendaftaran, Antrian.WaktuPanggil " +
                "FROM Antrian " +
                "INNER JOIN Dokter ON Antrian.DokterID = Dokter.DokterID " +
                "INNER JOIN Pasien ON Antrian.PasienID = Pasien.PasienID " +
                "WHERE Dokter.Nama_Dokter = @dokter ";

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                query += "AND (Antrian.NomorAntrian LIKE @search " +
                         "OR Pasien.Nama_Pasien LIKE @search " +
                         "OR Antrian.Status LIKE @search " +
                         "OR Antrian.WaktuPendaftaran LIKE @search " +
                         "OR Antrian.WaktuPanggil LIKE @search) ";
            }

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@dokter", lblNama.Text);

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");
            }

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Antrian");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Antrian";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }
    }
}
