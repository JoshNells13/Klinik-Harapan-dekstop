using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Aplikasi_klinik_Harapan
{
    public partial class DetailTransaksiObat : Form
    {
        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        void kondisiawal()
        {
            txtJumlah.Text = "";
            comboTransaksi.Enabled = false;
            comboObat.Enabled = false;
            txtJumlah.Enabled = false;

            btnTambah.Text = "Tambah";

            loaddata();
            loadObat();
            load_TransaksiID();
        }

        void loaddata()
        {
            SqlConnection konek = conn.GetConn();
            cmd = new SqlCommand("SELECT  dt.DetailTransaksiID, o.NamaObat, dt.TransaksiID, dt.Jumlah, dt.HargaSatuan, " +
                      "p.Nama_Pasien, a.Nama AS Nama_Apoteker, t.TotalHarga, t.MetodePembayaran, t.StatusPembayaran, t.Tanggal " +
                      "FROM DetailTransaksiObat dt " +
                      "INNER JOIN TransaksiObat t ON dt.TransaksiID = t.TransaksiID " +
                      "INNER JOIN Pasien p ON t.PasienID = p.PasienID " +
                      "INNER JOIN Apoteker a ON t.ApotekerID = a.ApotekerID " +
                      "INNER JOIN Obat o ON dt.ObatID = o.ObatID", konek);

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "DetailTransaksiObat");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "DetailTransaksiObat";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        void tambahaktif()
        {
            comboTransaksi.Enabled = true;
            comboObat.Enabled = true;
            txtJumlah.Enabled = true;


            btnTambah.Text = "Simpan";
        }


        void loadObat()
        {
            SqlConnection con = conn.GetConn();
            con.Open();

            string query = "SELECT DISTINCT NamaObat FROM Obat";
            cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();

            comboObat.Items.Clear();

            while (rd.Read())
            {
                comboObat.Items.Add(rd["NamaObat"].ToString());
            }

            con.Close();
        }

        void load_TransaksiID()
        {
            SqlConnection con = conn.GetConn();
            con.Open();

            string query = "SELECT DISTINCT TransaksiID FROM TransaksiObat";
            cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();

            comboTransaksi.Items.Clear();

            while (rd.Read())
            {
                comboTransaksi.Items.Add(rd["TransaksiID"].ToString());
            }

            con.Close();
        }

        public DetailTransaksiObat()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hapus"].Index)
            {
                // Mengambil nomor kamar dari baris yang dipilih
                string detailtransaksi = dataGridView1.Rows[e.RowIndex].Cells["DetailTransaksiID"].Value.ToString();

                // Menghapus data dari database
                SqlConnection con = conn.GetConn();
                con.Open();

                // Query untuk menghapus data di tabel FasilitasBerdasarkanTipeKamar
                string queryDelete = "DELETE FROM DetailTransaksiObat WHERE DetailTransaksiID =@detail_Transaksi ";
                cmd = new SqlCommand(queryDelete, con);
                cmd.Parameters.AddWithValue("@detail_Transaksi", detailtransaksi);
                cmd.ExecuteNonQuery();

                con.Close();

                // Menghapus baris dari DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection konek = conn.GetConn();

            string query = "SELECT dt.DetailTransaksiID, o.NamaObat, dt.TransaksiID, dt.Jumlah, dt.HargaSatuan, " +
                           "p.Nama_Pasien, a.Nama AS Nama_Apoteker, t.TotalHarga, t.MetodePembayaran, t.StatusPembayaran, t.Tanggal " +
                           "FROM DetailTransaksiObat dt " +
                           "INNER JOIN TransaksiObat t ON dt.TransaksiID = t.TransaksiID " +
                           "INNER JOIN Pasien p ON t.PasienID = p.PasienID " +
                           "INNER JOIN Apoteker a ON t.ApotekerID = a.ApotekerID " +
                           "INNER JOIN Obat o ON dt.ObatID = o.ObatID";

            if (!string.IsNullOrWhiteSpace(txtCari.Text))
            {
                query += " WHERE o.NamaObat LIKE @search " +
                         "OR p.Nama_Pasien LIKE @search " +
                         "OR a.Nama LIKE @search " +
                         "OR t.MetodePembayaran LIKE @search " +
                         "OR t.StatusPembayaran LIKE @search " +
                         "OR t.Tanggal LIKE @search";
            }

            cmd = new SqlCommand(query, konek);
            cmd.Parameters.AddWithValue("@search", "%" + txtCari.Text.Trim() + "%");

            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "DetailTransaksiObat");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "DetailTransaksiObat";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        private void DetailTransaksiObat_Load(object sender, EventArgs e)
        {
            kondisiawal();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (btnTambah.Text == "Tambah")
            {
                tambahaktif();
            }
            else
            {
                if (comboObat.SelectedIndex == -1 || txtJumlah.Text.Trim() == "" || comboTransaksi.SelectedIndex == -1)
                {
                    MessageBox.Show("Pastikan Mengisi Data Yang Ada");
                }
                else
                {
                    SqlConnection konek = conn.GetConn();
                    konek.Open();

                    string namaObat = comboObat.SelectedItem.ToString();
                    int transaksiID = Convert.ToInt32(comboTransaksi.SelectedItem.ToString());
                    int jumlah = Convert.ToInt32(txtJumlah.Text);

                    // **Ambil ObatID, Harga, dan Stok dari NamaObat**
                    string queryObatID = "SELECT ObatID, Harga, Stok FROM Obat WHERE NamaObat = @NamaObat";
                    SqlCommand cmdObat = new SqlCommand(queryObatID, konek);
                    cmdObat.Parameters.AddWithValue("@NamaObat", namaObat);

                    SqlDataReader reader = cmdObat.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("Obat tidak ditemukan!");
                        reader.Close();
                        return;
                    }

                    int obatID = reader.GetInt32(0);
                    decimal hargaSatuan = reader.GetDecimal(1);
                    int stok = reader.GetInt32(2);
                    reader.Close();

                    // **Cek stok tersedia**
                    if (stok < jumlah)
                    {
                        MessageBox.Show("Stok tidak mencukupi!");
                        return;
                    }

                    // **Hitung total harga transaksi ini**
                    decimal totalHargaBaru = jumlah * hargaSatuan;

                    // **Masukkan data ke DetailTransaksiObat**
                    string insertDetail = "INSERT INTO DetailTransaksiObat (TransaksiID, ObatID, Jumlah, HargaSatuan) " +
                                          "VALUES (@TransaksiID, @ObatID, @Jumlah, @HargaSatuan)";
                    SqlCommand cmdInsert = new SqlCommand(insertDetail, konek);
                    cmdInsert.Parameters.AddWithValue("@TransaksiID", transaksiID);
                    cmdInsert.Parameters.AddWithValue("@ObatID", obatID);
                    cmdInsert.Parameters.AddWithValue("@Jumlah", jumlah);
                    cmdInsert.Parameters.AddWithValue("@HargaSatuan", hargaSatuan);
                    cmdInsert.ExecuteNonQuery();

                    // **Kurangi stok obat**
                    string updateStok = "UPDATE Obat SET Stok = Stok - @Jumlah WHERE ObatID = @ObatID";
                    SqlCommand cmdUpdateStok = new SqlCommand(updateStok, konek);
                    cmdUpdateStok.Parameters.AddWithValue("@Jumlah", jumlah);
                    cmdUpdateStok.Parameters.AddWithValue("@ObatID", obatID);
                    cmdUpdateStok.ExecuteNonQuery();

                    // **UPDATE Total Harga di TransaksiObat**
                    string updateTotalHarga = "UPDATE TransaksiObat SET TotalHarga = COALESCE(TotalHarga, 0) + @TotalHargaBaru WHERE TransaksiID = @TransaksiID";
                    SqlCommand cmdUpdateTotal = new SqlCommand(updateTotalHarga, konek);
                    cmdUpdateTotal.Parameters.AddWithValue("@TotalHargaBaru", totalHargaBaru);
                    cmdUpdateTotal.Parameters.AddWithValue("@TransaksiID", transaksiID);
                    cmdUpdateTotal.ExecuteNonQuery();

                    MessageBox.Show($"Detail transaksi berhasil ditambahkan! Total harga transaksi bertambah {totalHargaBaru:C}");

                    // **Refresh tampilan**
                    kondisiawal();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
