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
    public partial class ManajemenResep : Form
    {

        Koneksi kon = new Koneksi();
        SqlDataAdapter da;
        SqlDataReader rd;
        SqlCommand cmd;
        DataSet ds;


        void loaddata()
        {
            SqlConnection konek = kon.GetConn();
            cmd = new SqlCommand("SELECT Resep.ResepID,Resep.RekamMedisID,Apoteker.Nama,Resep.Status,Resep.TanggalDibuat " +
                " FROM Resep " +
                "INNER JOIN Apoteker ON Resep.ApotekerID = Apoteker.ApotekerID ", konek);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Resep");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Resep";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        void kondisiawal()
        {
            txtID.Text = "";


            comboApoteker.SelectedIndex = -1;

            txtID.Enabled = false;


            txtID.Enabled = false;
            comboApoteker.Enabled = false;
            ComboIDRekamMedis.Enabled = false;
            tglDibuat.Enabled = false;

            RadioSelesai.Enabled = false;
            RadioMenunggu.Enabled = false;
            RadioProses.Enabled = false;

            btnEdit.Text = "Edit";
            btnTambah.Text = "Tambah";

            load_Rekam();
            load_Apoteker();
            loaddata();

        }

        void tambahaktif()
        {
            txtID.Enabled = false;


            txtID.Enabled = false;
            comboApoteker.Enabled = true;
            tglDibuat.Enabled = true;
            ComboIDRekamMedis.Enabled = true;
            RadioSelesai.Enabled = true;
            RadioMenunggu.Enabled = true;
            RadioProses.Enabled = true;

            btnEdit.Enabled = false;
            btnTambah.Text = "Simpan";
            btnHapus.Enabled = false;
            btnTambah.Enabled = true;
        }

        void editaktif()
        {
            txtID.Enabled = true;


            txtID.Enabled = true;
            comboApoteker.Enabled = true;
            tglDibuat.Enabled = true;
            ComboIDRekamMedis.Enabled = true;
            RadioSelesai.Enabled = true;
            RadioMenunggu.Enabled = true;
            RadioProses.Enabled = true;

            btnTambah.Enabled = false;
            btnEdit.Text = "Simpan";
            btnHapus.Enabled = true;
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


        void load_Rekam()
        {
            SqlConnection con = kon.GetConn();
            con.Open();

            string query = "SELECT DISTINCT RekamMedisID FROM RekamMedis";
            cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();

            ComboIDRekamMedis.Items.Clear();

            while (rd.Read())
            {
                ComboIDRekamMedis.Items.Add(rd["RekamMedisID"].ToString());
            }

            con.Close();
        }


        public ManajemenResep()
        {
            InitializeComponent();
        }

        private void ManajemenResep_Load(object sender, EventArgs e)
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
                // Validasi semua form harus terisi
                if (comboApoteker.SelectedIndex == -1 ||
                    ComboIDRekamMedis.SelectedIndex == -1 ||
                    tglDibuat.Text.Trim() == "" ||
                    (!RadioSelesai.Checked && !RadioProses.Checked && !RadioMenunggu.Checked))
                {
                    MessageBox.Show("Pastikan semua data di form telah diisi lengkap!");
                }
                else
                {
                    SqlConnection conn = kon.GetConn();
                    conn.Open();

                    // Data Status
                    string Status = "";
                    if (RadioSelesai.Checked) Status = "Selesai";
                    else if (RadioProses.Checked) Status = "DiProses";
                    else if (RadioMenunggu.Checked) Status = "Menunggu";
                    else Status = "Menunggu";

                    // Data Apoteker
                    string selectedApoteker = comboApoteker.SelectedItem.ToString();
                    string queryApoteker = "SELECT ApotekerID FROM Apoteker WHERE Nama = @tipeApoteker";
                    cmd = new SqlCommand(queryApoteker, conn);
                    cmd.Parameters.AddWithValue("@tipeApoteker", selectedApoteker);

                    object resultApoteker = cmd.ExecuteScalar();
                    if (resultApoteker == null)
                    {
                        MessageBox.Show("Data Apoteker yang dipilih tidak valid.");
                        conn.Close();
                        return;
                    }
                    int idApoteker = Convert.ToInt32(resultApoteker);

                    // Data Rekam Medis
                    string selectedRekam = ComboIDRekamMedis.SelectedItem.ToString();
                    string queryRekam = "SELECT RekamMedisID FROM RekamMedis WHERE RekamMedisID = @tiperekam";
                    cmd = new SqlCommand(queryRekam, conn);
                    cmd.Parameters.AddWithValue("@tiperekam", selectedRekam);

                    object resultRekam = cmd.ExecuteScalar();
                    if (resultRekam == null)
                    {
                        MessageBox.Show("Data Rekam Medis yang dipilih tidak valid.");
                        conn.Close();
                        return;
                    }
                    int idRekamMedis = Convert.ToInt32(resultRekam);

                    // Tanggal Pembuatan
                    DateTime Dibuat = Convert.ToDateTime(tglDibuat.Text);
                    string waktuDibuat = Dibuat.ToString("yyyy-MM-dd");

                    // Insert ke tabel Resep
                    cmd = new SqlCommand("INSERT INTO Resep (RekamMedisID, ApotekerID, Status, TanggalDiBuat) " +
                                         "VALUES (@rekamMedis, @Apoteker, @Status, @tglDibuat)", conn);

                    cmd.Parameters.AddWithValue("@rekamMedis", idRekamMedis);
                    cmd.Parameters.AddWithValue("@Apoteker", idApoteker);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@tglDibuat", waktuDibuat);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    kondisiawal();
                    MessageBox.Show("Data Resep Berhasil Ditambahkan");
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
                if (comboApoteker.SelectedIndex == -1 ||
         ComboIDRekamMedis.SelectedIndex == -1 ||
         tglDibuat.Text.Trim() == "" ||
         (!RadioSelesai.Checked && !RadioProses.Checked && !RadioMenunggu.Checked) ||
         txtID.Text.Trim() == "")
                {
                    MessageBox.Show("Pastikan Mengisi Data Yang Ada Di Form");
                }
                else
                {
                    SqlConnection conn = kon.GetConn();
                    conn.Open();

                    //Data Status
                    String Status = "";
                    if (RadioSelesai.Checked)
                    {
                        Status = "Selesai";

                    }
                    else if (RadioProses.Checked)
                    {
                        Status = "DiProses";
                    }
                    else if (RadioMenunggu.Checked)
                    {
                        Status = "Menunggu";
                    }
                    else
                    {
                        Status = "Menunggu";
                    }


                    //Data Apoteker
                    string selectedApoteker = comboApoteker.SelectedItem.ToString();
                    string query3 = "SELECT ApotekerID FROM Apoteker WHERE Nama = @tipeApoteker";
                    cmd = new SqlCommand(query3, conn);
                    cmd.Parameters.AddWithValue("@tipeApoteker", selectedApoteker);

                    object result2 = cmd.ExecuteScalar();
                    if (result2 == null)
                    {
                        MessageBox.Show("Data Apoteker yang dipilih tidak valid.");
                        conn.Close();
                        return;
                    }
                    int idApoteker = Convert.ToInt32(result2);


                    //Data Rekam Medis
                    string selectedRekam = ComboIDRekamMedis.SelectedItem.ToString();
                    string query2 = "SELECT RekamMedisID FROM RekamMedis WHERE RekamMedisID = @tiperekam";
                    cmd = new SqlCommand(query2, conn);
                    cmd.Parameters.AddWithValue("@tiperekam", selectedRekam);

                    object result3 = cmd.ExecuteScalar();
                    if (result3 == null)
                    {
                        MessageBox.Show("Data Apoteker yang dipilih tidak valid.");
                        conn.Close();
                        return;
                    }
                    int idrekamMedis = Convert.ToInt32(result3);

                    //Tanggal Pembuatan
                    DateTime Dibuat = Convert.ToDateTime(tglDibuat.Text);
                    string waktudibuat = Dibuat.ToString("yyyy-MM-dd");

                    cmd = new SqlCommand("UPDATE Resep SET RekamMedisID = @rekamMedis, ApotekerID = @Apoteker, " +
                                         "Status = @Status, TanggalDiBuat = @tgldibuat WHERE ResepID = @id", conn);

                    cmd.Parameters.AddWithValue("@rekamMedis", idrekamMedis);
                    cmd.Parameters.AddWithValue("@Apoteker", idApoteker);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@tgldibuat", waktudibuat);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);



                    cmd.ExecuteNonQuery();

                    kondisiawal();
                    MessageBox.Show("Data Berhasil Di Ubah");



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
                cmd = new SqlCommand("SELECT Resep.ResepID,Resep.RekamMedisID,Apoteker.Nama,Resep.Status,Resep.TanggalDibuat " +
                " FROM Resep " +
                 " INNER JOIN Apoteker ON Resep.ApotekerID = Apoteker.ApotekerID " +
                 "WHERE Resep.ResepID = @id ", con);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ComboIDRekamMedis.Text = reader["RekamMedisID"].ToString();
                    comboApoteker.Text = reader["Nama"].ToString();
                    tglDibuat.Text = reader["TanggalDiBuat"].ToString();
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Data Resep Tidak Ada");
                }
                editaktif();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlConnection konek = kon.GetConn();

            string query = "SELECT r.ResepID, r.RekamMedisID, a.Nama AS Nama_Apoteker, r.Status, r.TanggalDibuat " +
                           "FROM Resep r " +
                           "INNER JOIN Apoteker a ON r.ApotekerID = a.ApotekerID " +
                           "WHERE a.Nama LIKE @search " +
                           "ORDER BY r.TanggalDibuat DESC"; 

            cmd = new SqlCommand(query, konek);
            cmd.Parameters.AddWithValue("@search", "%" + txtCari.Text.Trim() + "%"); 

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Resep");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Resep";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data Ini", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = kon.GetConn();
                con.Open();

                cmd = new SqlCommand("Delete From Resep where ResepID= '" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Resep Berhasil Di Hapus");
                kondisiawal();
            }
            else
            {
                kondisiawal();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
