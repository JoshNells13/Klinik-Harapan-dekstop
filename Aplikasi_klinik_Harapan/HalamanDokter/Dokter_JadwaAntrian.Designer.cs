namespace Aplikasi_klinik_Harapan.HalamanDokter
{
    partial class Dokter_JadwaAntrian
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
            label9 = new Label();
            label2 = new Label();
            btncari = new Button();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            lblNama = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(388, 9);
            label9.Name = "label9";
            label9.Size = new Size(496, 86);
            label9.TabIndex = 40;
            label9.Text = "Klinik Harapan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(113, 141);
            label2.Name = "label2";
            label2.Size = new Size(208, 45);
            label2.TabIndex = 39;
            label2.Text = "Data Antrian";
            // 
            // btncari
            // 
            btncari.BackColor = Color.Teal;
            btncari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncari.ForeColor = SystemColors.ButtonHighlight;
            btncari.Location = new Point(1116, 148);
            btncari.Name = "btncari";
            btncari.Size = new Size(113, 39);
            btncari.TabIndex = 38;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = false;
            btncari.Click += btncari_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(673, 148);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(377, 39);
            txtSearch.TabIndex = 37;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(113, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1116, 709);
            dataGridView1.TabIndex = 36;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(502, 140);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(109, 45);
            lblNama.TabIndex = 53;
            lblNama.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(370, 141);
            label1.Name = "label1";
            label1.Size = new Size(117, 45);
            label1.TabIndex = 52;
            label1.Text = "Dokter";
            // 
            // Dokter_JadwaAntrian
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 954);
            Controls.Add(lblNama);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(btncari);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Name = "Dokter_JadwaAntrian";
            Text = "Jadwal Antrian";
            Load += Dokter_JadwaAntrian_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label2;
        private Button btncari;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Label lblNama;
        private Label label1;
    }
}