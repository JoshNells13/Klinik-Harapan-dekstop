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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikasi_klinik_Harapan
{
    public partial class ManajemenKaryawan : Form
    {
        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;


        void loaddata()
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT * FROM Admin", con);

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Admin");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Admin";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }


        void kondisiawal()
        {
            btnTambah.Text = "Tambah";
            BtnUbah.Text = "Edit";


            txtID.Enabled = false;
            txtAlamat.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;
            txtNama.Enabled = false;
            txtNoHP.Enabled = false;
            txtUsername.Enabled = false;
            tgldaftar.Enabled = false;


            RadioAktif.Enabled = false;
            RadioTidakAktif.Enabled = false;

            txtID.Text = "";
            txtAlamat.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtNama.Text = "";
            txtNoHP.Text = "";
            txtUsername.Text = "";




            loaddata();
        }

        void tambahaktif()
        {
            btnTambah.Text = "Simpan";
            BtnUbah.Text = "Edit";
            btnhapus.Enabled = false;
            BtnUbah.Enabled = false;

            txtID.Enabled = false;
            txtAlamat.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;
            txtNama.Enabled = true;
            txtNoHP.Enabled = true;
            txtUsername.Enabled = true;
            tgldaftar.Enabled = true;


            RadioAktif.Enabled = true;
            RadioTidakAktif.Enabled = true;
        }


        void edit()
        {
            btnTambah.Text = "Tambah";
            BtnUbah.Text = "Simpan";
            btnhapus.Enabled = true;
            BtnUbah.Enabled = true;
            btnTambah.Enabled = false;


            txtID.Enabled = true;
            txtAlamat.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;
            txtNama.Enabled = true;
            txtNoHP.Enabled = true;
            txtUsername.Enabled = true;
            tgldaftar.Enabled = true;


            RadioAktif.Enabled = true;
            RadioTidakAktif.Enabled = true;

            this.ActiveControl = txtID;
        }

        void edit2()
        {
            btnTambah.Text = "Tambah";
            BtnUbah.Text = "Simpan";
            btnhapus.Enabled = true;
            BtnUbah.Enabled = true;
            btnTambah.Enabled = false;


            txtID.Enabled = true;
            txtAlamat.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;
            txtNama.Enabled = true;
            txtNoHP.Enabled = true;
            txtUsername.Enabled = true;
            tgldaftar.Enabled = true;


            RadioAktif.Enabled = true;
            RadioTidakAktif.Enabled = true;

            this.ActiveControl = txtNama;

        }


        public ManajemenKaryawan()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnTambah.Text == "Tambah")
            {
                tambahaktif();
            }
            else
            {
                // Validasi data wajib terisi
                if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtNoHP.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                    string.IsNullOrWhiteSpace(tgldaftar.Text))
                {
                    MessageBox.Show("Pastikan semua data di form terisi dengan lengkap!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection con = conn.GetConn();
                    con.Open();

                    // Validasi dan format tanggal daftar
                    DateTime daftar = Convert.ToDateTime(tgldaftar.Text);
                    string formattedDate = daftar.ToString("yyyy-MM-dd");

                    int Status = 0;

                    if (RadioAktif.Checked)
                    {
                        Status = 1;
                    }
                    else if (RadioTidakAktif.Checked)
                    {
                        Status = 0;
                    }

                    cmd = new SqlCommand("INSERT INTO Admin (Nama, Username, PasswordHash, NoHP, Email, Alamat, StatusAktif, TanggalDaftar) " +
                                         "VALUES (@nama, @username, @password, @nohp, @email, @alamat, @status, @tanggaldaftar)", con);

                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@nohp", txtNoHP.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@status", Status);
                    cmd.Parameters.AddWithValue("@tanggaldaftar", formattedDate);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Data Admin Berhasil Ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kondisiawal();
                }
            }

        }

        private void ManajemenKaryawan_Load(object sender, EventArgs e)
        {
            kondisiawal();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT * FROM Admin " +
                "WHERE Nama LIKE @search " +
                "OR Username LIKE @search " +
                "OR NoHP LIKE @search " +
                "OR Email LIKE @search " +
                "OR Alamat LIKE @search ", con);

            cmd.Parameters.AddWithValue("@search", "%" + txtCari.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Admin");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Admin";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        private void BtnUbah_Click(object sender, EventArgs e)
        {
            if (BtnUbah.Text == "Edit")
            {
                edit();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                   string.IsNullOrWhiteSpace(txtUsername.Text) ||
                   string.IsNullOrWhiteSpace(txtPassword.Text) ||
                   string.IsNullOrWhiteSpace(txtNoHP.Text) ||
                   string.IsNullOrWhiteSpace(txtEmail.Text) ||
                   string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                   string.IsNullOrWhiteSpace(tgldaftar.Text) ||
                     string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Pastikan Mengisi Data Di Form Yang Ada");
                }
                else
                {
                    SqlConnection con = conn.GetConn();
                    con.Open();

                    DateTime daftar = Convert.ToDateTime(tgldaftar.Text);
                    string formattedDate = daftar.ToString("yyyy-MM-dd");


                    int Status = 0;

                    if (RadioAktif.Checked)
                    {
                        Status = 1;
                    }
                    else if (RadioTidakAktif.Checked)
                    {
                        Status = 0;
                    }



                    cmd = new SqlCommand("UPDATE Admin SET Nama = @nama, Username = @username, PasswordHash = @password, " +
                      "NoHP = @nohp, Email = @email, Alamat = @alamat, StatusAktif = @status, TanggalDaftar = @tanggaldaftar " +
                      "WHERE AdminID = @id", con);


                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@nohp", txtNoHP.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@status", Status);
                    cmd.Parameters.AddWithValue("@tanggaldaftar", formattedDate);
                    cmd.Parameters.AddWithValue("id", txtID.Text);


                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Data Berhasil Di Ubah");
                    kondisiawal();

                }
            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data Ini", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = conn.GetConn();
                con.Open();

                cmd = new SqlCommand("Delete From Admin where AdminID= '" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Admin/Pegawai Berhasil Di Hapus");
                kondisiawal();
            }
            else
            {
                kondisiawal();
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlDataReader reader = null;
                SqlConnection con = conn.GetConn();
                con.Open();
                cmd = new SqlCommand("Select * from Admin Where AdminID ='" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNama.Text = reader[1].ToString();
                    txtUsername.Text = reader[2].ToString();
                    txtPassword.Text = reader[3].ToString();
                    txtNoHP.Text = reader[4].ToString();
                    txtEmail.Text = reader[5].ToString();
                    txtAlamat.Text = reader[6].ToString();
                    tgldaftar.Text = reader[8].ToString();



                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Data Karyawan Tidak Ada");
                }
                edit2();
            }
        }
    }
}
