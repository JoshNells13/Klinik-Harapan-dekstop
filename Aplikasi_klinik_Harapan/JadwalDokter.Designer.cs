namespace Aplikasi_klinik_Harapan
{
    partial class JadwalDokter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JadwalDokter));
            label4 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Selesai = new DataGridViewButtonColumn();
            panel1 = new Panel();
            jamSelesai = new DateTimePicker();
            jammulai = new DateTimePicker();
            btnTambah = new Button();
            button1 = new Button();
            hari = new DateTimePicker();
            combodokter = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtCari = new TextBox();
            btnCari = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(704, 152);
            label4.Name = "label4";
            label4.Size = new Size(496, 86);
            label4.TabIndex = 20;
            label4.Text = "Klinik Harapan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(510, 299);
            label2.Name = "label2";
            label2.Size = new Size(241, 50);
            label2.TabIndex = 19;
            label2.Text = "Data Jadwal";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Selesai });
            dataGridView1.Location = new Point(510, 386);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(813, 670);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Selesai
            // 
            Selesai.HeaderText = "Selesai";
            Selesai.MinimumWidth = 10;
            Selesai.Name = "Selesai";
            Selesai.Width = 200;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(jamSelesai);
            panel1.Controls.Add(jammulai);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(hari);
            panel1.Controls.Add(combodokter);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 1126);
            panel1.TabIndex = 17;
            // 
            // jamSelesai
            // 
            jamSelesai.Location = new Point(56, 747);
            jamSelesai.Name = "jamSelesai";
            jamSelesai.Size = new Size(164, 39);
            jamSelesai.TabIndex = 18;
            // 
            // jammulai
            // 
            jammulai.Location = new Point(56, 621);
            jammulai.Name = "jammulai";
            jammulai.Size = new Size(164, 39);
            jammulai.TabIndex = 17;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Green;
            btnTambah.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = SystemColors.ButtonFace;
            btnTambah.Location = new Point(56, 1010);
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
            button1.Location = new Point(281, 1010);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 14;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // hari
            // 
            hari.Location = new Point(56, 506);
            hari.Name = "hari";
            hari.Size = new Size(400, 39);
            hari.TabIndex = 11;
            // 
            // combodokter
            // 
            combodokter.FormattingEnabled = true;
            combodokter.Location = new Point(56, 397);
            combodokter.Name = "combodokter";
            combodokter.Size = new Size(242, 40);
            combodokter.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(56, 681);
            label8.Name = "label8";
            label8.Size = new Size(164, 37);
            label8.TabIndex = 8;
            label8.Text = "Jam Selesai";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(56, 568);
            label7.Name = "label7";
            label7.Size = new Size(149, 37);
            label7.TabIndex = 7;
            label7.Text = "Jam Mulai";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(56, 453);
            label6.Name = "label6";
            label6.Size = new Size(72, 37);
            label6.TabIndex = 6;
            label6.Text = "Hari";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(56, 357);
            label5.Name = "label5";
            label5.Size = new Size(106, 37);
            label5.TabIndex = 5;
            label5.Text = "Dokter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(11, 255);
            label1.Name = "label1";
            label1.Size = new Size(471, 50);
            label1.TabIndex = 1;
            label1.Text = "Dashboard Jadwal Dokter";
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
            // txtCari
            // 
            txtCari.Location = new Point(777, 310);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(365, 39);
            txtCari.TabIndex = 21;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.DarkCyan;
            btnCari.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = SystemColors.ButtonFace;
            btnCari.Location = new Point(1173, 310);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(150, 46);
            btnCari.TabIndex = 19;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // JadwalDokter
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 1106);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "JadwalDokter";
            Text = "JadwalDokter";
            Load += JadwalDokter_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox combodokter;
        private DateTimePicker hari;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button btnTambah;
        private Button button4;
        private Button button1;
        private DateTimePicker jamSelesai;
        private DateTimePicker jammulai;
        private TextBox txtCari;
        private Button btnCari;
        private DataGridViewButtonColumn Selesai;
    }
}