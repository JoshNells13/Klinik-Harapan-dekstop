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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplikasi_klinik_Harapan
{

    public partial class LoginAdmin : Form
    {

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        Koneksi conn = new Koneksi();
        public LoginAdmin()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login mainform = new Login();
            mainform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader rd = null;
            SqlConnection con = conn.GetConn();
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Admin WHERE Email = @email AND PasswordHash = @password", con);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    // Ambil nilai Status dari database
                    int status = Convert.ToInt32(rd["StatusAktif"]);

                    if (status == 1) // Status Aktif
                    {
                        DashboardAdmin ke_Menu = new DashboardAdmin();
                        ke_Menu.emailkedua = txtEmail.Text;
                        ke_Menu.Show();
                        this.Hide();
                    }
                    else // Status Tidak Aktif
                    {
                        MessageBox.Show("Akun Anda Tidak Aktif. Silakan Hubungi Admin");
                    }
                }
                else
                {
                    MessageBox.Show("Email atau Password Salah, Mungkin Tidak Terdaftar");
                }

                rd.Close();
                con.Close();
            }

        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Hubungi Admin Untuk Pembuatan Akun Dan Registrasi");
        }
    }
}
