namespace Aplikasi_klinik_Harapan
{
    partial class ManajemenApoteker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManajemenApoteker));
            label3 = new Label();
            btncari = new Button();
            label2 = new Label();
            txtCari = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            pensiun = new RadioButton();
            cuti = new RadioButton();
            radioAktif = new RadioButton();
            txtAlamat = new TextBox();
            txtEmail = new TextBox();
            txtNoHP = new TextBox();
            comboPendidikan = new ComboBox();
            txtTahunLulus = new TextBox();
            txtSTRA = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtNama = new TextBox();
            txtID = new TextBox();
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnHapus = new Button();
            button3 = new Button();
            btnTambah = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(905, 52);
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
            btncari.Location = new Point(1533, 217);
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
            label2.Location = new Point(596, 210);
            label2.Name = "label2";
            label2.Size = new Size(240, 45);
            label2.TabIndex = 56;
            label2.Text = "Data Apoteker";
            // 
            // txtCari
            // 
            txtCari.Location = new Point(1002, 216);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(383, 39);
            txtCari.TabIndex = 55;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(596, 261);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1077, 961);
            dataGridView1.TabIndex = 54;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(pensiun);
            panel1.Controls.Add(cuti);
            panel1.Controls.Add(radioAktif);
            panel1.Controls.Add(txtAlamat);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtNoHP);
            panel1.Controls.Add(comboPendidikan);
            panel1.Controls.Add(txtTahunLulus);
            panel1.Controls.Add(txtSTRA);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(txtID);
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
            panel1.Size = new Size(534, 1429);
            panel1.TabIndex = 53;
            // 
            // pensiun
            // 
            pensiun.AutoSize = true;
            pensiun.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pensiun.ForeColor = SystemColors.ButtonHighlight;
            pensiun.Location = new Point(243, 1373);
            pensiun.Name = "pensiun";
            pensiun.Size = new Size(135, 36);
            pensiun.TabIndex = 27;
            pensiun.TabStop = true;
            pensiun.Text = "Pensiun";
            pensiun.UseVisualStyleBackColor = true;
            // 
            // cuti
            // 
            cuti.AutoSize = true;
            cuti.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuti.ForeColor = SystemColors.ButtonHighlight;
            cuti.Location = new Point(129, 1373);
            cuti.Name = "cuti";
            cuti.Size = new Size(91, 36);
            cuti.TabIndex = 26;
            cuti.TabStop = true;
            cuti.Text = "Cuti";
            cuti.UseVisualStyleBackColor = true;
            // 
            // radioAktif
            // 
            radioAktif.AutoSize = true;
            radioAktif.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioAktif.ForeColor = SystemColors.ButtonHighlight;
            radioAktif.Location = new Point(23, 1373);
            radioAktif.Name = "radioAktif";
            radioAktif.Size = new Size(100, 36);
            radioAktif.TabIndex = 25;
            radioAktif.TabStop = true;
            radioAktif.Text = "Aktif";
            radioAktif.UseVisualStyleBackColor = true;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(23, 1274);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(270, 39);
            txtAlamat.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 1179);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(242, 39);
            txtEmail.TabIndex = 23;
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(23, 1083);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(242, 39);
            txtNoHP.TabIndex = 22;
            // 
            // comboPendidikan
            // 
            comboPendidikan.FormattingEnabled = true;
            comboPendidikan.Location = new Point(23, 1000);
            comboPendidikan.Name = "comboPendidikan";
            comboPendidikan.Size = new Size(242, 40);
            comboPendidikan.TabIndex = 21;
            // 
            // txtTahunLulus
            // 
            txtTahunLulus.Location = new Point(23, 901);
            txtTahunLulus.Name = "txtTahunLulus";
            txtTahunLulus.Size = new Size(200, 39);
            txtTahunLulus.TabIndex = 20;
            // 
            // txtSTRA
            // 
            txtSTRA.Location = new Point(23, 819);
            txtSTRA.Name = "txtSTRA";
            txtSTRA.Size = new Size(295, 39);
            txtSTRA.TabIndex = 19;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(23, 722);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(295, 39);
            txtPassword.TabIndex = 18;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(23, 640);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(295, 39);
            txtUsername.TabIndex = 17;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(23, 556);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(295, 39);
            txtNama.TabIndex = 16;
            // 
            // txtID
            // 
            txtID.Location = new Point(23, 474);
            txtID.Name = "txtID";
            txtID.Size = new Size(200, 39);
            txtID.TabIndex = 15;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(23, 1316);
            label14.Name = "label14";
            label14.Size = new Size(195, 37);
            label14.TabIndex = 14;
            label14.Text = "Status Praktik";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Transparent;
            label13.Location = new Point(23, 1221);
            label13.Name = "label13";
            label13.Size = new Size(110, 37);
            label13.TabIndex = 13;
            label13.Text = "Alamat";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(23, 1125);
            label12.Name = "label12";
            label12.Size = new Size(164, 37);
            label12.TabIndex = 12;
            label12.Text = "Email/Surel";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(23, 1043);
            label11.Name = "label11";
            label11.Size = new Size(214, 37);
            label11.TabIndex = 11;
            label11.Text = "No HP/Telepon";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(23, 954);
            label10.Name = "label10";
            label10.Size = new Size(270, 37);
            label10.TabIndex = 10;
            label10.Text = "Institusi Pendidikan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(23, 861);
            label9.Name = "label9";
            label9.Size = new Size(161, 37);
            label9.TabIndex = 9;
            label9.Text = "Tahun lulus";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(23, 766);
            label8.Name = "label8";
            label8.Size = new Size(130, 37);
            label8.TabIndex = 8;
            label8.Text = "No STRA";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(23, 682);
            label7.Name = "label7";
            label7.Size = new Size(139, 37);
            label7.TabIndex = 7;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(23, 593);
            label6.Name = "label6";
            label6.Size = new Size(369, 37);
            label6.TabIndex = 6;
            label6.Text = "Nama Pengguna/Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(23, 516);
            label5.Name = "label5";
            label5.Size = new Size(93, 37);
            label5.TabIndex = 5;
            label5.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(23, 434);
            label4.Name = "label4";
            label4.Size = new Size(173, 37);
            label4.TabIndex = 4;
            label4.Text = "ID Apoteker";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(72, 336);
            label1.Name = "label1";
            label1.Size = new Size(344, 45);
            label1.TabIndex = 3;
            label1.Text = "Manajemen Apoteker";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = SystemColors.ButtonHighlight;
            btnHapus.Location = new Point(813, 1344);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(150, 62);
            btnHapus.TabIndex = 72;
            btnHapus.Text = "Delete";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(813, 1251);
            button3.Name = "button3";
            button3.Size = new Size(150, 63);
            button3.TabIndex = 71;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.MediumSeaGreen;
            btnTambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = SystemColors.ButtonHighlight;
            btnTambah.Location = new Point(596, 1344);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(150, 62);
            btnTambah.TabIndex = 70;
            btnTambah.Text = "Add";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.MediumTurquoise;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(596, 1251);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 63);
            btnEdit.TabIndex = 69;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // ManajemenApoteker
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1691, 1422);
            Controls.Add(btnHapus);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(btncari);
            Controls.Add(btnTambah);
            Controls.Add(label2);
            Controls.Add(btnEdit);
            Controls.Add(txtCari);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ManajemenApoteker";
            Text = "ManajemenApoteker";
            Load += ManajemenApoteker_Load;
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
        private TextBox txtCari;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private RadioButton cuti;
        private RadioButton radioAktif;
        private TextBox txtAlamat;
        private TextBox txtEmail;
        private TextBox txtNoHP;
        private ComboBox comboPendidikan;
        private TextBox txtTahunLulus;
        private TextBox txtSTRA;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtNama;
        private TextBox txtID;
        private Button btnHapus;
        private Button button3;
        private Button btnTambah;
        private Button btnEdit;
        private RadioButton pensiun;
    }
}