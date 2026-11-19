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
            dgvPanen.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvPanen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPanen.Columns.AddRange(new DataGridViewColumn[] { Tanggal, JumlahTotal, Telurbaik, Telurrusak, Keterangan });
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
            // MonitoringPanen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1172, 594);
            Controls.Add(lblTotal);
            Controls.Add(btnReset);
            Controls.Add(btnCari);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtCari);
            Controls.Add(cmbFilterBulan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHapus);
            Controls.Add(btnSimpan);
            Controls.Add(txtKeterangan);
            Controls.Add(txtRusak);
            Controls.Add(txtBaik);
            Controls.Add(txtTotal);
            Controls.Add(dtpTanggal);
            Controls.Add(dgvPanen);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "MonitoringPanen";
            Text = "MonitoringPanen";
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
    }
}