namespace Aplikasi_klinik_Harapan
{
    partial class LoginApoteker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginApoteker));
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            cancel = new Button();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            login = new Button();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 510);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 26;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 367);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 25;
            label1.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(128, 564);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(262, 39);
            txtPassword.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 418);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 39);
            txtEmail.TabIndex = 23;
            // 
            // cancel
            // 
            cancel.BackColor = Color.Red;
            cancel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel.ForeColor = Color.Transparent;
            cancel.Location = new Point(317, 698);
            cancel.Name = "cancel";
            cancel.Size = new Size(163, 62);
            cancel.TabIndex = 22;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += cancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(557, 305);
            panel1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(163, 24);
            label3.Name = "label3";
            label3.Size = new Size(229, 40);
            label3.TabIndex = 2;
            label3.Text = "Login Apoteker";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            login.BackColor = Color.DeepSkyBlue;
            login.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = Color.Transparent;
            login.Location = new Point(53, 698);
            login.Name = "login";
            login.Size = new Size(163, 62);
            login.TabIndex = 21;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(128, 628);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(216, 32);
            linkLabel1.TabIndex = 27;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Tidak Punya Akun?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginApoteker
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 767);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(cancel);
            Controls.Add(panel1);
            Controls.Add(login);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginApoteker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginApoteker";
            Load += LoginApoteker_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button cancel;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Button login;
        private LinkLabel linkLabel1;
    }
}