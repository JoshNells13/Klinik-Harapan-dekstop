namespace Aplikasi_klinik_Harapan
{
    partial class DashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            panel1 = new Panel();
            nama = new Label();
            email = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Selesai = new DataGridViewButtonColumn();
            label2 = new Label();
            txtcari = new TextBox();
            btncari = new Button();
            label3 = new Label();
            accountToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            gantiPasswordToolStripMenuItem = new ToolStripMenuItem();
            keluarToolStripMenuItem = new ToolStripMenuItem();
            manajemenPenggunaToolStripMenuItem = new ToolStripMenuItem();
            manajemenKaryawanToolStripMenuItem = new ToolStripMenuItem();
            manajemenDokterToolStripMenuItem = new ToolStripMenuItem();
            jadwalDokterToolStripMenuItem = new ToolStripMenuItem();
            manajemenPasienToolStripMenuItem = new ToolStripMenuItem();
            rekamMedisToolStripMenuItem = new ToolStripMenuItem();
            manajemenApotekerToolStripMenuItem = new ToolStripMenuItem();
            obatToolStripMenuItem = new ToolStripMenuItem();
            manajenenResepToolStripMenuItem = new ToolStripMenuItem();
            transaksiObatToolStripMenuItem = new ToolStripMenuItem();
            detailTransaksiToolStripMenuItem = new ToolStripMenuItem();
            manajemenKamarToolStripMenuItem = new ToolStripMenuItem();
            manajemenKamarToolStripMenuItem1 = new ToolStripMenuItem();
            manajemenTipeKamarToolStripMenuItem = new ToolStripMenuItem();
            manajemenToolStripMenuItem = new ToolStripMenuItem();
            manajemenPembayaranRawatInapToolStripMenuItem = new ToolStripMenuItem();
            manajemenPembayaranRawatInapToolStripMenuItem1 = new ToolStripMenuItem();
            manajemenAntrianToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(nama);
            panel1.Controls.Add(email);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 843);
            panel1.TabIndex = 0;
            // 
            // nama
            // 
            nama.AutoSize = true;
            nama.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nama.ForeColor = Color.Transparent;
            nama.Location = new Point(58, 364);
            nama.Name = "nama";
            nama.Size = new Size(118, 50);
            nama.TabIndex = 5;
            nama.Text = "nama";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.Transparent;
            email.Location = new Point(58, 429);
            email.Name = "email";
            email.Size = new Size(118, 50);
            email.TabIndex = 4;
            email.Text = "email";
            email.Click += email_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 192, 192);
            button2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(245, 743);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 3;
            button2.Text = "Menu";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(42, 743);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(58, 260);
            label1.Name = "label1";
            label1.Size = new Size(337, 50);
            label1.TabIndex = 1;
            label1.Text = "Dashboard Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Selesai });
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(495, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(796, 607);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Selesai
            // 
            Selesai.HeaderText = "Selesai";
            Selesai.MinimumWidth = 10;
            Selesai.Name = "Selesai";
            Selesai.Width = 200;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(495, 189);
            label2.Name = "label2";
            label2.Size = new Size(247, 45);
            label2.TabIndex = 4;
            label2.Text = "Antrian Hari Ini";
            // 
            // txtcari
            // 
            txtcari.Location = new Point(772, 203);
            txtcari.Name = "txtcari";
            txtcari.Size = new Size(316, 39);
            txtcari.TabIndex = 6;
            // 
            // btncari
            // 
            btncari.BackColor = Color.Teal;
            btncari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncari.ForeColor = SystemColors.ButtonHighlight;
            btncari.Location = new Point(1123, 203);
            btncari.Name = "btncari";
            btncari.Size = new Size(113, 39);
            btncari.TabIndex = 7;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = false;
            btncari.Click += btncari_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(671, 65);
            label3.Name = "label3";
            label3.Size = new Size(496, 86);
            label3.TabIndex = 8;
            label3.Text = "Klinik Harapan";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, gantiPasswordToolStripMenuItem, keluarToolStripMenuItem });
            accountToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(94, 36);
            accountToolStripMenuItem.Text = "Akun";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(323, 44);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // gantiPasswordToolStripMenuItem
            // 
            gantiPasswordToolStripMenuItem.Name = "gantiPasswordToolStripMenuItem";
            gantiPasswordToolStripMenuItem.Size = new Size(323, 44);
            gantiPasswordToolStripMenuItem.Text = "Ganti Password";
            gantiPasswordToolStripMenuItem.Click += gantiPasswordToolStripMenuItem_Click;
            // 
            // keluarToolStripMenuItem
            // 
            keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            keluarToolStripMenuItem.Size = new Size(323, 44);
            keluarToolStripMenuItem.Text = "Keluar";
            keluarToolStripMenuItem.Click += keluarToolStripMenuItem_Click;
            // 
            // manajemenPenggunaToolStripMenuItem
            // 
            manajemenPenggunaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manajemenKaryawanToolStripMenuItem, manajemenDokterToolStripMenuItem, manajemenPasienToolStripMenuItem, manajemenApotekerToolStripMenuItem });
            manajemenPenggunaToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manajemenPenggunaToolStripMenuItem.Name = "manajemenPenggunaToolStripMenuItem";
            manajemenPenggunaToolStripMenuItem.Size = new Size(290, 36);
            manajemenPenggunaToolStripMenuItem.Text = "Manajemen Pengguna";
            manajemenPenggunaToolStripMenuItem.Click += manajemenPenggunaToolStripMenuItem_Click;
            // 
            // manajemenKaryawanToolStripMenuItem
            // 
            manajemenKaryawanToolStripMenuItem.Name = "manajemenKaryawanToolStripMenuItem";
            manajemenKaryawanToolStripMenuItem.Size = new Size(401, 44);
            manajemenKaryawanToolStripMenuItem.Text = "Manajemen Karyawan";
            manajemenKaryawanToolStripMenuItem.Click += manajemenKaryawanToolStripMenuItem_Click;
            // 
            // manajemenDokterToolStripMenuItem
            // 
            manajemenDokterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { jadwalDokterToolStripMenuItem });
            manajemenDokterToolStripMenuItem.Name = "manajemenDokterToolStripMenuItem";
            manajemenDokterToolStripMenuItem.Size = new Size(401, 44);
            manajemenDokterToolStripMenuItem.Text = "Manajemen Dokter";
            manajemenDokterToolStripMenuItem.Click += manajemenDokterToolStripMenuItem_Click;
            // 
            // jadwalDokterToolStripMenuItem
            // 
            jadwalDokterToolStripMenuItem.Name = "jadwalDokterToolStripMenuItem";
            jadwalDokterToolStripMenuItem.Size = new Size(310, 44);
            jadwalDokterToolStripMenuItem.Text = "Jadwal Dokter";
            jadwalDokterToolStripMenuItem.Click += jadwalDokterToolStripMenuItem_Click;
            // 
            // manajemenPasienToolStripMenuItem
            // 
            manajemenPasienToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rekamMedisToolStripMenuItem });
            manajemenPasienToolStripMenuItem.Name = "manajemenPasienToolStripMenuItem";
            manajemenPasienToolStripMenuItem.Size = new Size(401, 44);
            manajemenPasienToolStripMenuItem.Text = "Manajemen Pasien";
            manajemenPasienToolStripMenuItem.Click += manajemenPasienToolStripMenuItem_Click;
            // 
            // rekamMedisToolStripMenuItem
            // 
            rekamMedisToolStripMenuItem.Name = "rekamMedisToolStripMenuItem";
            rekamMedisToolStripMenuItem.Size = new Size(299, 44);
            rekamMedisToolStripMenuItem.Text = "Rekam Medis";
            rekamMedisToolStripMenuItem.Click += rekamMedisToolStripMenuItem_Click;
            // 
            // manajemenApotekerToolStripMenuItem
            // 
            manajemenApotekerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { obatToolStripMenuItem, manajenenResepToolStripMenuItem, transaksiObatToolStripMenuItem });
            manajemenApotekerToolStripMenuItem.Name = "manajemenApotekerToolStripMenuItem";
            manajemenApotekerToolStripMenuItem.Size = new Size(401, 44);
            manajemenApotekerToolStripMenuItem.Text = "Manajemen Apoteker";
            manajemenApotekerToolStripMenuItem.Click += manajemenApotekerToolStripMenuItem_Click;
            // 
            // obatToolStripMenuItem
            // 
            obatToolStripMenuItem.Name = "obatToolStripMenuItem";
            obatToolStripMenuItem.Size = new Size(348, 44);
            obatToolStripMenuItem.Text = "Manajemen Obat";
            obatToolStripMenuItem.Click += obatToolStripMenuItem_Click;
            // 
            // manajenenResepToolStripMenuItem
            // 
            manajenenResepToolStripMenuItem.Name = "manajenenResepToolStripMenuItem";
            manajenenResepToolStripMenuItem.Size = new Size(348, 44);
            manajenenResepToolStripMenuItem.Text = "Manajenen Resep";
            manajenenResepToolStripMenuItem.Click += manajenenResepToolStripMenuItem_Click;
            // 
            // transaksiObatToolStripMenuItem
            // 
            transaksiObatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { detailTransaksiToolStripMenuItem });
            transaksiObatToolStripMenuItem.Name = "transaksiObatToolStripMenuItem";
            transaksiObatToolStripMenuItem.Size = new Size(348, 44);
            transaksiObatToolStripMenuItem.Text = "Transaksi Obat";
            transaksiObatToolStripMenuItem.Click += transaksiObatToolStripMenuItem_Click;
            // 
            // detailTransaksiToolStripMenuItem
            // 
            detailTransaksiToolStripMenuItem.Name = "detailTransaksiToolStripMenuItem";
            detailTransaksiToolStripMenuItem.Size = new Size(326, 44);
            detailTransaksiToolStripMenuItem.Text = "Detail Transaksi";
            detailTransaksiToolStripMenuItem.Click += detailTransaksiToolStripMenuItem_Click;
            // 
            // manajemenKamarToolStripMenuItem
            // 
            manajemenKamarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manajemenKamarToolStripMenuItem1, manajemenTipeKamarToolStripMenuItem });
            manajemenKamarToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manajemenKamarToolStripMenuItem.Name = "manajemenKamarToolStripMenuItem";
            manajemenKamarToolStripMenuItem.Size = new Size(249, 36);
            manajemenKamarToolStripMenuItem.Text = "Manajemen Kamar";
            manajemenKamarToolStripMenuItem.Click += manajemenKamarToolStripMenuItem_Click;
            // 
            // manajemenKamarToolStripMenuItem1
            // 
            manajemenKamarToolStripMenuItem1.Name = "manajemenKamarToolStripMenuItem1";
            manajemenKamarToolStripMenuItem1.Size = new Size(418, 44);
            manajemenKamarToolStripMenuItem1.Text = "Manajemen Kamar";
            manajemenKamarToolStripMenuItem1.Click += manajemenKamarToolStripMenuItem1_Click;
            // 
            // manajemenTipeKamarToolStripMenuItem
            // 
            manajemenTipeKamarToolStripMenuItem.Name = "manajemenTipeKamarToolStripMenuItem";
            manajemenTipeKamarToolStripMenuItem.Size = new Size(418, 44);
            manajemenTipeKamarToolStripMenuItem.Text = "Manajemen Tipe Kamar";
            manajemenTipeKamarToolStripMenuItem.Click += manajemenTipeKamarToolStripMenuItem_Click;
            // 
            // manajemenToolStripMenuItem
            // 
            manajemenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manajemenPembayaranRawatInapToolStripMenuItem, manajemenPembayaranRawatInapToolStripMenuItem1 });
            manajemenToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manajemenToolStripMenuItem.Name = "manajemenToolStripMenuItem";
            manajemenToolStripMenuItem.Size = new Size(303, 36);
            manajemenToolStripMenuItem.Text = "Manajemen Rawat Inap";
            // 
            // manajemenPembayaranRawatInapToolStripMenuItem
            // 
            manajemenPembayaranRawatInapToolStripMenuItem.Name = "manajemenPembayaranRawatInapToolStripMenuItem";
            manajemenPembayaranRawatInapToolStripMenuItem.Size = new Size(564, 44);
            manajemenPembayaranRawatInapToolStripMenuItem.Text = "Manajemen Rawat Inap";
            manajemenPembayaranRawatInapToolStripMenuItem.Click += manajemenPembayaranRawatInapToolStripMenuItem_Click;
            // 
            // manajemenPembayaranRawatInapToolStripMenuItem1
            // 
            manajemenPembayaranRawatInapToolStripMenuItem1.Name = "manajemenPembayaranRawatInapToolStripMenuItem1";
            manajemenPembayaranRawatInapToolStripMenuItem1.Size = new Size(564, 44);
            manajemenPembayaranRawatInapToolStripMenuItem1.Text = "Manajemen Pembayaran Rawat Inap";
            manajemenPembayaranRawatInapToolStripMenuItem1.Click += manajemenPembayaranRawatInapToolStripMenuItem1_Click;
            // 
            // manajemenAntrianToolStripMenuItem
            // 
            manajemenAntrianToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manajemenAntrianToolStripMenuItem.Name = "manajemenAntrianToolStripMenuItem";
            manajemenAntrianToolStripMenuItem.Size = new Size(261, 36);
            manajemenAntrianToolStripMenuItem.Text = "Manajemen Antrian";
            manajemenAntrianToolStripMenuItem.Click += manajemenAntrianToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { accountToolStripMenuItem, manajemenPenggunaToolStripMenuItem, manajemenKamarToolStripMenuItem, manajemenToolStripMenuItem, manajemenAntrianToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1329, 40);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1329, 880);
            Controls.Add(label3);
            Controls.Add(btncari);
            Controls.Add(txtcari);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Admin Klinik Harapan";
            Load += DashboardAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label email;
        private Label nama;
        private TextBox txtcari;
        private Button btncari;
        private Label label3;
        private DataGridViewButtonColumn Selesai;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem gantiPasswordToolStripMenuItem;
        private ToolStripMenuItem keluarToolStripMenuItem;
        private ToolStripMenuItem manajemenPenggunaToolStripMenuItem;
        private ToolStripMenuItem manajemenKaryawanToolStripMenuItem;
        private ToolStripMenuItem manajemenDokterToolStripMenuItem;
        private ToolStripMenuItem jadwalDokterToolStripMenuItem;
        private ToolStripMenuItem manajemenPasienToolStripMenuItem;
        private ToolStripMenuItem rekamMedisToolStripMenuItem;
        private ToolStripMenuItem manajemenApotekerToolStripMenuItem;
        private ToolStripMenuItem obatToolStripMenuItem;
        private ToolStripMenuItem manajenenResepToolStripMenuItem;
        private ToolStripMenuItem transaksiObatToolStripMenuItem;
        private ToolStripMenuItem detailTransaksiToolStripMenuItem;
        private ToolStripMenuItem manajemenKamarToolStripMenuItem;
        private ToolStripMenuItem manajemenKamarToolStripMenuItem1;
        private ToolStripMenuItem manajemenTipeKamarToolStripMenuItem;
        private ToolStripMenuItem manajemenToolStripMenuItem;
        private ToolStripMenuItem manajemenPembayaranRawatInapToolStripMenuItem;
        private ToolStripMenuItem manajemenPembayaranRawatInapToolStripMenuItem1;
        private ToolStripMenuItem manajemenAntrianToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}