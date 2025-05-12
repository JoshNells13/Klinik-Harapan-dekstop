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
    public partial class DaftarPasien : Form
    {

        Koneksi kon = new Koneksi();
        SqlDataAdapter da;
        SqlDataReader rd;
        SqlCommand cmd;


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


            Submit.Text = "Tambah";
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

            Submit.Text = "Submit";
        }

        public DaftarPasien()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            LoginPengguna pasien = new LoginPengguna();
            pasien.Show();
        }

        private void DaftarPasien_Load(object sender, EventArgs e)
        {
            kondisiawal();
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Submit.Text == "Tambah")
            {
                tambahaktif();
            }
            else
            {
                // Validasi jika ada input yang kosong
                if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(tglLahir.Text) ||
                    (!Laki.Checked && !Perempuan.Checked) ||
                    string.IsNullOrWhiteSpace(txtNomorHP.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                    string.IsNullOrWhiteSpace(txtGolongan.Text) ||
                    string.IsNullOrWhiteSpace(txtAlergi.Text) ||
                    string.IsNullOrWhiteSpace(txtPenyakit.Text) ||
                    !Status.Checked)
                {
                    MessageBox.Show("Pastikan semua data di form terisi dengan lengkap!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection conn = kon.GetConn();
                    conn.Open();

                    DateTime tglborn = Convert.ToDateTime(tglLahir.Text);
                    string formattedDate = tglborn.ToString("yyyy-MM-dd");

                    int StatusAktif = Status.Checked ? 1 : 0;

                    string JK = Laki.Checked ? "L" : "P";

                    SqlCommand cmd = new SqlCommand("INSERT INTO Pasien(Nama_Pasien, Username, PasswordHash, TanggalLahir, JenisKelamin, NoHP, Email, Alamat, GolonganDarah, Alergi, RiwayatPenyakit, StatusAktif) " +
                         "VALUES(@nama, @username, @password, @tgllahir, @JK, @hp, @email, @alamat, @txtgolongan, @alergi, @penyakit, @status)", conn);

                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
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

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Data Berhasil Ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kondisiawal();
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginPengguna loginPasien = new LoginPengguna();
            loginPasien.Show();
            this.Close();
        }

        private void Refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kondisiawal();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

