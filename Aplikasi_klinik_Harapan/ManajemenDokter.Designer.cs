namespace Aplikasi_klinik_Harapan
{
    partial class ManajemenDokter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManajemenDokter));
            label1 = new Label();
            label3 = new Label();
            btncari = new Button();
            label2 = new Label();
            txtCari = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            cuti = new CheckBox();
            comboSpesialisasi = new ComboBox();
            txtAlamat = new TextBox();
            txtEmail = new TextBox();
            txtNOHP = new TextBox();
            txtPengalaman = new TextBox();
            txtSIP = new TextBox();
            txtSTR = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtNama = new TextBox();
            txtID = new TextBox();
            ckAktif = new CheckBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            hapus = new Button();
            button3 = new Button();
            tambah = new Button();
            ubah = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(96, 289);
            label1.Name = "label1";
            label1.Size = new Size(308, 45);
            label1.TabIndex = 3;
            label1.Text = "Manajemen Dokter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(905, 77);
            label3.Name = "label3";
            label3.Size = new Size(496, 86);
            label3.TabIndex = 64;
            label3.Text = "Klinik Harapan";
            // 
            // btncari
            // 
            btncari.BackColor = Color.Teal;
            btncari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncari.ForeColor = SystemColors.ButtonHighlight;
            btncari.Location = new Point(1560, 275);
            btncari.Name = "btncari";
            btncari.Size = new Size(113, 39);
            btncari.TabIndex = 63;
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
            label2.Size = new Size(205, 45);
            label2.TabIndex = 62;
            label2.Text = "Data Dokter";
            // 
            // txtCari
            // 
            txtCari.Location = new Point(960, 275);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(383, 39);
            txtCari.TabIndex = 61;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(596, 335);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1077, 961);
            dataGridView1.TabIndex = 60;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(cuti);
            panel1.Controls.Add(comboSpesialisasi);
            panel1.Controls.Add(txtAlamat);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtNOHP);
            panel1.Controls.Add(txtPengalaman);
            panel1.Controls.Add(txtSIP);
            panel1.Controls.Add(txtSTR);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(ckAktif);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 1518);
            panel1.TabIndex = 59;
            // 
            // cuti
            // 
            cuti.AutoSize = true;
            cuti.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuti.ForeColor = SystemColors.ButtonHighlight;
            cuti.Location = new Point(375, 1415);
            cuti.Name = "cuti";
            cuti.Size = new Size(101, 41);
            cuti.TabIndex = 29;
            cuti.Text = "Cuti";
            cuti.UseVisualStyleBackColor = true;
            // 
            // comboSpesialisasi
            // 
            comboSpesialisasi.FormattingEnabled = true;
            comboSpesialisasi.Location = new Point(24, 1014);
            comboSpesialisasi.Name = "comboSpesialisasi";
            comboSpesialisasi.Size = new Size(242, 40);
            comboSpesialisasi.TabIndex = 28;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(24, 1363);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(332, 39);
            txtAlamat.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(24, 1278);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(332, 39);
            txtEmail.TabIndex = 26;
            // 
            // txtNOHP
            // 
            txtNOHP.Location = new Point(24, 1198);
            txtNOHP.Name = "txtNOHP";
            txtNOHP.Size = new Size(332, 39);
            txtNOHP.TabIndex = 25;
            // 
            // txtPengalaman
            // 
            txtPengalaman.Location = new Point(24, 1108);
            txtPengalaman.Name = "txtPengalaman";
            txtPengalaman.Size = new Size(332, 39);
            txtPengalaman.TabIndex = 24;
            // 
            // txtSIP
            // 
            txtSIP.Location = new Point(24, 916);
            txtSIP.Name = "txtSIP";
            txtSIP.Size = new Size(332, 39);
            txtSIP.TabIndex = 22;
            // 
            // txtSTR
            // 
            txtSTR.Location = new Point(24, 826);
            txtSTR.Name = "txtSTR";
            txtSTR.Size = new Size(332, 39);
            txtSTR.TabIndex = 21;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(24, 720);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(332, 39);
            txtPassword.TabIndex = 20;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(24, 619);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(332, 39);
            txtUsername.TabIndex = 19;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(24, 518);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(332, 39);
            txtNama.TabIndex = 18;
            // 
            // txtID
            // 
            txtID.Location = new Point(24, 428);
            txtID.Name = "txtID";
            txtID.Size = new Size(332, 39);
            txtID.TabIndex = 17;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // ckAktif
            // 
            ckAktif.AutoSize = true;
            ckAktif.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckAktif.ForeColor = SystemColors.ButtonHighlight;
            ckAktif.Location = new Point(257, 1416);
            ckAktif.Name = "ckAktif";
            ckAktif.Size = new Size(112, 41);
            ckAktif.TabIndex = 16;
            ckAktif.Text = "Aktif";
            ckAktif.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(24, 1411);
            label15.Name = "label15";
            label15.Size = new Size(227, 45);
            label15.TabIndex = 15;
            label15.Text = "Status Praktik";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(24, 1315);
            label14.Name = "label14";
            label14.Size = new Size(127, 45);
            label14.TabIndex = 14;
            label14.Text = "Alamat";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Transparent;
            label13.Location = new Point(24, 1230);
            label13.Name = "label13";
            label13.Size = new Size(101, 45);
            label13.TabIndex = 13;
            label13.Text = "Email";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(24, 1150);
            label12.Name = "label12";
            label12.Size = new Size(119, 45);
            label12.TabIndex = 12;
            label12.Text = "No HP";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(24, 1056);
            label11.Name = "label11";
            label11.Size = new Size(302, 45);
            label11.TabIndex = 11;
            label11.Text = "Pengalaman Tahun";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(24, 966);
            label10.Name = "label10";
            label10.Size = new Size(187, 45);
            label10.TabIndex = 10;
            label10.Text = "Spesialisasi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(24, 868);
            label9.Name = "label9";
            label9.Size = new Size(126, 45);
            label9.TabIndex = 9;
            label9.Text = "NO SIP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(24, 762);
            label8.Name = "label8";
            label8.Size = new Size(136, 45);
            label8.TabIndex = 8;
            label8.Text = "NO STR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(24, 661);
            label7.Name = "label7";
            label7.Size = new Size(163, 45);
            label7.TabIndex = 7;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(24, 558);
            label6.Name = "label6";
            label6.Size = new Size(430, 45);
            label6.TabIndex = 6;
            label6.Text = "Nama Pengguna/Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(24, 470);
            label5.Name = "label5";
            label5.Size = new Size(221, 45);
            label5.TabIndex = 5;
            label5.Text = "Nama Dokter";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(24, 369);
            label4.Name = "label4";
            label4.Size = new Size(167, 45);
            label4.TabIndex = 4;
            label4.Text = "ID Dokter";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(96, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // hapus
            // 
            hapus.BackColor = Color.Red;
            hapus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hapus.ForeColor = SystemColors.ButtonHighlight;
            hapus.Location = new Point(799, 1412);
            hapus.Name = "hapus";
            hapus.Size = new Size(150, 62);
            hapus.TabIndex = 68;
            hapus.Text = "Delete";
            hapus.UseVisualStyleBackColor = false;
            hapus.Click += hapus_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(799, 1319);
            button3.Name = "button3";
            button3.Size = new Size(150, 63);
            button3.TabIndex = 67;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // tambah
            // 
            tambah.BackColor = Color.MediumSeaGreen;
            tambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tambah.ForeColor = SystemColors.ButtonHighlight;
            tambah.Location = new Point(582, 1412);
            tambah.Name = "tambah";
            tambah.Size = new Size(150, 62);
            tambah.TabIndex = 66;
            tambah.Text = "Add";
            tambah.UseVisualStyleBackColor = false;
            tambah.Click += tambah_Click;
            // 
            // ubah
            // 
            ubah.BackColor = Color.MediumTurquoise;
            ubah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ubah.ForeColor = SystemColors.ButtonHighlight;
            ubah.Location = new Point(582, 1319);
            ubah.Name = "ubah";
            ubah.Size = new Size(150, 63);
            ubah.TabIndex = 65;
            ubah.Text = "Edit";
            ubah.UseVisualStyleBackColor = false;
            ubah.Click += ubah_Click;
            // 
            // ManajemenDokter
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1691, 1478);
            Controls.Add(hapus);
            Controls.Add(button3);
            Controls.Add(tambah);
            Controls.Add(ubah);
            Controls.Add(label3);
            Controls.Add(btncari);
            Controls.Add(label2);
            Controls.Add(txtCari);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ManajemenDokter";
            Text = "ManajemenDokter";
            Load += ManajemenDokter_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button btncari;
        private Label label2;
        private TextBox txtCari;
        private DataGridView dataGridView1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox comboSpesialisasi;
        private TextBox txtAlamat;
        private TextBox txtEmail;
        private TextBox txtNOHP;
        private TextBox txtPengalaman;
        private TextBox txtSIP;
        private TextBox txtSTR;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtNama;
        private TextBox txtID;
        private CheckBox ckAktif;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button hapus;
        private Button button3;
        private Button tambah;
        private Button ubah;
        private CheckBox cuti;
    }
}