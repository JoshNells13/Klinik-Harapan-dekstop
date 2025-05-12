namespace Aplikasi_klinik_Harapan
{
    partial class ManajemenPasien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManajemenPasien));
            label3 = new Label();
            btncari = new Button();
            label2 = new Label();
            txtcari = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label15 = new Label();
            txtID = new TextBox();
            Status = new CheckBox();
            label13 = new Label();
            label1 = new Label();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label14 = new Label();
            txtPenyakit = new TextBox();
            txtNama = new TextBox();
            txtAlergi = new TextBox();
            label10 = new Label();
            txtGolongan = new TextBox();
            label4 = new Label();
            label9 = new Label();
            txtUsername = new TextBox();
            label8 = new Label();
            txtAlamat = new TextBox();
            txtPassword = new TextBox();
            label7 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            tglLahir = new DateTimePicker();
            Perempuan = new RadioButton();
            txtNomorHP = new TextBox();
            Laki = new RadioButton();
            ubah = new Button();
            Tambah = new Button();
            button3 = new Button();
            hapus = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(905, 77);
            label3.Name = "label3";
            label3.Size = new Size(496, 86);
            label3.TabIndex = 58;
            label3.Text = "Klinik Harapan";
            // 
            // btncari
            // 
            btncari.BackColor = Color.Teal;
            btncari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncari.ForeColor = SystemColors.ButtonHighlight;
            btncari.Location = new Point(1476, 274);
            btncari.Name = "btncari";
            btncari.Size = new Size(113, 39);
            btncari.TabIndex = 57;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = false;
            btncari.Click += btncari_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(596, 268);
            label2.Name = "label2";
            label2.Size = new Size(367, 45);
            label2.TabIndex = 56;
            label2.Text = "Data Pasien/Pengguna";
            // 
            // txtcari
            // 
            txtcari.Location = new Point(1004, 275);
            txtcari.Name = "txtcari";
            txtcari.Size = new Size(383, 39);
            txtcari.TabIndex = 55;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(596, 335);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1077, 1090);
            dataGridView1.TabIndex = 54;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(Status);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtPenyakit);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(txtAlergi);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtGolongan);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtAlamat);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(tglLahir);
            panel1.Controls.Add(Perempuan);
            panel1.Controls.Add(txtNomorHP);
            panel1.Controls.Add(Laki);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 1699);
            panel1.TabIndex = 53;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(26, 353);
            label15.Name = "label15";
            label15.Size = new Size(135, 37);
            label15.TabIndex = 84;
            label15.Text = "ID Pasien";
            // 
            // txtID
            // 
            txtID.Location = new Point(26, 403);
            txtID.Name = "txtID";
            txtID.Size = new Size(252, 39);
            txtID.TabIndex = 83;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Status.ForeColor = SystemColors.ButtonHighlight;
            Status.Location = new Point(26, 1632);
            Status.Name = "Status";
            Status.Size = new Size(198, 41);
            Status.TabIndex = 82;
            Status.Text = "Status Aktif";
            Status.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Transparent;
            label13.Location = new Point(26, 1525);
            label13.Name = "label13";
            label13.Size = new Size(239, 37);
            label13.TabIndex = 81;
            label13.Text = "Riwayat Penyakit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(26, 289);
            label1.Name = "label1";
            label1.Size = new Size(463, 45);
            label1.TabIndex = 3;
            label1.Text = "Manajemen Pasien/Pengguna";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(26, 1438);
            label12.Name = "label12";
            label12.Size = new Size(95, 37);
            label12.TabIndex = 80;
            label12.Text = "Alergi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(26, 1332);
            label11.Name = "label11";
            label11.Size = new Size(226, 37);
            label11.TabIndex = 79;
            label11.Text = "Golongan Darah";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(26, 445);
            label14.Name = "label14";
            label14.Size = new Size(93, 37);
            label14.TabIndex = 60;
            label14.Text = "Nama";
            // 
            // txtPenyakit
            // 
            txtPenyakit.Location = new Point(26, 1565);
            txtPenyakit.Name = "txtPenyakit";
            txtPenyakit.Size = new Size(289, 39);
            txtPenyakit.TabIndex = 71;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(26, 496);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(252, 39);
            txtNama.TabIndex = 59;
            // 
            // txtAlergi
            // 
            txtAlergi.Location = new Point(26, 1483);
            txtAlergi.Name = "txtAlergi";
            txtAlergi.Size = new Size(200, 39);
            txtAlergi.TabIndex = 70;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(26, 1220);
            label10.Name = "label10";
            label10.Size = new Size(110, 37);
            label10.TabIndex = 78;
            label10.Text = "Alamat";
            // 
            // txtGolongan
            // 
            txtGolongan.Location = new Point(26, 1385);
            txtGolongan.Name = "txtGolongan";
            txtGolongan.Size = new Size(200, 39);
            txtGolongan.TabIndex = 69;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(26, 553);
            label4.Name = "label4";
            label4.Size = new Size(228, 37);
            label4.TabIndex = 72;
            label4.Text = "Nama Pengguna";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(26, 1114);
            label9.Name = "label9";
            label9.Size = new Size(87, 37);
            label9.TabIndex = 77;
            label9.Text = "Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(26, 602);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(252, 39);
            txtUsername.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(26, 1010);
            label8.Name = "label8";
            label8.Size = new Size(153, 37);
            label8.TabIndex = 76;
            label8.Text = "Nomor HP";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(26, 1272);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(324, 39);
            txtAlamat.TabIndex = 68;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(26, 706);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(252, 39);
            txtPassword.TabIndex = 62;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(26, 916);
            label7.Name = "label7";
            label7.Size = new Size(192, 37);
            label7.TabIndex = 75;
            label7.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(26, 662);
            label5.Name = "label5";
            label5.Size = new Size(139, 37);
            label5.TabIndex = 73;
            label5.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 1167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 39);
            txtEmail.TabIndex = 67;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(26, 767);
            label6.Name = "label6";
            label6.Size = new Size(190, 37);
            label6.TabIndex = 74;
            label6.Text = "Tanggal Lahir";
            // 
            // tglLahir
            // 
            tglLahir.Location = new Point(26, 820);
            tglLahir.Name = "tglLahir";
            tglLahir.Size = new Size(400, 39);
            tglLahir.TabIndex = 63;
            // 
            // Perempuan
            // 
            Perempuan.AutoSize = true;
            Perempuan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Perempuan.ForeColor = SystemColors.ButtonHighlight;
            Perempuan.Location = new Point(247, 958);
            Perempuan.Name = "Perempuan";
            Perempuan.Size = new Size(192, 36);
            Perempuan.TabIndex = 65;
            Perempuan.TabStop = true;
            Perempuan.Text = "PEREMPUAN";
            Perempuan.UseVisualStyleBackColor = true;
            // 
            // txtNomorHP
            // 
            txtNomorHP.Location = new Point(26, 1060);
            txtNomorHP.Name = "txtNomorHP";
            txtNomorHP.Size = new Size(374, 39);
            txtNomorHP.TabIndex = 66;
            // 
            // Laki
            // 
            Laki.AutoSize = true;
            Laki.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Laki.ForeColor = SystemColors.ButtonHighlight;
            Laki.Location = new Point(26, 958);
            Laki.Name = "Laki";
            Laki.Size = new Size(163, 36);
            Laki.TabIndex = 64;
            Laki.TabStop = true;
            Laki.Text = "LAKI-LAKI";
            Laki.UseVisualStyleBackColor = true;
            // 
            // ubah
            // 
            ubah.BackColor = Color.MediumTurquoise;
            ubah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ubah.ForeColor = SystemColors.ButtonHighlight;
            ubah.Location = new Point(596, 1484);
            ubah.Name = "ubah";
            ubah.Size = new Size(150, 46);
            ubah.TabIndex = 59;
            ubah.Text = "Edit";
            ubah.UseVisualStyleBackColor = false;
            ubah.Click += ubah_Click;
            // 
            // Tambah
            // 
            Tambah.BackColor = Color.MediumSeaGreen;
            Tambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tambah.ForeColor = SystemColors.ButtonHighlight;
            Tambah.Location = new Point(596, 1593);
            Tambah.Name = "Tambah";
            Tambah.Size = new Size(150, 46);
            Tambah.TabIndex = 60;
            Tambah.Text = "Add";
            Tambah.UseVisualStyleBackColor = false;
            Tambah.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(813, 1484);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 61;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // hapus
            // 
            hapus.BackColor = Color.Red;
            hapus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hapus.ForeColor = SystemColors.ButtonHighlight;
            hapus.Location = new Point(813, 1593);
            hapus.Name = "hapus";
            hapus.Size = new Size(150, 46);
            hapus.TabIndex = 62;
            hapus.Text = "Delete";
            hapus.UseVisualStyleBackColor = false;
            hapus.Click += hapus_Click;
            // 
            // ManajemenPasien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1691, 1696);
            Controls.Add(hapus);
            Controls.Add(button3);
            Controls.Add(Tambah);
            Controls.Add(ubah);
            Controls.Add(label3);
            Controls.Add(btncari);
            Controls.Add(label2);
            Controls.Add(txtcari);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ManajemenPasien";
            Text = "ManajemenPasien";
            Load += ManajemenPasien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btncari;
        private Label label2;
        private TextBox txtcari;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private CheckBox Status;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label14;
        private TextBox txtPenyakit;
        private TextBox txtNama;
        private TextBox txtAlergi;
        private Label label10;
        private TextBox txtGolongan;
        private Label label4;
        private Label label9;
        private TextBox txtUsername;
        private Label label8;
        private TextBox txtAlamat;
        private TextBox txtPassword;
        private Label label7;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private DateTimePicker tglLahir;
        private RadioButton Perempuan;
        private TextBox txtNomorHP;
        private RadioButton Laki;
        private Button ubah;
        private Button Tambah;
        private Button button3;
        private Button hapus;
        private Label label15;
        private TextBox txtID;
    }
}