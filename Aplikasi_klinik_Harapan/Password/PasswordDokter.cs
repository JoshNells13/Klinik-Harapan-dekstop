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

namespace Aplikasi_klinik_Harapan.Password
{
    public partial class PasswordDokter : Form
    {

        Koneksi conn = new Koneksi();
        SqlCommand cmd, cmd2;

        public string email
        {
            get { return Email.Text; }
            set { Email.Text = value; }
        }

        void kondisiawal()
        {
            txtoldpw.Text = "";
            txtnewpw.Text = "";
            txtconfirm.Text = "";
            this.ActiveControl = txtoldpw;
        }


        public PasswordDokter()
        {
            InitializeComponent();
        }

        private void PasswordDokter_Load(object sender, EventArgs e)
        {
            txtconfirm.PasswordChar = '*';
            txtnewpw.PasswordChar = '*';
            txtoldpw.PasswordChar = '*';
            this.ActiveControl = txtoldpw;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtoldpw.Text) ||
       string.IsNullOrWhiteSpace(txtnewpw.Text) ||
       string.IsNullOrWhiteSpace(txtconfirm.Text))
            {
                MessageBox.Show("Pastikan Mengisi Semua Form Yang Ada");
                return;
            }

            // Validasi apakah password baru dan konfirmasi password sama
            if (txtnewpw.Text != txtconfirm.Text)
            {
                MessageBox.Show("Konfirmasi Password tidak cocok dengan Password Baru.");
                return;
            }

            using (SqlConnection con = conn.GetConn())
            {
                con.Open();

                // Periksa apakah password lama sesuai
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Dokter WHERE Email = @Email AND PasswordHash = @Password", con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", txtoldpw.Text);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read()) // Jika data ditemukan (password lama cocok)
                        {
                            rd.Close();

                            // Update password baru
                            using (SqlCommand cmd2 = new SqlCommand("UPDATE Dokter SET PasswordHash = @NewPassword WHERE Email = @Email", con))
                            {
                                cmd2.Parameters.AddWithValue("@NewPassword", txtnewpw.Text);
                                cmd2.Parameters.AddWithValue("@Email", email);
                                cmd2.ExecuteNonQuery();
                            }

                            MessageBox.Show("Password Berhasil Diubah");
                            kondisiawal();
                        }
                        else
                        {
                            MessageBox.Show("Password Lama tidak Sesuai Dengan Email.");
                        }
                    }
                }
            }
        }
    }
}
