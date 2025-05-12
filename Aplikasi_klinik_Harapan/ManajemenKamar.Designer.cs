namespace Aplikasi_klinik_Harapan
{
    partial class ManajemenKamar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManajemenKamar));
            panel1 = new Panel();
            btnDelete = new Button();
            comboTipe = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            TidakAktif = new RadioButton();
            Aktif = new RadioButton();
            txtKapasitas = new TextBox();
            txtTarif = new TextBox();
            txtNomor = new TextBox();
            txtID = new TextBox();
            btnEdit = new Button();
            btnAdd = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            txtSearch = new TextBox();
            btncari = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(comboTipe);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TidakAktif);
            panel1.Controls.Add(Aktif);
            panel1.Controls.Add(txtKapasitas);
            panel1.Controls.Add(txtTarif);
            panel1.Controls.Add(txtNomor);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-6, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 1108);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(378, 921);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 56);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // comboTipe
            // 
            comboTipe.FormattingEnabled = true;
            comboTipe.Location = new Point(32, 600);
            comboTipe.Name = "comboTipe";
            comboTipe.Size = new Size(242, 40);
            comboTipe.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(32, 877);
            label9.Name = "label9";
            label9.Size = new Size(96, 37);
            label9.TabIndex = 26;
            label9.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(32, 768);
            label8.Name = "label8";
            label8.Size = new Size(140, 37);
            label8.TabIndex = 25;
            label8.Text = "Kapasitas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(32, 663);
            label7.Name = "label7";
            label7.Size = new Size(168, 37);
            label7.TabIndex = 24;
            label7.Text = "Tarif Harian";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(32, 545);
            label6.Name = "label6";
            label6.Size = new Size(157, 37);
            label6.TabIndex = 23;
            label6.Text = "TipeKamar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(32, 449);
            label5.Name = "label5";
            label5.Size = new Size(199, 37);
            label5.TabIndex = 22;
            label5.Text = "Nomor Kamar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(35, 330);
            label4.Name = "label4";
            label4.Size = new Size(137, 37);
            label4.TabIndex = 21;
            label4.Text = "ID Kamar";
            // 
            // TidakAktif
            // 
            TidakAktif.AutoSize = true;
            TidakAktif.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TidakAktif.ForeColor = Color.Transparent;
            TidakAktif.Location = new Point(170, 929);
            TidakAktif.Name = "TidakAktif";
            TidakAktif.Size = new Size(189, 41);
            TidakAktif.TabIndex = 20;
            TidakAktif.TabStop = true;
            TidakAktif.Text = "Tidak Aktif";
            TidakAktif.UseVisualStyleBackColor = true;
            // 
            // Aktif
            // 
            Aktif.AutoSize = true;
            Aktif.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Aktif.ForeColor = Color.Transparent;
            Aktif.Location = new Point(32, 929);
            Aktif.Name = "Aktif";
            Aktif.Size = new Size(111, 41);
            Aktif.TabIndex = 19;
            Aktif.TabStop = true;
            Aktif.Text = "Aktif";
            Aktif.UseVisualStyleBackColor = true;
            // 
            // txtKapasitas
            // 
            txtKapasitas.Location = new Point(32, 826);
            txtKapasitas.Name = "txtKapasitas";
            txtKapasitas.Size = new Size(265, 39);
            txtKapasitas.TabIndex = 18;
            // 
            // txtTarif
            // 
            txtTarif.Location = new Point(32, 703);
            txtTarif.Name = "txtTarif";
            txtTarif.Size = new Size(265, 39);
            txtTarif.TabIndex = 17;
            // 
            // txtNomor
            // 
            txtNomor.Location = new Point(32, 503);
            txtNomor.Name = "txtNomor";
            txtNomor.Size = new Size(281, 39);
            txtNomor.TabIndex = 15;
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
            btnEdit.Location = new Point(200, 1018);
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
            btnAdd.Location = new Point(18, 1018);
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
            button2.Location = new Point(378, 1018);
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
            label1.Size = new Size(349, 50);
            label1.TabIndex = 2;
            label1.Text = "Manajemen Kamar";
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(606, 264);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(835, 808);
            dataGridView1.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(930, 207);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(377, 39);
            txtSearch.TabIndex = 2;
            // 
            // btncari
            // 
            btncari.BackColor = Color.Teal;
            btncari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncari.ForeColor = SystemColors.ButtonHighlight;
            btncari.Location = new Point(1328, 208);
            btncari.Name = "btncari";
            btncari.Size = new Size(113, 39);
            btncari.TabIndex = 8;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = false;
            btncari.Click += btncari_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(687, 48);
            label3.Name = "label3";
            label3.Size = new Size(496, 86);
            label3.TabIndex = 10;
            label3.Text = "Klinik Harapan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(606, 200);
            label2.Name = "label2";
            label2.Size = new Size(195, 45);
            label2.TabIndex = 9;
            label2.Text = "Data Kamar";
            // 
            // ManajemenKamar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 1101);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btncari);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ManajemenKamar";
            Text = "ManajemenKamar";
            Load += ManajemenKamar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btncari;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button btnEdit;
        private Button btnAdd;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private RadioButton TidakAktif;
        private RadioButton Aktif;
        private TextBox txtKapasitas;
        private TextBox txtTarif;
        private TextBox txtNomor;
        private TextBox txtID;
        private ComboBox comboTipe;
        private Button btnDelete;
    }
}