using System.Security.Cryptography;

namespace Aplikasi_klinik_Harapan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoginAdmin admin = new LoginAdmin();
            admin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginPengguna pengguna = new LoginPengguna();
            pengguna.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginDokter dokter = new LoginDokter();
            dokter.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginApoteker apoteker = new LoginApoteker();
            apoteker.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DI BUAT OLEH JOSHUA CHRISTIAN LIONEL XI RPL 1 2025");
        }
    }
}
