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
using Aplikasi_klinik_Harapan.HalamanPengguna;
using Microsoft.Data.SqlClient;

namespace Aplikasi_klinik_Harapan
{
    public partial class DashboardPasien : Form
    {

        Koneksi con = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DashboardPasien()
        {
            InitializeComponent();
        }

        void load_data()
        {
            SqlConnection conn = con.GetConn();

            cmd = new SqlCommand("SELECT Antrian.AntrianID, Pasien.Nama_Pasien, Dokter.Nama_Dokter, " +
     "Antrian.NomorAntrian, Antrian.Status, Antrian.WaktuPendaftaran, Antrian.WaktuPanggil " +
     "FROM Antrian " +
     "INNER JOIN Dokter ON Antrian.DokterID = Dokter.DokterID " +
     "INNER JOIN Pasien ON Antrian.PasienID = Pasien.PasienID", conn);


            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Antrian");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Antrian";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        void kondisiawal()
        {
            load_data();
        }

        public string emailkedua
        {
            get { return email.Text; }
            set { email.Text = value; }
        }



        private void DashboardPasien_Load(object sender, EventArgs e)
        {

            SqlDataReader reader = null;
            SqlConnection conn = con.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from Pasien Where Email ='" + email.Text + "'", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                email.Text = reader[7].ToString();
                nama.Text = reader[1].ToString();
                reader.Close();
            }

            kondisiawal();
        }

        private void daftarAntrianToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginPengguna pengguna = new LoginPengguna();
            pengguna.Show();
            this.Close();
        }

        private void gantiPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordPengguna pengguna = new PasswordPengguna();
            pengguna.emailkedua = email.Text;
            pengguna.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void jadwalDokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasien_JadwalDokter jadwal = new Pasien_JadwalDokter();

            jadwal.Show();
        }

        private void rekamMedisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasien_RekamMedis rekam = new Pasien_RekamMedis();
            rekam.nama = nama.Text;
            rekam.Show();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection conn = con.GetConn();

            cmd = new SqlCommand("SELECT Antrian.AntrianID, Pasien.Nama_Pasien, Dokter.Nama_Dokter, " +
       "Antrian.NomorAntrian, Antrian.Status, Antrian.WaktuPendaftaran, Antrian.WaktuPanggil " +
       "FROM Antrian " +
       "INNER JOIN Dokter ON Antrian.DokterID = Dokter.DokterID " +
       "INNER JOIN Pasien ON Antrian.PasienID = Pasien.PasienID " +
       "WHERE Antrian.NomorAntrian LIKE '%' + @search + '%' " +
       "OR Pasien.Nama_Pasien LIKE '%' + @search + '%' " +
       "OR Dokter.Nama_Dokter LIKE '%' + @search + '%' " +
       "OR Antrian.Status LIKE '%' + @search + '%'", conn);

            cmd.Parameters.AddWithValue("@search", txtcari.Text.Trim());

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Antrian");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Antrian";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_data();            
        }
    }
}
