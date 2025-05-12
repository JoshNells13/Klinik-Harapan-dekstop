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
    public partial class ManajemenDokter : Form
    {


        Koneksi kon = new Koneksi();
        SqlDataAdapter da;
        SqlDataReader rd;
        SqlCommand cmd;
        DataSet ds;

        public ManajemenDokter()
        {
            InitializeComponent();
        }

        void loaddata()
        {
            SqlConnection conn = kon.GetConn();

            cmd = new SqlCommand("SELECT * FROM Dokter", conn);

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Dokter");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Dokter";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }


        void data_spesialisasi()
        {
            comboSpesialisasi.Items.Add("Jantung");
            comboSpesialisasi.Items.Add("Umum");
            comboSpesialisasi.Items.Add("Gizi");
            comboSpesialisasi.Items.Add("Anak");

        }

        void kondisiawal()
        {
            tambah.Text = "Tambah";
            ubah.Text = "Ubah";
            txtAlamat.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtID.Text = "";
            txtNama.Text = "";
            txtNOHP.Text = "";
            txtPengalaman.Text = "";
            txtUsername.Text = "";
            txtSTR.Text = "";
            txtSIP.Text = "";
            comboSpesialisasi.SelectedIndex = -1;

            tambah.Enabled = true;
            ubah.Enabled = true;

            txtAlamat.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;
            txtID.Enabled = false;
            txtNama.Enabled = false;
            txtNOHP.Enabled = false;
            txtPengalaman.Enabled = false;
            txtUsername.Enabled = false;
            txtSTR.Enabled = false;
            txtSIP.Enabled = false;
            comboSpesialisasi.Enabled = false;

            loaddata();
            data_spesialisasi();
        }

        void tambahaktif()
        {
            tambah.Text = "Simpan";
            ubah.Text = "Edit";

            tambah.Enabled = true;
            ubah.Enabled = false;

            txtAlamat.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;
            txtID.Enabled = false;
            txtNama.Enabled = true;
            txtNOHP.Enabled = true;
            txtPengalaman.Enabled = true;
            txtUsername.Enabled = true;
            txtSIP.Enabled = true;
            txtSTR.Enabled = true;
            comboSpesialisasi.Enabled = true;
        }


        void edit()
        {
            tambah.Text = "Tambah";
            ubah.Text = "Simpan";

            tambah.Enabled = false;
            ubah.Enabled = true;

            txtAlamat.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;
            txtID.Enabled = true;
            txtNama.Enabled = true;
            txtNOHP.Enabled = true;
            txtPengalaman.Enabled = true;
            txtUsername.Enabled = true;
            txtSIP.Enabled = true;
            txtSTR.Enabled = true;
            comboSpesialisasi.Enabled = true;

            this.ActiveControl = txtID;
        }

        void edit2()
        {
            tambah.Text = "Tambah";
            ubah.Text = "Simpan";

            tambah.Enabled = false;
            ubah.Enabled = true;

            txtAlamat.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;
            txtID.Enabled = true;
            txtNama.Enabled = true;
            txtNOHP.Enabled = true;
            txtPengalaman.Enabled = true;
            txtUsername.Enabled = true;
            txtSIP.Enabled = true;
            txtSTR.Enabled = true;
            comboSpesialisasi.Enabled = true;

            this.ActiveControl = txtNama;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManajemenDokter_Load(object sender, EventArgs e)
        {

            kondisiawal();
        }

        private void btncari_Click(object sender, EventArgs e)
        {


            SqlConnection conn = kon.GetConn();

            cmd = new SqlCommand("SELECT * FROM Dokter " +
                "WHERE Nama_Dokter LIKE @search " +
                "OR Username LIKE @search " +
                "OR NoSTR LIKE @search " +
                "OR NoSIP LIKE @search " +
                "OR Spesialisasi LIKE @search " +
                "OR PengalamanTahun LIKE @search " +
                "OR NoHP LIKE @search " +
                "OR Email LIKE @search " +
                "OR Alamat LIKE @search " +
                "OR StatusPraktik LIKE @search", conn);

            cmd.Parameters.AddWithValue("@search", "%" + txtCari.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Dokter");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Dokter";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();


        }

        private void tambah_Click(object sender, EventArgs e)
        {
            if (tambah.Text == "Tambah")
            {
                tambahaktif();
            }
            else
            {
                // Validasi input wajib diisi
                if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtSTR.Text) ||
                    string.IsNullOrWhiteSpace(txtSIP.Text) ||
                    string.IsNullOrWhiteSpace(txtPengalaman.Text) ||
                    string.IsNullOrWhiteSpace(txtNOHP.Text) ||
                    string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                    comboSpesialisasi.SelectedItem == null)
                {
                    MessageBox.Show("Pastikan semua data di form terisi dengan lengkap!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection conn = kon.GetConn();
                    conn.Open();

                    string StatusAktif = "Pensiun";
                    if (ckAktif.Checked)
                    {
                        StatusAktif = "Aktif";
                    }
                    else if (cuti.Checked)
                    {
                        StatusAktif = "Cuti";
                    }

                    string comboSpe = comboSpesialisasi.SelectedItem.ToString();

                    cmd = new SqlCommand("INSERT INTO Dokter(Nama_Dokter, Username, PasswordHash, NoSTR, NoSIP, Spesialisasi, PengalamanTahun, NoHP, Email, Alamat, StatusPraktik) " +
                       "VALUES(@nama, @username, @password, @str, @sip, @spesialisasi, @pengalaman, @noHP, @email, @alamat, @status)", conn);

                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@str", txtSTR.Text);
                    cmd.Parameters.AddWithValue("@sip", txtSIP.Text);
                    cmd.Parameters.AddWithValue("@spesialisasi", comboSpe);
                    cmd.Parameters.AddWithValue("@pengalaman", txtPengalaman.Text);
                    cmd.Parameters.AddWithValue("@noHP", txtNOHP.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@status", StatusAktif);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Data Dokter Berhasil Ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kondisiawal();
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
                cmd = new SqlCommand("Select * from Dokter Where DokterID ='" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNama.Text = reader[1].ToString();
                    txtUsername.Text = reader[2].ToString();
                    txtPassword.Text = reader[3].ToString();
                    txtSTR.Text = reader[4].ToString();
                    txtSIP.Text = reader[5].ToString();
                    comboSpesialisasi.Text = reader[6].ToString();
                    txtPengalaman.Text = reader[7].ToString();
                    txtNOHP.Text = reader[8].ToString();
                    txtEmail.Text = reader[9].ToString();
                    txtAlamat.Text = reader[10].ToString();





                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Data Dokter Tidak Ada");
                }
                edit2();
            }
        }

        private void ubah_Click(object sender, EventArgs e)
        {
            if (ubah.Text == "Ubah")
            {
                edit();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                 string.IsNullOrWhiteSpace(txtUsername.Text) ||
                 string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                 string.IsNullOrWhiteSpace(txtSTR.Text) ||
                 string.IsNullOrWhiteSpace(txtSIP.Text) ||
                 string.IsNullOrWhiteSpace(txtPengalaman.Text) ||
                string.IsNullOrWhiteSpace(txtNOHP.Text) ||
                string.IsNullOrWhiteSpace(txtAlamat.Text) ||
         comboSpesialisasi.SelectedItem == null ||
           string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Pastikan Mengisi Data Yang Ada Di Form");
                }
                else
                {
                    SqlConnection conn = kon.GetConn();
                    conn.Open();


                    String StatusAktif = "Tidak Aktif";

                    if (ckAktif.Checked)
                    {
                        StatusAktif = "Aktif";
                    }

                    String comboSpe = comboSpesialisasi.ToString();





                    cmd = new SqlCommand("UPDATE Dokter SET Nama_Dokter = @nama, PasswordHash = @password, NoSTR = @str, NoSIP = @sip, Spesialisasi = @spesialisasi, PengalamanTahun = @pengalaman, NoHP = @noHP, Email = @email, Alamat = @alamat, StatusPraktik = @status WHERE DokterID = @id", conn);

                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@str", txtSTR.Text);
                    cmd.Parameters.AddWithValue("@sip", txtSIP.Text);
                    cmd.Parameters.AddWithValue("@spesialisasi", comboSpe);
                    cmd.Parameters.AddWithValue("@pengalaman", txtPengalaman.Text);
                    cmd.Parameters.AddWithValue("@noHP", txtNOHP.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@status", StatusAktif);
                    cmd.Parameters.AddWithValue("id", txtID.Text);



                    cmd.ExecuteNonQuery();

                    conn.Close();
                    MessageBox.Show("Data Dokter Berhasil Di Ubah");
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

                cmd = new SqlCommand("Delete From Dokter where DokterID= '" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Dokter Berhasil Di Hapus");
                kondisiawal();
            }
            else
            {
                kondisiawal();
            }
        }
    }
}
