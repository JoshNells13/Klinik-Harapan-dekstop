namespace Aplikasi_klinik_Harapan.HalamanPengguna
{
    partial class Pasien_RekamMedis
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
            txtsearch = new TextBox();
            button3 = new Button();
            label4 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            lblNama = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(609, 207);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(315, 39);
            txtsearch.TabIndex = 32;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 192, 192);
            button3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1012, 207);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 28;
            button3.Text = "Cari";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(375, 55);
            label4.Name = "label4";
            label4.Size = new Size(496, 86);
            label4.TabIndex = 31;
            label4.Text = "Klinik Harapan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(111, 200);
            label2.Name = "label2";
            label2.Size = new Size(303, 45);
            label2.TabIndex = 30;
            label2.Text = "Data Rekam Medis";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(111, 259);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1051, 670);
            dataGridView1.TabIndex = 29;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNama.ForeColor = Color.Black;
            lblNama.Location = new Point(420, 201);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(113, 45);
            lblNama.TabIndex = 33;
            lblNama.Text = "Nama";
            // 
            // Pasien_RekamMedis
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 969);
            Controls.Add(lblNama);
            Controls.Add(txtsearch);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Pasien_RekamMedis";
            Text = "Pasien_RekamMedis";
            Load += Pasien_RekamMedis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsearch;
        private Button button3;
        private Label label4;
        private Label label2;
        private DataGridView dataGridView1;
        private Label lblNama;
    }
}