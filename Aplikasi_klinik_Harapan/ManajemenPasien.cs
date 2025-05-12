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
    public partial class ManajemenPasien : Form
    {

        Koneksi kon = new Koneksi();
        SqlDataAdapter da;
        SqlDataReader rd;
        SqlCommand cmd;
        DataSet ds;

        void kondisiawal()
        {
            txtAlamat.Text = "";
            txtEmail.Text = "";
            txtAlergi.Text = "";
            txtGolongan.Text = "";
            txtPassword.Text = "";
            txtPenyakit.Text = "";
            txtUsername.Text = "";
            txtNomorHP.Text = "";
            txtNama.Text = "";
            txtID.Text = "";

            txtID.Enabled = false;
            txtNama.Enabled = false;
            txtAlamat.Enabled = false;
            txtEmail.Enabled = false;
            txtAlergi.Enabled = false;
            txtGolongan.Enabled = false;
            txtPassword.Enabled = false;
            txtPenyakit.Enabled = false;
            txtUsername.Enabled = false;
            txtNomorHP.Enabled = false;

            tglLahir.Enabled = false;
            Perempuan.Enabled = false;
            Laki.Enabled = false;

            loaddata();
            Tambah.Text = "Tambah";
        }

        void tambahaktif()
        {
            tglLahir.Enabled = true;
            Perempuan.Enabled = true;
            Laki.Enabled = true;

            txtNama.Enabled = true;
            txtAlamat.Enabled = true;
            txtEmail.Enabled = true;
            txtAlergi.Enabled = true;
            txtGolongan.Enabled = true;
            txtPassword.Enabled = true;
            txtPenyakit.Enabled = true;
            txtUsername.Enabled = true;
            txtNomorHP.Enabled = true;

            Tambah.Text = "Simpan";
        }

        void edit()
        {
            tglLahir.Enabled = true;
            Perempuan.Enabled = true;
            Laki.Enabled = true;

            txtID.Enabled = true;
            txtNama.Enabled = true;
            txtAlamat.Enabled = true;
            txtEmail.Enabled = true;
            txtAlergi.Enabled = true;
            txtGolongan.Enabled = true;
            txtPassword.Enabled = true;
            txtPenyakit.Enabled = true;
            txtUsername.Enabled = true;
            txtNomorHP.Enabled = true;

            ubah.Text = "Simpan";
            Tambah.Enabled = false;

        }

        void edit2()
        {
            tglLahir.Enabled = true;
            Perempuan.Enabled = true;
            Laki.Enabled = true;

            txtID.Enabled = true;
            txtNama.Enabled = true;
            txtAlamat.Enabled = true;
            txtEmail.Enabled = true;
            txtAlergi.Enabled = true;
            txtGolongan.Enabled = true;
            txtPassword.Enabled = true;
            txtPenyakit.Enabled = true;
            txtUsername.Enabled = true;
            txtNomorHP.Enabled = true;


            ubah.Text = "Simpan";
            Tambah.Enabled = false;
        }


        void loaddata()
        {
            SqlConnection conn = kon.GetConn();

            cmd = new SqlCommand("SELECT * FROM Pasien", conn);

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pasien");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Pasien";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        public ManajemenPasien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Tambah.Text == "Tambah")
            {
                tambahaktif();
            }
            else
            {
                // Validasi input wajib
                if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtAlergi.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtNomorHP.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                    string.IsNullOrWhiteSpace(txtGolongan.Text) ||
                    string.IsNullOrWhiteSpace(txtPenyakit.Text) ||
                    string.IsNullOrWhiteSpace(tglLahir.Text))
                {
                    MessageBox.Show("Pastikan semua data di form terisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection conn = kon.GetConn();
                    conn.Open();

                    // Format tanggal lahir
                    DateTime tglborn = Convert.ToDateTime(tglLahir.Text);
                    string formattedDate = tglborn.ToString("yyyy-MM-dd");

                    int StatusAktif = 0;

                    if (Status.Checked)
                    {
                        StatusAktif = 1;
                    }
                    else
                    {
                        StatusAktif = 0;
                    }

                    // Jenis Kelamin
                    string JK = "";
                    if (Laki.Checked)
                        JK = "L";
                    else if (Perempuan.Checked)
                        JK = "P";

                    // Query Insert
                    cmd = new SqlCommand("INSERT INTO Pasien(Nama_Pasien, Username, PasswordHash, TanggalLahir, JenisKelamin, NoHP, Email, Alamat, GolonganDarah, Alergi, RiwayatPenyakit, StatusAktif) " +
                                         "VALUES(@nama, @username, @password, @tgllahir, @JK, @hp, @email, @alamat, @golongan, @alergi, @penyakit, @status)", conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@tgllahir", formattedDate);
                    cmd.Parameters.AddWithValue("@JK", JK);
                    cmd.Parameters.AddWithValue("@hp", txtNomorHP.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@golongan", txtGolongan.Text);
                    cmd.Parameters.AddWithValue("@alergi", txtAlergi.Text);
                    cmd.Parameters.AddWithValue("@penyakit", txtPenyakit.Text);
                    cmd.Parameters.AddWithValue("@status", StatusAktif);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Data Pasien Berhasil Ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kondisiawal();
                }
            }

        }

        private void ManajemenPasien_Load(object sender, EventArgs e)
        {

            loaddata();
            kondisiawal();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection conn = kon.GetConn();

            cmd = new SqlCommand("SELECT * FROM Pasien " +
                "WHERE Nama_Pasien LIKE @search " +
                "OR NoHP LIKE @search " +
                "OR Email LIKE @search " +
                "OR GolonganDarah LIKE @search " +
                "OR Alergi LIKE @search " +
                "OR RiwayatPenyakit LIKE @search", conn);

            cmd.Parameters.AddWithValue("@search", "%" + txtcari.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Pasien");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Pasien";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlDataReader reader = null;
                SqlConnection con = kon.GetConn();
                con.Open();
                cmd = new SqlCommand("Select * from Pasien Where PasienID ='" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNama.Text = reader[1].ToString();
                    txtUsername.Text = reader[2].ToString();
                    txtPassword.Text = reader[3].ToString();
                    tglLahir.Text = reader[4].ToString();
                    txtNomorHP.Text = reader[6].ToString();
                    txtEmail.Text = reader[7].ToString();
                    txtAlamat.Text = reader[8].ToString();
                    txtGolongan.Text = reader[9].ToString();
                    txtAlergi.Text = reader[10].ToString();
                    txtPenyakit.Text = reader[11].ToString();



                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Data Karyawan Tidak Ada");
                }
                edit2();
            }
        }

        private void ubah_Click(object sender, EventArgs e)
        {
            if (ubah.Text == "Edit")
            {
                edit();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtNama.Text) ||
               string.IsNullOrWhiteSpace(txtPassword.Text) ||
               string.IsNullOrWhiteSpace(txtAlergi.Text) ||
               string.IsNullOrWhiteSpace(txtUsername.Text) ||
               string.IsNullOrWhiteSpace(txtNomorHP.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) ||
               string.IsNullOrWhiteSpace(txtAlamat.Text) ||
               string.IsNullOrWhiteSpace(txtGolongan.Text) ||
               string.IsNullOrWhiteSpace(txtPenyakit.Text) ||
               string.IsNullOrWhiteSpace(tglLahir.Text) ||
                 string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Pastikan Mengisi Data Yang Ada Di Form");
                }
                else
                {
                    SqlConnection conn = kon.GetConn();
                    conn.Open();

                    DateTime tglborn = Convert.ToDateTime(tglLahir.Text);
                    string formattedDate = tglborn.ToString("yyyy-MM-dd");


                    int StatusAktif = 0;

                    if (Status.Checked)
                    {
                        StatusAktif = 1;
                    }
                    else
                    {
                        StatusAktif = 0;
                    }


                    String JK = "";

                    if (Laki.Checked)
                    {
                        JK = "L";
                    }
                    else if (Perempuan.Checked)
                    {
                        JK = "P";
                    }



                    cmd = new SqlCommand("UPDATE Pasien SET Nama_Pasien = @nama, PasswordHash = @password, TanggalLahir = @tgllahir, JenisKelamin = @JK, NoHP = @hp, Email = @email, Alamat = @alamat, GolonganDarah = @txtgolongan, Alergi = @alergi, RiwayatPenyakit = @penyakit, StatusAktif = @status WHERE PasienID = @id", conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@tgllahir", formattedDate);
                    cmd.Parameters.AddWithValue("@JK", JK);
                    cmd.Parameters.AddWithValue("@hp", txtNomorHP.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@txtgolongan", txtGolongan.Text);
                    cmd.Parameters.AddWithValue("@alergi", txtAlergi.Text);
                    cmd.Parameters.AddWithValue("@penyakit", txtPenyakit.Text);
                    cmd.Parameters.AddWithValue("@status", StatusAktif);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);


                    cmd.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Data Berhasil Di Ubah");
                    kondisiawal();

                }
            }
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data Ini", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = kon.GetConn();
                con.Open();

                cmd = new SqlCommand("Delete From Pasien where PasienID= '" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Pasien Berhasil Di Hapus");
                kondisiawal();
            }
            else
            {
                kondisiawal();
            }
        }
    }
}
