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
    public partial class LoginDokter : Form
    {

        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        public LoginDokter()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Login mainform = new Login();
            mainform.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlDataReader rd = null;
            SqlConnection con = conn.GetConn();
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Dokter WHERE Email = @email AND PasswordHash = @password", con);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    string status = rd["StatusPraktik"].ToString();  // Pastikan kolom 'Status' ada di tabel Dokter

                    if (status == "Aktif")
                    {
                        DashboardDokter ke_Menu = new DashboardDokter();
                        ke_Menu.emailkedua = txtEmail.Text;
                        ke_Menu.Show();
                        this.Hide();
                    }
                    else if (status == "Pensiun")
                    {
                        MessageBox.Show("Akun Anda sudah PENSIUN. Tidak dapat mengakses aplikasi.");
                    }
                    else if (status == "Cuti")
                    {
                        MessageBox.Show("Akun Anda sedang CUTI. Silakan login kembali setelah aktif.");
                    }
                    else
                    {
                        MessageBox.Show("Status akun tidak dikenali. Silakan hubungi admin.");
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

        private void LoginDokter_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            this.ActiveControl = txtEmail;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Hubungi Admin Untuk Pembuatan Akun Dan Registrasi Nya");
        }
    }
}
