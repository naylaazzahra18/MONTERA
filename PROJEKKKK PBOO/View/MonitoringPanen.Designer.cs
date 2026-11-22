namespace PROJEKKKK_PBOO.View
{
    partial class MonitoringPanen
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
            panelInput = new Panel();
            panelFilter = new Panel();
            lblSubjudul = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dgvPanen = new DataGridView();
            Tanggal = new DataGridViewTextBoxColumn();
            JumlahTotal = new DataGridViewTextBoxColumn();
            Telurbaik = new DataGridViewTextBoxColumn();
            Telurrusak = new DataGridViewTextBoxColumn();
            Keterangan = new DataGridViewTextBoxColumn();
            PersentaseBaik = new DataGridViewTextBoxColumn();
            dtpTanggal = new DateTimePicker();
            txtTotal = new TextBox();
            txtBaik = new TextBox();
            txtRusak = new TextBox();
            txtKeterangan = new TextBox();
            btnSimpan = new Button();
            btnHapus = new Button();
            label1 = new Label();
            label2 = new Label();
            cmbFilterBulan = new ComboBox();
            txtCari = new TextBox();
            label8 = new Label();
            label9 = new Label();
            btnCari = new Button();
            btnReset = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPanen).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 8;
            label3.Text = "Jumlah Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 188);
            label4.Name = "label4";
            label4.Size = new Size(162, 25);
            label4.TabIndex = 9;
            label4.Text = "Jumlah Telur Baik";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 230);
            label5.Name = "label5";
            label5.Size = new Size(176, 25);
            label5.TabIndex = 10;
            label5.Text = "Jumlah Telur Buruk";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 293);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 11;
            label6.Text = "Keterangan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 351);
            label7.Name = "label7";
            label7.Size = new Size(450, 41);
            label7.TabIndex = 12;
            label7.Text = "RIWAYAT HASIL PANEN TELUR";
            // 
            // dgvPanen
            // 
            dgvPanen.BackgroundColor = Color.White;
            dgvPanen.BorderStyle = BorderStyle.None;
            dgvPanen.GridColor = Color.FromArgb(225, 231, 222);
            dgvPanen.EnableHeadersVisualStyles = false;
            dgvPanen.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 240, 250);
            dgvPanen.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 49, 69);
            dgvPanen.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvPanen.DefaultCellStyle.BackColor = Color.White;
            dgvPanen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPanen.Columns.AddRange(new DataGridViewColumn[] { Tanggal, JumlahTotal, Telurbaik, Telurrusak, PersentaseBaik, Keterangan });
            dgvPanen.Location = new Point(43, 395);
            dgvPanen.Name = "dgvPanen";
            dgvPanen.RowHeadersWidth = 51;
            dgvPanen.Size = new Size(809, 161);
            dgvPanen.TabIndex = 13;
            // 
            // Tanggal
            // 
            Tanggal.HeaderText = "Tanggal";
            Tanggal.MinimumWidth = 6;
            Tanggal.Name = "Tanggal";
            Tanggal.Width = 125;
            // 
            // JumlahTotal
            // 
            JumlahTotal.HeaderText = "Jumlah Total";
            JumlahTotal.MinimumWidth = 6;
            JumlahTotal.Name = "JumlahTotal";
            JumlahTotal.Width = 125;
            // 
            // Telurbaik
            // 
            Telurbaik.HeaderText = "Telur Baik";
            Telurbaik.MinimumWidth = 6;
            Telurbaik.Name = "Telurbaik";
            Telurbaik.Width = 125;
            // 
            // Telurrusak
            // 
            Telurrusak.HeaderText = "Telur Rusak";
            Telurrusak.MinimumWidth = 6;
            Telurrusak.Name = "Telurrusak";
            Telurrusak.Width = 125;
            // 
            // Keterangan
            // 
            PersentaseBaik.HeaderText = "Persentase Baik (%)";
            PersentaseBaik.MinimumWidth = 6;
            PersentaseBaik.Name = "Persen";
            PersentaseBaik.Width = 125;
            // 
            // Keterangan
            // 
            Keterangan.HeaderText = "Keterangan";
            Keterangan.MinimumWidth = 6;
            Keterangan.Name = "Keterangan";
            Keterangan.Width = 125;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(189, 87);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(250, 27);
            dtpTanggal.TabIndex = 14;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(189, 137);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 15;
            // 
            // txtBaik
            // 
            txtBaik.Location = new Point(189, 181);
            txtBaik.Name = "txtBaik";
            txtBaik.Size = new Size(125, 27);
            txtBaik.TabIndex = 16;
            // 
            // txtRusak
            // 
            txtRusak.Location = new Point(189, 225);
            txtRusak.Name = "txtRusak";
            txtRusak.Size = new Size(125, 27);
            txtRusak.TabIndex = 17;
            // 
            // txtKeterangan
            // 
            txtKeterangan.Location = new Point(154, 286);
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(367, 27);
            txtKeterangan.TabIndex = 18;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Lime;
            btnSimpan.Location = new Point(154, 319);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(160, 29);
            btnSimpan.TabIndex = 19;
            btnSimpan.Text = "Simpan Data";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.Red;
            btnHapus.Location = new Point(408, 319);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 20;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 88);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 21;
            label1.Text = "Tanggal Panen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 24);
            label2.Name = "label2";
            label2.Size = new Size(520, 41);
            label2.TabIndex = 22;
            label2.Text = "MONITORING HASIL PANEN TELUR";
            // 
            // cmbFilterBulan
            // 
            cmbFilterBulan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterBulan.FormattingEnabled = true;
            cmbFilterBulan.Location = new Point(671, 178);
            cmbFilterBulan.Name = "cmbFilterBulan";
            cmbFilterBulan.Size = new Size(151, 28);
            cmbFilterBulan.TabIndex = 23;
            // 
            // txtCari
            // 
            txtCari.Location = new Point(607, 83);
            txtCari.Name = "txtCari";
            txtCari.Size = new Size(215, 27);
            txtCari.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(506, 87);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 25;
            label8.Text = "Pencarian";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(544, 180);
            label9.Name = "label9";
            label9.Size = new Size(109, 25);
            label9.TabIndex = 26;
            label9.Text = "Filter Bulan";
            // 
            // btnCari
            // 
            btnCari.BackColor = Color.Lime;
            btnCari.Location = new Point(607, 125);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(64, 29);
            btnCari.TabIndex = 27;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += btnCari_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.Location = new Point(766, 125);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(56, 29);
            btnReset.TabIndex = 28;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(46, 565);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 29;
            lblTotal.Text = "Total";
            // 
            // Layout dashboard MONTERA
            // 
            panelInput.BackColor = Color.White;
            panelInput.Location = new Point(24, 100);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(1176, 155);
            panelInput.TabIndex = 30;
            panelInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelInput.Controls.Add(label1);
            panelInput.Controls.Add(dtpTanggal);
            panelInput.Controls.Add(label3);
            panelInput.Controls.Add(txtTotal);
            panelInput.Controls.Add(label4);
            panelInput.Controls.Add(txtBaik);
            panelInput.Controls.Add(label5);
            panelInput.Controls.Add(txtRusak);
            panelInput.Controls.Add(label6);
            panelInput.Controls.Add(txtKeterangan);
            panelInput.Controls.Add(btnSimpan);
            panelInput.Controls.Add(btnHapus);
            panelFilter.BackColor = Color.White;
            panelFilter.Location = new Point(24, 270);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1176, 78);
            panelFilter.TabIndex = 31;
            panelFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFilter.Controls.Add(label8);
            panelFilter.Controls.Add(txtCari);
            panelFilter.Controls.Add(btnCari);
            panelFilter.Controls.Add(btnReset);
            panelFilter.Controls.Add(label9);
            panelFilter.Controls.Add(cmbFilterBulan);
            lblSubjudul.Font = new Font("Segoe UI", 9.5F);
            lblSubjudul.ForeColor = Color.FromArgb(105, 121, 139);
            lblSubjudul.Location = new Point(31, 60);
            lblSubjudul.Name = "lblSubjudul";
            lblSubjudul.Size = new Size(800, 28);
            lblSubjudul.TabIndex = 32;
            lblSubjudul.Text = "Catat hasil harian, pantau kualitas telur, dan lihat rekap panen kandang.";
            label2.Text = "🥚 Monitoring & Rekap Panen Telur";
            label2.Location = new Point(28, 20);
            label2.Size = new Size(820, 38);
            label2.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.Location = new Point(18, 16);
            label1.Text = "TANGGAL PANEN";
            dtpTanggal.Location = new Point(18, 46);
            dtpTanggal.Size = new Size(205, 30);
            label3.Location = new Point(248, 16);
            label3.Text = "TOTAL TELUR";
            txtTotal.Location = new Point(248, 46);
            txtTotal.Size = new Size(130, 30);
            label4.Location = new Point(406, 16);
            label4.Text = "TELUR BAIK";
            txtBaik.Location = new Point(406, 46);
            txtBaik.Size = new Size(130, 30);
            label5.Location = new Point(564, 16);
            label5.Text = "TELUR RUSAK";
            txtRusak.Location = new Point(564, 46);
            txtRusak.Size = new Size(130, 30);
            label6.Location = new Point(722, 16);
            label6.Text = "KETERANGAN / KONDISI KANDANG";
            txtKeterangan.Location = new Point(722, 46);
            txtKeterangan.Size = new Size(420, 30);
            btnSimpan.Location = new Point(722, 95);
            btnSimpan.Size = new Size(160, 38);
            btnSimpan.Text = "Simpan Data";
            btnSimpan.BackColor = Color.FromArgb(0, 111, 77);
            btnSimpan.ForeColor = Color.White;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Cursor = Cursors.Hand;
            btnHapus.Location = new Point(896, 95);
            btnHapus.Size = new Size(120, 38);
            btnHapus.BackColor = Color.FromArgb(179, 73, 65);
            btnHapus.ForeColor = Color.White;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Cursor = Cursors.Hand;
            label8.Location = new Point(18, 22);
            label8.Text = "Cari tanggal / catatan";
            txtCari.Location = new Point(181, 20);
            txtCari.Size = new Size(260, 32);
            btnCari.Location = new Point(454, 19);
            btnCari.Size = new Size(95, 34);
            btnCari.BackColor = Color.FromArgb(76, 128, 91);
            btnCari.ForeColor = Color.White;
            btnCari.FlatStyle = FlatStyle.Flat;
            btnCari.FlatAppearance.BorderSize = 0;
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Cursor = Cursors.Hand;
            btnReset.Location = new Point(558, 19);
            btnReset.Size = new Size(100, 34);
            btnReset.BackColor = Color.FromArgb(185, 132, 47);
            btnReset.ForeColor = Color.White;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Cursor = Cursors.Hand;
            label9.Location = new Point(720, 22);
            label9.Text = "Filter bulan";
            cmbFilterBulan.Location = new Point(831, 18);
            cmbFilterBulan.Size = new Size(250, 34);
            label7.Location = new Point(28, 364);
            label7.Size = new Size(1080, 30);
            label7.Text = "📋 Riwayat Panen  |  Persentase telur baik = telur baik ÷ total panen × 100%";
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            dgvPanen.Location = new Point(28, 402);
            dgvPanen.Size = new Size(1172, 330);
            dgvPanen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPanen.RowHeadersVisible = false;
            dgvPanen.ReadOnly = true;
            dgvPanen.AllowUserToAddRows = false;
            dgvPanen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblTotal.Location = new Point(32, 744);
            lblTotal.Size = new Size(1150, 30);
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // MonitoringPanen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(1240, 820);
            MinimumSize = new Size(1080, 760);
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MONTERA | Monitoring Panen";
            Controls.Add(panelInput);
            Controls.Add(panelFilter);
            Controls.Add(lblSubjudul);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(dgvPanen);
            Controls.Add(label7);
            Name = "MonitoringPanen";
            Text = "MONTERA | Monitoring Panen";
            Load += MonitoringPanen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPanen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dgvPanen;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewTextBoxColumn JumlahTotal;
        private DataGridViewTextBoxColumn Telurbaik;
        private DataGridViewTextBoxColumn Telurrusak;
        private DataGridViewTextBoxColumn PersentaseBaik;
        private DataGridViewTextBoxColumn Keterangan;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtpTanggal;
        private TextBox txtTotal;
        private TextBox txtBaik;
        private TextBox txtRusak;
        private TextBox txtKeterangan;
        private Button btnSimpan;
        private Button btnHapus;
        private Label label1;
        private Label label2;
        private ComboBox cmbFilterBulan;
        private TextBox txtCari;
        private Label label8;
        private Label label9;
        private Button btnCari;
        private Button btnReset;
        private Label lblTotal;
        private Panel panelInput;
        private Panel panelFilter;
        private Label lblSubjudul;
    }
}