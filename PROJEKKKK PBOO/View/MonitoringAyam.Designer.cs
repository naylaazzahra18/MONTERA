namespace PROJEKKKK_PBOO.View
{
    partial class MonitoringAyam
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPetunjuk;
        private System.Windows.Forms.Label lblRingkasan;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Label lblFilterBulan;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.TextBox txtJumlahBaik;
        private System.Windows.Forms.TextBox txtJumlahSakit;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cmbFilterBulan;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.DataGridView dgvAyam;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelInput = new Panel();
            lblTanggal = new Label();
            dtpTanggal = new DateTimePicker();
            lblJumlah = new Label();
            txtJumlahBaik = new TextBox();
            txtJumlahSakit = new TextBox();
            lblKeterangan = new Label();
            txtKeterangan = new TextBox();
            btnSimpan = new Button();
            btnReset = new Button();
            btnHapus = new Button();
            panelFilter = new Panel();
            txtCari = new TextBox();
            btnCari = new Button();
            btnResetFilter = new Button();
            lblFilterBulan = new Label();
            cmbFilterBulan = new ComboBox();
            lblJudul = new Label();
            lblPetunjuk = new Label();
            lblRingkasan = new Label();
            dgvAyam = new DataGridView();
            colTanggal = new DataGridViewTextBoxColumn();
            colGejala = new DataGridViewTextBoxColumn();
            colAyam = new DataGridViewTextBoxColumn();
            colSakit = new DataGridViewTextBoxColumn();
            panelInput.SuspendLayout();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAyam).BeginInit();
            SuspendLayout();
            // 
            // panelInput
            // 
            panelInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelInput.BackColor = Color.White;
            panelInput.Controls.Add(lblTanggal);
            panelInput.Controls.Add(dtpTanggal);
            panelInput.Controls.Add(lblJumlah);
            panelInput.Controls.Add(txtJumlahBaik);
            panelInput.Controls.Add(txtJumlahSakit);
            panelInput.Controls.Add(lblKeterangan);
            panelInput.Controls.Add(txtKeterangan);
            panelInput.Controls.Add(btnSimpan);
            panelInput.Controls.Add(btnReset);
            panelInput.Controls.Add(btnHapus);
            panelInput.Location = new Point(24, 108);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(1240, 190);
            panelInput.TabIndex = 2;
            // 
            // lblTanggal
            // 
            lblTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTanggal.Location = new Point(20, 18);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(180, 24);
            lblTanggal.TabIndex = 0;
            lblTanggal.Text = "TANGGAL PENCATATAN";
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(20, 48);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(210, 27);
            dtpTanggal.TabIndex = 1;
            // 
            // lblJumlah
            // 
            lblJumlah.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblJumlah.Location = new Point(260, 18);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(330, 24);
            lblJumlah.TabIndex = 2;
            lblJumlah.Text = "JUMLAH AYAM";
            // 
            // txtJumlahBaik
            // 
            txtJumlahBaik.Location = new Point(260, 48);
            txtJumlahBaik.Name = "txtJumlahBaik";
            txtJumlahBaik.PlaceholderText = "Total jumlah ayam";
            txtJumlahBaik.Size = new Size(155, 27);
            txtJumlahBaik.TabIndex = 3;
            // 
            // txtJumlahSakit
            // 
            txtJumlahSakit.Location = new Point(440, 48);
            txtJumlahSakit.Name = "txtJumlahSakit";
            txtJumlahSakit.PlaceholderText = "Jumlah ayam sakit";
            txtJumlahSakit.Size = new Size(155, 27);
            txtJumlahSakit.TabIndex = 4;
            // 
            // lblKeterangan
            // 
            lblKeterangan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblKeterangan.Location = new Point(20, 108);
            lblKeterangan.Name = "lblKeterangan";
            lblKeterangan.Size = new Size(300, 24);
            lblKeterangan.TabIndex = 6;
            lblKeterangan.Text = "GEJALA";
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(20, 138);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.PlaceholderText = "Wajib diisi";
            txtKeterangan.Size = new Size(650, 27);
            txtKeterangan.TabIndex = 7;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(0, 111, 77);
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.ForeColor = Color.White;
            btnSimpan.Location = new Point(800, 136);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(150, 38);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan Catatan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(970, 136);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 38);
            btnReset.TabIndex = 9;
            btnReset.Text = "Bersihkan";
            btnReset.Click += btnReset_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(179, 73, 65);
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.ForeColor = Color.White;
            btnHapus.Location = new Point(1110, 136);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(110, 38);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "Hapus Pilihan";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // panelFilter
            // 
            panelFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFilter.BackColor = Color.White;
            panelFilter.Controls.Add(txtCari);
            panelFilter.Controls.Add(btnCari);
            panelFilter.Controls.Add(btnResetFilter);
            panelFilter.Controls.Add(lblFilterBulan);
            panelFilter.Controls.Add(cmbFilterBulan);
            panelFilter.Location = new Point(24, 316);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1240, 72);
            panelFilter.TabIndex = 3;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(20, 20);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari tanggal, status, atau keterangan";
            txtCari.Size = new Size(420, 27);
            txtCari.TabIndex = 0;
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.FromArgb(76, 128, 91);
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.ForeColor = Color.White;
            btnCari.Location = new Point(455, 17);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(100, 36);
            btnCari.TabIndex = 1;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // btnResetFilter
            // 
            btnResetFilter.Location = new Point(570, 17);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new Size(105, 36);
            btnResetFilter.TabIndex = 2;
            btnResetFilter.Text = "Reset";
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // lblFilterBulan
            // 
            lblFilterBulan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFilterBulan.Location = new Point(730, 22);
            lblFilterBulan.Name = "lblFilterBulan";
            lblFilterBulan.Size = new Size(110, 24);
            lblFilterBulan.TabIndex = 3;
            lblFilterBulan.Text = "FILTER BULAN";
            // 
            // cmbFilterBulan
            // 
            cmbFilterBulan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFilterBulan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterBulan.Location = new Point(850, 19);
            cmbFilterBulan.Name = "cmbFilterBulan";
            cmbFilterBulan.Size = new Size(250, 28);
            cmbFilterBulan.TabIndex = 4;
            cmbFilterBulan.SelectedIndexChanged += cmbFilterBulan_SelectedIndexChanged;
            // 
            // lblJudul
            // 
            lblJudul.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(34, 49, 69);
            lblJudul.Location = new Point(24, 35);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(800, 42);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "🐔 Monitoring Kesehatan Ayam";
            // 
            // lblPetunjuk
            // 
            lblPetunjuk.ForeColor = Color.FromArgb(105, 121, 139);
            lblPetunjuk.Location = new Point(32, 66);
            lblPetunjuk.Name = "lblPetunjuk";
            lblPetunjuk.Size = new Size(1100, 28);
            lblPetunjuk.TabIndex = 1;
            // 
            // lblRingkasan
            // 
            lblRingkasan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRingkasan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRingkasan.ForeColor = Color.FromArgb(34, 49, 69);
            lblRingkasan.Location = new Point(28, 744);
            lblRingkasan.Name = "lblRingkasan";
            lblRingkasan.Size = new Size(1180, 30);
            lblRingkasan.TabIndex = 21;
            // 
            // dgvAyam
            // 
            dgvAyam.AllowUserToAddRows = false;
            dgvAyam.AllowUserToDeleteRows = false;
            dgvAyam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAyam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAyam.BackgroundColor = Color.White;
            dgvAyam.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(231, 240, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(34, 49, 69);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAyam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAyam.ColumnHeadersHeight = 38;
            dgvAyam.Columns.AddRange(new DataGridViewColumn[] { colTanggal, colGejala, colAyam, colSakit });
            dgvAyam.EnableHeadersVisualStyles = false;
            dgvAyam.GridColor = Color.FromArgb(225, 232, 240);
            dgvAyam.Location = new Point(24, 418);
            dgvAyam.Name = "dgvAyam";
            dgvAyam.ReadOnly = true;
            dgvAyam.RowHeadersVisible = false;
            dgvAyam.RowHeadersWidth = 51;
            dgvAyam.RowTemplate.Height = 34;
            dgvAyam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAyam.Size = new Size(1240, 310);
            dgvAyam.TabIndex = 20;
            dgvAyam.CellContentClick += dgvAyam_CellContentClick;
            // 
            // colTanggal
            // 
            colTanggal.HeaderText = "TANGGAL";
            colTanggal.MinimumWidth = 6;
            colTanggal.Name = "colTanggal";
            colTanggal.ReadOnly = true;
            // 
            // colGejala
            // 
            colGejala.HeaderText = "GEJALA";
            colGejala.MinimumWidth = 6;
            colGejala.Name = "colGejala";
            colGejala.ReadOnly = true;
            // 
            // colAyam
            // 
            colAyam.HeaderText = "TOTAL AYAM";
            colAyam.MinimumWidth = 6;
            colAyam.Name = "colAyam";
            colAyam.ReadOnly = true;
            // 
            // colSakit
            // 
            colSakit.HeaderText = "JUMLAH AYAM SAKIT";
            colSakit.MinimumWidth = 6;
            colSakit.Name = "colSakit";
            colSakit.ReadOnly = true;
            // 
            // MonitoringAyam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(1300, 800);
            Controls.Add(lblJudul);
            Controls.Add(lblPetunjuk);
            Controls.Add(panelInput);
            Controls.Add(panelFilter);
            Controls.Add(dgvAyam);
            Controls.Add(lblRingkasan);
            MinimumSize = new Size(1100, 700);
            Name = "MonitoringAyam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MONTERA | Monitoring Ayam";
            WindowState = FormWindowState.Maximized;
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAyam).EndInit();
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn colTanggal;
        private DataGridViewTextBoxColumn colGejala;
        private DataGridViewTextBoxColumn colAyam;
        private DataGridViewTextBoxColumn colSakit;
    }
}
