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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikasi_klinik_Harapan
{
    public partial class ManajemenKamar : Form
    {

        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;


        void load_kamar()
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT Kamar.KamarID ,Kamar.NomorKamar , Kamar.Kapasitas , Kamar.TarifHarian,Kamar.Status,TipeKamar.Nama_Tipe " +
                "FROM Kamar " +
                "INNER JOIN TipeKamar ON Kamar.ID_TipeKamar = TipeKamar.ID_TipeKamar", con);

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "kamar");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "kamar";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        void kondisiawal()
        {
            txtID.Enabled = false;
            txtKapasitas.Enabled = false;
            txtNomor.Enabled = false;
            txtTarif.Enabled = false;
            comboTipe.Enabled = false;

            comboTipe.SelectedItem = null;

            txtID.Text = "";
            txtNomor.Text = "";
            txtKapasitas.Text = "";
            txtTarif.Text = "";

            btnAdd.Text = "Add";
            btnEdit.Text = "Edit";
            btnDelete.Text = "Delete";

            load_kamar();
            load_tipe();
        }

        void tambahaktif()
        {
            txtID.Enabled = false;
            txtKapasitas.Enabled = true;
            txtNomor.Enabled = true;
            txtTarif.Enabled = true;
            comboTipe.Enabled = true;

            btnAdd.Text = "Save";
        }

        void edit()
        {

            btnEdit.Text = "Save";
            btnDelete.Text = "Delete";

            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            txtID.Enabled = true;
            txtTarif.Enabled = true;
            txtNomor.Enabled = true;
            txtKapasitas.Enabled = true;

            comboTipe.Enabled = true;

            this.ActiveControl = txtID;


         
        }

        void edit2()
        {

            btnEdit.Text = "Save";
            btnDelete.Text = "Delete";

            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

            txtID.Enabled = true;
            txtTarif.Enabled = true;
            txtNomor.Enabled = true;
            txtKapasitas.Enabled = true;


            comboTipe.Enabled = true;



            this.ActiveControl = txtNomor;
        }


        void load_tipe()
        {
            SqlConnection con = conn.GetConn();
            con.Open();

            string query = "SELECT DISTINCT Nama_Tipe FROM TipeKamar";
            cmd = new SqlCommand(query, con);
            SqlDataReader rd = cmd.ExecuteReader();

            comboTipe.Items.Clear();

            while (rd.Read())
            {
                comboTipe.Items.Add(rd["Nama_Tipe"].ToString());
            }

            con.Close();
        }

        public ManajemenKamar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManajemenKamar_Load(object sender, EventArgs e)
        {
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
                if (txtKapasitas.Text.Trim() == "" || txtNomor.Text.Trim() == "" || txtTarif.Text.Trim() == "" || comboTipe.SelectedIndex == null || Aktif.Checked == null || TidakAktif.Checked == null)
                {
                    MessageBox.Show("Pastikan Mengisi Form Yang Ada");
                }
                else
                {
                    SqlConnection con = conn.GetConn();
                    con.Open();

                    string selectedTipeKamar = comboTipe.SelectedItem.ToString();
                    string query2 = "SELECT ID_TipeKamar FROM TipeKamar WHERE Nama_Tipe = @tipeKamar";
                    cmd = new SqlCommand(query2, con);
                    cmd.Parameters.AddWithValue("@tipeKamar", selectedTipeKamar);



                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Tipe Kamar yang dipilih tidak valid.");
                        con.Close();
                        return;
                    }

                    int idTipeKamar = Convert.ToInt32(result);

                    String Status = "Tidak Di ketahui";


                    if (Aktif.Checked)
                    {
                        Status = "Aktif";
                    }
                    else if (TidakAktif.Checked)
                    {
                        Status = "Tidak Aktif";
                    }

                    string query = "INSERT INTO Kamar (NomorKamar, Kapasitas, TarifHarian,Status,ID_TipeKamar) VALUES(@nomor, @kapasitas, @tarif,@status,@idTipe)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nomor", txtNomor.Text);
                    cmd.Parameters.AddWithValue("@kapasitas", txtKapasitas.Text);
                    cmd.Parameters.AddWithValue("@tarif", txtTarif.Text);
                    cmd.Parameters.AddWithValue("@status", Status);
                    cmd.Parameters.AddWithValue("@idTipe", idTipeKamar);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Kamar Berhasil Di Tambah");
                    kondisiawal();


                }
            }
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT Kamar.KamarID, Kamar.NomorKamar, Kamar.Kapasitas, Kamar.TarifHarian, Kamar.Status, TipeKamar.Nama_Tipe " +
                "FROM Kamar " +
                "INNER JOIN TipeKamar ON Kamar.ID_TipeKamar = TipeKamar.ID_TipeKamar " +
                "WHERE Kamar.NomorKamar LIKE @search " +
                "OR Kamar.Kapasitas LIKE @search " +
                "OR Kamar.TarifHarian LIKE @search " +
                "OR Kamar.Status LIKE @search " +
                "OR TipeKamar.Nama_Tipe LIKE @search", con);

            cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Kamar");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Kamar";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlDataReader reader = null;
                SqlConnection con = conn.GetConn();
                con.Open();
                cmd = new SqlCommand("Select * from Kamar Where KamarID ='" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtNomor.Text = reader[1].ToString();
                    txtKapasitas.Text = reader[2].ToString();
                    txtTarif.Text = reader[3].ToString();




                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Data Kamar Tidak Ada");
                }
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
                if (txtKapasitas.Text.Trim() == "" || txtNomor.Text.Trim() == "" || txtTarif.Text.Trim() == "" || comboTipe.SelectedIndex == null || Aktif.Checked == null || TidakAktif.Checked == null || txtID.Text.Trim() == "")
                {
                    MessageBox.Show("Pastikan Mengisi Form yang ada");
                    return;
                }

                SqlConnection con = conn.GetConn();
                con.Open();

                string selectedTipeKamar = comboTipe.SelectedItem.ToString();
                string query2 = "SELECT ID_TipeKamar FROM TipeKamar WHERE Nama_Tipe = @tipeKamar";
                cmd = new SqlCommand(query2, con);
                cmd.Parameters.AddWithValue("@tipeKamar", selectedTipeKamar);

                object result = cmd.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Tipe Kamar yang dipilih tidak valid.");
                    con.Close();
                    return;
                }

                int idTipeKamar = Convert.ToInt32(result);

                // Konversi nilai Kapasitas dan TarifHarian
                int kapasitas;
                decimal tarif;

                if (!int.TryParse(txtKapasitas.Text, out kapasitas))
                {
                    MessageBox.Show("Kapasitas harus berupa angka.");
                    con.Close();
                    return;
                }

                if (!decimal.TryParse(txtTarif.Text, out tarif))
                {
                    MessageBox.Show("Tarif harus berupa angka.");
                    con.Close();
                    return;
                }

                string Status = "Tidak Di Ketahui";
                if (Aktif.Checked)
                {
                    Status = "Aktif";
                }
                else if (TidakAktif.Checked)
                {
                    Status = "Tidak Aktif";
                }

                string query = "UPDATE Kamar SET NomorKamar = @nomor, Kapasitas = @kapasitas, TarifHarian = @tarif, Status = @status, ID_TipeKamar = @idTipe WHERE KamarID = @id";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nomor", txtNomor.Text);
                cmd.Parameters.AddWithValue("@kapasitas", kapasitas);
                cmd.Parameters.AddWithValue("@tarif", tarif);
                cmd.Parameters.AddWithValue("@status", Status);
                cmd.Parameters.AddWithValue("@idTipe", idTipeKamar);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Kamar Berhasil Di Edit!");
                kondisiawal();
                con.Close();



            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data Ini", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = conn.GetConn();
                con.Open();

                cmd = new SqlCommand("Delete From Kamar where KamarID= '" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Tipe Kamar Berhasil Di Hapus");
                kondisiawal();
            }
            else
            {
                kondisiawal();
            }
        }
    }
}
