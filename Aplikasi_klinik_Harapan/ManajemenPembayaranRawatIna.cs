using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Aplikasi_klinik_Harapan
{
    public partial class ManajemenPembayaranRawatIna : Form
    {

        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        void loaddata()
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT   PembayaranRawatInap.ID_Pembayaran,PembayaranRawatInap.Tanggal_Pembayaran,PembayaranRawatInap.Total_Biaya,PembayaranRawatInap.Metode_Pembayaran,PembayaranRawatInap.Status_Pembayaran,PembayaranRawatInap.Keterangan  ,RawatInap.RawatInapID,Pasien.Nama_Pasien,Kamar.NomorKamar,RawatInap.TanggalMasuk,RawatInap.TanggalKeluar " +
                "From PembayaranRawatInap " +
                "INNER JOIN RawatInap ON PembayaranRawatInap.RawatInapID = RawatInap.RawatInapID " +
                "INNER JOIN Pasien ON RawatInap.PasienID = Pasien.PasienID " +
                "INNER JOIN Kamar ON RawatInap.KamarID = Kamar.KamarID", con);

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "PembayaranRawatInap");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "PembayaranRawatInap";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        public ManajemenPembayaranRawatIna()
        {
            InitializeComponent();
        }

        void loadmetode()
        {
            comboMetode.Items.Add("CASH");
            comboMetode.Items.Add("KREDIT");
            comboMetode.Items.Add("TRANSFER");
            comboMetode.Items.Add("QRIS");
        }



        void kondisiawal()
        {
            txtTotal.Text = "";
            txtID.Text = "";
            txtKeterangan.Text = "";
            comboMetode.SelectedIndex = -1;
            comboIDrawat.SelectedIndex = -1;

            comboIDrawat.Enabled = false;
            tglbayar.Enabled = false;
            txtTotal.Enabled = false;
            txtKeterangan.Enabled = false;
            txtID.Enabled = false;
            comboMetode.Enabled = false;



            btnAdd.Text = "Add";
            loaddata();
            loadmetode();
        }

        void tambahaktif()
        {
            btnAdd.Text = "Save";

            comboIDrawat.Enabled = true;
            tglbayar.Enabled = true;
            txtTotal.Enabled = false;
            txtKeterangan.Enabled = true;
            txtID.Enabled = false;
          comboMetode.Enabled = true;
        }

        void load_rawat()
        {
            SqlConnection con = conn.GetConn();
            con.Open();

            string query = "SELECT DISTINCT RawatInapID FROM RawatInap";
            cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();

            comboIDrawat.Items.Clear();

            while (rd.Read())
            {
                comboIDrawat.Items.Add(rd["RawatInapID"].ToString());
            }

            con.Close();
        }

        private void ManajemenPembayaranRawatIna_Load(object sender, EventArgs e)
        {
            load_rawat();
            kondisiawal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                tambahaktif();
            }
            else
            {
                // Validasi semua form harus diisi
                if (
                    txtKeterangan.Text.Trim() == "" ||
                    comboIDrawat.SelectedIndex == -1 ||
                    tglbayar.Text.Trim() == "" ||
                    (!radiolunas.Checked && !radiotidaklunas.Checked))
                {
                    MessageBox.Show("Pastikan semua data di form telah diisi lengkap!");
                }
                else
                {
                    SqlConnection koneksi = conn.GetConn();
                    koneksi.Open();

                    // Ambil ID Rawat Inap
                    string selectedrawat = comboIDrawat.SelectedItem.ToString();
                    string query2 = "SELECT RawatInapID, TanggalMasuk, TanggalKeluar, KamarID FROM RawatInap WHERE RawatInapID = @tiperawatid";
                    cmd = new SqlCommand(query2, koneksi);
                    cmd.Parameters.AddWithValue("@tiperawatid", selectedrawat);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("Data Rawat Inap yang dipilih tidak valid.");
                        koneksi.Close();
                        return;
                    }

                    int idrawat = Convert.ToInt32(reader["RawatInapID"]);
                    DateTime tanggalMasuk = Convert.ToDateTime(reader["TanggalMasuk"]);
                    DateTime tanggalKeluar = Convert.ToDateTime(reader["TanggalKeluar"]);
                    int idKamar = Convert.ToInt32(reader["KamarID"]);
                    reader.Close();

                    // Hitung lama rawat inap
                    int lamaInap = (tanggalKeluar - tanggalMasuk).Days;
                    if (lamaInap <= 0) lamaInap = 1; // Minimal 1 hari

                    // Ambil Tarif Kamar
                    string queryTarif = "SELECT TarifHarian FROM Kamar WHERE KamarID = @kamarid";
                    cmd = new SqlCommand(queryTarif, koneksi);
                    cmd.Parameters.AddWithValue("@kamarid", idKamar);

                    object tarifResult = cmd.ExecuteScalar();
                    if (tarifResult == null)
                    {
                        MessageBox.Show("Tarif kamar tidak ditemukan.");
                        koneksi.Close();
                        return;
                    }

                    decimal tarifKamar = Convert.ToDecimal(tarifResult);
                    decimal totalBiaya = lamaInap * tarifKamar; // Hitung total biaya

                    // Ambil Waktu Pembayaran
                    DateTime bayar = Convert.ToDateTime(tglbayar.Text);
                    string WaktuBayar = bayar.ToString("yyyy-MM-dd");

                    // Status Pembayaran
                    string Status = radiolunas.Checked ? "Lunas" : "Belum Lunas";

                    // Insert Data ke PembayaranRawatInap
                    cmd = new SqlCommand("INSERT INTO PembayaranRawatInap(RawatInapID, Tanggal_Pembayaran, Total_Biaya, Metode_Pembayaran, Status_Pembayaran, Keterangan) " +
                                         "VALUES(@RawatinapID, @tglbayar, @total, @metode, @status, @keterangan)", koneksi);

                    cmd.Parameters.AddWithValue("@RawatinapID", idrawat);
                    cmd.Parameters.AddWithValue("@tglbayar", WaktuBayar);
                    cmd.Parameters.AddWithValue("@total", totalBiaya);
                    cmd.Parameters.AddWithValue("@metode", comboMetode.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@status", Status);
                    cmd.Parameters.AddWithValue("@keterangan", txtKeterangan.Text);

                    cmd.ExecuteNonQuery();
                    koneksi.Close();
                    kondisiawal();
                    MessageBox.Show("Data Pembayaran Berhasil Ditambahkan");
                }
            }

        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();

            string query = "SELECT pbi.ID_Pembayaran, pbi.Tanggal_Pembayaran, pbi.Total_Biaya, pbi.Metode_Pembayaran, " +
                           "pbi.Status_Pembayaran, pbi.Keterangan, ri.RawatInapID, ps.Nama_Pasien, km.NomorKamar, " +
                           "ri.TanggalMasuk, ri.TanggalKeluar " +
                           "FROM PembayaranRawatInap pbi " +
                           "INNER JOIN RawatInap ri ON pbi.RawatInapID = ri.RawatInapID " +
                           "INNER JOIN Pasien ps ON ri.PasienID = ps.PasienID " +
                           "INNER JOIN Kamar km ON ri.KamarID = km.KamarID " +
                           "WHERE ps.Nama_Pasien LIKE @search " +
                           "OR km.NomorKamar LIKE @search " +
                           "OR pbi.Status_Pembayaran LIKE @search " +
                           "ORDER BY pbi.Tanggal_Pembayaran DESC";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "PembayaranRawatInap");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "PembayaranRawatInap";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hapus"].Index)
            {
                // Mengambil nomor kamar dari baris yang dipilih
                string idbayar = dataGridView1.Rows[e.RowIndex].Cells["ID_Pembayaran"].Value.ToString();

                // Menghapus data dari database
                SqlConnection con = conn.GetConn();
                con.Open();

                // Query untuk menghapus data di tabel FasilitasBerdasarkanTipeKamar
                string queryDelete = "DELETE From PembayaranRawatInap WHERE ID_Pembayaran =@idbayar";
                cmd = new SqlCommand(queryDelete, con);
                cmd.Parameters.AddWithValue("@idbayar", idbayar);
                cmd.ExecuteNonQuery();

                con.Close();

                // Menghapus baris dari DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
