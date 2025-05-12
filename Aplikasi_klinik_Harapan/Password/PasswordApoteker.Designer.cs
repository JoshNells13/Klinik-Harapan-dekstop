namespace Aplikasi_klinik_Harapan.Password
{
    partial class PasswordApoteker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordApoteker));
            button2 = new Button();
            Submit = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtconfirm = new TextBox();
            txtnewpw = new TextBox();
            txtoldpw = new TextBox();
            panel1 = new Panel();
            Email = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(280, 812);
            button2.Name = "button2";
            button2.Size = new Size(154, 56);
            button2.TabIndex = 17;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // Submit
            // 
            Submit.BackColor = Color.DeepSkyBlue;
            Submit.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Submit.ForeColor = Color.Transparent;
            Submit.Location = new Point(42, 812);
            Submit.Name = "Submit";
            Submit.Size = new Size(153, 56);
            Submit.TabIndex = 16;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 669);
            label3.Name = "label3";
            label3.Size = new Size(230, 32);
            label3.TabIndex = 15;
            label3.Text = "Konfirmasi Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 559);
            label2.Name = "label2";
            label2.Size = new Size(166, 32);
            label2.TabIndex = 14;
            label2.Text = "Password Baru";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 433);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 13;
            label1.Text = "Password Lama";
            // 
            // txtconfirm
            // 
            txtconfirm.Location = new Point(69, 713);
            txtconfirm.Name = "txtconfirm";
            txtconfirm.Size = new Size(281, 39);
            txtconfirm.TabIndex = 12;
            // 
            // txtnewpw
            // 
            txtnewpw.Location = new Point(69, 605);
            txtnewpw.Name = "txtnewpw";
            txtnewpw.Size = new Size(281, 39);
            txtnewpw.TabIndex = 11;
            // 
            // txtoldpw
            // 
            txtoldpw.Location = new Point(69, 480);
            txtoldpw.Name = "txtoldpw";
            txtoldpw.Size = new Size(281, 39);
            txtoldpw.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(Email);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 351);
            panel1.TabIndex = 9;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Email.ForeColor = Color.White;
            Email.Location = new Point(103, 285);
            Email.Name = "Email";
            Email.Size = new Size(113, 45);
            Email.TabIndex = 1;
            Email.Text = "label4";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(73, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(343, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PasswordApoteker
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 874);
            Controls.Add(button2);
            Controls.Add(Submit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtconfirm);
            Controls.Add(txtnewpw);
            Controls.Add(txtoldpw);
            Controls.Add(panel1);
            Name = "PasswordApoteker";
            Text = "PasswordApoteker";
            Load += PasswordApoteker_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button Submit;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtconfirm;
        private TextBox txtnewpw;
        private TextBox txtoldpw;
        private Panel panel1;
        private Label Email;
        private PictureBox pictureBox1;
    }
}