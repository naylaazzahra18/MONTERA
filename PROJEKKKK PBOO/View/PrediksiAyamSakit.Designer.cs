namespace PROJEKKKK_PBOO.PrediksiAyam
{
    partial class PrediksiAyamSakit
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrediksiAyamSakit));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtTanggal = new TextBox();
            txtJumlahAyam = new TextBox();
            txtAyamSakit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvHasil = new DataGridView();
            btnSimpan = new Button();
            btnReset = new Button();
            btnHapus = new Button();
            pictureBox1 = new PictureBox();
            panelInput = new Panel();
            lblSumberData = new Label();
            lblRingkasan = new Label();
            btnMuatUlang = new Button();
            panelRiwayat = new Panel();
            lblJudulRiwayat = new Label();
            lblJudul = new Label();
            lblPetunjuk = new Label();
            Tanggal = new DataGridViewTextBoxColumn();
            JumlahAyam = new DataGridViewTextBoxColumn();
            AyamSakit = new DataGridViewTextBoxColumn();
            Persentase = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHasil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelInput.SuspendLayout();
            panelRiwayat.SuspendLayout();
            SuspendLayout();
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(339, 54);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(197, 27);
            txtTanggal.TabIndex = 0;
            // 
            // txtJumlahAyam
            // 
            txtJumlahAyam.Location = new Point(339, 119);
            txtJumlahAyam.Name = "txtJumlahAyam";
            txtJumlahAyam.Size = new Size(197, 27);
            txtJumlahAyam.TabIndex = 1;
            // 
            // txtAyamSakit
            // 
            txtAyamSakit.Location = new Point(339, 196);
            txtAyamSakit.Name = "txtAyamSakit";
            txtAyamSakit.Size = new Size(197, 27);
            txtAyamSakit.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 53);
            label1.Name = "label1";
            label1.Size = new Size(94, 26);
            label1.TabIndex = 3;
            label1.Text = "Tanggal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 118);
            label2.Name = "label2";
            label2.Size = new Size(150, 26);
            label2.TabIndex = 4;
            label2.Text = "Jumlah Ayam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Elephant", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 197);
            label3.Name = "label3";
            label3.Size = new Size(209, 26);
            label3.TabIndex = 5;
            label3.Text = "Jumlah Ayam Sakit";
            // 
            // dgvHasil
            // 
            dgvHasil.AllowUserToAddRows = false;
            dgvHasil.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(246, 249, 244);
            dgvHasil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHasil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHasil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHasil.BackgroundColor = Color.White;
            dgvHasil.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(231, 240, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(34, 49, 69);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHasil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHasil.ColumnHeadersHeight = 38;
            dgvHasil.Columns.AddRange(new DataGridViewColumn[] { Tanggal, JumlahAyam, AyamSakit, Persentase, Status });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(213, 232, 214);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(34, 49, 69);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvHasil.DefaultCellStyle = dataGridViewCellStyle4;
            dgvHasil.EnableHeadersVisualStyles = false;
            dgvHasil.GridColor = Color.FromArgb(225, 232, 240);
            dgvHasil.Location = new Point(16, 48);
            dgvHasil.MultiSelect = false;
            dgvHasil.Name = "dgvHasil";
            dgvHasil.ReadOnly = true;
            dgvHasil.RowHeadersVisible = false;
            dgvHasil.RowHeadersWidth = 51;
            dgvHasil.RowTemplate.Height = 34;
            dgvHasil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHasil.Size = new Size(1032, 420);
            dgvHasil.TabIndex = 6;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Lime;
            btnSimpan.Location = new Point(85, 259);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 7;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Yellow;
            btnReset.Location = new Point(199, 259);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.Location = new Point(318, 259);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 9;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(598, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 244);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panelInput
            // 
            panelInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelInput.BackColor = Color.White;
            panelInput.Controls.Add(lblSumberData);
            panelInput.Controls.Add(lblRingkasan);
            panelInput.Controls.Add(btnMuatUlang);
            panelInput.Location = new Point(28, 102);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(1064, 100);
            panelInput.TabIndex = 11;
            // 
            // lblSumberData
            // 
            lblSumberData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSumberData.ForeColor = Color.FromArgb(34, 49, 69);
            lblSumberData.Location = new Point(20, 15);
            lblSumberData.Name = "lblSumberData";
            lblSumberData.Size = new Size(730, 28);
            lblSumberData.TabIndex = 0;
            lblSumberData.Text = "Sumber data: Monitoring Ayam (status baik, sakit, dan mati)";
            // 
            // lblRingkasan
            // 
            lblRingkasan.Font = new Font("Segoe UI", 9F);
            lblRingkasan.ForeColor = Color.FromArgb(105, 121, 139);
            lblRingkasan.Location = new Point(20, 48);
            lblRingkasan.Name = "lblRingkasan";
            lblRingkasan.Size = new Size(760, 34);
            lblRingkasan.TabIndex = 1;
            lblRingkasan.Text = "Data prediksi akan dimuat dari catatan monitoring.";
            // 
            // btnMuatUlang
            // 
            btnMuatUlang.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMuatUlang.BackColor = Color.FromArgb(0, 111, 77);
            btnMuatUlang.FlatAppearance.BorderSize = 0;
            btnMuatUlang.FlatStyle = FlatStyle.Flat;
            btnMuatUlang.ForeColor = Color.White;
            btnMuatUlang.Location = new Point(1714, 30);
            btnMuatUlang.Name = "btnMuatUlang";
            btnMuatUlang.Size = new Size(190, 40);
            btnMuatUlang.TabIndex = 2;
            btnMuatUlang.Text = "Muat Ulang Monitoring";
            btnMuatUlang.UseVisualStyleBackColor = false;
            btnMuatUlang.Click += btnMuatUlang_Click;
            // 
            // panelRiwayat
            // 
            panelRiwayat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelRiwayat.BackColor = Color.White;
            panelRiwayat.Controls.Add(lblJudulRiwayat);
            panelRiwayat.Controls.Add(dgvHasil);
            panelRiwayat.Location = new Point(28, 222);
            panelRiwayat.Name = "panelRiwayat";
            panelRiwayat.Size = new Size(1064, 493);
            panelRiwayat.TabIndex = 12;
            // 
            // lblJudulRiwayat
            // 
            lblJudulRiwayat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblJudulRiwayat.Location = new Point(16, 14);
            lblJudulRiwayat.Name = "lblJudulRiwayat";
            lblJudulRiwayat.Size = new Size(700, 28);
            lblJudulRiwayat.TabIndex = 15;
            lblJudulRiwayat.Text = "Riwayat Kesehatan & Tren Ayam";
            // 
            // lblJudul
            // 
            lblJudul.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblJudul.Location = new Point(30, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(700, 40);
            lblJudul.TabIndex = 13;
            lblJudul.Text = "🐔 Prediksi Kesehatan Ayam";
            // 
            // lblPetunjuk
            // 
            lblPetunjuk.Font = new Font("Segoe UI", 9F);
            lblPetunjuk.ForeColor = Color.FromArgb(105, 121, 139);
            lblPetunjuk.Location = new Point(34, 62);
            lblPetunjuk.Name = "lblPetunjuk";
            lblPetunjuk.Size = new Size(950, 30);
            lblPetunjuk.TabIndex = 14;
            lblPetunjuk.Text = "Persentase sakit = jumlah ayam sakit ÷ (ayam baik + ayam sakit) × 100%. Ayam mati tidak dihitung sebagai ayam hidup.";
            // 
            // Tanggal
            // 
            Tanggal.HeaderText = "Tanggal";
            Tanggal.MinimumWidth = 6;
            Tanggal.Name = "Tanggal";
            Tanggal.ReadOnly = true;
            // 
            // JumlahAyam
            // 
            JumlahAyam.HeaderText = "Total Ayam";
            JumlahAyam.MinimumWidth = 6;
            JumlahAyam.Name = "JumlahAyam";
            JumlahAyam.ReadOnly = true;
            // 
            // AyamSakit
            // 
            AyamSakit.HeaderText = "Ayam Sakit";
            AyamSakit.MinimumWidth = 6;
            AyamSakit.Name = "AyamSakit";
            AyamSakit.ReadOnly = true;
            // 
            // Persentase
            // 
            dataGridViewCellStyle3.Format = "F2";
            Persentase.DefaultCellStyle = dataGridViewCellStyle3;
            Persentase.HeaderText = "Persentase Ayam Sakit (%)";
            Persentase.MinimumWidth = 6;
            Persentase.Name = "Persentase";
            Persentase.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // PrediksiAyamSakit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(1120, 760);
            Controls.Add(panelInput);
            Controls.Add(panelRiwayat);
            Controls.Add(lblJudul);
            Controls.Add(lblPetunjuk);
            MinimumSize = new Size(1000, 700);
            Name = "PrediksiAyamSakit";
            Text = "MONTERA | Prediksi Kesehatan Ayam";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvHasil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelInput.ResumeLayout(false);
            panelRiwayat.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTanggal;
        private TextBox txtJumlahAyam;
        private TextBox txtAyamSakit;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgvHasil;
        private Button btnSimpan;
        private Button btnReset;
        private Button btnHapus;
        private PictureBox pictureBox1;
        private Panel panelInput;
        private Panel panelRiwayat;
        private Label lblJudul;
        private Label lblPetunjuk;
        private Label lblJudulRiwayat;
        private Label lblRingkasan;
        private Label lblSumberData;
        private Button btnMuatUlang;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewTextBoxColumn JumlahAyam;
        private DataGridViewTextBoxColumn AyamSakit;
        private DataGridViewTextBoxColumn Persentase;
        private DataGridViewTextBoxColumn Status;
    }
}