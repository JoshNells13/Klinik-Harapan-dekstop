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
    public partial class DashboardAdmin : Form
    {
        SqlCommand cmd;
        Koneksi konek = new Koneksi();
        DataSet ds;
        SqlDataAdapter da;
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        void load_data()
        {
            SqlConnection con = konek.GetConn();

            cmd = new SqlCommand("SELECT Pasien.Nama_Pasien,Dokter.Nama_Dokter,Antrian.NomorAntrian,Antrian.Status,Antrian.WaktuPendaftaran,Antrian.WaktuPanggil " +
                "FROM Antrian " +
                "INNER JOIN Dokter ON Antrian.DokterID = Dokter.DokterID " +
                "INNER JOIN Pasien ON Antrian.PasienID = Pasien.PasienID", con);

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Antrian");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Antrian";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }



        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            datagrid();
            load_data();

            SqlDataReader reader = null;
            SqlConnection conn = konek.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from Admin Where Email ='" + email.Text + "'", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                email.Text = reader[5].ToString();
                nama.Text = reader[1].ToString();
                reader.Close();
            }

        }

        public string emailkedua
        {
            get { return email.Text; }
            set { email.Text = value; }
        }

        void datagrid()
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginAdmin login = new LoginAdmin();
            login.Show();
            this.Close();
        }

        private void gantiPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordAdmin gantipw = new PasswordAdmin();
            gantipw.emailkedua = email.Text;
            gantipw.Show();
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void manajemenKamarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manajemenKamarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManajemenKamar kamar = new ManajemenKamar();
            kamar.Show();
        }

        private void manajemenTipeKamarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManajemenTipeKamar tipekamar = new ManajemenTipeKamar();
            tipekamar.Show();
        }

        private void manajemenAntrianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManajemenAntrian antrian = new ManajemenAntrian();
            antrian.Show();
        }

        private void manajemenPembayaranRawatInapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManajemenRawatInap rawatinap = new ManajemenRawatInap();
            rawatinap.Show();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection con = konek.GetConn();

            cmd = new SqlCommand("SELECT  Antrian.AntrianID, Pasien.Nama_Pasien,Dokter.Nama_Dokter,Antrian.NomorAntrian,Antrian.Status,Antrian.WaktuPendaftaran,Antrian.WaktuPanggil " +
                "FROM Antrian " +
                "INNER JOIN Dokter ON Antrian.DokterID = Dokter.DokterID " +
                "INNER JOIN Pasien ON Antrian.PasienID = Pasien.PasienID " +
                "WHERE Antrian.NomorAntrian LIKE @search OR Pasien.Nama_Pasien LIKE @search", con);

            cmd.Parameters.AddWithValue("@search", "%" + txtcari.Text + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Antrian");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Antrian";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Selesai"].Index)
            {
                // Mengambil nomor kamar dari baris yang dipilih
                string nomorantrian = dataGridView1.Rows[e.RowIndex].Cells["NomorAntrian"].Value.ToString();
            
                // Menghapus data dari database
                SqlConnection conn = konek.GetConn();
                conn.Open();

                // Query untuk menghapus data di tabel FasilitasBerdasarkanTipeKamar
                string queryDelete = "DELETE FROM Antrian " +
                                     "WHERE AntrianID IN (SELECT AntrianID FROM Antrian WHERE NomorAntrian = @NomorAntrian)";
                cmd = new SqlCommand(queryDelete, conn);
                cmd.Parameters.AddWithValue("@Nomorantrian", nomorantrian);
                cmd.ExecuteNonQuery();

                conn.Close();

                // Menghapus baris dari DataGridView
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void manajemenPembayaranRawatInapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManajemenPembayaranRawatIna pembayaran = new ManajemenPembayaranRawatIna();
            pembayaran.Show();
        }

        private void manajemenKaryawanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManajemenKaryawan karyawan = new ManajemenKaryawan();
            karyawan.Show();
        }

        private void manajemenPasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManajemenPasien PasienPengguna = new ManajemenPasien();
            PasienPengguna.Show();
        }

        private void manajemenDokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManajemenDokter dokter = new ManajemenDokter();
            dokter.Show();
        }

        private void manajemenApotekerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManajemenApoteker Apoteker = new ManajemenApoteker();
            Apoteker.Show();
        }

        private void jadwalDokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JadwalDokter JadwalDokter = new JadwalDokter();
            JadwalDokter.Show();
        }

        private void rekamMedisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RekamMedis rekamMedis = new RekamMedis();
            rekamMedis.Show();
        }

        private void obatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManajemenObat manajemenObat = new ManajemenObat();
            manajemenObat.Show();
        }

        private void manajenenResepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManajemenResep resep = new ManajemenResep();
            resep.Show();
        }

        private void transaksiObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManajemenTransaksiObat transaksiObat = new ManajemenTransaksiObat();
            transaksiObat.Show();
        }

        private void detailTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailTransaksiObat detail = new DetailTransaksiObat();
            detail.Show();
        }

        private void manajemenPenggunaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

