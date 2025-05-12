namespace Aplikasi_klinik_Harapan
{
    partial class ManajemenResep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManajemenResep));
            txtCari = new TextBox();
            btnCari = new Button();
            label4 = new Label();
            btnHapus = new Button();
            btnTambah = new Button();
            button1 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            RadioMenunggu = new RadioButton();
            RadioProses = new RadioButton();
            RadioSelesai = new RadioButton();
            tglDibuat = new DateTimePicker();
            label9 = new Label();
            comboApoteker = new ComboBox();
            ComboIDRekamMedis = new ComboBox();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCari
            // 
            txtCari.Location = new Point(866, 215);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(315, 39);
            txtCari.TabIndex = 37;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(0, 192, 192);
            btnCari.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = SystemColors.ButtonHighlight;
            btnCari.Location = new Point(1253, 211);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(150, 46);
            btnCari.TabIndex = 32;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(781, 45);
            label4.Name = "label4";
            label4.Size = new Size(496, 86);
            label4.TabIndex = 36;
            label4.Text = "Klinik Harapan";
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = SystemColors.ButtonHighlight;
            btnHapus.Location = new Point(770, 1048);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(150, 46);
            btnHapus.TabIndex = 30;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Green;
            btnTambah.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = SystemColors.ButtonFace;
            btnTambah.Location = new Point(590, 970);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(150, 46);
            btnTambah.TabIndex = 31;
            btnTambah.Text = "Add";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(770, 970);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 29;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(590, 208);
            label2.Name = "label2";
            label2.Size = new Size(190, 45);
            label2.TabIndex = 35;
            label2.Text = "Data Resep";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(590, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(813, 670);
            dataGridView1.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(RadioMenunggu);
            panel1.Controls.Add(RadioProses);
            panel1.Controls.Add(RadioSelesai);
            panel1.Controls.Add(tglDibuat);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(comboApoteker);
            panel1.Controls.Add(ComboIDRekamMedis);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 1126);
            panel1.TabIndex = 33;
            // 
            // RadioMenunggu
            // 
            RadioMenunggu.AutoSize = true;
            RadioMenunggu.ForeColor = SystemColors.ButtonHighlight;
            RadioMenunggu.Location = new Point(380, 688);
            RadioMenunggu.Name = "RadioMenunggu";
            RadioMenunggu.Size = new Size(164, 36);
            RadioMenunggu.TabIndex = 22;
            RadioMenunggu.TabStop = true;
            RadioMenunggu.Text = "Menunggu";
            RadioMenunggu.UseVisualStyleBackColor = true;
            // 
            // RadioProses
            // 
            RadioProses.AutoSize = true;
            RadioProses.ForeColor = SystemColors.ButtonHighlight;
            RadioProses.Location = new Point(211, 688);
            RadioProses.Name = "RadioProses";
            RadioProses.Size = new Size(136, 36);
            RadioProses.TabIndex = 21;
            RadioProses.TabStop = true;
            RadioProses.Text = "DiProses";
            RadioProses.UseVisualStyleBackColor = true;
            // 
            // RadioSelesai
            // 
            RadioSelesai.AutoSize = true;
            RadioSelesai.ForeColor = SystemColors.ButtonHighlight;
            RadioSelesai.Location = new Point(66, 688);
            RadioSelesai.Name = "RadioSelesai";
            RadioSelesai.Size = new Size(118, 36);
            RadioSelesai.TabIndex = 20;
            RadioSelesai.TabStop = true;
            RadioSelesai.Text = "Selesai";
            RadioSelesai.UseVisualStyleBackColor = true;
            // 
            // tglDibuat
            // 
            tglDibuat.Location = new Point(66, 819);
            tglDibuat.Name = "tglDibuat";
            tglDibuat.Size = new Size(418, 39);
            tglDibuat.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(64, 753);
            label9.Name = "label9";
            label9.Size = new Size(220, 37);
            label9.TabIndex = 18;
            label9.Text = "Tanggal Di buat";
            // 
            // comboApoteker
            // 
            comboApoteker.FormattingEnabled = true;
            comboApoteker.Location = new Point(64, 576);
            comboApoteker.Name = "comboApoteker";
            comboApoteker.Size = new Size(242, 40);
            comboApoteker.TabIndex = 17;
            // 
            // ComboIDRekamMedis
            // 
            ComboIDRekamMedis.FormattingEnabled = true;
            ComboIDRekamMedis.Location = new Point(64, 459);
            ComboIDRekamMedis.Name = "ComboIDRekamMedis";
            ComboIDRekamMedis.Size = new Size(242, 40);
            ComboIDRekamMedis.TabIndex = 10;
            // 
            // txtID
            // 
            txtID.Location = new Point(64, 353);
            txtID.Name = "txtID";
            txtID.Size = new Size(274, 39);
            txtID.TabIndex = 9;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(64, 629);
            label7.Name = "label7";
            label7.Size = new Size(96, 37);
            label7.TabIndex = 7;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(64, 520);
            label6.Name = "label6";
            label6.Size = new Size(137, 37);
            label6.TabIndex = 6;
            label6.Text = "Apoteker";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(64, 410);
            label5.Name = "label5";
            label5.Size = new Size(225, 37);
            label5.TabIndex = 5;
            label5.Text = "ID Rekam Medis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(64, 299);
            label3.Name = "label3";
            label3.Size = new Size(129, 37);
            label3.TabIndex = 4;
            label3.Text = "ID Resep";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(85, 227);
            label1.Name = "label1";
            label1.Size = new Size(338, 50);
            label1.TabIndex = 1;
            label1.Text = "Manajemen Resep";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 192, 192);
            btnEdit.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(590, 1048);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 46);
            btnEdit.TabIndex = 28;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // ManajemenResep
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 1106);
            Controls.Add(txtCari);
            Controls.Add(btnCari);
            Controls.Add(label4);
            Controls.Add(btnHapus);
            Controls.Add(btnTambah);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(btnEdit);
            Name = "ManajemenResep";
            Text = "ManajemenResep";
            Load += ManajemenResep_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCari;
        private Button btnCari;
        private Label label4;
        private Button btnHapus;
        private Button btnTambah;
        private Button button1;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private DateTimePicker tglDibuat;
        private Label label9;
        private ComboBox comboApoteker;
        private ComboBox ComboIDRekamMedis;
        private TextBox txtID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnEdit;
        private RadioButton RadioMenunggu;
        private RadioButton RadioProses;
        private RadioButton RadioSelesai;
    }
}