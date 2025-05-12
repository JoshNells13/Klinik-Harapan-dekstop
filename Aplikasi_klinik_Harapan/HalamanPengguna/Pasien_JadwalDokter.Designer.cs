namespace Aplikasi_klinik_Harapan.HalamanPengguna
{
    partial class Pasien_JadwalDokter
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.DarkCyan;
            btnCari.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCari.ForeColor = SystemColors.ButtonFace;
            btnCari.Location = new Point(1190, 275);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(169, 46);
            btnCari.TabIndex = 23;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(536, 275);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(441, 39);
            txtCari.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(498, 43);
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
            label2.Location = new Point(96, 264);
            label2.Name = "label2";
            label2.Size = new Size(241, 50);
            label2.TabIndex = 24;
            label2.Text = "Data Jadwal";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(96, 401);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1263, 788);
            dataGridView1.TabIndex = 22;
            // 
            // Pasien_JadwalDokter
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 1243);
            Controls.Add(btnCari);
            Controls.Add(txtCari);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Pasien_JadwalDokter";
            Text = "Jadwal Dokter";
            Load += Pasien_JadwalDokter_Load;
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
    }
}