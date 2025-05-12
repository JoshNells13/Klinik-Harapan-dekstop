namespace Aplikasi_klinik_Harapan
{
    partial class DaftarPasien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaftarPasien));
            txtNama = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            tglLahir = new DateTimePicker();
            Laki = new RadioButton();
            Perempuan = new RadioButton();
            txtNomorHP = new TextBox();
            txtEmail = new TextBox();
            txtAlamat = new TextBox();
            txtGolongan = new TextBox();
            txtAlergi = new TextBox();
            txtPenyakit = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            Submit = new Button();
            Status = new CheckBox();
            Refresh = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Location = new Point(312, 98);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(252, 39);
            txtNama.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-10, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 1182);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(62, 222);
            label1.Name = "label1";
            label1.Size = new Size(174, 37);
            label1.TabIndex = 1;
            label1.Text = "Form Daftar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(642, 1090);
            button1.Name = "button1";
            button1.Size = new Size(153, 51);
            button1.TabIndex = 27;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(312, 9);
            label2.Name = "label2";
            label2.Size = new Size(374, 30);
            label2.TabIndex = 2;
            label2.Text = "Pastikan Mengisi Data Dengan Benar";
            label2.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(312, 1109);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(324, 32);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sudah Mendaftar?Klik Di Sini";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(312, 181);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(252, 39);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(312, 272);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(252, 39);
            txtPassword.TabIndex = 4;
            // 
            // tglLahir
            // 
            tglLahir.Location = new Point(312, 367);
            tglLahir.Name = "tglLahir";
            tglLahir.Size = new Size(400, 39);
            tglLahir.TabIndex = 5;
            // 
            // Laki
            // 
            Laki.AutoSize = true;
            Laki.Location = new Point(312, 466);
            Laki.Name = "Laki";
            Laki.Size = new Size(149, 36);
            Laki.TabIndex = 6;
            Laki.TabStop = true;
            Laki.Text = "LAKI-LAKI";
            Laki.UseVisualStyleBackColor = true;
            // 
            // Perempuan
            // 
            Perempuan.AutoSize = true;
            Perempuan.Location = new Point(533, 466);
            Perempuan.Name = "Perempuan";
            Perempuan.Size = new Size(179, 36);
            Perempuan.TabIndex = 7;
            Perempuan.TabStop = true;
            Perempuan.Text = "PEREMPUAN";
            Perempuan.UseVisualStyleBackColor = true;
            // 
            // txtNomorHP
            // 
            txtNomorHP.Location = new Point(312, 556);
            txtNomorHP.Name = "txtNomorHP";
            txtNomorHP.Size = new Size(374, 39);
            txtNomorHP.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(312, 642);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 39);
            txtEmail.TabIndex = 9;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(312, 744);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(324, 39);
            txtAlamat.TabIndex = 10;
            // 
            // txtGolongan
            // 
            txtGolongan.Location = new Point(312, 845);
            txtGolongan.Name = "txtGolongan";
            txtGolongan.Size = new Size(200, 39);
            txtGolongan.TabIndex = 11;
            // 
            // txtAlergi
            // 
            txtAlergi.Location = new Point(312, 943);
            txtAlergi.Name = "txtAlergi";
            txtAlergi.Size = new Size(200, 39);
            txtAlergi.TabIndex = 12;
            // 
            // txtPenyakit
            // 
            txtPenyakit.Location = new Point(312, 1018);
            txtPenyakit.Name = "txtPenyakit";
            txtPenyakit.Size = new Size(289, 39);
            txtPenyakit.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(312, 55);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 2;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(312, 148);
            label4.Name = "label4";
            label4.Size = new Size(176, 30);
            label4.TabIndex = 15;
            label4.Text = "Nama Pengguna";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(312, 228);
            label5.Name = "label5";
            label5.Size = new Size(105, 30);
            label5.TabIndex = 16;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(312, 324);
            label6.Name = "label6";
            label6.Size = new Size(145, 30);
            label6.TabIndex = 17;
            label6.Text = "Tanggal Lahir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(312, 424);
            label7.Name = "label7";
            label7.Size = new Size(147, 30);
            label7.TabIndex = 18;
            label7.Text = "Jenis Kelamin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(312, 523);
            label8.Name = "label8";
            label8.Size = new Size(118, 30);
            label8.TabIndex = 19;
            label8.Text = "Nomor HP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(312, 609);
            label9.Name = "label9";
            label9.Size = new Size(66, 30);
            label9.TabIndex = 20;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(312, 699);
            label10.Name = "label10";
            label10.Size = new Size(83, 30);
            label10.TabIndex = 21;
            label10.Text = "Alamat";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(312, 799);
            label11.Name = "label11";
            label11.Size = new Size(174, 30);
            label11.TabIndex = 22;
            label11.Text = "Golongan Darah";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(312, 898);
            label12.Name = "label12";
            label12.Size = new Size(72, 30);
            label12.TabIndex = 23;
            label12.Text = "Alergi";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(312, 985);
            label13.Name = "label13";
            label13.Size = new Size(181, 30);
            label13.TabIndex = 24;
            label13.Text = "Riwayat Penyakit";
            // 
            // Submit
            // 
            Submit.BackColor = Color.FromArgb(0, 192, 0);
            Submit.Font = new Font("Segoe UI", 7.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.ForeColor = Color.Transparent;
            Submit.Location = new Point(641, 1019);
            Submit.Name = "Submit";
            Submit.Size = new Size(153, 51);
            Submit.TabIndex = 25;
            Submit.Text = "SUBMIT";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += button1_Click;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(312, 1070);
            Status.Name = "Status";
            Status.Size = new Size(166, 36);
            Status.TabIndex = 26;
            Status.Text = "Status Aktif";
            Status.UseVisualStyleBackColor = true;
            // 
            // Refresh
            // 
            Refresh.AutoSize = true;
            Refresh.Location = new Point(312, 1141);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(93, 32);
            Refresh.TabIndex = 28;
            Refresh.TabStop = true;
            Refresh.Text = "Refresh";
            Refresh.LinkClicked += Refresh_LinkClicked;
            // 
            // DaftarPasien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 1180);
            Controls.Add(Refresh);
            Controls.Add(button1);
            Controls.Add(Status);
            Controls.Add(Submit);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPenyakit);
            Controls.Add(txtAlergi);
            Controls.Add(txtGolongan);
            Controls.Add(txtAlamat);
            Controls.Add(txtEmail);
            Controls.Add(txtNomorHP);
            Controls.Add(Perempuan);
            Controls.Add(Laki);
            Controls.Add(tglLahir);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(txtNama);
            Name = "DaftarPasien";
            Text = "DaftarPasien";
            Load += DaftarPasien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNama;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private LinkLabel linkLabel1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private DateTimePicker tglLahir;
        private RadioButton Laki;
        private RadioButton Perempuan;
        private TextBox txtNomorHP;
        private TextBox txtEmail;
        private TextBox txtAlamat;
        private TextBox txtGolongan;
        private TextBox txtAlergi;
        private TextBox txtPenyakit;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button Submit;
        private CheckBox Status;
        private Button button1;
        private LinkLabel Refresh;
    }
}