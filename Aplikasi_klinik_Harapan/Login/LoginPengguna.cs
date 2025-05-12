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
    public partial class LoginPengguna : Form
    {

        Koneksi conn = new Koneksi();
        SqlCommand cmd;
        public LoginPengguna()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlDataReader rd = null;
            SqlConnection con = conn.GetConn();
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Pasien WHERE Email = @email AND PasswordHash = @password", con);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    int status = Convert.ToInt32(rd["StatusAktif"]); // Pastikan nama kolom di database 'Status'

                    if (status == 1) // Status Aktif
                    {
                        DashboardPasien ke_Menu = new DashboardPasien();
                        ke_Menu.emailkedua = txtEmail.Text;
                        ke_Menu.Show();
                        this.Hide();
                    }
                    else // Status Tidak Aktif (0)
                    {
                        MessageBox.Show("Akun Anda Tidak Aktif. Silakan hubungi Admin.");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginPengguna_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            this.ActiveControl = txtEmail;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Login mainform = new Login();
            mainform.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DaftarPasien pasien = new DaftarPasien();
            pasien.Show();
        }
    }
}
