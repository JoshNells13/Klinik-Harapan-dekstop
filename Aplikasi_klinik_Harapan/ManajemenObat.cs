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
    public partial class ManajemenObat : Form
    {

        Koneksi kon = new Koneksi();
        SqlDataAdapter da;
        SqlDataReader rd;
        SqlCommand cmd;
        DataSet ds;


        void kondisiawal()
        {
            txtDeskripsi.Text = "";
            txtHarga.Text = "";
            txtID.Text = "";
            txtNama.Text = "";
            txtStok.Text = "";
            comboKategori.SelectedIndex = -1;

            txtDeskripsi.Enabled = false;
            txtHarga.Enabled = false;
            txtID.Enabled = false;
            txtNama.Enabled = false;
            txtStok.Enabled = false;
            comboKategori.Enabled = false;
            tglBasi.Enabled = false;



            btnTambah.Text = "Tambah";
            btnEdit.Text = "Edit";
            loadKategori();
            load_data();
        }

        void tambah()
        {
            txtDeskripsi.Enabled = true;
            txtHarga.Enabled = true;
            txtID.Enabled = false;
            txtNama.Enabled = true;
            txtStok.Enabled = true;
            comboKategori.Enabled = true;
            tglBasi.Enabled = true;

            btnTambah.Text = "Simpan";
            btnEdit.Text = "Edit";
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
        }




        void edit()
        {
            txtDeskripsi.Enabled = true;
            txtHarga.Enabled = true;
            txtID.Enabled = true;
            txtNama.Enabled = true;
            txtStok.Enabled = true;
            comboKategori.Enabled = true;
            tglBasi.Enabled = true;

            btnTambah.Text = "Tambah";
            btnEdit.Text = "Simpan";
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
        }

        void load_data()
        {
            SqlConnection konek = kon.GetConn();
            cmd = new SqlCommand("SELECT * FROM Obat", konek);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Obat");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Obat";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        void loadKategori()
        {
            comboKategori.Items.Add("Tablet & Kapsul");
            comboKategori.Items.Add("Sirup & Suspensi");
            comboKategori.Items.Add("Injeksi(Suntikan)");
            comboKategori.Items.Add("Salep & krim");
        }

        public ManajemenObat()
        {
            InitializeComponent();
        }



        private void ManajemenObat_Load(object sender, EventArgs e)
        {
            kondisiawal();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (btnTambah.Text == "Tambah")
            {
                tambah();
            }
            else
            {

                if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                    string.IsNullOrWhiteSpace(txtStok.Text) ||
                    string.IsNullOrWhiteSpace(txtHarga.Text) ||
                    string.IsNullOrWhiteSpace(tglBasi.Text) ||
                    comboKategori.SelectedItem == null)
                {
                    MessageBox.Show("Pastikan semua data di form terisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection conn = kon.GetConn();
                    conn.Open();

                    string SelectedKategori = comboKategori.SelectedItem.ToString();

                    DateTime expired = Convert.ToDateTime(tglBasi.Text);
                    string ExpiredDate = expired.ToString("yyyy-MM-dd");

                    cmd = new SqlCommand("INSERT INTO Obat(NamaObat, Stok, Harga, ExpiredDate, Kategori, Deskripsi) " +
                                         "VALUES (@nama, @stok, @harga, @expired, @kategori, @deskripsi)", conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@stok", txtStok.Text);
                    cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                    cmd.Parameters.AddWithValue("@expired", ExpiredDate);
                    cmd.Parameters.AddWithValue("@kategori", SelectedKategori);
                    cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);

                    cmd.ExecuteNonQuery();

                    conn.Close();

                    kondisiawal();
                    MessageBox.Show("Data Obat Berhasil Ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cmd = new SqlCommand("Select * from Obat Where ObatID ='" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNama.Text = reader[1].ToString();
                    txtStok.Text = reader[2].ToString();
                    txtHarga.Text = reader[3].ToString();
                    tglBasi.Text = reader[4].ToString();
                    comboKategori.Text = reader[5].ToString();
                    txtDeskripsi.Text = reader[6].ToString();
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Data Obat Tidak Ada");
                }
                edit();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data Ini", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = kon.GetConn();
                con.Open();

                cmd = new SqlCommand("Delete From Obat where ObatID= '" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Obat Berhasil Di Hapus");
                kondisiawal();
            }
            else
            {
                kondisiawal();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Edit")
            {
                edit();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                  string.IsNullOrWhiteSpace(txtStok.Text) ||
                  string.IsNullOrWhiteSpace(txtHarga.Text) ||
                  string.IsNullOrWhiteSpace(tglBasi.Text) ||
                  comboKategori.SelectedItem == null ||
                  string.IsNullOrWhiteSpace(txtID.Text))
                {
                    MessageBox.Show("Pastikan Mengisi Data Yang Ada Di Form");
                }
                else
                {
                    SqlConnection conn = kon.GetConn();
                    conn.Open();

                    String SelectedKategori = comboKategori.SelectedItem.ToString();

                    DateTime expired = Convert.ToDateTime(tglBasi.Text);
                    string ExpiredDate = expired.ToString("yyyy-MM-dd");

                    Decimal harga = Convert.ToDecimal(txtHarga.Text);

                    int stok = Convert.ToInt32(txtStok.Text);

                    cmd = new SqlCommand("UPDATE Obat SET NamaObat=@nama,Stok=@stok,harga=@harga,ExpiredDate=@expired,Kategori = @kategori,Deskripsi = @deskripsi WHERE ObatID = @id", conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@stok", stok);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@expired", expired);
                    cmd.Parameters.AddWithValue("@kategori", SelectedKategori);
                    cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsi.Text);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    kondisiawal();

                    MessageBox.Show("Data Berhasil Di Ubah");
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlConnection konek = kon.GetConn();

            cmd = new SqlCommand("SELECT * FROM Obat " +
                "WHERE NamaObat LIKE @search " +
                "OR Kategori LIKE @search " +
                "OR Harga LIKE @search " +
                "OR ExpiredDate LIKE @search", konek);

            cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Obat");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Obat";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
