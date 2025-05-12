using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplikasi_klinik_Harapan.HalamanDokter;
using Aplikasi_klinik_Harapan.Password;
using Microsoft.Data.SqlClient;

namespace Aplikasi_klinik_Harapan
{
    public partial class DashboardDokter : Form
    {

        Koneksi con = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public DashboardDokter()
        {
            InitializeComponent();
        }

        void load_data()
        {
            SqlConnection conn = con.GetConn();

            cmd = new SqlCommand("SELECT JadwalDokter.JadwalID ,Dokter.Nama_Dokter,JadwalDokter.Hari,JadwalDokter.JamMulai,JadwalDokter.JamSelesai " +
                "FROM JadwalDokter " +
                "INNER JOIN Dokter ON JadwalDokter.DokterID = Dokter.DokterID " +
                "WHERE Dokter.Nama_Dokter =@dokter", conn);
            cmd.Parameters.AddWithValue("@dokter", nama.Text);
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
            load_data();
        }

        public string emailkedua
        {
            get { return email.Text; }
            set { email.Text = value; }
        }

        private void DashboardDokter_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = con.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from Dokter Where Email ='" + email.Text + "'", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                email.Text = reader[9].ToString();
                nama.Text = reader[1].ToString();
                reader.Close();
            }

            kondisiawal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void antrianPasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokter_JadwaAntrian antrian = new Dokter_JadwaAntrian();
            antrian.nama = nama.Text;
            antrian.Show();
        }

        private void jadwalPraktekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokter_JadwalPraktik jadwalpraktik = new Dokter_JadwalPraktik();
            jadwalpraktik.nama = nama.Text;
            jadwalpraktik.Show();
        }

        private void rawatInapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokter_RawatInap rawat = new Dokter_RawatInap();
            rawat.nama = nama.Text;
            rawat.Show();
        }

        private void rekamMedisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dokter_RekamMedis rekam = new Dokter_RekamMedis();
            rekam.nama = nama.Text;
            rekam.Show();
        }

        private void gantiPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordDokter passwordDokter = new PasswordDokter();
            passwordDokter.email = email.Text;
            passwordDokter.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginDokter loginDokter = new LoginDokter();
            loginDokter.Show();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection conn = con.GetConn();

            string query = "SELECT JadwalDokter.JadwalID, Dokter.Nama_Dokter, JadwalDokter.Hari, " +
                "JadwalDokter.JamMulai, JadwalDokter.JamSelesai " +
                "FROM JadwalDokter " +
                "INNER JOIN Dokter ON JadwalDokter.DokterID = Dokter.DokterID " +
                "WHERE Dokter.Nama_Dokter = @dokter ";

            if (!string.IsNullOrWhiteSpace(txtcari.Text))
            {
                query += "AND (JadwalDokter.Hari LIKE @search " +
                         "OR JadwalDokter.JamMulai LIKE @search " +
                         "OR JadwalDokter.JamSelesai LIKE @search) ";
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@dokter", nama.Text);

            if (!string.IsNullOrWhiteSpace(txtcari.Text))
            {
                cmd.Parameters.AddWithValue("@search", "%" + txtcari.Text.Trim() + "%");
            }

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "JadwalDokter");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "JadwalDokter";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
