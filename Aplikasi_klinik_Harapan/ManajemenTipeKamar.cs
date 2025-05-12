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
    public partial class ManajemenTipeKamar : Form
    {

        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public ManajemenTipeKamar()
        {
            InitializeComponent();
        }

        void load_kamar()
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT * FROM TipeKamar", con);

            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TipeKamar");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TipeKamar";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        void kondisiawal()
        {
            txtFasilitas.Text = "";
            txtTipe.Text = "";
            txtID.Text = "";

            txtFasilitas.Enabled = false;
            txtID.Enabled = false;
            txtTipe.Enabled = false;


            btnAdd.Text = "Add";
            btnEdit.Text = "Edit";

            load_kamar();
        }

        void tambahaktif()
        {
            txtFasilitas.Enabled = true;
            txtID.Enabled = false;
            txtTipe.Enabled = true;


            btnAdd.Text = "Save";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManajemenTipeKamar_Load(object sender, EventArgs e)
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
                if (txtFasilitas.Text.Trim() == "" || txtTipe.Text.Trim() == "")
                {
                    MessageBox.Show("Pastikan Mengisi Data Di Form Yang Ada");
                }
                else
                {
                    SqlConnection konek = conn.GetConn();
                    konek.Open();

                    cmd = new SqlCommand("INSERT INTO TipeKamar(Nama_Tipe,Fasilitas) VALUES(@TipeKamar,@Fasilitas)", konek);

                    cmd.Parameters.AddWithValue("@TipeKamar", txtTipe.Text);
                    cmd.Parameters.AddWithValue("@Fasilitas", txtFasilitas.Text);
                    cmd.ExecuteNonQuery();



                    konek.Close();

                    MessageBox.Show("Data Berhasil Di Tambah");
                    kondisiawal();
                }
            }
        }

        void edit()
        {
            btnAdd.Text = "Add";
            btnEdit.Text = "Save";
            btndelete.Text = "Delete";

            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btndelete.Enabled = true;

            txtID.Enabled = true;
            txtTipe.Enabled = false;
            txtFasilitas.Enabled = false;

            this.ActiveControl = txtID;


            load_kamar();
        }

        void edit2()
        {
            btnAdd.Text = "Add";
            btnEdit.Text = "Save";
            btndelete.Text = "Delete";

            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btndelete.Enabled = true;

            txtID.Enabled = true;
            txtTipe.Enabled = true;
            txtFasilitas.Enabled = true;



            this.ActiveControl = txtTipe;
        }

        private void btncari_Click(object sender, EventArgs e)
        {
            SqlConnection con = conn.GetConn();

            cmd = new SqlCommand("SELECT * FROM TipeKamar WHERE Nama_Tipe LIKE @search OR Fasilitas LIKE @search", con);
            cmd.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TipeKamar");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TipeKamar";
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
                cmd = new SqlCommand("Select * from TipeKamar Where ID_TipeKamar ='" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTipe.Text = reader[1].ToString();
                    txtFasilitas.Text = reader[2].ToString();



                    reader.Close();
                }
                else
                {
                    MessageBox.Show("Data Karyawan Tidak Ada");
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
                if (txtFasilitas.Text.Trim() == "" || txtTipe.Text.Trim() == "" || txtID.Text.Trim() == "")
                {
                    MessageBox.Show("Pastikan Mengisi Form yang ada");
                    return;
                }
                SqlConnection con = conn.GetConn();
                con.Open();
                string query = "UPDATE TipeKamar SET Nama_Tipe = @tipe, Fasilitas = @fasilitas WHERE ID_TipeKamar = @id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fasilitas", txtFasilitas.Text);
                cmd.Parameters.AddWithValue("@tipe", txtTipe.Text);
                cmd.Parameters.AddWithValue("id", Convert.ToInt32(txtID.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Tipe Kamar Berhasil Di Edit!");
                kondisiawal();
                con.Close();


            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data Ini", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = conn.GetConn();
                con.Open();

                cmd = new SqlCommand("Delete From TipeKamar where ID_TipeKamar= '" + txtID.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Tipe Kamar Berhasil Di Hapus");
                kondisiawal();
            }
            else
            {
                kondisiawal();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
