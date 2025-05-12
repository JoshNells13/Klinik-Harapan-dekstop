namespace Aplikasi_klinik_Harapan
{
    partial class ManajemenRawatInap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManajemenRawatInap));
            label9 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            radiomeninggal = new RadioButton();
            radiosembuh = new RadioButton();
            radiopindah = new RadioButton();
            radiorawat = new RadioButton();
            txtDiag = new TextBox();
            tglkeluar = new DateTimePicker();
            tglmasuk = new DateTimePicker();
            combonomor = new ComboBox();
            combodokter = new ComboBox();
            combopasien = new ComboBox();
            txtID = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            btndelete = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnEdit = new Button();
            btnAdd = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btncari = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(798, 30);
            label9.Name = "label9";
            label9.Size = new Size(496, 86);
            label9.TabIndex = 40;
            label9.Text = "Klinik Harapan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(600, 182);
            label2.Name = "label2";
            label2.Size = new Size(263, 45);
            label2.TabIndex = 39;
            label2.Text = "Data Rawat Inap";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(917, 188);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(377, 39);
            txtSearch.TabIndex = 38;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(600, 266);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(883, 1063);
            dataGridView1.TabIndex = 37;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(radiomeninggal);
            panel1.Controls.Add(radiosembuh);
            panel1.Controls.Add(radiopindah);
            panel1.Controls.Add(radiorawat);
            panel1.Controls.Add(txtDiag);
            panel1.Controls.Add(tglkeluar);
            panel1.Controls.Add(tglmasuk);
            panel1.Controls.Add(combonomor);
            panel1.Controls.Add(combodokter);
            panel1.Controls.Add(combopasien);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btndelete);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-10, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 1434);
            panel1.TabIndex = 41;
            // 
            // radiomeninggal
            // 
            radiomeninggal.AutoSize = true;
            radiomeninggal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radiomeninggal.ForeColor = SystemColors.ButtonFace;
            radiomeninggal.Location = new Point(89, 1190);
            radiomeninggal.Name = "radiomeninggal";
            radiomeninggal.Size = new Size(168, 36);
            radiomeninggal.TabIndex = 41;
            radiomeninggal.TabStop = true;
            radiomeninggal.Text = "Meninggal";
            radiomeninggal.UseVisualStyleBackColor = true;
            // 
            // radiosembuh
            // 
            radiosembuh.AutoSize = true;
            radiosembuh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radiosembuh.ForeColor = SystemColors.ButtonFace;
            radiosembuh.Location = new Point(89, 1130);
            radiosembuh.Name = "radiosembuh";
            radiosembuh.Size = new Size(137, 36);
            radiosembuh.TabIndex = 40;
            radiosembuh.TabStop = true;
            radiosembuh.Text = "Sembuh";
            radiosembuh.UseVisualStyleBackColor = true;
            // 
            // radiopindah
            // 
            radiopindah.AutoSize = true;
            radiopindah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radiopindah.ForeColor = SystemColors.ButtonFace;
            radiopindah.Location = new Point(316, 1067);
            radiopindah.Name = "radiopindah";
            radiopindah.Size = new Size(124, 36);
            radiopindah.TabIndex = 39;
            radiopindah.TabStop = true;
            radiopindah.Text = "Pindah";
            radiopindah.UseVisualStyleBackColor = true;
            // 
            // radiorawat
            // 
            radiorawat.AutoSize = true;
            radiorawat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radiorawat.ForeColor = SystemColors.ButtonFace;
            radiorawat.Location = new Point(89, 1067);
            radiorawat.Name = "radiorawat";
            radiorawat.Size = new Size(147, 36);
            radiorawat.TabIndex = 38;
            radiorawat.TabStop = true;
            radiorawat.Text = "Di Rawat";
            radiorawat.UseVisualStyleBackColor = true;
            // 
            // txtDiag
            // 
            txtDiag.Location = new Point(89, 970);
            txtDiag.Name = "txtDiag";
            txtDiag.Size = new Size(211, 39);
            txtDiag.TabIndex = 37;
            // 
            // tglkeluar
            // 
            tglkeluar.Location = new Point(89, 888);
            tglkeluar.Name = "tglkeluar";
            tglkeluar.Size = new Size(400, 39);
            tglkeluar.TabIndex = 36;
            // 
            // tglmasuk
            // 
            tglmasuk.Location = new Point(89, 791);
            tglmasuk.Name = "tglmasuk";
            tglmasuk.Size = new Size(400, 39);
            tglmasuk.TabIndex = 35;
            // 
            // combonomor
            // 
            combonomor.FormattingEnabled = true;
            combonomor.Location = new Point(89, 691);
            combonomor.Name = "combonomor";
            combonomor.Size = new Size(242, 40);
            combonomor.TabIndex = 34;
            // 
            // combodokter
            // 
            combodokter.FormattingEnabled = true;
            combodokter.Location = new Point(89, 599);
            combodokter.Name = "combodokter";
            combodokter.Size = new Size(242, 40);
            combodokter.TabIndex = 33;
            // 
            // combopasien
            // 
            combopasien.FormattingEnabled = true;
            combopasien.Location = new Point(89, 501);
            combopasien.Name = "combopasien";
            combopasien.Size = new Size(242, 40);
            combopasien.TabIndex = 32;
            // 
            // txtID
            // 
            txtID.Location = new Point(89, 398);
            txtID.Name = "txtID";
            txtID.Size = new Size(321, 39);
            txtID.TabIndex = 31;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(89, 1014);
            label11.Name = "label11";
            label11.Size = new Size(96, 37);
            label11.TabIndex = 30;
            label11.Text = "Status";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(89, 930);
            label10.Name = "label10";
            label10.Size = new Size(137, 37);
            label10.TabIndex = 29;
            label10.Text = "Diagnosa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(89, 844);
            label8.Name = "label8";
            label8.Size = new Size(209, 37);
            label8.TabIndex = 28;
            label8.Text = "Tanggal Keluar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(89, 734);
            label7.Name = "label7";
            label7.Size = new Size(210, 37);
            label7.TabIndex = 27;
            label7.Text = "Tanggal Masuk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(89, 642);
            label3.Name = "label3";
            label3.Size = new Size(196, 37);
            label3.TabIndex = 26;
            label3.Text = "Nomor kamar";
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = Color.Transparent;
            btndelete.Location = new Point(401, 1170);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(154, 56);
            btndelete.TabIndex = 25;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(89, 555);
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
            label5.Location = new Point(89, 450);
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
            label4.Location = new Point(89, 346);
            label4.Name = "label4";
            label4.Size = new Size(198, 37);
            label4.TabIndex = 21;
            label4.Text = "ID Rawat Inap";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightSeaGreen;
            btnEdit.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Transparent;
            btnEdit.Location = new Point(216, 1272);
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
            btnAdd.Location = new Point(22, 1272);
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
            button2.Location = new Point(401, 1272);
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
            label1.Location = new Point(89, 265);
            label1.Name = "label1";
            label1.Size = new Size(431, 50);
            label1.TabIndex = 2;
            label1.Text = "Manajemen Rawat Inap";
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
            // btncari
            // 
            btncari.BackColor = Color.Teal;
            btncari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncari.ForeColor = SystemColors.ButtonHighlight;
            btncari.Location = new Point(1353, 189);
            btncari.Name = "btncari";
            btncari.Size = new Size(113, 39);
            btncari.TabIndex = 42;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = false;
            btncari.Click += btncari_Click;
            // 
            // ManajemenRawatInap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 1403);
            Controls.Add(btncari);
            Controls.Add(panel1);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Name = "ManajemenRawatInap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManajemenRawatInap";
            Load += ManajemenRawatInap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label2;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btndelete;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnEdit;
        private Button btnAdd;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtID;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label3;
        private Button btncari;
        private TextBox txtDiag;
        private DateTimePicker tglkeluar;
        private DateTimePicker tglmasuk;
        private ComboBox combonomor;
        private ComboBox combodokter;
        private ComboBox combopasien;
        private RadioButton radiomeninggal;
        private RadioButton radiosembuh;
        private RadioButton radiopindah;
        private RadioButton radiorawat;
    }
}