namespace Aplikasi_klinik_Harapan.HalamanDokter
{
    partial class Dokter_RekamMedis
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
            btnSearch = new Button();
            label4 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Hapus = new DataGridViewButtonColumn();
            lblNama = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(691, 181);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(315, 39);
            txtsearch.TabIndex = 32;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 192, 192);
            btnSearch.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(1037, 174);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 46);
            btnSearch.TabIndex = 28;
            btnSearch.Text = "Cari";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(422, 9);
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
            label2.Location = new Point(75, 175);
            label2.Name = "label2";
            label2.Size = new Size(303, 45);
            label2.TabIndex = 30;
            label2.Text = "Data Rekam Medis";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Hapus });
            dataGridView1.Location = new Point(75, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1153, 636);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Hapus
            // 
            Hapus.HeaderText = "Hapus";
            Hapus.MinimumWidth = 10;
            Hapus.Name = "Hapus";
            Hapus.Width = 200;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(537, 174);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(109, 45);
            lblNama.TabIndex = 51;
            lblNama.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(405, 175);
            label1.Name = "label1";
            label1.Size = new Size(117, 45);
            label1.TabIndex = 50;
            label1.Text = "Dokter";
            // 
            // Dokter_RekamMedis
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 916);
            Controls.Add(lblNama);
            Controls.Add(label1);
            Controls.Add(txtsearch);
            Controls.Add(btnSearch);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "Dokter_RekamMedis";
            Text = "Dokter_RekamMedis";
            Load += Dokter_RekamMedis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsearch;
        private Button btnSearch;
        private Label label4;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewButtonColumn Hapus;
        private Label lblNama;
        private Label label1;
    }
}