namespace Aplikasi_klinik_Harapan.HalamanDokter
{
    partial class Dokter_RawatInap
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
            btncari = new Button();
            label9 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            lblNama = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btncari
            // 
            btncari.BackColor = Color.Teal;
            btncari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncari.ForeColor = SystemColors.ButtonHighlight;
            btncari.Location = new Point(1091, 190);
            btncari.Name = "btncari";
            btncari.Size = new Size(113, 39);
            btncari.TabIndex = 47;
            btncari.Text = "Cari";
            btncari.UseVisualStyleBackColor = false;
            btncari.Click += btncari_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(454, 11);
            label9.Name = "label9";
            label9.Size = new Size(496, 86);
            label9.TabIndex = 46;
            label9.Text = "Klinik Harapan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 182);
            label2.Name = "label2";
            label2.Size = new Size(263, 45);
            label2.TabIndex = 45;
            label2.Text = "Data Rawat Inap";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(687, 189);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(377, 39);
            txtSearch.TabIndex = 44;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1151, 618);
            dataGridView1.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(322, 183);
            label1.Name = "label1";
            label1.Size = new Size(117, 45);
            label1.TabIndex = 48;
            label1.Text = "Dokter";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(454, 182);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(109, 45);
            lblNama.TabIndex = 49;
            lblNama.Text = "Nama";
            // 
            // Dokter_RawatInap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 916);
            Controls.Add(lblNama);
            Controls.Add(label1);
            Controls.Add(btncari);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Name = "Dokter_RawatInap";
            Text = "Dokter_RawatInap";
            Load += Dokter_RawatInap_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncari;
        private Label label9;
        private Label label2;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Label label1;
        private Label lblNama;
    }
}