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
    public partial class Dokter_JadwalPraktik : Form
    {
        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public string nama
        {
            get { return lblNama.Text; }
            set { lblNama.Text = value; }
        }

        void loaddata()
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT JadwalDokter.JadwalID ,Dokter.Nama_Dokter,JadwalDokter.Hari,JadwalDokter.JamMulai,JadwalDokter.JamSelesai " +
                "FROM JadwalDokter " +
                "INNER JOIN Dokter ON JadwalDokter.DokterID = Dokter.DokterID " +
                "WHERE Dokter.Nama_Dokter =@dokter", con);
            cmd.Parameters.AddWithValue("@dokter", lblNama.Text);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "JadwalDokter");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "JadwalDokter";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        public Dokter_JadwalPraktik()
        {
            InitializeComponent();
        }

        private void Dokter_JadwalPraktik_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();

            string query = "SELECT JadwalDokter.JadwalID, Dokter.Nama_Dokter, JadwalDokter.Hari, " +
                "JadwalDokter.JamMulai, JadwalDokter.JamSelesai " +
                "FROM JadwalDokter " +
                "INNER JOIN Dokter ON JadwalDokter.DokterID = Dokter.DokterID " +
                "WHERE Dokter.Nama_Dokter = @dokter ";

            if (!string.IsNullOrWhiteSpace(txtCari.Text))
            {
                query += "AND (JadwalDokter.Hari LIKE @search " +
                         "OR JadwalDokter.JamMulai LIKE @search " +
                         "OR JadwalDokter.JamSelesai LIKE @search) ";
            }

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@dokter", lblNama.Text);

            if (!string.IsNullOrWhiteSpace(txtCari.Text))
            {
                cmd.Parameters.AddWithValue("@search", "%" + txtCari.Text.Trim() + "%");
            }

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "JadwalDokter");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "JadwalDokter";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Selesai"].Index)
            {
                // Mengambil nomor kamar dari baris yang dipilih
                string idjadwal = dataGridView1.Rows[e.RowIndex].Cells["JadwalID"].Value.ToString();

                // Menghapus data dari database
                SqlConnection con = conn.GetConn();
                con.Open();

                // Query untuk menghapus data di tabel FasilitasBerdasarkanTipeKamar
                string queryDelete = "DELETE From JadwalDokter WHERE JadwalID =@idjadwal";
                cmd = new SqlCommand(queryDelete, con);
                cmd.Parameters.AddWithValue("@idjadwal", idjadwal);
                cmd.ExecuteNonQuery();

                con.Close();

                // Menghapus baris dari DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
