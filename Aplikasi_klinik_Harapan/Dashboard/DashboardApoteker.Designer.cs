namespace Aplikasi_klinik_Harapan
{
    partial class DashboardApoteker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardApoteker));
            label3 = new Label();
            btncari = new Button();
            txtcari = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            nama = new Label();
            email = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            akunToolStripMenuItem = new ToolStripMenuItem();
            gantiPasswordToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            keluarToolStripMenuItem = new ToolStripMenuItem();
            manToolStripMenuItem = new ToolStripMenuItem();
            resepObatToolStripMenuItem = new ToolStripMenuItem();
            transaksiObatToolStripMenuItem = new ToolStripMenuItem();
            manajemenTransaksiObatToolStripMenuItem = new ToolStripMenuItem();
            manajemenDetailTransaksiObatToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(673, 50);
            label3.Name = "label3";
            label3.Size = new Size(496, 86);
            label3.TabIndex = 13;
            label3.Text = "Klinik Harapan";
            // 
            // btncari
            // 
            btncari.BackColor = Color.Teal;
            btncari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncari.ForeColor = SystemColors.ButtonHighlight;
            btncari.Location = new Point(1148, 213);
            btncari.Name = "btncari";
            btncari.Size = new Size(113, 39);
            btncari.TabIndex = 12;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = false;
            btncari.Click += btncari_Click;
            // 
            // txtcari
            // 
            txtcari.Location = new Point(773, 223);
            txtcari.Name = "txtcari";
            txtcari.Size = new Size(316, 39);
            txtcari.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Info;
            dataGridView1.Location = new Point(504, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(796, 607);
            dataGridView1.TabIndex = 10;
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
            panel1.Location = new Point(-6, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 881);
            panel1.TabIndex = 9;
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
            label1.Size = new Size(382, 50);
            label1.TabIndex = 1;
            label1.Text = "Dashboard Apoteker";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(504, 216);
            label2.Name = "label2";
            label2.Size = new Size(177, 45);
            label2.TabIndex = 14;
            label2.Text = "Data Obat";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { akunToolStripMenuItem, manToolStripMenuItem, resepObatToolStripMenuItem, transaksiObatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1312, 40);
            menuStrip1.TabIndex = 15;
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
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // keluarToolStripMenuItem
            // 
            keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            keluarToolStripMenuItem.Size = new Size(323, 44);
            keluarToolStripMenuItem.Text = "Keluar";
            keluarToolStripMenuItem.Click += keluarToolStripMenuItem_Click;
            // 
            // manToolStripMenuItem
            // 
            manToolStripMenuItem.Name = "manToolStripMenuItem";
            manToolStripMenuItem.Size = new Size(230, 36);
            manToolStripMenuItem.Text = "Manajemen Obat";
            manToolStripMenuItem.Click += manToolStripMenuItem_Click;
            // 
            // resepObatToolStripMenuItem
            // 
            resepObatToolStripMenuItem.Name = "resepObatToolStripMenuItem";
            resepObatToolStripMenuItem.Size = new Size(163, 36);
            resepObatToolStripMenuItem.Text = "Resep Obat";
            resepObatToolStripMenuItem.Click += resepObatToolStripMenuItem_Click;
            // 
            // transaksiObatToolStripMenuItem
            // 
            transaksiObatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manajemenTransaksiObatToolStripMenuItem, manajemenDetailTransaksiObatToolStripMenuItem });
            transaksiObatToolStripMenuItem.Name = "transaksiObatToolStripMenuItem";
            transaksiObatToolStripMenuItem.Size = new Size(201, 36);
            transaksiObatToolStripMenuItem.Text = "Transaksi Obat";
            transaksiObatToolStripMenuItem.Click += transaksiObatToolStripMenuItem_Click;
            // 
            // manajemenTransaksiObatToolStripMenuItem
            // 
            manajemenTransaksiObatToolStripMenuItem.Name = "manajemenTransaksiObatToolStripMenuItem";
            manajemenTransaksiObatToolStripMenuItem.Size = new Size(529, 44);
            manajemenTransaksiObatToolStripMenuItem.Text = "Manajemen Transaksi Obat";
            manajemenTransaksiObatToolStripMenuItem.Click += manajemenTransaksiObatToolStripMenuItem_Click;
            // 
            // manajemenDetailTransaksiObatToolStripMenuItem
            // 
            manajemenDetailTransaksiObatToolStripMenuItem.Name = "manajemenDetailTransaksiObatToolStripMenuItem";
            manajemenDetailTransaksiObatToolStripMenuItem.Size = new Size(529, 44);
            manajemenDetailTransaksiObatToolStripMenuItem.Text = "Manajemen Detail Transaksi Obat";
            manajemenDetailTransaksiObatToolStripMenuItem.Click += manajemenDetailTransaksiObatToolStripMenuItem_Click;
            // 
            // DashboardApoteker
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 919);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btncari);
            Controls.Add(txtcari);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "DashboardApoteker";
            Text = "DashboardApoteker";
            Load += DashboardApoteker_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btncari;
        private TextBox txtcari;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label nama;
        private Label email;
        private Button button2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem akunToolStripMenuItem;
        private ToolStripMenuItem manToolStripMenuItem;
        private ToolStripMenuItem resepObatToolStripMenuItem;
        private ToolStripMenuItem transaksiObatToolStripMenuItem;
        private ToolStripMenuItem manajemenTransaksiObatToolStripMenuItem;
        private ToolStripMenuItem manajemenDetailTransaksiObatToolStripMenuItem;
        private ToolStripMenuItem gantiPasswordToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem keluarToolStripMenuItem;
    }
}