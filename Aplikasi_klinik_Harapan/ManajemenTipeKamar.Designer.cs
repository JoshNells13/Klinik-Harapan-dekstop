namespace Aplikasi_klinik_Harapan
{
    partial class ManajemenTipeKamar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManajemenTipeKamar));
            panel1 = new Panel();
            btndelete = new Button();
            txtFasilitas = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtTipe = new TextBox();
            txtID = new TextBox();
            btnEdit = new Button();
            btnAdd = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            btncari = new Button();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(btndelete);
            panel1.Controls.Add(txtFasilitas);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTipe);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 1132);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Red;
            btndelete.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = Color.Transparent;
            btndelete.Location = new Point(378, 932);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(154, 56);
            btndelete.TabIndex = 25;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // txtFasilitas
            // 
            txtFasilitas.Location = new Point(89, 621);
            txtFasilitas.Name = "txtFasilitas";
            txtFasilitas.Size = new Size(281, 39);
            txtFasilitas.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(89, 560);
            label6.Name = "label6";
            label6.Size = new Size(119, 37);
            label6.TabIndex = 23;
            label6.Text = "Fasilitas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(89, 450);
            label5.Name = "label5";
            label5.Size = new Size(247, 37);
            label5.TabIndex = 22;
            label5.Text = "Nama Tipe Kamar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(89, 346);
            label4.Name = "label4";
            label4.Size = new Size(200, 37);
            label4.TabIndex = 21;
            label4.Text = "ID Tipe Kamar";
            // 
            // txtTipe
            // 
            txtTipe.Location = new Point(89, 503);
            txtTipe.Name = "txtTipe";
            txtTipe.Size = new Size(281, 39);
            txtTipe.TabIndex = 15;
            // 
            // txtID
            // 
            txtID.Location = new Point(89, 395);
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
            label1.Location = new Point(89, 265);
            label1.Name = "label1";
            label1.Size = new Size(435, 50);
            label1.TabIndex = 2;
            label1.Text = "Manajemen Tipe Kamar";
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
            dataGridView1.Location = new Point(580, 396);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(810, 679);
            dataGridView1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(748, 108);
            label3.Name = "label3";
            label3.Size = new Size(496, 86);
            label3.TabIndex = 15;
            label3.Text = "Klinik Harapan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(580, 311);
            label2.Name = "label2";
            label2.Size = new Size(265, 45);
            label2.TabIndex = 14;
            label2.Text = "Data Tipe Kamar";
            // 
            // btncari
            // 
            btncari.BackColor = Color.Teal;
            btncari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncari.ForeColor = SystemColors.ButtonHighlight;
            btncari.Location = new Point(1277, 317);
            btncari.Name = "btncari";
            btncari.Size = new Size(113, 39);
            btncari.TabIndex = 13;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = false;
            btncari.Click += btncari_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(867, 317);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(377, 39);
            txtSearch.TabIndex = 12;
            // 
            // ManajemenTipeKamar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 1129);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btncari);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ManajemenTipeKamar";
            Text = "Manajemen Tipe Kamar";
            Load += ManajemenTipeKamar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtKapasitas;
        private TextBox txtTarif;
        private TextBox txtTipe;
        private TextBox txtID;
        private Button btnEdit;
        private Button btnAdd;
        private Button button2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private Button btncari;
        private TextBox txtSearch;
        private TextBox txtFasilitas;
        private Button btndelete;
    }
}