namespace Aplikasi_klinik_Harapan
{
    partial class ManajemenPembayaranRawatIna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManajemenPembayaranRawatIna));
            btncari = new Button();
            label2 = new Label();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            Hapus = new DataGridViewButtonColumn();
            panel1 = new Panel();
            txtID = new TextBox();
            txtKeterangan = new TextBox();
            radiotidaklunas = new RadioButton();
            radiolunas = new RadioButton();
            txtTotal = new TextBox();
            tglbayar = new DateTimePicker();
            comboIDrawat = new ComboBox();
            label12 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            comboMetode = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btncari
            // 
            btncari.BackColor = Color.Teal;
            btncari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncari.ForeColor = SystemColors.ButtonHighlight;
            btncari.Location = new Point(1417, 187);
            btncari.Name = "btncari";
            btncari.Size = new Size(113, 39);
            btncari.TabIndex = 48;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = false;
            btncari.Click += btncari_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(647, 181);
            label2.Name = "label2";
            label2.Size = new Size(281, 45);
            label2.TabIndex = 45;
            label2.Text = "Data Pembayaran";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(984, 188);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(377, 39);
            txtSearch.TabIndex = 44;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Hapus });
            dataGridView1.Location = new Point(647, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(883, 1063);
            dataGridView1.TabIndex = 43;
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
            panel1.Controls.Add(comboMetode);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtKeterangan);
            panel1.Controls.Add(radiotidaklunas);
            panel1.Controls.Add(radiolunas);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(tglbayar);
            panel1.Controls.Add(comboIDrawat);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 1335);
            panel1.TabIndex = 49;
            // 
            // txtID
            // 
            txtID.Location = new Point(35, 387);
            txtID.Name = "txtID";
            txtID.Size = new Size(247, 39);
            txtID.TabIndex = 35;
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(32, 1066);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(285, 39);
            txtKeterangan.TabIndex = 34;
            // 
            // radiotidaklunas
            // 
            radiotidaklunas.AutoSize = true;
            radiotidaklunas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radiotidaklunas.ForeColor = SystemColors.ButtonHighlight;
            radiotidaklunas.Location = new Point(200, 933);
            radiotidaklunas.Name = "radiotidaklunas";
            radiotidaklunas.Size = new Size(180, 36);
            radiotidaklunas.TabIndex = 33;
            radiotidaklunas.TabStop = true;
            radiotidaklunas.Text = "Tidak Lunas";
            radiotidaklunas.UseVisualStyleBackColor = true;
            // 
            // radiolunas
            // 
            radiolunas.AutoSize = true;
            radiolunas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radiolunas.ForeColor = SystemColors.ButtonHighlight;
            radiolunas.Location = new Point(32, 933);
            radiolunas.Name = "radiolunas";
            radiolunas.Size = new Size(111, 36);
            radiolunas.TabIndex = 32;
            radiolunas.TabStop = true;
            radiolunas.Text = "Lunas";
            radiolunas.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(35, 713);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(247, 39);
            txtTotal.TabIndex = 30;
            // 
            // tglbayar
            // 
            tglbayar.Location = new Point(32, 605);
            tglbayar.Name = "tglbayar";
            tglbayar.Size = new Size(400, 39);
            tglbayar.TabIndex = 29;
            // 
            // comboIDrawat
            // 
            comboIDrawat.FormattingEnabled = true;
            comboIDrawat.Location = new Point(32, 502);
            comboIDrawat.Name = "comboIDrawat";
            comboIDrawat.Size = new Size(242, 40);
            comboIDrawat.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(32, 990);
            label12.Name = "label12";
            label12.Size = new Size(166, 37);
            label12.TabIndex = 27;
            label12.Text = "Keterangan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(32, 877);
            label9.Name = "label9";
            label9.Size = new Size(263, 37);
            label9.TabIndex = 26;
            label9.Text = "Status Pembayaran";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(32, 768);
            label8.Name = "label8";
            label8.Size = new Size(285, 37);
            label8.TabIndex = 25;
            label8.Text = "Metode Pembayaran";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(32, 663);
            label7.Name = "label7";
            label7.Size = new Size(159, 37);
            label7.TabIndex = 24;
            label7.Text = "Total Biaya";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(32, 545);
            label6.Name = "label6";
            label6.Size = new Size(286, 37);
            label6.TabIndex = 23;
            label6.Text = "Tanggal Pembayaran";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(32, 449);
            label5.Name = "label5";
            label5.Size = new Size(198, 37);
            label5.TabIndex = 22;
            label5.Text = "ID Rawat Inap";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(35, 330);
            label4.Name = "label4";
            label4.Size = new Size(213, 37);
            label4.TabIndex = 21;
            label4.Text = "ID Pembayaran";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.YellowGreen;
            btnAdd.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Transparent;
            btnAdd.Location = new Point(77, 1192);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 56);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(326, 1192);
            button2.Name = "button2";
            button2.Size = new Size(154, 56);
            button2.TabIndex = 11;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(14, 253);
            label1.Name = "label1";
            label1.Size = new Size(566, 45);
            label1.TabIndex = 2;
            label1.Text = "Manajemen Pembayaran Rawat Inap";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(170, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(879, 47);
            label3.Name = "label3";
            label3.Size = new Size(496, 86);
            label3.TabIndex = 50;
            label3.Text = "Klinik Harapan";
            // 
            // comboMetode
            // 
            comboMetode.FormattingEnabled = true;
            comboMetode.Location = new Point(32, 824);
            comboMetode.Name = "comboMetode";
            comboMetode.Size = new Size(242, 40);
            comboMetode.TabIndex = 36;
            // 
            // ManajemenPembayaranRawatIna
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1566, 1331);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btncari);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Name = "ManajemenPembayaranRawatIna";
            Text = "Pembayaran Rawat Inap";
            Load += ManajemenPembayaranRawatIna_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncari;
        private Panel panel1;
        private RadioButton radiomeninggal;
        private RadioButton radiosembuh;
        private RadioButton radiopindah;
        private RadioButton radiorawat;
        private TextBox txtDiag;
        private DateTimePicker tglkeluar;
        private DateTimePicker tglmasuk;
        private ComboBox combonomor;
        private ComboBox combodokter;
        private ComboBox combopasien;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label3;
        private Button btndelete;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnAdd;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label2;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Label label12;
        private TextBox txtKeterangan;
        private RadioButton radiotidaklunas;
        private RadioButton radiolunas;
        private TextBox txtTotal;
        private DateTimePicker tglbayar;
        private ComboBox comboIDrawat;
        private TextBox txtID;
        private DataGridViewButtonColumn Hapus;
        private ComboBox comboMetode;
    }
}