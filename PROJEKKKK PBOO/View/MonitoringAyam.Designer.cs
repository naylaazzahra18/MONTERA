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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Label lblFilterBulan;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.TextBox txtJumlahBaik;
        private System.Windows.Forms.TextBox txtJumlahSakit;
        private System.Windows.Forms.TextBox txtJumlahMati;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.CheckBox chkBaik;
        private System.Windows.Forms.CheckBox chkSakit;
        private System.Windows.Forms.CheckBox chkMati;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cmbFilterBulan;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.DataGridView dgvAyam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaik;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSakit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMati;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalHarian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKeterangan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelInput = new System.Windows.Forms.Panel();
            panelFilter = new System.Windows.Forms.Panel();
            lblJudul = new System.Windows.Forms.Label();
            lblPetunjuk = new System.Windows.Forms.Label();
            lblRingkasan = new System.Windows.Forms.Label();
            lblTanggal = new System.Windows.Forms.Label();
            lblJumlah = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            lblKeterangan = new System.Windows.Forms.Label();
            lblFilterBulan = new System.Windows.Forms.Label();
            dtpTanggal = new System.Windows.Forms.DateTimePicker();
            txtJumlahBaik = new System.Windows.Forms.TextBox();
            txtJumlahSakit = new System.Windows.Forms.TextBox();
            txtJumlahMati = new System.Windows.Forms.TextBox();
            txtKeterangan = new System.Windows.Forms.TextBox();
            chkBaik = new System.Windows.Forms.CheckBox();
            chkSakit = new System.Windows.Forms.CheckBox();
            chkMati = new System.Windows.Forms.CheckBox();
            btnSimpan = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            btnHapus = new System.Windows.Forms.Button();
            txtCari = new System.Windows.Forms.TextBox();
            cmbFilterBulan = new System.Windows.Forms.ComboBox();
            btnCari = new System.Windows.Forms.Button();
            btnResetFilter = new System.Windows.Forms.Button();
            dgvAyam = new System.Windows.Forms.DataGridView();
            colTanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colBaik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSakit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTotalHarian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colKeterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAyam).BeginInit();
            SuspendLayout();
            //
            // lblJudul
            //
            lblJudul.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblJudul.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            lblJudul.Location = new System.Drawing.Point(28, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new System.Drawing.Size(800, 42);
            lblJudul.Text = "🐔 Monitoring Kesehatan Ayam";
            //
            // lblPetunjuk
            //
            lblPetunjuk.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblPetunjuk.Location = new System.Drawing.Point(32, 66);
            lblPetunjuk.Name = "lblPetunjuk";
            lblPetunjuk.Size = new System.Drawing.Size(1100, 28);
            lblPetunjuk.Text = "Pilih kondisi yang ingin dicatat, lalu isi jumlah ayam baik, sakit, dan/atau mati untuk tanggal yang sama.";
            //
            // panelInput
            //
            panelInput.BackColor = System.Drawing.Color.White;
            panelInput.Location = new System.Drawing.Point(24, 108);
            panelInput.Name = "panelInput";
            panelInput.Size = new System.Drawing.Size(1240, 190);
            panelInput.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelInput.Controls.Add(lblTanggal);
            panelInput.Controls.Add(dtpTanggal);
            panelInput.Controls.Add(lblJumlah);
            panelInput.Controls.Add(lblStatus);
            panelInput.Controls.Add(chkBaik);
            panelInput.Controls.Add(txtJumlahBaik);
            panelInput.Controls.Add(chkSakit);
            panelInput.Controls.Add(txtJumlahSakit);
            panelInput.Controls.Add(chkMati);
            panelInput.Controls.Add(txtJumlahMati);
            panelInput.Controls.Add(lblKeterangan);
            panelInput.Controls.Add(txtKeterangan);
            panelInput.Controls.Add(btnSimpan);
            panelInput.Controls.Add(btnReset);
            panelInput.Controls.Add(btnHapus);
            //
            // lblTanggal
            //
            lblTanggal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblTanggal.Location = new System.Drawing.Point(20, 18);
            lblTanggal.Size = new System.Drawing.Size(180, 24);
            lblTanggal.Text = "TANGGAL PENCATATAN";
            //
            // dtpTanggal
            //
            dtpTanggal.Location = new System.Drawing.Point(20, 48);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new System.Drawing.Size(210, 27);
            //
            // lblJumlah
            //
            lblJumlah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblJumlah.Location = new System.Drawing.Point(260, 18);
            lblJumlah.Size = new System.Drawing.Size(330, 24);
            lblJumlah.Text = "PILIH KONDISI DAN ISI JUMLAHNYA";
            //
            // txtJumlahBaik
            //
            txtJumlahBaik.Location = new System.Drawing.Point(260, 80);
            txtJumlahBaik.Name = "txtJumlahBaik";
            txtJumlahBaik.PlaceholderText = "Jumlah ayam baik";
            txtJumlahBaik.Size = new System.Drawing.Size(155, 27);
            //
            // txtJumlahSakit
            //
            txtJumlahSakit.Location = new System.Drawing.Point(440, 80);
            txtJumlahSakit.Name = "txtJumlahSakit";
            txtJumlahSakit.PlaceholderText = "Jumlah ayam sakit";
            txtJumlahSakit.Size = new System.Drawing.Size(155, 27);
            txtJumlahSakit.Enabled = false;
            //
            // txtJumlahMati
            //
            txtJumlahMati.Location = new System.Drawing.Point(620, 80);
            txtJumlahMati.Name = "txtJumlahMati";
            txtJumlahMati.PlaceholderText = "Jumlah ayam mati";
            txtJumlahMati.Size = new System.Drawing.Size(155, 27);
            txtJumlahMati.Enabled = false;
            //
            // lblStatus
            //
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblStatus.Location = new System.Drawing.Point(460, 18);
            lblStatus.Size = new System.Drawing.Size(220, 24);
            lblStatus.Text = "PILIH STATUS AYAM";
            //
            // chkBaik
            //
            chkBaik.Location = new System.Drawing.Point(260, 48);
            chkBaik.Name = "chkBaik";
            chkBaik.Size = new System.Drawing.Size(155, 28);
            chkBaik.Text = "Baik / Sehat";
            chkBaik.Checked = true;
            chkBaik.CheckedChanged += chkStatus_CheckedChanged;
            //
            // chkSakit
            //
            chkSakit.Location = new System.Drawing.Point(440, 48);
            chkSakit.Name = "chkSakit";
            chkSakit.Size = new System.Drawing.Size(155, 28);
            chkSakit.Text = "Sakit";
            chkSakit.CheckedChanged += chkStatus_CheckedChanged;
            //
            // chkMati
            //
            chkMati.Location = new System.Drawing.Point(620, 48);
            chkMati.Name = "chkMati";
            chkMati.Size = new System.Drawing.Size(155, 28);
            chkMati.Text = "Mati";
            chkMati.CheckedChanged += chkStatus_CheckedChanged;
            //
            // lblKeterangan
            //
            lblKeterangan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblKeterangan.Location = new System.Drawing.Point(20, 108);
            lblKeterangan.Size = new System.Drawing.Size(300, 24);
            lblKeterangan.Text = "KETERANGAN / KONDISI KANDANG";
            //
            // txtKeterangan
            //
            txtKeterangan.Location = new System.Drawing.Point(20, 138);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.PlaceholderText = "Opsional";
            txtKeterangan.Size = new System.Drawing.Size(650, 27);
            //
            // btnSimpan
            //
            btnSimpan.BackColor = System.Drawing.Color.FromArgb(0, 111, 77);
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSimpan.ForeColor = System.Drawing.Color.White;
            btnSimpan.Location = new System.Drawing.Point(800, 136);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new System.Drawing.Size(150, 38);
            btnSimpan.Text = "Simpan Catatan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            //
            // btnReset
            //
            btnReset.Location = new System.Drawing.Point(970, 136);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(120, 38);
            btnReset.Text = "Bersihkan";
            btnReset.Click += btnReset_Click;
            //
            // btnHapus
            //
            btnHapus.BackColor = System.Drawing.Color.FromArgb(179, 73, 65);
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHapus.ForeColor = System.Drawing.Color.White;
            btnHapus.Location = new System.Drawing.Point(1110, 136);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new System.Drawing.Size(110, 38);
            btnHapus.Text = "Hapus Pilihan";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            //
            // panelFilter
            //
            panelFilter.BackColor = System.Drawing.Color.White;
            panelFilter.Location = new System.Drawing.Point(24, 316);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new System.Drawing.Size(1240, 72);
            panelFilter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelFilter.Controls.Add(txtCari);
            panelFilter.Controls.Add(btnCari);
            panelFilter.Controls.Add(btnResetFilter);
            panelFilter.Controls.Add(lblFilterBulan);
            panelFilter.Controls.Add(cmbFilterBulan);
            //
            // txtCari
            //
            txtCari.Location = new System.Drawing.Point(20, 20);
            txtCari.Name = "txtCari";
            txtCari.PlaceholderText = "Cari tanggal, status, atau keterangan";
            txtCari.Size = new System.Drawing.Size(420, 27);
            //
            // btnCari
            //
            btnCari.BackColor = System.Drawing.Color.FromArgb(76, 128, 91);
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCari.ForeColor = System.Drawing.Color.White;
            btnCari.Location = new System.Drawing.Point(455, 17);
            btnCari.Name = "btnCari";
            btnCari.Size = new System.Drawing.Size(100, 36);
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            //
            // btnResetFilter
            //
            btnResetFilter.Location = new System.Drawing.Point(570, 17);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.Size = new System.Drawing.Size(105, 36);
            btnResetFilter.Text = "Reset";
            btnResetFilter.Click += btnResetFilter_Click;
            //
            // lblFilterBulan
            //
            lblFilterBulan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblFilterBulan.Location = new System.Drawing.Point(730, 22);
            lblFilterBulan.Name = "lblFilterBulan";
            lblFilterBulan.Size = new System.Drawing.Size(110, 24);
            lblFilterBulan.Text = "FILTER BULAN";
            //
            // cmbFilterBulan
            //
            cmbFilterBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFilterBulan.Location = new System.Drawing.Point(850, 19);
            cmbFilterBulan.Name = "cmbFilterBulan";
            cmbFilterBulan.Size = new System.Drawing.Size(250, 28);
            cmbFilterBulan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            cmbFilterBulan.SelectedIndexChanged += cmbFilterBulan_SelectedIndexChanged;
            //
            // lblRingkasan
            //
            lblRingkasan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblRingkasan.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            lblRingkasan.Location = new System.Drawing.Point(28, 744);
            lblRingkasan.Name = "lblRingkasan";
            lblRingkasan.Size = new System.Drawing.Size(1180, 30);
            lblRingkasan.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            //
            // dgvAyam
            //
            dgvAyam.AllowUserToAddRows = false;
            dgvAyam.AllowUserToDeleteRows = false;
            dgvAyam.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvAyam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAyam.BackgroundColor = System.Drawing.Color.White;
            dgvAyam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvAyam.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(231, 240, 250);
            dgvAyam.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvAyam.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            dgvAyam.ColumnHeadersHeight = 38;
            dgvAyam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colTanggal, colBaik, colSakit, colMati, colTotalHarian, colKeterangan });
            dgvAyam.EnableHeadersVisualStyles = false;
            dgvAyam.GridColor = System.Drawing.Color.FromArgb(225, 232, 240);
            dgvAyam.Location = new System.Drawing.Point(24, 418);
            dgvAyam.Name = "dgvAyam";
            dgvAyam.ReadOnly = true;
            dgvAyam.RowHeadersVisible = false;
            dgvAyam.RowTemplate.Height = 34;
            dgvAyam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAyam.Size = new System.Drawing.Size(1240, 310);
            dgvAyam.TabIndex = 20;
            //
            // colTanggal
            //
            colTanggal.HeaderText = "TANGGAL";
            colTanggal.Name = "colTanggal";
            //
            // colBaik
            //
            colBaik.HeaderText = "AYAM BAIK / SEHAT";
            colBaik.Name = "colBaik";
            //
            // colSakit
            //
            colSakit.HeaderText = "AYAM SAKIT";
            colSakit.Name = "colSakit";
            //
            // colMati
            //
            colMati.HeaderText = "AYAM MATI";
            colMati.Name = "colMati";
            //
            // colTotalHarian
            //
            colTotalHarian.HeaderText = "TOTAL AYAM HARIAN";
            colTotalHarian.Name = "colTotalHarian";
            //
            // colKeterangan
            //
            colKeterangan.HeaderText = "KETERANGAN";
            colKeterangan.Name = "colKeterangan";
            //
            // MonitoringAyam
            //
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            ClientSize = new System.Drawing.Size(1300, 800);
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Controls.Add(lblJudul);
            Controls.Add(lblPetunjuk);
            Controls.Add(panelInput);
            Controls.Add(panelFilter);
            Controls.Add(dgvAyam);
            Controls.Add(lblRingkasan);
            MinimumSize = new System.Drawing.Size(1100, 700);
            Name = "MonitoringAyam";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MONTERA | Monitoring Ayam";
            ((System.ComponentModel.ISupportInitialize)dgvAyam).EndInit();
            ResumeLayout(false);
        }
    }
}
