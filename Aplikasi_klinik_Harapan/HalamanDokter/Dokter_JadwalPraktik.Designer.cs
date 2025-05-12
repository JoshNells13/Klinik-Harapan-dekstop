namespace Aplikasi_klinik_Harapan.HalamanDokter
{
    partial class Dokter_JadwalPraktik
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
            btnCari = new Button();
            txtCari = new TextBox();
            label4 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Selesai = new DataGridViewButtonColumn();
            lblNama = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.DarkCyan;
            btnCari.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = SystemColors.ButtonFace;
            btnCari.Location = new Point(1087, 164);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(150, 46);
            btnCari.TabIndex = 23;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(693, 164);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(365, 39);
            txtCari.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(425, 6);
            label4.Name = "label4";
            label4.Size = new Size(496, 86);
            label4.TabIndex = 25;
            label4.Text = "Klinik Harapan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(74, 159);
            label2.Name = "label2";
            label2.Size = new Size(241, 50);
            label2.TabIndex = 24;
            label2.Text = "Data Jadwal";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Selesai });
            dataGridView1.Location = new Point(74, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1163, 670);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Selesai
            // 
            Selesai.HeaderText = "Selesai";
            Selesai.MinimumWidth = 10;
            Selesai.Name = "Selesai";
            Selesai.Width = 200;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(479, 162);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(109, 45);
            lblNama.TabIndex = 51;
            lblNama.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 163);
            label1.Name = "label1";
            label1.Size = new Size(117, 45);
            label1.TabIndex = 50;
            label1.Text = "Dokter";
            // 
            // Dokter_JadwalPraktik
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 916);
            Controls.Add(lblNama);
            Controls.Add(label1);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Dokter_JadwalPraktik";
            Text = "Dokter_JadwalPraktik";
            Load += Dokter_JadwalPraktik_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCari;
        private TextBox txtCari;
        private Label label4;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn Selesai;
        private Label lblNama;
        private Label label1;
    }
}