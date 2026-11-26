namespace PROJEKKKK_PBOO.View
{
    partial class Beranda
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel panelHalaman;
        private System.Windows.Forms.Panel panelHalamanKonten;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblHalaman;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMonitoringPanen;
        private System.Windows.Forms.Button btnMonitoringAyam;
        private System.Windows.Forms.Button btnPrediksiAyam;
        private System.Windows.Forms.Button btnPrediksiTelur;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label lblAktor;
        private System.Windows.Forms.Label lblFacility;
        private System.Windows.Forms.Label lblLive;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubjudul;
        private System.Windows.Forms.Label lblStatusData;
        private System.Windows.Forms.Button btnInputPanen;
        private System.Windows.Forms.Panel cardTotal;
        private System.Windows.Forms.Panel cardKualitas;
        private System.Windows.Forms.Panel cardRataRata;
        private System.Windows.Forms.Panel cardPrediksi;
        private System.Windows.Forms.Label lblTotalCaption;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalNote;
        private System.Windows.Forms.Label lblKualitasCaption;
        private System.Windows.Forms.Label lblKualitasValue;
        private System.Windows.Forms.Label lblKualitasNote;
        private System.Windows.Forms.Label lblRataCaption;
        private System.Windows.Forms.Label lblRataValue;
        private System.Windows.Forms.Label lblRataNote;
        private System.Windows.Forms.Label lblPrediksiCaption;
        private System.Windows.Forms.Label lblPrediksiValue;
        private System.Windows.Forms.Label lblPrediksiNote;
        private System.Windows.Forms.Label lblTabelJudul;
        private System.Windows.Forms.Label lblTabelPetunjuk;
        private System.Windows.Forms.DataGridView dgvPanenTerbaru;
        private System.Windows.Forms.Label lblCatatanKaki;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            sidebar = new Panel();
            btnKeluar = new Button();
            lblAktor = new Label();
            btnPrediksiTelur = new Button();
            btnPrediksiAyam = new Button();
            btnMonitoringAyam = new Button();
            btnMonitoringPanen = new Button();
            btnDashboard = new Button();
            lblMenu = new Label();
            lblBrand = new Label();
            topbar = new Panel();
            lblWaktu = new Label();
            contentPanel = new Panel();
            lblCatatanKaki = new Label();
            dgvPanenTerbaru = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            lblTabelPetunjuk = new Label();
            lblTabelJudul = new Label();
            cardPrediksi = new Panel();
            lblPrediksiNote = new Label();
            lblPrediksiValue = new Label();
            lblPrediksiCaption = new Label();
            cardRataRata = new Panel();
            lblRataNote = new Label();
            lblRataValue = new Label();
            lblRataCaption = new Label();
            cardKualitas = new Panel();
            lblKualitasNote = new Label();
            lblKualitasValue = new Label();
            lblKualitasCaption = new Label();
            cardTotal = new Panel();
            lblTotalNote = new Label();
            lblTotalValue = new Label();
            lblTotalCaption = new Label();
            btnInputPanen = new Button();
            lblStatusData = new Label();
            lblSubjudul = new Label();
            lblJudul = new Label();
            panelHalaman = new Panel();
            panelHalamanKonten = new Panel();
            btnKembali = new Button();
            lblHalaman = new Label();
            sidebar.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPanenTerbaru).BeginInit();
            cardPrediksi.SuspendLayout();
            cardRataRata.SuspendLayout();
            cardKualitas.SuspendLayout();
            cardTotal.SuspendLayout();
            panelHalaman.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Controls.Add(btnKeluar);
            sidebar.Controls.Add(lblAktor);
            sidebar.Controls.Add(btnPrediksiTelur);
            sidebar.Controls.Add(btnPrediksiAyam);
            sidebar.Controls.Add(btnMonitoringAyam);
            sidebar.Controls.Add(btnMonitoringPanen);
            sidebar.Controls.Add(btnDashboard);
            sidebar.Controls.Add(lblMenu);
            sidebar.Controls.Add(lblBrand);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(14);
            sidebar.Size = new Size(220, 861);
            sidebar.TabIndex = 0;
            // 
            // btnKeluar
            // 
            btnKeluar.Dock = DockStyle.Bottom;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Segoe UI", 9F);
            btnKeluar.ForeColor = Color.FromArgb(105, 121, 139);
            btnKeluar.Location = new Point(14, 769);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(192, 36);
            btnKeluar.TabIndex = 8;
            btnKeluar.Text = "↩  Keluar / Ganti Akun";
            btnKeluar.TextAlign = ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = true;
            // 
            // lblAktor
            // 
            lblAktor.Dock = DockStyle.Bottom;
            lblAktor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAktor.ForeColor = Color.FromArgb(34, 49, 69);
            lblAktor.Location = new Point(14, 805);
            lblAktor.Name = "lblAktor";
            lblAktor.Size = new Size(192, 42);
            lblAktor.TabIndex = 7;
            lblAktor.Text = "●  OWNER\n    Pengelola Kandang";
            lblAktor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPrediksiTelur
            // 
            btnPrediksiTelur.Dock = DockStyle.Top;
            btnPrediksiTelur.FlatAppearance.BorderSize = 0;
            btnPrediksiTelur.FlatStyle = FlatStyle.Flat;
            btnPrediksiTelur.Font = new Font("Segoe UI", 9F);
            btnPrediksiTelur.ForeColor = Color.FromArgb(34, 49, 69);
            btnPrediksiTelur.Location = new Point(14, 288);
            btnPrediksiTelur.Name = "btnPrediksiTelur";
            btnPrediksiTelur.Padding = new Padding(10, 0, 0, 0);
            btnPrediksiTelur.Size = new Size(192, 42);
            btnPrediksiTelur.TabIndex = 6;
            btnPrediksiTelur.Text = "◷   Prediksi Telur";
            btnPrediksiTelur.TextAlign = ContentAlignment.MiddleLeft;
            btnPrediksiTelur.UseVisualStyleBackColor = true;
            // 
            // btnPrediksiAyam
            // 
            btnPrediksiAyam.Dock = DockStyle.Top;
            btnPrediksiAyam.FlatAppearance.BorderSize = 0;
            btnPrediksiAyam.FlatStyle = FlatStyle.Flat;
            btnPrediksiAyam.Font = new Font("Segoe UI", 9F);
            btnPrediksiAyam.ForeColor = Color.FromArgb(34, 49, 69);
            btnPrediksiAyam.Location = new Point(14, 246);
            btnPrediksiAyam.Name = "btnPrediksiAyam";
            btnPrediksiAyam.Padding = new Padding(10, 0, 0, 0);
            btnPrediksiAyam.Size = new Size(192, 42);
            btnPrediksiAyam.TabIndex = 5;
            btnPrediksiAyam.Text = "↗   Prediksi Ayam";
            btnPrediksiAyam.TextAlign = ContentAlignment.MiddleLeft;
            btnPrediksiAyam.UseVisualStyleBackColor = true;
            // 
            // btnMonitoringAyam
            // 
            btnMonitoringAyam.Dock = DockStyle.Top;
            btnMonitoringAyam.FlatAppearance.BorderSize = 0;
            btnMonitoringAyam.FlatStyle = FlatStyle.Flat;
            btnMonitoringAyam.Font = new Font("Segoe UI", 9F);
            btnMonitoringAyam.ForeColor = Color.FromArgb(34, 49, 69);
            btnMonitoringAyam.Location = new Point(14, 204);
            btnMonitoringAyam.Name = "btnMonitoringAyam";
            btnMonitoringAyam.Padding = new Padding(10, 0, 0, 0);
            btnMonitoringAyam.Size = new Size(192, 42);
            btnMonitoringAyam.TabIndex = 4;
            btnMonitoringAyam.Text = "♟   Monitoring Ayam";
            btnMonitoringAyam.TextAlign = ContentAlignment.MiddleLeft;
            btnMonitoringAyam.UseVisualStyleBackColor = true;
            // 
            // btnMonitoringPanen
            // 
            btnMonitoringPanen.Dock = DockStyle.Top;
            btnMonitoringPanen.FlatAppearance.BorderSize = 0;
            btnMonitoringPanen.FlatStyle = FlatStyle.Flat;
            btnMonitoringPanen.Font = new Font("Segoe UI", 9F);
            btnMonitoringPanen.ForeColor = Color.FromArgb(34, 49, 69);
            btnMonitoringPanen.Location = new Point(14, 162);
            btnMonitoringPanen.Name = "btnMonitoringPanen";
            btnMonitoringPanen.Padding = new Padding(10, 0, 0, 0);
            btnMonitoringPanen.Size = new Size(192, 42);
            btnMonitoringPanen.TabIndex = 3;
            btnMonitoringPanen.Text = "♧   Monitoring Panen";
            btnMonitoringPanen.TextAlign = ContentAlignment.MiddleLeft;
            btnMonitoringPanen.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(0, 111, 77);
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(14, 120);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(192, 42);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "▦   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblMenu
            // 
            lblMenu.Dock = DockStyle.Top;
            lblMenu.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMenu.ForeColor = Color.FromArgb(105, 121, 139);
            lblMenu.Location = new Point(14, 82);
            lblMenu.Name = "lblMenu";
            lblMenu.Padding = new Padding(5, 0, 0, 6);
            lblMenu.Size = new Size(192, 38);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "MENU OPERASIONAL";
            lblMenu.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblBrand
            // 
            lblBrand.Dock = DockStyle.Top;
            lblBrand.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(0, 111, 77);
            lblBrand.Location = new Point(14, 14);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(192, 68);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "🐔  MONTERA\n      MONITORING KANDANG";
            lblBrand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // topbar
            // 
            topbar.BackColor = Color.White;
            topbar.Dock = DockStyle.Top;
            topbar.Location = new Point(220, 0);
            topbar.Name = "topbar";
            topbar.Padding = new Padding(22, 0, 22, 0);
            topbar.Size = new Size(1204, 58);
            topbar.TabIndex = 1;
            topbar.Controls.Add(lblWaktu);
            // 
            // lblWaktu
            // 
            lblWaktu.Dock = DockStyle.Right;
            lblWaktu.Font = new Font("Segoe UI", 8F);
            lblWaktu.ForeColor = Color.FromArgb(105, 121, 139);
            lblWaktu.Name = "lblWaktu";
            lblWaktu.Size = new Size(220, 58);
            lblWaktu.TabIndex = 0;
            lblWaktu.TextAlign = ContentAlignment.MiddleRight;
            // 
            // contentPanel
            // 
            contentPanel.AutoScroll = true;
            contentPanel.BackColor = Color.FromArgb(245, 248, 252);
            contentPanel.Controls.Add(lblCatatanKaki);
            contentPanel.Controls.Add(dgvPanenTerbaru);
            contentPanel.Controls.Add(lblTabelPetunjuk);
            contentPanel.Controls.Add(lblTabelJudul);
            contentPanel.Controls.Add(cardPrediksi);
            contentPanel.Controls.Add(cardRataRata);
            contentPanel.Controls.Add(cardKualitas);
            contentPanel.Controls.Add(cardTotal);
            contentPanel.Controls.Add(btnInputPanen);
            contentPanel.Controls.Add(lblStatusData);
            contentPanel.Controls.Add(lblSubjudul);
            contentPanel.Controls.Add(lblJudul);
            contentPanel.Controls.Add(panelHalaman);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(220, 58);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(24, 18, 24, 22);
            contentPanel.Size = new Size(1204, 803);
            contentPanel.TabIndex = 2;
            // 
            // lblCatatanKaki
            // 
            lblCatatanKaki.Font = new Font("Segoe UI", 8F);
            lblCatatanKaki.ForeColor = Color.FromArgb(105, 121, 139);
            lblCatatanKaki.Location = new Point(28, 675);
            lblCatatanKaki.Name = "lblCatatanKaki";
            lblCatatanKaki.Size = new Size(1050, 42);
            lblCatatanKaki.TabIndex = 11;
            lblCatatanKaki.Text = "Persentase kualitas menunjukkan bagian telur baik dari seluruh telur yang dicatat; angka prediksi hanya perkiraan berdasarkan riwayat.";
            // 
            // dgvPanenTerbaru
            // 
            dgvPanenTerbaru.AllowUserToAddRows = false;
            dgvPanenTerbaru.AllowUserToDeleteRows = false;
            dgvPanenTerbaru.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPanenTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPanenTerbaru.BackgroundColor = Color.White;
            dgvPanenTerbaru.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(231, 240, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(34, 49, 69);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPanenTerbaru.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPanenTerbaru.ColumnHeadersHeight = 38;
            dgvPanenTerbaru.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvPanenTerbaru.EnableHeadersVisualStyles = false;
            dgvPanenTerbaru.GridColor = Color.FromArgb(225, 232, 240);
            dgvPanenTerbaru.Location = new Point(26, 354);
            dgvPanenTerbaru.Name = "dgvPanenTerbaru";
            dgvPanenTerbaru.ReadOnly = true;
            dgvPanenTerbaru.RowHeadersVisible = false;
            dgvPanenTerbaru.RowHeadersWidth = 51;
            dgvPanenTerbaru.RowTemplate.Height = 34;
            dgvPanenTerbaru.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPanenTerbaru.Size = new Size(1130, 310);
            dgvPanenTerbaru.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "TANGGAL PANEN";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "TOTAL";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "TELUR BAIK";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "TELUR RUSAK";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "KUALITAS (%)";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "PREDIKSI TANGGAL";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "PERKIRAAN TELUR";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "KETERANGAN";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // lblTabelPetunjuk
            // 
            lblTabelPetunjuk.Font = new Font("Segoe UI", 8.5F);
            lblTabelPetunjuk.ForeColor = Color.FromArgb(105, 121, 139);
            lblTabelPetunjuk.Location = new Point(28, 324);
            lblTabelPetunjuk.Name = "lblTabelPetunjuk";
            lblTabelPetunjuk.Size = new Size(900, 24);
            lblTabelPetunjuk.TabIndex = 9;
            lblTabelPetunjuk.Text = "Perkiraan untuk satu hari setelah tanggal panen, dihitung dari rata-rata hingga 3 catatan terakhir.";
            // 
            // lblTabelJudul
            // 
            lblTabelJudul.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTabelJudul.ForeColor = Color.FromArgb(34, 49, 69);
            lblTabelJudul.Location = new Point(28, 292);
            lblTabelJudul.Name = "lblTabelJudul";
            lblTabelJudul.Size = new Size(600, 30);
            lblTabelJudul.TabIndex = 8;
            lblTabelJudul.Text = "▰  Riwayat Panen Terbaru";
            // 
            // cardPrediksi
            // 
            cardPrediksi.BackColor = Color.White;
            cardPrediksi.Controls.Add(lblPrediksiNote);
            cardPrediksi.Controls.Add(lblPrediksiValue);
            cardPrediksi.Controls.Add(lblPrediksiCaption);
            cardPrediksi.Location = new Point(842, 142);
            cardPrediksi.Name = "cardPrediksi";
            cardPrediksi.Padding = new Padding(14, 12, 10, 8);
            cardPrediksi.Size = new Size(260, 130);
            cardPrediksi.TabIndex = 7;
            // 
            // lblPrediksiNote
            // 
            lblPrediksiNote.Dock = DockStyle.Fill;
            lblPrediksiNote.Font = new Font("Segoe UI", 8F);
            lblPrediksiNote.ForeColor = Color.FromArgb(105, 121, 139);
            lblPrediksiNote.Location = new Point(14, 84);
            lblPrediksiNote.Name = "lblPrediksiNote";
            lblPrediksiNote.Size = new Size(236, 38);
            lblPrediksiNote.TabIndex = 2;
            lblPrediksiNote.Text = "Belum ada data panen";
            // 
            // lblPrediksiValue
            // 
            lblPrediksiValue.Dock = DockStyle.Top;
            lblPrediksiValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPrediksiValue.ForeColor = Color.FromArgb(34, 49, 69);
            lblPrediksiValue.Location = new Point(14, 36);
            lblPrediksiValue.Name = "lblPrediksiValue";
            lblPrediksiValue.Size = new Size(236, 48);
            lblPrediksiValue.TabIndex = 1;
            lblPrediksiValue.Text = "—";
            // 
            // lblPrediksiCaption
            // 
            lblPrediksiCaption.Dock = DockStyle.Top;
            lblPrediksiCaption.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblPrediksiCaption.ForeColor = Color.FromArgb(105, 121, 139);
            lblPrediksiCaption.Location = new Point(14, 12);
            lblPrediksiCaption.Name = "lblPrediksiCaption";
            lblPrediksiCaption.Size = new Size(236, 24);
            lblPrediksiCaption.TabIndex = 0;
            lblPrediksiCaption.Text = "PERKIRAAN PANEN BERIKUTNYA";
            // 
            // cardRataRata
            // 
            cardRataRata.BackColor = Color.White;
            cardRataRata.Controls.Add(lblRataNote);
            cardRataRata.Controls.Add(lblRataValue);
            cardRataRata.Controls.Add(lblRataCaption);
            cardRataRata.Location = new Point(570, 142);
            cardRataRata.Name = "cardRataRata";
            cardRataRata.Padding = new Padding(14, 12, 10, 8);
            cardRataRata.Size = new Size(260, 130);
            cardRataRata.TabIndex = 6;
            // 
            // lblRataNote
            // 
            lblRataNote.Dock = DockStyle.Fill;
            lblRataNote.Font = new Font("Segoe UI", 8F);
            lblRataNote.ForeColor = Color.FromArgb(105, 121, 139);
            lblRataNote.Location = new Point(14, 84);
            lblRataNote.Name = "lblRataNote";
            lblRataNote.Size = new Size(236, 38);
            lblRataNote.TabIndex = 2;
            lblRataNote.Text = "Butir per hari pencatatan";
            // 
            // lblRataValue
            // 
            lblRataValue.Dock = DockStyle.Top;
            lblRataValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblRataValue.ForeColor = Color.FromArgb(34, 49, 69);
            lblRataValue.Location = new Point(14, 36);
            lblRataValue.Name = "lblRataValue";
            lblRataValue.Size = new Size(236, 48);
            lblRataValue.TabIndex = 1;
            lblRataValue.Text = "—";
            // 
            // lblRataCaption
            // 
            lblRataCaption.Dock = DockStyle.Top;
            lblRataCaption.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblRataCaption.ForeColor = Color.FromArgb(105, 121, 139);
            lblRataCaption.Location = new Point(14, 12);
            lblRataCaption.Name = "lblRataCaption";
            lblRataCaption.Size = new Size(236, 24);
            lblRataCaption.TabIndex = 0;
            lblRataCaption.Text = "RATA-RATA PANEN";
            // 
            // cardKualitas
            // 
            cardKualitas.BackColor = Color.White;
            cardKualitas.Controls.Add(lblKualitasNote);
            cardKualitas.Controls.Add(lblKualitasValue);
            cardKualitas.Controls.Add(lblKualitasCaption);
            cardKualitas.Location = new Point(298, 142);
            cardKualitas.Name = "cardKualitas";
            cardKualitas.Padding = new Padding(14, 12, 10, 8);
            cardKualitas.Size = new Size(260, 130);
            cardKualitas.TabIndex = 5;
            // 
            // lblKualitasNote
            // 
            lblKualitasNote.Dock = DockStyle.Fill;
            lblKualitasNote.Font = new Font("Segoe UI", 8F);
            lblKualitasNote.ForeColor = Color.FromArgb(105, 121, 139);
            lblKualitasNote.Location = new Point(14, 84);
            lblKualitasNote.Name = "lblKualitasNote";
            lblKualitasNote.Size = new Size(236, 38);
            lblKualitasNote.TabIndex = 2;
            lblKualitasNote.Text = "Telur baik ÷ total panen";
            // 
            // lblKualitasValue
            // 
            lblKualitasValue.Dock = DockStyle.Top;
            lblKualitasValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblKualitasValue.ForeColor = Color.FromArgb(34, 49, 69);
            lblKualitasValue.Location = new Point(14, 36);
            lblKualitasValue.Name = "lblKualitasValue";
            lblKualitasValue.Size = new Size(236, 48);
            lblKualitasValue.TabIndex = 1;
            lblKualitasValue.Text = "—";
            // 
            // lblKualitasCaption
            // 
            lblKualitasCaption.Dock = DockStyle.Top;
            lblKualitasCaption.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblKualitasCaption.ForeColor = Color.FromArgb(105, 121, 139);
            lblKualitasCaption.Location = new Point(14, 12);
            lblKualitasCaption.Name = "lblKualitasCaption";
            lblKualitasCaption.Size = new Size(236, 24);
            lblKualitasCaption.TabIndex = 0;
            lblKualitasCaption.Text = "KUALITAS TELUR BAIK";
            // 
            // cardTotal
            // 
            cardTotal.BackColor = Color.White;
            cardTotal.Controls.Add(lblTotalNote);
            cardTotal.Controls.Add(lblTotalValue);
            cardTotal.Controls.Add(lblTotalCaption);
            cardTotal.Location = new Point(26, 142);
            cardTotal.Name = "cardTotal";
            cardTotal.Padding = new Padding(14, 12, 10, 8);
            cardTotal.Size = new Size(260, 130);
            cardTotal.TabIndex = 4;
            // 
            // lblTotalNote
            // 
            lblTotalNote.Dock = DockStyle.Fill;
            lblTotalNote.Font = new Font("Segoe UI", 8F);
            lblTotalNote.ForeColor = Color.FromArgb(105, 121, 139);
            lblTotalNote.Location = new Point(14, 84);
            lblTotalNote.Name = "lblTotalNote";
            lblTotalNote.Size = new Size(236, 38);
            lblTotalNote.TabIndex = 2;
            lblTotalNote.Text = "Butir tercatat di semua tanggal";
            // 
            // lblTotalValue
            // 
            lblTotalValue.Dock = DockStyle.Top;
            lblTotalValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalValue.ForeColor = Color.FromArgb(34, 49, 69);
            lblTotalValue.Location = new Point(14, 36);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(236, 48);
            lblTotalValue.TabIndex = 1;
            lblTotalValue.Text = "0";
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.Dock = DockStyle.Top;
            lblTotalCaption.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTotalCaption.ForeColor = Color.FromArgb(105, 121, 139);
            lblTotalCaption.Location = new Point(14, 12);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(236, 24);
            lblTotalCaption.TabIndex = 0;
            lblTotalCaption.Text = "TOTAL TELUR TERDATA";
            // 
            // btnInputPanen
            // 
            btnInputPanen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInputPanen.BackColor = Color.FromArgb(0, 111, 77);
            btnInputPanen.FlatAppearance.BorderSize = 0;
            btnInputPanen.FlatStyle = FlatStyle.Flat;
            btnInputPanen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInputPanen.ForeColor = Color.White;
            btnInputPanen.Location = new Point(951, 98);
            btnInputPanen.Name = "btnInputPanen";
            btnInputPanen.Size = new Size(205, 40);
            btnInputPanen.TabIndex = 3;
            btnInputPanen.Text = "+  Input Data Panen";
            btnInputPanen.UseVisualStyleBackColor = false;
            // 
            // lblStatusData
            // 
            lblStatusData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatusData.ForeColor = Color.FromArgb(0, 111, 77);
            lblStatusData.Location = new Point(28, 98);
            lblStatusData.Name = "lblStatusData";
            lblStatusData.Size = new Size(580, 28);
            lblStatusData.TabIndex = 2;
            lblStatusData.Text = "Data panen";
            // 
            // lblSubjudul
            // 
            lblSubjudul.Font = new Font("Segoe UI", 9.5F);
            lblSubjudul.ForeColor = Color.FromArgb(105, 121, 139);
            lblSubjudul.Location = new Point(28, 62);
            lblSubjudul.Name = "lblSubjudul";
            lblSubjudul.Size = new Size(800, 28);
            lblSubjudul.TabIndex = 1;
            lblSubjudul.Text = "Sistem Monitoring dan Prediksi Tren Panen serta Jumlah Ayam Sakit.";
            // 
            // lblJudul
            // 
            lblJudul.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblJudul.ForeColor = Color.FromArgb(34, 49, 69);
            lblJudul.Location = new Point(26, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(720, 40);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Dashboard MONTERA";
            // 
            // panelHalaman
            // 
            panelHalaman.BackColor = Color.FromArgb(245, 248, 252);
            panelHalaman.Controls.Add(panelHalamanKonten);
            panelHalaman.Controls.Add(btnKembali);
            panelHalaman.Controls.Add(lblHalaman);
            panelHalaman.Dock = DockStyle.Fill;
            panelHalaman.Location = new Point(24, 18);
            panelHalaman.Name = "panelHalaman";
            panelHalaman.Size = new Size(1156, 763);
            panelHalaman.TabIndex = 12;
            panelHalaman.Visible = false;
            // 
            // panelHalamanKonten
            // 
            panelHalamanKonten.Dock = DockStyle.Fill;
            panelHalamanKonten.BackColor = Color.FromArgb(245, 248, 252);
            panelHalamanKonten.Padding = new Padding(0, 58, 0, 0);
            panelHalamanKonten.Name = "panelHalamanKonten";
            panelHalamanKonten.TabIndex = 2;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.FromArgb(0, 111, 77);
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatStyle = FlatStyle.Flat;
            btnKembali.ForeColor = Color.White;
            btnKembali.Location = new Point(12, 10);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(130, 38);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "← Dashboard";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // lblHalaman
            // 
            lblHalaman.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHalaman.ForeColor = Color.FromArgb(34, 49, 69);
            lblHalaman.Location = new Point(160, 10);
            lblHalaman.Name = "lblHalaman";
            lblHalaman.Size = new Size(850, 38);
            lblHalaman.TabIndex = 1;
            lblHalaman.Text = "Halaman";
            lblHalaman.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Beranda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(1424, 861);
            Controls.Add(contentPanel);
            Controls.Add(topbar);
            Controls.Add(sidebar);
            MinimumSize = new Size(1120, 720);
            Name = "Beranda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MONTERA | Dashboard";
            WindowState = FormWindowState.Maximized;
            sidebar.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPanenTerbaru).EndInit();
            cardPrediksi.ResumeLayout(false);
            cardRataRata.ResumeLayout(false);
            cardKualitas.ResumeLayout(false);
            cardTotal.ResumeLayout(false);
            panelHalaman.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
