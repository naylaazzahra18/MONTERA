namespace PROJEKKKK_PBOO.Prediksi_Telur
{
    partial class PrediksiTelur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrediksiTelur));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTanggal = new TextBox();
            txtAyam = new TextBox();
            txtTelur = new TextBox();
            btnSimpan = new Button();
            btnReset = new Button();
            btnHapus = new Button();
            dgvPanen = new DataGridView();
            Tanggal = new DataGridViewTextBoxColumn();
            Ayam = new DataGridViewTextBoxColumn();
            Telur = new DataGridViewTextBoxColumn();
            Prediksi = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            panelRingkasan = new Panel();
            lblJudul = new Label();
            lblPetunjuk = new Label();
            lblJudulRiwayat = new Label();
            lblRingkasan = new Label();
            btnMuatUlang = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPanen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 35);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 0;
            label1.Text = "Tanggal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 116);
            label2.Name = "label2";
            label2.Size = new Size(235, 28);
            label2.TabIndex = 1;
            label2.Text = "Jumlah Ayam Produktif";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 190);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 2;
            label3.Text = "Jumlah Telur";
            // 
            // txtTanggal
            // 
            txtTanggal.Location = new Point(57, 69);
            txtTanggal.Name = "txtTanggal";
            txtTanggal.Size = new Size(311, 27);
            txtTanggal.TabIndex = 3;
            // 
            // txtAyam
            // 
            txtAyam.Location = new Point(57, 147);
            txtAyam.Name = "txtAyam";
            txtAyam.Size = new Size(311, 27);
            txtAyam.TabIndex = 4;
            // 
            // txtTelur
            // 
            txtTelur.Location = new Point(57, 224);
            txtTelur.Name = "txtTelur";
            txtTelur.Size = new Size(311, 27);
            txtTelur.TabIndex = 5;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LawnGreen;
            btnSimpan.Location = new Point(57, 257);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(111, 32);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += button1_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Yellow;
            btnReset.Location = new Point(191, 257);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(111, 32);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.ForeColor = SystemColors.ControlText;
            btnHapus.Location = new Point(325, 257);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(110, 32);
            btnHapus.TabIndex = 8;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            // 
            // dgvPanen
            // 
            dgvPanen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPanen.BackgroundColor = Color.DarkOrange;
            dgvPanen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPanen.Columns.AddRange(new DataGridViewColumn[] { Tanggal, Ayam, Telur, Prediksi, Status });
            dgvPanen.Location = new Point(32, 260);
            dgvPanen.Name = "dgvPanen";
            dgvPanen.RowHeadersVisible = false;
            dgvPanen.RowHeadersWidth = 51;
            dgvPanen.Size = new Size(936, 340);
            dgvPanen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPanen.AllowUserToAddRows = false;
            dgvPanen.ReadOnly = true;
            dgvPanen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPanen.TabIndex = 9;
            dgvPanen.CellContentClick += dgvPanen_CellContentClick;
            // 
            // Tanggal
            // 
            Tanggal.HeaderText = "Tanggal Panen";
            Tanggal.MinimumWidth = 6;
            Tanggal.Name = "TanggalPanen";
            Tanggal.FillWeight = 90;
            // 
            // Ayam
            // 
            Ayam.HeaderText = "Telur Baik Aktual (butir)";
            Ayam.MinimumWidth = 6;
            Ayam.Name = "TelurBaik";
            Ayam.FillWeight = 110;
            // 
            // Telur
            // 
            Telur.HeaderText = "Telur Baik (%)";
            Telur.MinimumWidth = 6;
            Telur.Name = "PersentaseBaik";
            Telur.FillWeight = 90;
            // 
            // Prediksi
            // 
            Prediksi.HeaderText = "Prediksi untuk Tanggal";
            Prediksi.MinimumWidth = 6;
            Prediksi.Name = "TanggalPrediksi";
            Prediksi.FillWeight = 120;
            // 
            // Status
            // 
            Status.HeaderText = "Perkiraan Telur Baik (butir)";
            Status.MinimumWidth = 6;
            Status.Name = "PerkiraanTelur";
            Status.FillWeight = 140;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(564, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 196);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelRingkasan
            // 
            panelRingkasan.BackColor = Color.FromArgb(229, 239, 228);
            panelRingkasan.Location = new Point(32, 145);
            panelRingkasan.Name = "panelRingkasan";
            panelRingkasan.Size = new Size(936, 66);
            panelRingkasan.TabIndex = 11;
            // 
            // lblJudul
            // 
            lblJudul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblJudul.Location = new Point(32, 22);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(680, 42);
            lblJudul.TabIndex = 12;
            lblJudul.Text = "🥚 Prediksi Produksi Telur";
            // 
            // lblPetunjuk
            // 
            lblPetunjuk.Font = new Font("Segoe UI", 10F);
            lblPetunjuk.Location = new Point(36, 74);
            lblPetunjuk.Name = "lblPetunjuk";
            lblPetunjuk.Size = new Size(925, 62);
            lblPetunjuk.TabIndex = 13;
            lblPetunjuk.Text = "Sumber data: Monitoring Panen. Setiap baris memperkirakan jumlah telur baik untuk sehari setelah tanggal panen. Perkiraan memakai rata-rata hingga 3 catatan panen terbaru. Persentase telur baik = telur baik ÷ total telur × 100%.";
            // 
            // lblJudulRiwayat
            // 
            lblJudulRiwayat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblJudulRiwayat.Location = new Point(32, 222);
            lblJudulRiwayat.Name = "lblJudulRiwayat";
            lblJudulRiwayat.Size = new Size(700, 28);
            lblJudulRiwayat.TabIndex = 14;
            lblJudulRiwayat.Text = "Riwayat Prediksi Produksi Telur";
            // 
            // lblRingkasan
            // 
            lblRingkasan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRingkasan.Location = new Point(14, 8);
            lblRingkasan.Name = "lblRingkasan";
            lblRingkasan.Size = new Size(908, 50);
            lblRingkasan.TabIndex = 15;
            lblRingkasan.Text = "Memuat riwayat panen...";
            panelRingkasan.Controls.Add(lblRingkasan);
            // 
            // btnMuatUlang
            // 
            btnMuatUlang.Location = new Point(785, 27);
            btnMuatUlang.Name = "btnMuatUlang";
            btnMuatUlang.Size = new Size(183, 38);
            btnMuatUlang.TabIndex = 15;
            btnMuatUlang.Text = "↻ Muat Ulang Data";
            btnMuatUlang.UseVisualStyleBackColor = true;
            btnMuatUlang.Click += btnMuatUlang_Click;
            // 
            // PrediksiTelur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(1000, 640);
            MinimumSize = new Size(1000, 640);
            Controls.Add(lblJudul);
            Controls.Add(lblPetunjuk);
            Controls.Add(panelRingkasan);
            Controls.Add(btnMuatUlang);
            Controls.Add(lblJudulRiwayat);
            Controls.Add(dgvPanen);
            Name = "PrediksiTelur";
            Text = "MONTERA | Prediksi Produksi Telur";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPanen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTanggal;
        private TextBox txtAyam;
        private TextBox txtTelur;
        private Button btnSimpan;
        private Button btnReset;
        private Button btnHapus;
        private DataGridView dgvPanen;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewTextBoxColumn Ayam;
        private DataGridViewTextBoxColumn Telur;
        private DataGridViewTextBoxColumn Prediksi;
        private DataGridViewTextBoxColumn Status;
        private Panel panelRingkasan;
        private Label lblJudul;
        private Label lblPetunjuk;
        private Label lblJudulRiwayat;
        private Label lblRingkasan;
        private Button btnMuatUlang;
    }
}