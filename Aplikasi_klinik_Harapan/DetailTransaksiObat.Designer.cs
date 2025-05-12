namespace Aplikasi_klinik_Harapan
{
    partial class DetailTransaksiObat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailTransaksiObat));
            txtCari = new TextBox();
            btnCari = new Button();
            label4 = new Label();
            btnTambah = new Button();
            button1 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Hapus = new DataGridViewButtonColumn();
            panel1 = new Panel();
            comboObat = new ComboBox();
            txtJumlah = new TextBox();
            comboTransaksi = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCari
            // 
            txtCari.Location = new Point(932, 222);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(315, 39);
            txtCari.TabIndex = 47;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(0, 192, 192);
            btnCari.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = SystemColors.ButtonHighlight;
            btnCari.Location = new Point(1253, 222);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(150, 46);
            btnCari.TabIndex = 42;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(781, 45);
            label4.Name = "label4";
            label4.Size = new Size(496, 86);
            label4.TabIndex = 46;
            label4.Text = "Klinik Harapan";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.Green;
            btnTambah.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = SystemColors.ButtonFace;
            btnTambah.Location = new Point(590, 970);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(150, 46);
            btnTambah.TabIndex = 41;
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
            button1.TabIndex = 39;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(590, 222);
            label2.Name = "label2";
            label2.Size = new Size(323, 32);
            label2.TabIndex = 45;
            label2.Text = "Data Detail Transaksi Obat";
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
            dataGridView1.TabIndex = 44;
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
            panel1.Controls.Add(comboObat);
            panel1.Controls.Add(txtJumlah);
            panel1.Controls.Add(comboTransaksi);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 1126);
            panel1.TabIndex = 43;
            // 
            // comboObat
            // 
            comboObat.FormattingEnabled = true;
            comboObat.Location = new Point(66, 547);
            comboObat.Name = "comboObat";
            comboObat.Size = new Size(242, 40);
            comboObat.TabIndex = 17;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(66, 686);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(200, 39);
            txtJumlah.TabIndex = 12;
            // 
            // comboTransaksi
            // 
            comboTransaksi.FormattingEnabled = true;
            comboTransaksi.Location = new Point(64, 420);
            comboTransaksi.Name = "comboTransaksi";
            comboTransaksi.Size = new Size(242, 40);
            comboTransaksi.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(64, 629);
            label7.Name = "label7";
            label7.Size = new Size(109, 37);
            label7.TabIndex = 7;
            label7.Text = "Jumlah";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(64, 491);
            label6.Name = "label6";
            label6.Size = new Size(80, 37);
            label6.TabIndex = 6;
            label6.Text = "Obat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(64, 356);
            label5.Name = "label5";
            label5.Size = new Size(171, 37);
            label5.TabIndex = 5;
            label5.Text = "ID Transaksi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(31, 227);
            label1.Name = "label1";
            label1.Size = new Size(509, 50);
            label1.TabIndex = 1;
            label1.Text = "Manajemen Detail Transaksi";
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
            // DetailTransaksiObat
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 1106);
            Controls.Add(txtCari);
            Controls.Add(btnCari);
            Controls.Add(label4);
            Controls.Add(btnTambah);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "DetailTransaksiObat";
            Text = "DetailTransaksiObat";
            Load += DetailTransaksiObat_Load;
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
        private Button btnTambah;
        private Button button1;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private ComboBox comboObat;
        private TextBox txtJumlah;
        private ComboBox comboTransaksi;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridViewButtonColumn Hapus;
    }
}