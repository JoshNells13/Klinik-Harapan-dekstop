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
    public partial class JadwalDokter : Form
    {
        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;


        public JadwalDokter()
        {
            InitializeComponent();
        }


        void loaddata()
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT JadwalDokter.JadwalID ,Dokter.Nama_Dokter,JadwalDokter.Hari,JadwalDokter.JamMulai,JadwalDokter.JamSelesai " +
                "FROM JadwalDokter " +
                "INNER JOIN Dokter ON JadwalDokter.DokterID = Dokter.DokterID", con);

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "JadwalDokter");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "JadwalDokter";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }
        void kondisiawal()
        {
            combodokter.Enabled = false;
            jammulai.Enabled = false;
            jamSelesai.Enabled = false;
            hari.Enabled = false;
            btnTambah.Text = "Tambah";


            loaddata();
        }

        void tambahaktif()
        {
            combodokter.Enabled = true;
            jammulai.Enabled = true;
            jamSelesai.Enabled = true;
            hari.Enabled = true;
            btnTambah.Text = "Simpan";
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
        void datajam()
        {
            jammulai.Format = DateTimePickerFormat.Custom;
            jammulai.CustomFormat = "HH:mm";
            jammulai.ShowUpDown = true;

            jamSelesai.Format = DateTimePickerFormat.Custom;
            jamSelesai.CustomFormat = "HH:mm";
            jamSelesai.ShowUpDown = true;
        }
        private void JadwalDokter_Load(object sender, EventArgs e)
        {
            kondisiawal();
            datajam();
            load_dokter();

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();

            string query = "SELECT JadwalDokter.JadwalID, Dokter.Nama_Dokter, JadwalDokter.Hari, JadwalDokter.JamMulai, JadwalDokter.JamSelesai " +
                           "FROM JadwalDokter " +
                           "INNER JOIN Dokter ON JadwalDokter.DokterID = Dokter.DokterID ";

            if (!string.IsNullOrWhiteSpace(txtCari.Text))
            {
                query += "WHERE Dokter.Nama_Dokter LIKE @search " +
                         "OR JadwalDokter.Hari LIKE @search";
            }

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@search", "%" + txtCari.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "JadwalDokter");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "JadwalDokter";
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
                if (combodokter.SelectedIndex == -1)
                {
                    MessageBox.Show("Pastikan Memilih Data Yang Ada di Form");
                }
                else
                {
                    SqlConnection con = conn.GetConn();
                    con.Open();

                    //Data Dokter
                    string selecteddokter = combodokter.SelectedItem.ToString();
                    string query2 = "SELECT DokterID FROM Dokter WHERE Nama_Dokter = @tipedokter";
                    cmd = new SqlCommand(query2, con);
                    cmd.Parameters.AddWithValue("@tipedokter", selecteddokter);



                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Data Dokter yang dipilih tidak valid.");
                        con.Close();
                        return;
                    }

                    int iddokter = Convert.ToInt32(result);

                    //data waktu
                    DateTime selesai = Convert.ToDateTime(jamSelesai.Text);
                    string waktuselesai = selesai.ToString("HH:mm");

                    DateTime mulai = Convert.ToDateTime(jammulai.Text);
                    string waktumulai = mulai.ToString("HH:mm");


                    DateTime haribiasa = Convert.ToDateTime(hari.Text);
                    string waktuhari = haribiasa.ToString("yyyy-MM-dd");


                    cmd = new SqlCommand("INSERT INTO JadwalDokter(DokterId,Hari,JamMulai,JamSelesai) VALUES(@Dokter,@hari,@mulai,@selesai)", con);
                    cmd.Parameters.AddWithValue("@Dokter", iddokter);
                    cmd.Parameters.AddWithValue("@mulai", waktumulai);
                    cmd.Parameters.AddWithValue("@selesai", waktuselesai);
                    cmd.Parameters.AddWithValue("@hari", waktuhari);

                    cmd.ExecuteNonQuery();

                    kondisiawal();
                    MessageBox.Show("Data Jadwal Dokter Berhasil Di Tambah");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Selesai"].Index)
            {
                // Mengambil nomor kamar dari baris yang dipilih
                string idjadwal = dataGridView1.Rows[e.RowIndex].Cells["JadwalID"].Value.ToString();

                // Menghapus data dari database
                SqlConnection con = conn.GetConn();
                con.Open();

                // Query untuk menghapus data di tabel FasilitasBerdasarkanTipeKamar
                string queryDelete = "DELETE From JadwalDokter WHERE JadwalID =@idjadwal";
                cmd = new SqlCommand(queryDelete, con);
                cmd.Parameters.AddWithValue("@idjadwal", idjadwal);
                cmd.ExecuteNonQuery();

                con.Close();

                // Menghapus baris dari DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
