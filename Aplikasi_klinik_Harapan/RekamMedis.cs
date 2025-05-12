using System;
using System.CodeDom;
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
    public partial class RekamMedis : Form
    {
        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;


        void kondisiawal()
        {
            txtCatatan.Text = "";
            txtdiag.Text = "";
            txtTindakan.Text = "";

            txtCatatan.Enabled = false;
            txtdiag.Enabled = false;
            txtTindakan.Enabled = false;

            tglrekam.Enabled = false;
            combodokter.Enabled = false;
            combopasien.Enabled = false;
            btnTambah.Enabled = true;
            btnTambah.Text = "Tambah";
            loaddata();
        }


        void tambahaktif()
        {
            txtCatatan.Enabled = true;
            txtdiag.Enabled = true;
            txtTindakan.Enabled = true;

            tglrekam.Enabled = true;
            combodokter.Enabled = true;
            combopasien.Enabled = true;
            btnTambah.Enabled = true;
            btnTambah.Text = "Simpan";
        }
        void loaddata()
        {

            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT RekamMedis.RekamMedisID  ,Pasien.Nama_Pasien,Dokter.Nama_Dokter,RekamMedis.Diagnosa,RekamMedis.Tindakan,RekamMedis.Tanggal,RekamMedis.CatatanTambahan " +
                "FROM RekamMedis " +
                "INNER JOIN Pasien ON RekamMedis.PasienID = Pasien.PasienID " +
                "INNER JOIN Dokter ON RekamMedis.DokterID = Dokter.DokterID", con);

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "RekamMedis");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RekamMedis";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        void load_dokter()
        {
            SqlConnection con = conn.GetConn();
            con.Open();

            string query = "SELECT DISTINCT Nama_Dokter FROM Dokter";
            cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();

            combodokter.Items.Clear();

            while (rd.Read())
            {
                combodokter.Items.Add(rd["Nama_Dokter"].ToString());
            }

            con.Close();
        }

        void load_pasien()
        {
            SqlConnection con = conn.GetConn();
            con.Open();

            string query = "SELECT DISTINCT Nama_Pasien FROM Pasien";
            cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();

            combopasien.Items.Clear();

            while (rd.Read())
            {
                combopasien.Items.Add(rd["Nama_Pasien"].ToString());
            }


            con.Close();
        }


        public RekamMedis()
        {
            InitializeComponent();
        }

        private void RekamMedis_Load(object sender, EventArgs e)
        {
            load_pasien();
            load_dokter();
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
                // Validasi input
                if (txtTindakan.Text.Trim() == "" ||
                    txtdiag.Text.Trim() == "" ||
                    txtCatatan.Text.Trim() == "" ||
                    combodokter.SelectedIndex == -1 ||
                    combopasien.SelectedIndex == -1 ||
                    tglrekam.Text.Trim() == "")
                {
                    MessageBox.Show("Pastikan semua data di form telah diisi lengkap!");
                    return;
                }

                SqlConnection con = conn.GetConn();
                con.Open();

                // Format tanggal rekam
                DateTime rekam = Convert.ToDateTime(tglrekam.Text);
                string WaktuRekam = rekam.ToString("yyyy-MM-dd");

                // Ambil ID Dokter
                string selecteddokter = combodokter.SelectedItem.ToString();
                string queryDokter = "SELECT DokterID FROM Dokter WHERE Nama_Dokter = @tipedokter";
                cmd = new SqlCommand(queryDokter, con);
                cmd.Parameters.AddWithValue("@tipedokter", selecteddokter);
                object resultDokter = cmd.ExecuteScalar();

                if (resultDokter == null)
                {
                    MessageBox.Show("Data Dokter yang dipilih tidak valid.");
                    con.Close();
                    return;
                }
                int iddokter = Convert.ToInt32(resultDokter);

                // Ambil ID Pasien
                string selectedpasien = combopasien.SelectedItem.ToString();
                string queryPasien = "SELECT PasienID FROM Pasien WHERE Nama_Pasien = @tipepasien";
                cmd = new SqlCommand(queryPasien, con);
                cmd.Parameters.AddWithValue("@tipepasien", selectedpasien);
                object resultPasien = cmd.ExecuteScalar();

                if (resultPasien == null)
                {
                    MessageBox.Show("Data Pasien yang dipilih tidak valid.");
                    con.Close();
                    return;
                }
                int idpasien = Convert.ToInt32(resultPasien);

                // Simpan ke Rekam Medis
                cmd = new SqlCommand("INSERT INTO RekamMedis (PasienID, DokterID, Diagnosa, Tindakan, Tanggal, CatatanTambahan) " +
                                     "VALUES (@pasien, @dokter, @diag, @tindakan, @tglrekam, @catatan)", con);

                cmd.Parameters.AddWithValue("@pasien", idpasien);
                cmd.Parameters.AddWithValue("@dokter", iddokter);
                cmd.Parameters.AddWithValue("@diag", txtdiag.Text.Trim());
                cmd.Parameters.AddWithValue("@tindakan", txtTindakan.Text.Trim());
                cmd.Parameters.AddWithValue("@tglrekam", WaktuRekam);
                cmd.Parameters.AddWithValue("@catatan", txtCatatan.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();

                kondisiawal();
                MessageBox.Show("Data Rekam Medis Berhasil Ditambahkan");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hapus"].Index)
            {
           
                string idrekam = dataGridView1.Rows[e.RowIndex].Cells["RekamMedisID"].Value.ToString();

                using (SqlConnection con = conn.GetConn())
                {
                    con.Open();

    
                    string queryDeleteResep = "DELETE FROM Resep WHERE RekamMedisID = @idrekam";
                    using (SqlCommand cmd = new SqlCommand(queryDeleteResep, con))
                    {
                        cmd.Parameters.AddWithValue("@idrekam", idrekam);
                        cmd.ExecuteNonQuery();
                    }

                    string queryDeleteRekamMedis = "DELETE FROM RekamMedis WHERE RekamMedisID = @idrekam";
                    using (SqlCommand cmd = new SqlCommand(queryDeleteRekamMedis, con))
                    {
                        cmd.Parameters.AddWithValue("@idrekam", idrekam);
                        cmd.ExecuteNonQuery();
                    }
                }

                dataGridView1.Rows.RemoveAt(e.RowIndex);

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT RekamMedis.RekamMedisID, Pasien.Nama_Pasien, Dokter.Nama_Dokter, " +
                                 "RekamMedis.Diagnosa, RekamMedis.Tindakan, RekamMedis.Tanggal, RekamMedis.CatatanTambahan " +
                                 "FROM RekamMedis " +
                                 "INNER JOIN Pasien ON RekamMedis.PasienID = Pasien.PasienID " +
                                 "INNER JOIN Dokter ON RekamMedis.DokterID = Dokter.DokterID " +
                                 "WHERE Pasien.Nama_Pasien LIKE @search " +
                                 "OR Dokter.Nama_Dokter LIKE @search " +
                                 "OR RekamMedis.Diagnosa LIKE @search " +
                                 "OR RekamMedis.Tindakan LIKE @search " +
                                 "OR RekamMedis.Tanggal LIKE @search " +
                                 "OR RekamMedis.CatatanTambahan LIKE @search", con);

            cmd.Parameters.AddWithValue("@search", "%" + txtsearch.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "RekamMedis");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RekamMedis";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
