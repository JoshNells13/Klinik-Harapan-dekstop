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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikasi_klinik_Harapan
{
    public partial class ManajemenApoteker : Form
    {
        Koneksi kon = new Koneksi();
        SqlDataAdapter da;
        SqlDataReader rd;
        SqlCommand cmd;
        DataSet ds;
        public ManajemenApoteker()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loaddata()
        {
            SqlConnection con = kon.GetConn();

            cmd = new SqlCommand("SELECT * FROM Apoteker", con);

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Apoteker");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Apoteker";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        void kondisiawal()
        {
            txtAlamat.Text = "";
            txtEmail.Text = "";
            txtID.Text = "";
            txtNama.Text = "";
            txtNoHP.Text = "";
            txtPassword.Text = "";
            txtSTRA.Text = "";
            txtTahunLulus.Text = "";
            txtUsername.Text = "";

            txtAlamat.Enabled = false;
            txtEmail.Enabled = false;
            txtID.Enabled = false;
            txtNama.Enabled = false;
            txtNoHP.Enabled = false;
            txtPassword.Enabled = false;
            txtSTRA.Enabled = false;
            txtTahunLulus.Enabled = false;
            txtUsername.Enabled = false;
            radioAktif.Enabled = false;
            cuti.Enabled = false;
            comboPendidikan.Enabled = false;


            btnTambah.Text = "Tambah";
            btnEdit.Text = "Edit";
            btnHapus.Text = "Hapus";

            loaddata();
        }


        void tambahaktif()
        {
            txtAlamat.Enabled = true;
            txtEmail.Enabled = true;
            txtID.Enabled = false;
            txtNama.Enabled = true;
            txtNoHP.Enabled = true;
            txtPassword.Enabled = true;
            txtSTRA.Enabled = true;
            txtTahunLulus.Enabled = true;
            txtUsername.Enabled = true;
            radioAktif.Enabled = true;
            cuti.Enabled = true;
            comboPendidikan.Enabled = true;


            btnTambah.Text = "Simpan";
            btnEdit.Text = "Edit";
            btnHapus.Text = "Hapus";

            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
        }

        void editaktif()
        {
            txtAlamat.Enabled = true;
            txtEmail.Enabled = true;
            txtID.Enabled = true;
            txtNama.Enabled = true;
            txtNoHP.Enabled = true;
            txtPassword.Enabled = true;
            txtSTRA.Enabled = true;
            txtTahunLulus.Enabled = true;
            txtUsername.Enabled = true;
            radioAktif.Enabled = true;
            cuti.Enabled = true;
            comboPendidikan.Enabled = true;


            btnTambah.Text = "Tambah";
            btnEdit.Text = "Simpan";
            btnHapus.Text = "Hapus";

            btnTambah.Enabled = false;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
        }

        void dataInstanti()
        {
            comboPendidikan.Items.Add("ITB");
            comboPendidikan.Items.Add("ITS");
            comboPendidikan.Items.Add("UI");
            comboPendidikan.Items.Add("UNDIP");
            comboPendidikan.Items.Add("UNESA");
            comboPendidikan.Items.Add("UGM");
            comboPendidikan.Items.Add("UPR");
        }

        private void ManajemenApoteker_Load(object sender, EventArgs e)
        {
            kondisiawal();
            dataInstanti();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection con = kon.GetConn();

            cmd = new SqlCommand("SELECT * FROM Apoteker " +
                "WHERE Nama LIKE @search " +
                "OR Username LIKE @search " +
                "OR NoSTRA LIKE @search " +
                "OR TahunLulus LIKE @search " +
                "OR InstitusiPendidikan LIKE @search " +
                "OR NoHP LIKE @search " +
                "OR Email LIKE @search " +
                "OR Alamat LIKE @search " +
                "OR StatusPraktik LIKE @search", con);

            cmd.Parameters.AddWithValue("@search", "%" + txtCari.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Apoteker");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Apoteker";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (btnTambah.Text == "Tambah")
            {
                tambahaktif();
            }
            else
            {
                // Validasi form wajib diisi
                if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtNama.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtSTRA.Text) ||
                    string.IsNullOrWhiteSpace(txtTahunLulus.Text) ||
                    comboPendidikan.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtNoHP.Text) ||
                    string.IsNullOrWhiteSpace(txtAlamat.Text))
                {
                    MessageBox.Show("Pastikan semua data di form terisi dengan lengkap!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection conn = kon.GetConn();
                    conn.Open();

                    string Instansi = comboPendidikan.SelectedItem.ToString();
                    string Status = "Pensiun"; // Default

                    if (radioAktif.Checked)
                        Status = "Aktif";
                    else if (cuti.Checked)
                        Status = "Cuti";

                    cmd = new SqlCommand("INSERT INTO Apoteker (Nama, Username, PasswordHash, NoSTRA, TahunLulus, InstitusiPendidikan, NoHP, Email, Alamat, StatusPraktik) " +
                                         "VALUES (@nama, @username, @pw, @stra, @tahunlulus, @instansi, @noHp, @email, @alamat, @status)", conn);

                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pw", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@stra", txtSTRA.Text);
                    cmd.Parameters.AddWithValue("@tahunlulus", txtTahunLulus.Text);
                    cmd.Parameters.AddWithValue("@instansi", Instansi);
                    cmd.Parameters.AddWithValue("@noHp", txtNoHP.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@status", Status);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    kondisiawal();
                    MessageBox.Show("Data Berhasil Ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                // Validasi input tidak boleh kosong
                if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtNama.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtSTRA.Text) ||
                    string.IsNullOrWhiteSpace(txtTahunLulus.Text) ||
                    comboPendidikan.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtNoHP.Text) ||
                    string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                    string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Pastikan semua data di form terisi dengan lengkap!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection konek = kon.GetConn();
                    konek.Open();

                    string Instansi = comboPendidikan.SelectedItem.ToString();

                    string Status = "Tidak Aktif";
                    if (radioAktif.Checked)
                        Status = "Aktif";
                    else if (cuti.Checked)
                        Status = "Cuti";
                    else if (pensiun.Checked)
                        Status = "Pensiun";

                    cmd = new SqlCommand("UPDATE Apoteker SET Nama = @nama, Username = @username, PasswordHash = @pw, NoSTRA = @stra, TahunLulus = @tahunlulus, " +
                                         "InstitusiPendidikan = @instansi, NoHP = @noHp, Email = @email, Alamat = @alamat, StatusPraktik = @status " +
                                         "WHERE ApotekerID = @id", konek);

                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pw", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@stra", txtSTRA.Text);
                    cmd.Parameters.AddWithValue("@tahunlulus", txtTahunLulus.Text);
                    cmd.Parameters.AddWithValue("@instansi", Instansi);
                    cmd.Parameters.AddWithValue("@noHp", txtNoHP.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@status", Status);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);

                    cmd.ExecuteNonQuery();
                    konek.Close();

                    kondisiawal();
                    MessageBox.Show("Data Berhasil Diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmd = new SqlCommand("Select * from Apoteker Where ApotekerID ='" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNama.Text = reader[1].ToString();
                    txtUsername.Text = reader[2].ToString();
                    txtPassword.Text = reader[3].ToString();
                    txtSTRA.Text = reader[4].ToString();
                    txtTahunLulus.Text = reader[5].ToString();
                    comboPendidikan.Text = reader[6].ToString();
                    txtNoHP.Text = reader[7].ToString();
                    txtEmail.Text = reader[8].ToString();
                    txtAlamat.Text = reader[9].ToString();
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Data Apoteker Tidak Ada");
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

                cmd = new SqlCommand("Delete From Apoteker where ApotekerID= '" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Apoteker Berhasil Di Hapus");
                kondisiawal();
            }
            else
            {
                kondisiawal();
            }
        }
    }
}
