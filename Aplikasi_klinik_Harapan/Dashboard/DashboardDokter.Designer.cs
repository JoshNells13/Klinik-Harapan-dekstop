namespace Aplikasi_klinik_Harapan
{
    partial class DashboardDokter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardDokter));
            pictureBox1 = new PictureBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            nama = new Label();
            label3 = new Label();
            email = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            akunToolStripMenuItem = new ToolStripMenuItem();
            gantiPasswordToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            keluarToolStripMenuItem = new ToolStripMenuItem();
            jadwalPraktekToolStripMenuItem = new ToolStripMenuItem();
            antrianPasienToolStripMenuItem = new ToolStripMenuItem();
            rekamMedisToolStripMenuItem = new ToolStripMenuItem();
            rawatInapToolStripMenuItem = new ToolStripMenuItem();
            btncari = new Button();
            txtcari = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(97, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(700, 91);
            label4.Name = "label4";
            label4.Size = new Size(496, 86);
            label4.TabIndex = 19;
            label4.Text = "Klinik Harapan";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(540, 320);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(863, 603);
            dataGridView1.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(nama);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(email);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 940);
            panel1.TabIndex = 17;
            // 
            // nama
            // 
            nama.AutoSize = true;
            nama.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nama.ForeColor = Color.Transparent;
            nama.Location = new Point(58, 434);
            nama.Name = "nama";
            nama.Size = new Size(118, 50);
            nama.TabIndex = 7;
            nama.Text = "nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(97, 346);
            label3.Name = "label3";
            label3.Size = new Size(298, 50);
            label3.TabIndex = 6;
            label3.Text = "Selamat Datang";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.Transparent;
            email.Location = new Point(58, 503);
            email.Name = "email";
            email.Size = new Size(118, 50);
            email.TabIndex = 4;
            email.Text = "email";
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
            label1.Location = new Point(77, 258);
            label1.Name = "label1";
            label1.Size = new Size(341, 50);
            label1.TabIndex = 1;
            label1.Text = "Dashboard Dokter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(540, 248);
            label2.Name = "label2";
            label2.Size = new Size(252, 45);
            label2.TabIndex = 20;
            label2.Text = "Jadwal Praktek";
            label2.Click += label2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { akunToolStripMenuItem, jadwalPraktekToolStripMenuItem, antrianPasienToolStripMenuItem, rekamMedisToolStripMenuItem, rawatInapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1469, 40);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // akunToolStripMenuItem
            // 
            akunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gantiPasswordToolStripMenuItem, logOutToolStripMenuItem, keluarToolStripMenuItem });
            akunToolStripMenuItem.Name = "akunToolStripMenuItem";
            akunToolStripMenuItem.Size = new Size(94, 36);
            akunToolStripMenuItem.Text = "Akun";
            // 
            // gantiPasswordToolStripMenuItem
            // 
            gantiPasswordToolStripMenuItem.Name = "gantiPasswordToolStripMenuItem";
            gantiPasswordToolStripMenuItem.Size = new Size(323, 44);
            gantiPasswordToolStripMenuItem.Text = "Ganti Password";
            gantiPasswordToolStripMenuItem.Click += gantiPasswordToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(323, 44);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // keluarToolStripMenuItem
            // 
            keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            keluarToolStripMenuItem.Size = new Size(323, 44);
            keluarToolStripMenuItem.Text = "Keluar";
            keluarToolStripMenuItem.Click += keluarToolStripMenuItem_Click;
            // 
            // jadwalPraktekToolStripMenuItem
            // 
            jadwalPraktekToolStripMenuItem.Name = "jadwalPraktekToolStripMenuItem";
            jadwalPraktekToolStripMenuItem.Size = new Size(205, 36);
            jadwalPraktekToolStripMenuItem.Text = "Jadwal Praktek";
            jadwalPraktekToolStripMenuItem.Click += jadwalPraktekToolStripMenuItem_Click;
            // 
            // antrianPasienToolStripMenuItem
            // 
            antrianPasienToolStripMenuItem.Name = "antrianPasienToolStripMenuItem";
            antrianPasienToolStripMenuItem.Size = new Size(200, 36);
            antrianPasienToolStripMenuItem.Text = "Antrian Pasien";
            antrianPasienToolStripMenuItem.Click += antrianPasienToolStripMenuItem_Click;
            // 
            // rekamMedisToolStripMenuItem
            // 
            rekamMedisToolStripMenuItem.Name = "rekamMedisToolStripMenuItem";
            rekamMedisToolStripMenuItem.Size = new Size(186, 36);
            rekamMedisToolStripMenuItem.Text = "Rekam Medis";
            rekamMedisToolStripMenuItem.Click += rekamMedisToolStripMenuItem_Click;
            // 
            // rawatInapToolStripMenuItem
            // 
            rawatInapToolStripMenuItem.Name = "rawatInapToolStripMenuItem";
            rawatInapToolStripMenuItem.Size = new Size(162, 36);
            rawatInapToolStripMenuItem.Text = "Rawat Inap";
            rawatInapToolStripMenuItem.Click += rawatInapToolStripMenuItem_Click;
            // 
            // btncari
            // 
            btncari.BackColor = Color.Teal;
            btncari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncari.ForeColor = SystemColors.ButtonHighlight;
            btncari.Location = new Point(1280, 255);
            btncari.Name = "btncari";
            btncari.Size = new Size(113, 39);
            btncari.TabIndex = 23;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = false;
            btncari.Click += btncari_Click;
            // 
            // txtcari
            // 
            txtcari.Location = new Point(929, 255);
            txtcari.Name = "txtcari";
            txtcari.Size = new Size(316, 39);
            txtcari.TabIndex = 22;
            // 
            // DashboardDokter
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 973);
            Controls.Add(btncari);
            Controls.Add(txtcari);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "DashboardDokter";
            Text = "DashboardDokter";
            Load += DashboardDokter_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label3;
        private Label email;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem akunToolStripMenuItem;
        private ToolStripMenuItem gantiPasswordToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem keluarToolStripMenuItem;
        private ToolStripMenuItem jadwalPraktekToolStripMenuItem;
        private ToolStripMenuItem antrianPasienToolStripMenuItem;
        private ToolStripMenuItem rekamMedisToolStripMenuItem;
        private ToolStripMenuItem rawatInapToolStripMenuItem;
        private Label nama;
        private Button btncari;
        private TextBox txtcari;
    }
}