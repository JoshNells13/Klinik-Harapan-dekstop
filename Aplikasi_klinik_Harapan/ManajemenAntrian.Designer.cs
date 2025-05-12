namespace Aplikasi_klinik_Harapan
{
    partial class ManajemenAntrian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManajemenAntrian));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btncari = new Button();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            batal = new RadioButton();
            selesai = new RadioButton();
            tglpanggil = new DateTimePicker();
            label3 = new Label();
            tgldaftar = new DateTimePicker();
            dipanggil = new RadioButton();
            Menunggu = new RadioButton();
            combopasien = new ComboBox();
            btnDelete = new Button();
            combodokter = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            btnEdit = new Button();
            btnAdd = new Button();
            button2 = new Button();
            label1 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(720, 188);
            label2.Name = "label2";
            label2.Size = new Size(208, 45);
            label2.TabIndex = 15;
            label2.Text = "Data Antrian";
            // 
            // btncari
            // 
            btncari.BackColor = Color.Teal;
            btncari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncari.ForeColor = SystemColors.ButtonHighlight;
            btncari.Location = new Point(1442, 196);
            btncari.Name = "btncari";
            btncari.Size = new Size(113, 39);
            btncari.TabIndex = 14;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = false;
            btncari.Click += btncari_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1033, 195);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(377, 39);
            txtSearch.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(720, 264);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(835, 808);
            dataGridView1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(batal);
            panel1.Controls.Add(selesai);
            panel1.Controls.Add(tglpanggil);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tgldaftar);
            panel1.Controls.Add(dipanggil);
            panel1.Controls.Add(Menunggu);
            panel1.Controls.Add(combopasien);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(combodokter);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 1122);
            panel1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumTurquoise;
            button1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(464, 826);
            button1.Name = "button1";
            button1.Size = new Size(154, 56);
            button1.TabIndex = 37;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // batal
            // 
            batal.AutoSize = true;
            batal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            batal.ForeColor = SystemColors.ButtonHighlight;
            batal.Location = new Point(516, 725);
            batal.Name = "batal";
            batal.Size = new Size(102, 36);
            batal.TabIndex = 36;
            batal.TabStop = true;
            batal.Text = "Batal";
            batal.UseVisualStyleBackColor = true;
            // 
            // selesai
            // 
            selesai.AutoSize = true;
            selesai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selesai.ForeColor = SystemColors.ButtonHighlight;
            selesai.Location = new Point(391, 725);
            selesai.Name = "selesai";
            selesai.Size = new Size(122, 36);
            selesai.TabIndex = 35;
            selesai.TabStop = true;
            selesai.Text = "Selesai";
            selesai.UseVisualStyleBackColor = true;
            // 
            // tglpanggil
            // 
            tglpanggil.Location = new Point(32, 941);
            tglpanggil.Name = "tglpanggil";
            tglpanggil.Size = new Size(400, 39);
            tglpanggil.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(32, 889);
            label3.Name = "label3";
            label3.Size = new Size(204, 37);
            label3.TabIndex = 33;
            label3.Text = "Waktu Panggil";
            // 
            // tgldaftar
            // 
            tgldaftar.Location = new Point(32, 835);
            tgldaftar.Name = "tgldaftar";
            tgldaftar.Size = new Size(400, 39);
            tgldaftar.TabIndex = 32;
            // 
            // dipanggil
            // 
            dipanggil.AutoSize = true;
            dipanggil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dipanggil.ForeColor = SystemColors.ButtonHighlight;
            dipanggil.Location = new Point(222, 725);
            dipanggil.Name = "dipanggil";
            dipanggil.Size = new Size(163, 36);
            dipanggil.TabIndex = 31;
            dipanggil.TabStop = true;
            dipanggil.Text = "Di Panggil";
            dipanggil.UseVisualStyleBackColor = true;
            // 
            // Menunggu
            // 
            Menunggu.AutoSize = true;
            Menunggu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Menunggu.ForeColor = SystemColors.ButtonHighlight;
            Menunggu.Location = new Point(32, 725);
            Menunggu.Name = "Menunggu";
            Menunggu.Size = new Size(171, 36);
            Menunggu.TabIndex = 30;
            Menunggu.TabStop = true;
            Menunggu.Text = "Menunggu";
            Menunggu.UseVisualStyleBackColor = true;
            // 
            // combopasien
            // 
            combopasien.FormattingEnabled = true;
            combopasien.Location = new Point(32, 489);
            combopasien.Name = "combopasien";
            combopasien.Size = new Size(242, 40);
            combopasien.TabIndex = 29;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(463, 911);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 56);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // combodokter
            // 
            combodokter.FormattingEnabled = true;
            combodokter.Location = new Point(32, 600);
            combodokter.Name = "combodokter";
            combodokter.Size = new Size(242, 40);
            combodokter.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(32, 781);
            label8.Name = "label8";
            label8.Size = new Size(265, 37);
            label8.TabIndex = 25;
            label8.Text = "Waktu Pendaftaran";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(32, 663);
            label7.Name = "label7";
            label7.Size = new Size(96, 37);
            label7.TabIndex = 24;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(32, 545);
            label6.Name = "label6";
            label6.Size = new Size(106, 37);
            label6.TabIndex = 23;
            label6.Text = "Dokter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(32, 438);
            label5.Name = "label5";
            label5.Size = new Size(99, 37);
            label5.TabIndex = 22;
            label5.Text = "Pasien";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(35, 330);
            label4.Name = "label4";
            label4.Size = new Size(149, 37);
            label4.TabIndex = 21;
            label4.Text = "ID Antrian";
            // 
            // txtID
            // 
            txtID.Location = new Point(32, 386);
            txtID.Name = "txtID";
            txtID.Size = new Size(281, 39);
            txtID.TabIndex = 14;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSeaGreen;
            btnEdit.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Transparent;
            btnEdit.Location = new Point(237, 1009);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(154, 56);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.YellowGreen;
            btnAdd.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Transparent;
            btnAdd.Location = new Point(35, 1009);
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
            button2.Location = new Point(463, 1009);
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
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(89, 266);
            label1.Name = "label1";
            label1.Size = new Size(366, 50);
            label1.TabIndex = 2;
            label1.Text = "Manajemen Antrian";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(880, 48);
            label9.Name = "label9";
            label9.Size = new Size(496, 86);
            label9.TabIndex = 35;
            label9.Text = "Klinik Harapan";
            // 
            // ManajemenAntrian
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1585, 1097);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(btncari);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ManajemenAntrian";
            Text = "ManajemenAntrian";
            Load += ManajemenAntrian_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Button btncari;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Panel panel1;
        private ComboBox combopasien;
        private Button btnDelete;
        private ComboBox combodokter;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtID;
        private Button btnEdit;
        private Button btnAdd;
        private Button button2;
        private Label label1;
        private DateTimePicker tglpanggil;
        private Label label3;
        private DateTimePicker tgldaftar;
        private RadioButton dipanggil;
        private RadioButton Menunggu;
        private Label label9;
        private RadioButton batal;
        private RadioButton selesai;
        private Button button1;
    }
}