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

namespace Aplikasi_klinik_Harapan
{
    public partial class ManajemenTransaksiObat : Form
    {

        Koneksi kon = new Koneksi();
        SqlDataAdapter da;
        SqlDataReader rd;
        SqlCommand cmd;
        DataSet ds;
        public ManajemenTransaksiObat()
        {
            InitializeComponent();
        }

        void kondisiawal()
        {
            txtHarga.Text = "";
            txtID.Text = "";

            comboApoteker.SelectedIndex = -1;
            comboMetode.SelectedIndex = -1;
            comboPasien.SelectedIndex = -1;

            Tanggal.Enabled = false;
            txtID.Enabled = false;
            txtHarga.Enabled = false;
            comboPasien.Enabled = false;
            comboMetode.Enabled = false;
            comboApoteker.Enabled = false;
            RadioLunas.Enabled = false;
            RadioTidakLunas.Enabled = false;

            btnTambah.Text = "Tambah";
            btnEdit.Text = "Edit";
            load_Apoteker();
            load_pasien();
            loadMetode();
            loaddata();
        }

        void tambahaktif()
        {
            Tanggal.Enabled = true;
            txtID.Enabled = false;
            txtHarga.Enabled = true;
            comboPasien.Enabled = true;
            comboMetode.Enabled = true;
            comboApoteker.Enabled = true;
            RadioLunas.Enabled = true;
            RadioTidakLunas.Enabled = true;

            btnTambah.Text = "Simpan";
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
        }
        void editaktif()
        {
            Tanggal.Enabled = true;
            txtID.Enabled = true;
            txtHarga.Enabled = true;
            comboPasien.Enabled = true;
            comboMetode.Enabled = true;
            comboApoteker.Enabled = true;
            RadioLunas.Enabled = true;
            RadioTidakLunas.Enabled = true;


            btnEdit.Text = "Simpan";
            btnHapus.Enabled = true;
            btnTambah.Enabled = false;
        }

        void loaddata()
        {
            SqlConnection konek = kon.GetConn();
            cmd = new SqlCommand("SELECT TransaksiObat.TransaksiID,  Pasien.Nama_Pasien,Apoteker.Nama,TransaksiObat.TotalHarga,TransaksiObat.MetodePembayaran,TransaksiObat.StatusPembayaran,TransaksiObat.Tanggal " +
                " FROM TransaksiObat " +
                "INNER JOIN Apoteker ON TransaksiObat.ApotekerID = Apoteker.ApotekerID " +
                "INNER JOIN Pasien ON TransaksiObat.PasienID = Pasien.PasienID ", konek);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TransaksiObat");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TransaksiObat";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        void load_pasien()
        {
            SqlConnection con = kon.GetConn();
            con.Open();

            string query = "SELECT DISTINCT Nama_Pasien FROM Pasien";
            cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();

            comboPasien.Items.Clear();

            while (rd.Read())
            {
                comboPasien.Items.Add(rd["Nama_Pasien"].ToString());
            }


            con.Close();
        }

        void load_Apoteker()
        {
            SqlConnection con = kon.GetConn();
            con.Open();

            string query = "SELECT DISTINCT Nama FROM Apoteker";
            cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();

            comboApoteker.Items.Clear();

            while (rd.Read())
            {
                comboApoteker.Items.Add(rd["Nama"].ToString());
            }


            con.Close();
        }


        void loadMetode()
        {
            comboMetode.Items.Add("Uang Tunai");
            comboMetode.Items.Add("Kartu Kredit");
            comboMetode.Items.Add("Transfer Bank");
            comboMetode.Items.Add("Qris");
        }

        private void ManajemenTransaksiObat_Load(object sender, EventArgs e)
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

                if (comboApoteker.SelectedIndex == -1 ||
                    comboPasien.SelectedIndex == -1 ||
                    comboMetode.SelectedIndex == -1 ||
                    Tanggal.Text.Trim() == "")
                {
                    MessageBox.Show("Pastikan semua data di form telah diisi lengkap!");
                    return;
                }

                SqlConnection con = kon.GetConn();
                con.Open();

                // Status Pembayaran
                string Status = RadioLunas.Checked ? "Lunas" : "Tidak Lunas";

                // Ambil ID Apoteker
                string selectedApoteker = comboApoteker.SelectedItem.ToString();
                string queryApoteker = "SELECT ApotekerID FROM Apoteker WHERE Nama = @tipeApoteker";
                cmd = new SqlCommand(queryApoteker, con);
                cmd.Parameters.AddWithValue("@tipeApoteker", selectedApoteker);
                object resultApoteker = cmd.ExecuteScalar();

                if (resultApoteker == null)
                {
                    MessageBox.Show("Data Apoteker yang dipilih tidak valid.");
                    con.Close();
                    return;
                }
                int idApoteker = Convert.ToInt32(resultApoteker);

                // Ambil ID Pasien
                string selectedPasien = comboPasien.SelectedItem.ToString();
                string queryPasien = "SELECT PasienID FROM Pasien WHERE Nama_Pasien = @tipepasien";
                cmd = new SqlCommand(queryPasien, con);
                cmd.Parameters.AddWithValue("@tipepasien", selectedPasien);
                object resultPasien = cmd.ExecuteScalar();

                if (resultPasien == null)
                {
                    MessageBox.Show("Data Pasien yang dipilih tidak valid.");
                    con.Close();
                    return;
                }
                int idPasien = Convert.ToInt32(resultPasien);

                // Tanggal Transaksi
                DateTime dibuat = Convert.ToDateTime(Tanggal.Text);
                string waktuDibuat = dibuat.ToString("yyyy-MM-dd");

                // Metode Pembayaran
                string metode = comboMetode.SelectedItem.ToString();

                // Simpan Data ke Database
                cmd = new SqlCommand("INSERT INTO TransaksiObat (PasienID, ApotekerID, MetodePembayaran, StatusPembayaran, Tanggal) " +
                                     "VALUES (@pasien, @apoteker, @metode, @status, @tanggal)", con);
                cmd.Parameters.AddWithValue("@pasien", idPasien);
                cmd.Parameters.AddWithValue("@apoteker", idApoteker);
                cmd.Parameters.AddWithValue("@metode", metode);
                cmd.Parameters.AddWithValue("@status", Status);
                cmd.Parameters.AddWithValue("@tanggal", waktuDibuat);

                cmd.ExecuteNonQuery();
                con.Close();

                kondisiawal();
                MessageBox.Show("Data Transaksi Berhasil Ditambahkan");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                editaktif();
            }
            else
            {
                if (comboApoteker.SelectedIndex == -1 ||
          comboPasien.SelectedIndex == -1 ||
          comboMetode.SelectedIndex == -1 ||
          txtID.Text.Trim() == "")
                {
                    MessageBox.Show("Pastikan Mengisi Data Yang Ada Di Form");
                }
                else
                {
                    SqlConnection con = kon.GetConn();
                    con.Open();

                    //Status
                    String Status = "Tidak Lunas";
                    if (RadioLunas.Checked)
                    {
                        Status = "Lunas";
                    }
                    else
                    {
                        Status = "Tidak Lunas";
                    }


                    //Data Apoteker
                    string selectedApoteker = comboApoteker.SelectedItem.ToString();
                    string query3 = "SELECT ApotekerID FROM Apoteker WHERE Nama = @tipeApoteker";
                    cmd = new SqlCommand(query3, con);
                    cmd.Parameters.AddWithValue("@tipeApoteker", selectedApoteker);

                    object result2 = cmd.ExecuteScalar();
                    if (result2 == null)
                    {
                        MessageBox.Show("Data Apoteker yang dipilih tidak valid.");
                        con.Close();
                        return;
                    }
                    int idApoteker = Convert.ToInt32(result2);

                    //Data Pasien
                    string selectedpasien = comboPasien.SelectedItem.ToString();
                    string query = "SELECT PasienID FROM Pasien WHERE Nama_Pasien = @tipepasien";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@tipepasien", selectedpasien);
                    object result3 = cmd.ExecuteScalar();

                    if (result3 == null)
                    {
                        MessageBox.Show("Data Pasien yang dipilih tidak valid.");
                        con.Close();
                        return;
                    }

                    int idpasien = Convert.ToInt32(result3);

                    //Tanggal
                    DateTime Dibuat = Convert.ToDateTime(Tanggal.Text);
                    string waktudibuat = Dibuat.ToString("yyyy-MM-dd");

                    //metode
                    String Metode = comboMetode.SelectedItem.ToString();

                    cmd = new SqlCommand("UPDATE TransaksiObat SET PasienID = @pasien, ApotekerID = @apoteker, MetodePembayaran = @metode, StatusPembayaran = @status, Tanggal = @tanggal WHERE TransaksiID = @id", con);
                    cmd.Parameters.AddWithValue("@pasien", idpasien);
                    cmd.Parameters.AddWithValue("@apoteker", idApoteker);
                    cmd.Parameters.AddWithValue("@metode", Metode);
                    cmd.Parameters.AddWithValue("@status", Status);
                    cmd.Parameters.AddWithValue("@tanggal", waktudibuat);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);

                    cmd.ExecuteNonQuery();

                    kondisiawal();
                    MessageBox.Show("Data Berhasil di Ubah");
                }
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlDataReader reader = null;
                SqlConnection con = kon.GetConn();
                con.Open();
                cmd = new SqlCommand("SELECT TransaksiObat.TransaksiID  Pasien.Nama_Pasien,Apoteker.Nama,TransaksiObat.TotalHarga,TransaksiObat.MetodePembayaran,TransaksiObat.StatusPembayaran,TransaksiObat.Tanggal " +
                " FROM TransaksiObat " +
                "INNER JOIN Apoteker ON TransaksiObat.ApotekerID = Apoteker.ApotekerID " +
                "INNER JOIN Pasien ON TransaksiObat.PasienID = Pasien.PasienID " +
                "WHERE TransaksiObat.TransaksiID = @id", con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    comboPasien.Text = reader[1].ToString();
                    comboApoteker.Text = reader[2].ToString();
                    txtHarga.Text = reader[3].ToString();
                    comboMetode.Text = reader[4].ToString();
                    Tanggal.Text = reader[6].ToString();
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Data Transaksi Tidak Ada");
                }
                editaktif();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data Ini", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = kon.GetConn();
                con.Open();

                cmd = new SqlCommand("Delete From TransaksiObat where TransaksiID= '" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Transaksi Berhasil Di Hapus");
                kondisiawal();
            }
            else
            {
                kondisiawal();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlConnection konek = kon.GetConn();

            string query = "SELECT t.TransaksiID, p.Nama_Pasien, a.Nama AS Nama_Apoteker, " +
                           "t.TotalHarga, t.MetodePembayaran, t.StatusPembayaran, t.Tanggal " +
                           "FROM TransaksiObat t " +
                           "INNER JOIN Apoteker a ON t.ApotekerID = a.ApotekerID " +
                           "INNER JOIN Pasien p ON t.PasienID = p.PasienID " +
                           "WHERE p.Nama_Pasien LIKE @search " +
                           "ORDER BY t.Tanggal DESC";  

            cmd = new SqlCommand(query, konek);
            cmd.Parameters.AddWithValue("@search", "%" + txtCari.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TransaksiObat");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TransaksiObat";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
