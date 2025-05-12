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
    public partial class Dokter_RekamMedis : Form
    {
        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public Dokter_RekamMedis()
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

            cmd = new SqlCommand("SELECT RekamMedis.RekamMedisID  ,Pasien.Nama_Pasien,Dokter.Nama_Dokter,RekamMedis.Diagnosa,RekamMedis.Tindakan,RekamMedis.Tanggal,RekamMedis.CatatanTambahan " +
                "FROM RekamMedis " +
                "INNER JOIN Pasien ON RekamMedis.PasienID = Pasien.PasienID " +
                "INNER JOIN Dokter ON RekamMedis.DokterID = Dokter.DokterID " +
                "WHERE Dokter.Nama_Dokter = @dokter", con);
            cmd.Parameters.AddWithValue("@dokter", lblNama.Text);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "RekamMedis");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RekamMedis";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        private void Dokter_RekamMedis_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();
            string query = "SELECT RekamMedis.RekamMedisID, Pasien.Nama_Pasien, Dokter.Nama_Dokter, " +
                           "RekamMedis.Diagnosa, RekamMedis.Tindakan, RekamMedis.Tanggal, RekamMedis.CatatanTambahan " +
                           "FROM RekamMedis " +
                           "INNER JOIN Pasien ON RekamMedis.PasienID = Pasien.PasienID " +
                           "INNER JOIN Dokter ON RekamMedis.DokterID = Dokter.DokterID " +
                           "WHERE Dokter.Nama_Dokter = @dokter ";

            if (!string.IsNullOrWhiteSpace(txtsearch.Text))
            {
                query += "AND (Pasien.Nama_Pasien LIKE @search " +
                         "OR RekamMedis.Diagnosa LIKE @search " +
                         "OR RekamMedis.Tindakan LIKE @search " +
                         "OR RekamMedis.Tanggal LIKE @search " +
                         "OR RekamMedis.CatatanTambahan LIKE @search) ";
            }

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@dokter", lblNama.Text);

            if (!string.IsNullOrWhiteSpace(txtsearch.Text))
            {
                cmd.Parameters.AddWithValue("@search", "%" + txtsearch.Text.Trim() + "%");
            }

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "RekamMedis");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RekamMedis";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hapus"].Index)
            {
                // Mengambil nomor kamar dari baris yang dipilih
                string idrekam = dataGridView1.Rows[e.RowIndex].Cells["RekamMedisID"].Value.ToString();

                // Menghapus data dari database
                SqlConnection con = conn.GetConn();
                con.Open();

                // Query untuk menghapus data di tabel FasilitasBerdasarkanTipeKamar
                string queryDelete = "DELETE FROM RekamMedis " +
                                     "WHERE RekamMedisID IN (SELECT RekamMedisID FROM RekamMedis WHERE RekamMedisID = @idrekam)";
                cmd = new SqlCommand(queryDelete, con);
                cmd.Parameters.AddWithValue("@idrekam", idrekam);
                cmd.ExecuteNonQuery();

                con.Close();

                // Menghapus baris dari DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
