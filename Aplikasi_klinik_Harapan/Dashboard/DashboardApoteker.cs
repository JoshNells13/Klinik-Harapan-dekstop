using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplikasi_klinik_Harapan.Password;
using Microsoft.Data.SqlClient;

namespace Aplikasi_klinik_Harapan
{
    public partial class DashboardApoteker : Form
    {

        SqlCommand cmd;
        Koneksi konek = new Koneksi();
        DataSet ds;
        SqlDataAdapter da;


        void load_data()
        {
            SqlConnection con = konek.GetConn();

            cmd = new SqlCommand("SELECT * FROM Obat", con);

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Obat");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Obat";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        public string emailkedua
        {
            get { return email.Text; }
            set { email.Text = value; }
        }
        public DashboardApoteker()
        {
            InitializeComponent();
        }

        private void DashboardApoteker_Load(object sender, EventArgs e)
        {
            load_data();

            SqlDataReader reader = null;
            SqlConnection conn = konek.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from Apoteker Where Email ='" + email.Text + "'", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                email.Text = reader[8].ToString();
                nama.Text = reader[1].ToString();
                reader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void manToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManajemenObat obat = new ManajemenObat();
            obat.Show();
        }

        private void resepObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManajemenResep resep = new ManajemenResep();
            resep.Show();
        }

        private void transaksiObatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manajemenTransaksiObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManajemenTransaksiObat transaksi = new ManajemenTransaksiObat();
            transaksi.Show();
        }

        private void manajemenDetailTransaksiObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailTransaksiObat detail = new DetailTransaksiObat();
            detail.Show();
        }

        private void gantiPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordApoteker passwordApoteker = new PasswordApoteker();
            passwordApoteker.email = email.Text;
            passwordApoteker.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginApoteker login = new LoginApoteker();
            login.Show();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection kon = konek.GetConn();
            cmd = new SqlCommand("SELECT * FROM Obat WHERE NamaObat LIKE @search ", kon);
            cmd.Parameters.AddWithValue("@search", "%" + txtcari.Text + "%");
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Obat");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Obat";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }
    }
}
