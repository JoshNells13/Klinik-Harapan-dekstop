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
    public partial class ManajemenAntrian : Form
    {

        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public ManajemenAntrian()
        {
            InitializeComponent();
        }
        void load_antrian()
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT Antrian.AntrianID, Pasien.Nama_Pasien,Dokter.Nama_Dokter,Antrian.NomorAntrian,Antrian.Status,Antrian.WaktuPendaftaran,Antrian.WaktuPanggil " +
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

        void datajam()
        {
            tgldaftar.Format = DateTimePickerFormat.Custom;
            tgldaftar.CustomFormat = "yyyy-MM-dd HH:mm";
        

            tglpanggil.Format = DateTimePickerFormat.Custom;
            tglpanggil.CustomFormat = "yyyy-MM-dd HH:mm";
        
        }

        void kondisiawal()
        {
            txtID.Enabled = false;
            combodokter.Enabled = false;
            combopasien.Enabled = false;

            Menunggu.Enabled = false;
            dipanggil.Enabled = false;
            batal.Enabled = false;
            selesai.Enabled = false;

            combodokter.SelectedIndex = -1;
            combopasien.SelectedIndex = -1;

            tgldaftar.Enabled = false;
            tglpanggil.Enabled = false;

            btnAdd.Text = "Add";
            btnEdit.Text = "Edit";
            btnDelete.Text = "Delete";

            datajam();
            load_antrian();
        }


        void tambahaktif()
        {
            txtID.Enabled = false;
            combodokter.Enabled = true;
            combopasien.Enabled = true;

            Menunggu.Enabled = true;
            dipanggil.Enabled = true;
            batal.Enabled = true;
            selesai.Enabled = true;

            tgldaftar.Enabled = true;
            tglpanggil.Enabled = true;

            btnAdd.Text = "Save";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        void edit()
        {
            btnEdit.Text = "Save";
            btnDelete.Text = "Delete";

            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;


            Menunggu.Enabled = true;
            dipanggil.Enabled = true;
            batal.Enabled = true;
            selesai.Enabled = true;

            txtID.Enabled = true;
            combodokter.Enabled = true;
            combopasien.Enabled = true;
            tgldaftar.Enabled = true;
            tglpanggil.Enabled = true;

            this.ActiveControl = txtID;
        }

        void edit2()
        {
            btnEdit.Text = "Save";
            btnDelete.Text = "Delete";

            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;



            Menunggu.Enabled = true;
            dipanggil.Enabled = true;
            batal.Enabled = true;
            selesai.Enabled = true;

            txtID.Enabled = true;
            combopasien.Enabled = true;
            combodokter.Enabled = true;
            tglpanggil.Enabled = true;
            tgldaftar.Enabled = true;





            this.ActiveControl = txtID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManajemenAntrian_Load(object sender, EventArgs e)
        {
            load_dokter();
            load_pasien();
            kondisiawal();
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT Antrian.AntrianID, Pasien.Nama_Pasien, Dokter.Nama_Dokter, Antrian.NomorAntrian, Antrian.Status, Antrian.WaktuPendaftaran, Antrian.WaktuPanggil " +
                "FROM Antrian " +
                "INNER JOIN Dokter ON Antrian.DokterID = Dokter.DokterID " +
                "INNER JOIN Pasien ON Antrian.PasienID = Pasien.PasienID " +
                "WHERE Antrian.NomorAntrian LIKE @search " +
                "OR Pasien.Nama_Pasien LIKE @search " +
                "OR Dokter.Nama_Dokter LIKE @search " +
                "OR Antrian.Status LIKE @search", con);

            cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Antrian");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Antrian";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                tambahaktif();
            }
            else
            {
                if (combodokter.SelectedIndex == -1 || combopasien.SelectedIndex == -1)
                {
                    MessageBox.Show("Pastikan Mengisi Data Di Form Yang Ada");
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

                    //data Pasien
                    string selectedpasien = combopasien.SelectedItem.ToString();
                    string query3 = "SELECT PasienID FROM Pasien WHERE Nama_Pasien = @tipepasien";
                    cmd = new SqlCommand(query3, con);
                    cmd.Parameters.AddWithValue("@tipepasien", selectedpasien);



                    object result2 = cmd.ExecuteScalar();

                    if (result2 == null)
                    {
                        MessageBox.Show("Data Pasien yang dipilih tidak valid.");
                        con.Close();
                        return;
                    }

                    int idpasien = Convert.ToInt32(result2);



                    //Status
                    String Status = "";

                    if (Menunggu.Checked)
                    {
                        Status = "Menunggu";
                    }
                    else if (dipanggil.Checked)
                    {
                        Status = "Dipanggil";
                    }
                    else if (selesai.Checked)
                    {
                        Status = "Selesai";
                    }
                    else if (batal.Checked)
                    {
                        Status = "Batal";
                    }
                    else
                    {
                        Status = "Batal";
                    }



                    //Tanggal

                    DateTime daftar = Convert.ToDateTime(tgldaftar.Text);
                    string waktuDaftar = daftar.ToString("yyyy-MM-dd HH:mm");

                    DateTime panggil = Convert.ToDateTime(tglpanggil.Text);
                    string waktupanggil = panggil.ToString("yyyy-MM-dd HH:mm");


                    //nomor antrian
                    string queryAntrian = "SELECT COALESCE(MAX(NomorAntrian), 0) + 1 FROM Antrian";
                    cmd = new SqlCommand(queryAntrian, con);
                    int nomorAntrian = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd = new SqlCommand("INSERT INTO Antrian(PasienID,DokterID,NomorAntrian,Status,WaktuPendaftaran,WaktuPanggil) " +
                        "VALUES(@pasien,@dokter,@nomorantrian,@status,@daftar,@panggil)", con);
                    cmd.Parameters.AddWithValue("@pasien", idpasien);
                    cmd.Parameters.AddWithValue("@dokter", iddokter);
                    cmd.Parameters.AddWithValue("@nomorantrian", nomorAntrian);
                    cmd.Parameters.AddWithValue("@status", Status);
                    cmd.Parameters.AddWithValue("@daftar", waktuDaftar);
                    cmd.Parameters.AddWithValue("@panggil", waktupanggil);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    kondisiawal();
                    MessageBox.Show("Data Antrian Berhasil Di Tambah");
                }
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SqlDataReader reader = null;
                SqlConnection con = conn.GetConn();
                con.Open();


                if (!int.TryParse(txtID.Text, out int antrianID))
                {
                    MessageBox.Show("ID Antrian tidak valid.");
                    return;
                }

                string query = "SELECT Pasien.Nama_Pasien, Dokter.Nama_Dokter, Antrian.WaktuPendaftaran, Antrian.WaktuPanggil " +
                               "FROM Antrian " +
                               "INNER JOIN Pasien ON Antrian.PasienID = Pasien.PasienID " +
                               "INNER JOIN Dokter ON Antrian.DokterID = Dokter.DokterID " +
                               "WHERE Antrian.AntrianID = @id";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", antrianID);

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        combopasien.Text = reader["Nama_Pasien"].ToString();
                        combodokter.Text = reader["Nama_Dokter"].ToString();
                        tgldaftar.Text = reader["WaktuPendaftaran"].ToString();
                        tglpanggil.Text = reader["WaktuPanggil"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Data Antrian Tidak Ada");
                }

                reader.Close();
                con.Close();

                edit2();
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
                if (combodokter.SelectedIndex == -1 || combopasien.SelectedIndex == -1 || txtID.Text.Trim() == "")
                {
                    MessageBox.Show("Pastikan Semua Data Terisi");
                }
                else
                {
                    if (combodokter.SelectedIndex == -1 || combopasien.SelectedIndex == -1)
                    {
                        MessageBox.Show("Pastikan Mengisi Data Di Form Yang Ada");
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

                        //data Pasien
                        string selectedpasien = combopasien.SelectedItem.ToString();
                        string query3 = "SELECT PasienID FROM Pasien WHERE Nama_Pasien = @tipepasien";
                        cmd = new SqlCommand(query3, con);
                        cmd.Parameters.AddWithValue("@tipepasien", selectedpasien);



                        object result2 = cmd.ExecuteScalar();

                        if (result2 == null)
                        {
                            MessageBox.Show("Data Pasien yang dipilih tidak valid.");
                            con.Close();
                            return;
                        }

                        int idpasien = Convert.ToInt32(result2);



                        //Status
                        String Status = "";

                        if (Menunggu.Checked)
                        {
                            Status = "Menunggu";
                        }
                        else if (dipanggil.Checked)
                        {
                            Status = "Dipanggil";
                        }
                        else if (selesai.Checked)
                        {
                            Status = "Selesai";
                        }
                        else if (batal.Checked)
                        {
                            Status = "Batal";
                        }
                        else
                        {
                            Status = "Batal";
                        }



                        //Tanggal

                        DateTime daftar = Convert.ToDateTime(tgldaftar.Text);
                        string waktuDaftar = daftar.ToString("yyyy-MM-dd HH:mm");

                        DateTime panggil = Convert.ToDateTime(tglpanggil.Text);
                        string waktupanggil = panggil.ToString("yyyy-MM-dd HH:mm");




                        cmd = new SqlCommand("UPDATE Antrian SET PasienID = @pasien, DokterID = @dokter ,  " +
      "Status = @status, WaktuPendaftaran = @daftar, WaktuPanggil = @panggil " +
      "WHERE AntrianID = @id", con);

                        cmd.Parameters.AddWithValue("@pasien", idpasien);
                        cmd.Parameters.AddWithValue("@dokter", iddokter);

                        cmd.Parameters.AddWithValue("@status", Status);
                        cmd.Parameters.AddWithValue("@daftar", waktuDaftar);
                        cmd.Parameters.AddWithValue("@panggil", waktupanggil);
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));

                        cmd.ExecuteNonQuery();


                        con.Close();
                        kondisiawal();
                        MessageBox.Show("Data Antrian Berhasil Di Edit");
                    }
                }
            }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            kondisiawal();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data Ini", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = conn.GetConn();
                con.Open();

                cmd = new SqlCommand("Delete From Antrian where AntrianID= '" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Antrian Berhasil Di Hapus");
                kondisiawal();
            }
            else
            {
                kondisiawal();
            }
        }
    }
}
