namespace Aplikasi_klinik_Harapan
{
    partial class RekamMedis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RekamMedis));
            txtsearch = new TextBox();
            button3 = new Button();
            label4 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Hapus = new DataGridViewButtonColumn();
            panel1 = new Panel();
            combopasien = new ComboBox();
            combodokter = new ComboBox();
            txtdiag = new TextBox();
            txtTindakan = new TextBox();
            tglrekam = new DateTimePicker();
            txtCatatan = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnTambah = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(915, 217);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(315, 39);
            txtsearch.TabIndex = 27;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 192);
            button3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1253, 222);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 22;
            button3.Text = "Cari";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(781, 45);
            label4.Name = "label4";
            label4.Size = new Size(496, 86);
            label4.TabIndex = 26;
            label4.Text = "Klinik Harapan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(590, 208);
            label2.Name = "label2";
            label2.Size = new Size(303, 45);
            label2.TabIndex = 25;
            label2.Text = "Data Rekam Medis";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Hapus });
            dataGridView1.Location = new Point(590, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(813, 670);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Hapus
            // 
            Hapus.HeaderText = "Hapus";
            Hapus.MinimumWidth = 10;
            Hapus.Name = "Hapus";
            Hapus.Width = 200;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(combopasien);
            panel1.Controls.Add(combodokter);
            panel1.Controls.Add(txtdiag);
            panel1.Controls.Add(txtTindakan);
            panel1.Controls.Add(tglrekam);
            panel1.Controls.Add(txtCatatan);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 1126);
            panel1.TabIndex = 23;
            // 
            // combopasien
            // 
            combopasien.FormattingEnabled = true;
            combopasien.Location = new Point(64, 413);
            combopasien.Name = "combopasien";
            combopasien.Size = new Size(242, 40);
            combopasien.TabIndex = 26;
            // 
            // combodokter
            // 
            combodokter.FormattingEnabled = true;
            combodokter.Location = new Point(64, 524);
            combodokter.Name = "combodokter";
            combodokter.Size = new Size(242, 40);
            combodokter.TabIndex = 25;
            // 
            // txtdiag
            // 
            txtdiag.Location = new Point(64, 639);
            txtdiag.Name = "txtdiag";
            txtdiag.Size = new Size(279, 39);
            txtdiag.TabIndex = 24;
            // 
            // txtTindakan
            // 
            txtTindakan.Location = new Point(64, 750);
            txtTindakan.Name = "txtTindakan";
            txtTindakan.Size = new Size(279, 39);
            txtTindakan.TabIndex = 23;
            // 
            // tglrekam
            // 
            tglrekam.Location = new Point(64, 856);
            tglrekam.Name = "tglrekam";
            tglrekam.Size = new Size(400, 39);
            tglrekam.TabIndex = 22;
            // 
            // txtCatatan
            // 
            txtCatatan.Location = new Point(64, 974);
            txtCatatan.Name = "txtCatatan";
            txtCatatan.Size = new Size(298, 39);
            txtCatatan.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(66, 918);
            label10.Name = "label10";
            label10.Size = new Size(257, 37);
            label10.TabIndex = 20;
            label10.Text = "Catatan Tambahan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(64, 792);
            label9.Name = "label9";
            label9.Size = new Size(119, 37);
            label9.TabIndex = 18;
            label9.Text = "Tanggal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(64, 695);
            label8.Name = "label8";
            label8.Size = new Size(135, 37);
            label8.TabIndex = 8;
            label8.Text = "Tindakan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(64, 579);
            label7.Name = "label7";
            label7.Size = new Size(137, 37);
            label7.TabIndex = 7;
            label7.Text = "Diagnosa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(64, 470);
            label6.Name = "label6";
            label6.Size = new Size(106, 37);
            label6.TabIndex = 6;
            label6.Text = "Dokter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(64, 360);
            label5.Name = "label5";
            label5.Size = new Size(99, 37);
            label5.TabIndex = 5;
            label5.Text = "Pasien";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(11, 227);
            label1.Name = "label1";
            label1.Size = new Size(469, 50);
            label1.TabIndex = 1;
            label1.Text = "Manajemen Rekam Medis";
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
            // btnTambah
            // 
            btnTambah.BackColor = Color.Green;
            btnTambah.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = SystemColors.ButtonFace;
            btnTambah.Location = new Point(590, 970);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(150, 46);
            btnTambah.TabIndex = 16;
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
            button1.TabIndex = 14;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RekamMedis
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 1106);
            Controls.Add(txtsearch);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(btnTambah);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "RekamMedis";
            Text = "RekamMedis";
            Load += RekamMedis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsearch;
        private Button button3;
        private Label label4;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private ComboBox comboBox2;
        private Button btnTambah;
        private Button button4;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private TextBox txtCatatan;
        private DataGridViewButtonColumn Hapus;
        private ComboBox combopasien;
        private ComboBox combodokter;
        private TextBox txtdiag;
        private TextBox txtTindakan;
        private DateTimePicker tglrekam;
    }
}