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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Aplikasi_klinik_Harapan
{
    public partial class ManajemenRawatInap : Form
    {

        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        void loaddata()
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT RawatInap.RawatInapID,Pasien.Nama_Pasien,Dokter.Nama_Dokter,Kamar.NomorKamar,TipeKamar.Nama_Tipe,RawatInap.TanggalMasuk,RawatInap.TanggalKeluar,RawatInap.Diagnosa,RawatInap.Status " +
                "From RawatInap " +
                "INNER JOIN Kamar ON RawatInap.KamarID = Kamar.KamarID " +
                "INNER JOIN Dokter ON RawatInap.DokterID = Dokter.DokterID " +
                "INNER JOIN TipeKamar ON Kamar.ID_TipeKamar = TipeKamar.ID_TipeKamar " +
                "INNER JOIN Pasien ON RawatInap.PasienID = Pasien.PasienID", con);

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "RawatInap");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RawatInap";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }


        void datajam()
        {
            tglmasuk.Format = DateTimePickerFormat.Custom;
            tglmasuk.CustomFormat = "yyyy-MM-dd HH:mm";


            tglkeluar.Format = DateTimePickerFormat.Custom;
            tglkeluar.CustomFormat = "yyyy-MM-dd HH:mm";

        }

        void kondisiawal()
        {
            txtDiag.Enabled = false;
            txtID.Enabled = false;
            combodokter.Enabled = false;
            combonomor.Enabled = false;
            combopasien.Enabled = false;
            tglmasuk.Enabled = false;
            tglkeluar.Enabled = false;

            txtDiag.Text = "";
            txtID.Text = "";

            btnAdd.Enabled = true;
            btndelete.Enabled = true;
            btnEdit.Enabled = true;

            btnAdd.Text = "Add";
            btndelete.Text = "Delete";
            btnEdit.Text = "Edit";

            loaddata();
            datajam();
        }


        void tambahaktif()
        {
            txtDiag.Enabled = true;
            txtID.Enabled = false;
            combodokter.Enabled = true;
            combonomor.Enabled = true;
            combopasien.Enabled = true;
            tglmasuk.Enabled = true;
            tglkeluar.Enabled = true;


            btnAdd.Enabled = true;
            btndelete.Enabled = false;
            btnEdit.Enabled = false;

            btnAdd.Text = "Save";
            btndelete.Text = "Delete";
            btnEdit.Text = "Edit";
        }

        void edit()
        {
            txtDiag.Enabled = true;
            txtID.Enabled = true;
            combodokter.Enabled = true;
            combonomor.Enabled = true;
            combopasien.Enabled = true;
            tglmasuk.Enabled = true;
            tglkeluar.Enabled = true;


            btnAdd.Enabled = false;
            btndelete.Enabled = true;
            btnEdit.Enabled = true;

            btnAdd.Text = "Add";
            btndelete.Text = "Delete";
            btnEdit.Text = "Save";

            this.ActiveControl = txtID;
        }

        void edit2()
        {
            txtDiag.Enabled = true;
            txtID.Enabled = true;
            combodokter.Enabled = true;
            combonomor.Enabled = true;
            combopasien.Enabled = true;
            tglmasuk.Enabled = true;
            tglkeluar.Enabled = true;


            btnAdd.Enabled = false;
            btndelete.Enabled = true;
            btnEdit.Enabled = true;

            btnAdd.Text = "Add";
            btndelete.Text = "Delete";
            btnEdit.Text = "Save";

            this.ActiveControl = txtID;
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

        void load_nomorkamar()
        {
            SqlConnection con = conn.GetConn();
            con.Open();

            string query = "SELECT DISTINCT NomorKamar FROM Kamar Where Status = 'Aktif'";
            cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();

            combonomor.Items.Clear();

            while (rd.Read())
            {
                combonomor.Items.Add(rd["NomorKamar"].ToString());
            }

            con.Close();
        }

        public ManajemenRawatInap()
        {
            InitializeComponent();
        }

        private void ManajemenRawatInap_Load(object sender, EventArgs e)
        {
            load_nomorkamar();
            load_pasien();
            load_dokter();
            kondisiawal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                tambahaktif();
            }
            else
            {
                // Validasi semua form harus diisi
                if (txtDiag.Text.Trim() == "" ||
                    combodokter.SelectedIndex == -1 ||
                    combopasien.SelectedIndex == -1 ||
                    combonomor.SelectedIndex == -1 ||
                    tglmasuk.Text.Trim() == "" ||
                    tglkeluar.Text.Trim() == "" ||
                    (!radiosembuh.Checked && !radiorawat.Checked && !radiopindah.Checked && !radiomeninggal.Checked))
                {
                    MessageBox.Show("Pastikan semua data di form telah diisi lengkap!");
                }
                else
                {
                    SqlConnection con = conn.GetConn();
                    con.Open();

                    // Data Dokter
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

                    // Data Pasien
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

                    // Data Kamar
                    string selectedkamar = combonomor.SelectedItem.ToString();
                    string query4 = "SELECT KamarID FROM Kamar WHERE NomorKamar = @tipenomor";
                    cmd = new SqlCommand(query4, con);
                    cmd.Parameters.AddWithValue("@tipenomor", selectedkamar);

                    object result3 = cmd.ExecuteScalar();
                    if (result3 == null)
                    {
                        MessageBox.Show("Data kamar yang dipilih tidak valid.");
                        con.Close();
                        return;
                    }
                    int idkamar = Convert.ToInt32(result3);

                    // Status
                    string Status = "";
                    if (radiosembuh.Checked) Status = "Sembuh";
                    else if (radiorawat.Checked) Status = "DiRawat";
                    else if (radiopindah.Checked) Status = "Pindah";
                    else if (radiomeninggal.Checked) Status = "Meninggal";
                    else Status = "Batal";

                    // Tanggal
                    DateTime masuk = Convert.ToDateTime(tglmasuk.Text);
                    string waktumasuk = masuk.ToString("yyyy-MM-dd HH:mm");

                    DateTime keluar = Convert.ToDateTime(tglkeluar.Text);
                    string waktukeluar = keluar.ToString("yyyy-MM-dd HH:mm");

                    // Insert ke database
                    cmd = new SqlCommand("INSERT INTO RawatInap (PasienID, DokterID, KamarID, TanggalMasuk, TanggalKeluar, Diagnosa, Status) " +
                                         "VALUES (@pasien, @dokter, @kamar, @tglmasuk, @tglkeluar, @diagnosa, @status)", con);

                    cmd.Parameters.AddWithValue("@pasien", idpasien);
                    cmd.Parameters.AddWithValue("@dokter", iddokter);
                    cmd.Parameters.AddWithValue("@kamar", idkamar);
                    cmd.Parameters.AddWithValue("@tglmasuk", waktumasuk);
                    cmd.Parameters.AddWithValue("@tglkeluar", waktukeluar);
                    cmd.Parameters.AddWithValue("@diagnosa", txtDiag.Text);
                    cmd.Parameters.AddWithValue("@status", Status);

                    cmd.ExecuteNonQuery();

                    con.Close();
                    kondisiawal();
                    MessageBox.Show("Data Rawat Inap Berhasil Ditambahkan");
                }
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
                if (txtDiag.Text.Trim() == "" ||
                     combodokter.SelectedIndex == -1 ||
                     combopasien.SelectedIndex == -1 ||
                     combonomor.SelectedIndex == -1 ||
                     tglmasuk.Text.Trim() == "" ||
                     tglkeluar.Text.Trim() == "" ||
                     (!radiosembuh.Checked && !radiorawat.Checked && !radiopindah.Checked && !radiomeninggal.Checked) ||
                     txtID.Text.Trim() == "")
                {
                    MessageBox.Show("Pastikan Mengisi Data Yang Ada Di Form");
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



                    //data kamar
                    string selectedkamar = combonomor.SelectedItem.ToString();
                    string query4 = "SELECT KamarID FROM Kamar WHERE NomorKamar = @tipenomor";
                    cmd = new SqlCommand(query4, con);
                    cmd.Parameters.AddWithValue("@tipenomor", selectedkamar);



                    object result3 = cmd.ExecuteScalar();

                    if (result3 == null)
                    {
                        MessageBox.Show("Data kamar yang dipilih tidak valid.");
                        con.Close();
                        return;
                    }

                    int idkamar = Convert.ToInt32(result3);



                    //Status
                    String Status = "";

                    if (radiosembuh.Checked)
                    {
                        Status = "Sembuh";
                    }
                    else if (radiorawat.Checked)
                    {
                        Status = "DiRawat";
                    }
                    else if (radiopindah.Checked)
                    {
                        Status = "Pindah";
                    }
                    else if (radiomeninggal.Checked)
                    {
                        Status = "Meninggal";
                    }
                    else
                    {
                        Status = "Batal";
                    }



                    //Tanggal

                    DateTime masuk = Convert.ToDateTime(tglmasuk.Text);
                    string waktumasuk = masuk.ToString("yyyy-MM-dd--HH--mm");

                    DateTime keluar = Convert.ToDateTime(tglkeluar.Text);
                    string waktukeluar = keluar.ToString("yyyy-MM-dd--HH--mm");

                    cmd = new SqlCommand("UPDATE RawatInap SET PasienID = @pasien, DokterID = @dokter, KamarID = @kamar, " +
                      "TanggalMasuk = @tglmasuk, TanggalKeluar = @tglkeluar, Diagnosa = @diagnosa, Status = @status " +
                      "WHERE RawatInapID = @id", con);

                    cmd.Parameters.AddWithValue("@pasien", idpasien);
                    cmd.Parameters.AddWithValue("@dokter", iddokter);
                    cmd.Parameters.AddWithValue("@kamar", idkamar);
                    cmd.Parameters.AddWithValue("@tglmasuk", waktumasuk);
                    cmd.Parameters.AddWithValue("@tglkeluar", waktukeluar);
                    cmd.Parameters.AddWithValue("@diagnosa", txtDiag.Text);
                    cmd.Parameters.AddWithValue("@status", Status);
                    cmd.Parameters.AddWithValue("@id", txtID.Text); 


                    cmd.ExecuteNonQuery();

                    con.Close();
                    kondisiawal();
                    MessageBox.Show("Data Rawat Inap Berhasil Di Edit");
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data Ini", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = conn.GetConn();
                con.Open();

                cmd = new SqlCommand("Delete From RawatInap where RawatInapID= '" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Rawat inap Berhasil Di Hapus");
                kondisiawal();
            }
            else
            {
                kondisiawal();
            }
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();

            string query = "SELECT ri.RawatInapID, ps.Nama_Pasien, dr.Nama_Dokter, km.NomorKamar, tk.Nama_Tipe, " +
                           "ri.TanggalMasuk, ri.TanggalKeluar, ri.Diagnosa, ri.Status " +
                           "FROM RawatInap ri " +
                           "INNER JOIN Kamar km ON ri.KamarID = km.KamarID " +
                           "INNER JOIN Dokter dr ON ri.DokterID = dr.DokterID " +
                           "INNER JOIN Pasien ps ON ri.PasienID = ps.PasienID " +
                           "INNER JOIN TipeKamar tk ON km.ID_TipeKamar = tk.ID_TipeKamar " +
                           "WHERE ps.Nama_Pasien LIKE @search " +
                           "OR km.NomorKamar LIKE @search " +
                           "OR ri.Status LIKE @search " +  
                           "ORDER BY ri.TanggalMasuk DESC"; 

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "RawatInap");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RawatInap";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

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

                string query = "SELECT RawatInap.RawatInapID,Pasien.Nama_Pasien,Dokter.Nama_Dokter,Kamar.NomorKamar,RawatInap.TanggalMasuk,RawatInap.TanggalKeluar,RawatInap.Diagnosa,RawatInap.Status " +
                "From RawatInap " +
                "INNER JOIN Kamar ON RawatInap.KamarID = Kamar.KamarID " +
                "INNER JOIN Dokter ON RawatInap.DokterID = Dokter.DokterID " +
                "INNER JOIN Pasien ON RawatInap.PasienID = Pasien.PasienID " +
                               "WHERE RawatInapID = @id";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", antrianID);

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        combodokter.Text = reader[2].ToString();
                        combonomor.Text = reader[3].ToString();
                        combopasien.Text = reader[1].ToString();
                        tglkeluar.Text = reader[5].ToString();
                        tglmasuk.Text = reader[4].ToString();
                        txtDiag.Text = reader[6].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Data Rawat Inap Tidak Ada");
                }

                reader.Close();
                con.Close();

                edit2();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
