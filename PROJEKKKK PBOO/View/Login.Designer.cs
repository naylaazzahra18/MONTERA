namespace PROJEKKKK_PBOO.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            folderBrowserDialog1 = new FolderBrowserDialog();
            lblDeskripsi = new Label();
            judul = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            picLogo = new PictureBox();
            panelLogin = new Panel();
            chkLihatPassword = new CheckBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // judul
            // 
            judul.AutoSize = false;
            judul.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            judul.Location = new Point(32, 36);
            judul.Name = "judul";
            judul.Size = new Size(330, 45);
            judul.TabIndex = 0;
            judul.Text = "Masuk ke sistem";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUsername.Location = new Point(36, 112);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 24);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(36, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Masukkan username";
            txtUsername.Size = new Size(320, 34);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPassword.Location = new Point(36, 194);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(103, 24);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(36, 222);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Masukkan password";
            txtPassword.Size = new Size(320, 34);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 111, 77);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(36, 320);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(320, 44);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImage = (Image)resources.GetObject("picLogo.BackgroundImage");
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.Location = new Point(128, 112);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(270, 180);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 6;
            picLogo.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.Controls.Add(chkLihatPassword);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(judul);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Location = new Point(535, 70);
            panelLogin.Name = "panelLogin";
            panelLogin.Padding = new Padding(12);
            panelLogin.Size = new Size(400, 510);
            panelLogin.TabIndex = 7;
            // 
            // chkLihatPassword
            // 
            chkLihatPassword.AutoSize = true;
            chkLihatPassword.Location = new Point(36, 268);
            chkLihatPassword.Name = "chkLihatPassword";
            chkLihatPassword.Size = new Size(128, 24);
            chkLihatPassword.TabIndex = 0;
            chkLihatPassword.Text = "Lihat Password";
            chkLihatPassword.UseVisualStyleBackColor = true;
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblDeskripsi.ForeColor = Color.FromArgb(105, 121, 139);
            lblDeskripsi.Location = new Point(70, 450);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(390, 58);
            lblDeskripsi.TabIndex = 9;
            lblDeskripsi.Text = "Catat hasil panen, pantau kualitas telur, dan lihat perkiraan produksi dalam satu aplikasi.";
            lblDeskripsi.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = false;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(34, 49, 69);
            label1.Location = new Point(68, 322);
            label1.Name = "label1";
            label1.Size = new Size(390, 118);
            label1.TabIndex = 8;
            label1.Text = "MONTERA\r\nSistem Monitoring dan Prediksi Tren Panen\r\nserta Jumlah Ayam Sakit";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(1000, 650);
            Controls.Add(lblDeskripsi);
            Controls.Add(label1);
            Controls.Add(picLogo);
            Controls.Add(panelLogin);
            MinimumSize = new Size(1000, 650);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MONTERA | Masuk";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Label judul;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox picLogo;
        private Panel panelLogin;
        private CheckBox chkLihatPassword;
        private Label label1;
        private Label lblDeskripsi;
    }
}