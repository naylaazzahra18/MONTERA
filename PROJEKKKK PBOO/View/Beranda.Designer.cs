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
            sidebar = new System.Windows.Forms.Panel();
            lblBrand = new System.Windows.Forms.Label();
            lblMenu = new System.Windows.Forms.Label();
            btnDashboard = new System.Windows.Forms.Button();
            btnMonitoringPanen = new System.Windows.Forms.Button();
            btnMonitoringAyam = new System.Windows.Forms.Button();
            btnPrediksiAyam = new System.Windows.Forms.Button();
            btnPrediksiTelur = new System.Windows.Forms.Button();
            lblAktor = new System.Windows.Forms.Label();
            btnKeluar = new System.Windows.Forms.Button();
            topbar = new System.Windows.Forms.Panel();
            lblFacility = new System.Windows.Forms.Label();
            lblLive = new System.Windows.Forms.Label();
            lblWaktu = new System.Windows.Forms.Label();
            contentPanel = new System.Windows.Forms.Panel();
            lblJudul = new System.Windows.Forms.Label();
            lblSubjudul = new System.Windows.Forms.Label();
            lblStatusData = new System.Windows.Forms.Label();
            btnInputPanen = new System.Windows.Forms.Button();
            cardTotal = new System.Windows.Forms.Panel();
            lblTotalCaption = new System.Windows.Forms.Label();
            lblTotalValue = new System.Windows.Forms.Label();
            lblTotalNote = new System.Windows.Forms.Label();
            cardKualitas = new System.Windows.Forms.Panel();
            lblKualitasCaption = new System.Windows.Forms.Label();
            lblKualitasValue = new System.Windows.Forms.Label();
            lblKualitasNote = new System.Windows.Forms.Label();
            cardRataRata = new System.Windows.Forms.Panel();
            lblRataCaption = new System.Windows.Forms.Label();
            lblRataValue = new System.Windows.Forms.Label();
            lblRataNote = new System.Windows.Forms.Label();
            cardPrediksi = new System.Windows.Forms.Panel();
            lblPrediksiCaption = new System.Windows.Forms.Label();
            lblPrediksiValue = new System.Windows.Forms.Label();
            lblPrediksiNote = new System.Windows.Forms.Label();
            lblTabelJudul = new System.Windows.Forms.Label();
            lblTabelPetunjuk = new System.Windows.Forms.Label();
            dgvPanenTerbaru = new System.Windows.Forms.DataGridView();
            lblCatatanKaki = new System.Windows.Forms.Label();
            panelHalaman = new System.Windows.Forms.Panel();
            panelHalamanKonten = new System.Windows.Forms.Panel();
            btnKembali = new System.Windows.Forms.Button();
            lblHalaman = new System.Windows.Forms.Label();
            sidebar.SuspendLayout();
            topbar.SuspendLayout();
            contentPanel.SuspendLayout();
            cardTotal.SuspendLayout();
            cardKualitas.SuspendLayout();
            cardRataRata.SuspendLayout();
            cardPrediksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPanenTerbaru).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = System.Drawing.Color.White;
            sidebar.Controls.Add(btnKeluar);
            sidebar.Controls.Add(lblAktor);
            sidebar.Controls.Add(btnPrediksiTelur);
            sidebar.Controls.Add(btnPrediksiAyam);
            sidebar.Controls.Add(btnMonitoringAyam);
            sidebar.Controls.Add(btnMonitoringPanen);
            sidebar.Controls.Add(btnDashboard);
            sidebar.Controls.Add(lblMenu);
            sidebar.Controls.Add(lblBrand);
            sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            sidebar.Location = new System.Drawing.Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Padding = new System.Windows.Forms.Padding(14);
            sidebar.Size = new System.Drawing.Size(220, 861);
            sidebar.TabIndex = 0;
            // 
            // lblBrand
            // 
            lblBrand.Dock = System.Windows.Forms.DockStyle.Top;
            lblBrand.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblBrand.ForeColor = System.Drawing.Color.FromArgb(0, 111, 77);
            lblBrand.Location = new System.Drawing.Point(14, 14);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new System.Drawing.Size(192, 68);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "🐔  MONTERA\n      MONITORING KANDANG";
            lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMenu
            // 
            lblMenu.Dock = System.Windows.Forms.DockStyle.Top;
            lblMenu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblMenu.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblMenu.Location = new System.Drawing.Point(14, 82);
            lblMenu.Name = "lblMenu";
            lblMenu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 6);
            lblMenu.Size = new System.Drawing.Size(192, 38);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "MENU OPERASIONAL";
            lblMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(0, 111, 77);
            btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnDashboard.ForeColor = System.Drawing.Color.White;
            btnDashboard.Location = new System.Drawing.Point(14, 120);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btnDashboard.Size = new System.Drawing.Size(192, 42);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "▦   Dashboard";
            btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnMonitoringPanen
            // 
            btnMonitoringPanen.Dock = System.Windows.Forms.DockStyle.Top;
            btnMonitoringPanen.FlatAppearance.BorderSize = 0;
            btnMonitoringPanen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMonitoringPanen.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnMonitoringPanen.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            btnMonitoringPanen.Location = new System.Drawing.Point(14, 162);
            btnMonitoringPanen.Name = "btnMonitoringPanen";
            btnMonitoringPanen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btnMonitoringPanen.Size = new System.Drawing.Size(192, 42);
            btnMonitoringPanen.TabIndex = 3;
            btnMonitoringPanen.Text = "♧   Monitoring Panen";
            btnMonitoringPanen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMonitoringPanen.UseVisualStyleBackColor = true;
            // 
            // btnMonitoringAyam
            // 
            btnMonitoringAyam.Dock = System.Windows.Forms.DockStyle.Top;
            btnMonitoringAyam.FlatAppearance.BorderSize = 0;
            btnMonitoringAyam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMonitoringAyam.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnMonitoringAyam.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            btnMonitoringAyam.Location = new System.Drawing.Point(14, 204);
            btnMonitoringAyam.Name = "btnMonitoringAyam";
            btnMonitoringAyam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btnMonitoringAyam.Size = new System.Drawing.Size(192, 42);
            btnMonitoringAyam.TabIndex = 4;
            btnMonitoringAyam.Text = "♟   Monitoring Ayam";
            btnMonitoringAyam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnMonitoringAyam.UseVisualStyleBackColor = true;
            // 
            // btnPrediksiAyam
            // 
            btnPrediksiAyam.Dock = System.Windows.Forms.DockStyle.Top;
            btnPrediksiAyam.FlatAppearance.BorderSize = 0;
            btnPrediksiAyam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrediksiAyam.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnPrediksiAyam.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            btnPrediksiAyam.Location = new System.Drawing.Point(14, 246);
            btnPrediksiAyam.Name = "btnPrediksiAyam";
            btnPrediksiAyam.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btnPrediksiAyam.Size = new System.Drawing.Size(192, 42);
            btnPrediksiAyam.TabIndex = 5;
            btnPrediksiAyam.Text = "↗   Prediksi Ayam";
            btnPrediksiAyam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPrediksiAyam.UseVisualStyleBackColor = true;
            // 
            // btnPrediksiTelur
            // 
            btnPrediksiTelur.Dock = System.Windows.Forms.DockStyle.Top;
            btnPrediksiTelur.FlatAppearance.BorderSize = 0;
            btnPrediksiTelur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPrediksiTelur.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnPrediksiTelur.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            btnPrediksiTelur.Location = new System.Drawing.Point(14, 288);
            btnPrediksiTelur.Name = "btnPrediksiTelur";
            btnPrediksiTelur.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            btnPrediksiTelur.Size = new System.Drawing.Size(192, 42);
            btnPrediksiTelur.TabIndex = 6;
            btnPrediksiTelur.Text = "◷   Prediksi Telur";
            btnPrediksiTelur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPrediksiTelur.UseVisualStyleBackColor = true;
            // 
            // lblAktor
            // 
            lblAktor.Dock = System.Windows.Forms.DockStyle.Bottom;
            lblAktor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblAktor.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            lblAktor.Location = new System.Drawing.Point(14, 769);
            lblAktor.Name = "lblAktor";
            lblAktor.Size = new System.Drawing.Size(192, 42);
            lblAktor.TabIndex = 7;
            lblAktor.Text = "●  OWNER\n    Pengelola Kandang";
            lblAktor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnKeluar
            // 
            btnKeluar.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnKeluar.FlatAppearance.BorderSize = 0;
            btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnKeluar.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnKeluar.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            btnKeluar.Location = new System.Drawing.Point(14, 811);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new System.Drawing.Size(192, 36);
            btnKeluar.TabIndex = 8;
            btnKeluar.Text = "↩  Keluar / Ganti Akun";
            btnKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnKeluar.UseVisualStyleBackColor = true;
            // 
            // topbar
            // 
            topbar.BackColor = System.Drawing.Color.White;
            topbar.Controls.Add(lblWaktu);
            topbar.Controls.Add(lblLive);
            topbar.Controls.Add(lblFacility);
            topbar.Dock = System.Windows.Forms.DockStyle.Top;
            topbar.Location = new System.Drawing.Point(220, 0);
            topbar.Name = "topbar";
            topbar.Padding = new System.Windows.Forms.Padding(22, 0, 22, 0);
            topbar.Size = new System.Drawing.Size(1204, 58);
            topbar.TabIndex = 1;
            // 
            // lblFacility
            // 
            lblFacility.Dock = System.Windows.Forms.DockStyle.Left;
            lblFacility.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblFacility.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            lblFacility.Location = new System.Drawing.Point(22, 0);
            lblFacility.Name = "lblFacility";
            lblFacility.Size = new System.Drawing.Size(390, 58);
            lblFacility.TabIndex = 0;
            lblFacility.Text = "▣  FACILITY: Kandang Ayam - Layer Farm";
            lblFacility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLive
            // 
            lblLive.Dock = System.Windows.Forms.DockStyle.Right;
            lblLive.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblLive.ForeColor = System.Drawing.Color.FromArgb(0, 111, 77);
            lblLive.Location = new System.Drawing.Point(882, 0);
            lblLive.Name = "lblLive";
            lblLive.Size = new System.Drawing.Size(150, 58);
            lblLive.TabIndex = 1;
            lblLive.Text = "●  DATA PANEN LIVE";
            lblLive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWaktu
            // 
            lblWaktu.Dock = System.Windows.Forms.DockStyle.Right;
            lblWaktu.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblWaktu.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblWaktu.Location = new System.Drawing.Point(1032, 0);
            lblWaktu.Name = "lblWaktu";
            lblWaktu.Size = new System.Drawing.Size(150, 58);
            lblWaktu.TabIndex = 2;
            lblWaktu.Text = "Tanggal | Jam";
            lblWaktu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contentPanel
            // 
            contentPanel.AutoScroll = true;
            contentPanel.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
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
            contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            contentPanel.Location = new System.Drawing.Point(220, 58);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new System.Windows.Forms.Padding(24, 18, 24, 22);
            contentPanel.Size = new System.Drawing.Size(1204, 803);
            contentPanel.TabIndex = 2;
            // 
            // lblJudul
            // 
            lblJudul.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            lblJudul.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            lblJudul.Location = new System.Drawing.Point(26, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new System.Drawing.Size(720, 40);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Dashboard MONTERA";
            // 
            // lblSubjudul
            // 
            lblSubjudul.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblSubjudul.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblSubjudul.Location = new System.Drawing.Point(28, 62);
            lblSubjudul.Name = "lblSubjudul";
            lblSubjudul.Size = new System.Drawing.Size(800, 28);
            lblSubjudul.TabIndex = 1;
            lblSubjudul.Text = "Sistem Monitoring dan Prediksi Tren Panen serta Jumlah Ayam Sakit.";
            // 
            // lblStatusData
            // 
            lblStatusData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblStatusData.ForeColor = System.Drawing.Color.FromArgb(0, 111, 77);
            lblStatusData.Location = new System.Drawing.Point(28, 98);
            lblStatusData.Name = "lblStatusData";
            lblStatusData.Size = new System.Drawing.Size(580, 28);
            lblStatusData.TabIndex = 2;
            lblStatusData.Text = "Data panen";
            // 
            // btnInputPanen
            // 
            btnInputPanen.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnInputPanen.BackColor = System.Drawing.Color.FromArgb(0, 111, 77);
            btnInputPanen.FlatAppearance.BorderSize = 0;
            btnInputPanen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInputPanen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnInputPanen.ForeColor = System.Drawing.Color.White;
            btnInputPanen.Location = new System.Drawing.Point(951, 98);
            btnInputPanen.Name = "btnInputPanen";
            btnInputPanen.Size = new System.Drawing.Size(205, 40);
            btnInputPanen.TabIndex = 3;
            btnInputPanen.Text = "+  Input Data Panen";
            btnInputPanen.UseVisualStyleBackColor = false;
            // 
            // cardTotal
            // 
            cardTotal.BackColor = System.Drawing.Color.White;
            cardTotal.Controls.Add(lblTotalNote);
            cardTotal.Controls.Add(lblTotalValue);
            cardTotal.Controls.Add(lblTotalCaption);
            cardTotal.Location = new System.Drawing.Point(26, 142);
            cardTotal.Name = "cardTotal";
            cardTotal.Padding = new System.Windows.Forms.Padding(14, 12, 10, 8);
            cardTotal.Size = new System.Drawing.Size(260, 130);
            cardTotal.TabIndex = 4;
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.Dock = System.Windows.Forms.DockStyle.Top;
            lblTotalCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblTotalCaption.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblTotalCaption.Location = new System.Drawing.Point(14, 12);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new System.Drawing.Size(236, 24);
            lblTotalCaption.TabIndex = 0;
            lblTotalCaption.Text = "TOTAL TELUR TERDATA";
            // 
            // lblTotalValue
            // 
            lblTotalValue.Dock = System.Windows.Forms.DockStyle.Top;
            lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            lblTotalValue.Location = new System.Drawing.Point(14, 36);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new System.Drawing.Size(236, 48);
            lblTotalValue.TabIndex = 1;
            lblTotalValue.Text = "0";
            // 
            // lblTotalNote
            // 
            lblTotalNote.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTotalNote.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblTotalNote.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblTotalNote.Location = new System.Drawing.Point(14, 84);
            lblTotalNote.Name = "lblTotalNote";
            lblTotalNote.Size = new System.Drawing.Size(236, 38);
            lblTotalNote.TabIndex = 2;
            lblTotalNote.Text = "Butir tercatat di semua tanggal";
            // 
            // cardKualitas
            // 
            cardKualitas.BackColor = System.Drawing.Color.White;
            cardKualitas.Controls.Add(lblKualitasNote);
            cardKualitas.Controls.Add(lblKualitasValue);
            cardKualitas.Controls.Add(lblKualitasCaption);
            cardKualitas.Location = new System.Drawing.Point(298, 142);
            cardKualitas.Name = "cardKualitas";
            cardKualitas.Padding = new System.Windows.Forms.Padding(14, 12, 10, 8);
            cardKualitas.Size = new System.Drawing.Size(260, 130);
            cardKualitas.TabIndex = 5;
            // 
            // lblKualitasCaption
            // 
            lblKualitasCaption.Dock = System.Windows.Forms.DockStyle.Top;
            lblKualitasCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblKualitasCaption.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblKualitasCaption.Location = new System.Drawing.Point(14, 12);
            lblKualitasCaption.Name = "lblKualitasCaption";
            lblKualitasCaption.Size = new System.Drawing.Size(236, 24);
            lblKualitasCaption.TabIndex = 0;
            lblKualitasCaption.Text = "KUALITAS TELUR BAIK";
            // 
            // lblKualitasValue
            // 
            lblKualitasValue.Dock = System.Windows.Forms.DockStyle.Top;
            lblKualitasValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblKualitasValue.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            lblKualitasValue.Location = new System.Drawing.Point(14, 36);
            lblKualitasValue.Name = "lblKualitasValue";
            lblKualitasValue.Size = new System.Drawing.Size(236, 48);
            lblKualitasValue.TabIndex = 1;
            lblKualitasValue.Text = "—";
            // 
            // lblKualitasNote
            // 
            lblKualitasNote.Dock = System.Windows.Forms.DockStyle.Fill;
            lblKualitasNote.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblKualitasNote.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblKualitasNote.Location = new System.Drawing.Point(14, 84);
            lblKualitasNote.Name = "lblKualitasNote";
            lblKualitasNote.Size = new System.Drawing.Size(236, 38);
            lblKualitasNote.TabIndex = 2;
            lblKualitasNote.Text = "Telur baik ÷ total panen";
            // 
            // cardRataRata
            // 
            cardRataRata.BackColor = System.Drawing.Color.White;
            cardRataRata.Controls.Add(lblRataNote);
            cardRataRata.Controls.Add(lblRataValue);
            cardRataRata.Controls.Add(lblRataCaption);
            cardRataRata.Location = new System.Drawing.Point(570, 142);
            cardRataRata.Name = "cardRataRata";
            cardRataRata.Padding = new System.Windows.Forms.Padding(14, 12, 10, 8);
            cardRataRata.Size = new System.Drawing.Size(260, 130);
            cardRataRata.TabIndex = 6;
            // 
            // lblRataCaption
            // 
            lblRataCaption.Dock = System.Windows.Forms.DockStyle.Top;
            lblRataCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblRataCaption.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblRataCaption.Location = new System.Drawing.Point(14, 12);
            lblRataCaption.Name = "lblRataCaption";
            lblRataCaption.Size = new System.Drawing.Size(236, 24);
            lblRataCaption.TabIndex = 0;
            lblRataCaption.Text = "RATA-RATA PANEN";
            // 
            // lblRataValue
            // 
            lblRataValue.Dock = System.Windows.Forms.DockStyle.Top;
            lblRataValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblRataValue.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            lblRataValue.Location = new System.Drawing.Point(14, 36);
            lblRataValue.Name = "lblRataValue";
            lblRataValue.Size = new System.Drawing.Size(236, 48);
            lblRataValue.TabIndex = 1;
            lblRataValue.Text = "—";
            // 
            // lblRataNote
            // 
            lblRataNote.Dock = System.Windows.Forms.DockStyle.Fill;
            lblRataNote.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblRataNote.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblRataNote.Location = new System.Drawing.Point(14, 84);
            lblRataNote.Name = "lblRataNote";
            lblRataNote.Size = new System.Drawing.Size(236, 38);
            lblRataNote.TabIndex = 2;
            lblRataNote.Text = "Butir per hari pencatatan";
            // 
            // cardPrediksi
            // 
            cardPrediksi.BackColor = System.Drawing.Color.White;
            cardPrediksi.Controls.Add(lblPrediksiNote);
            cardPrediksi.Controls.Add(lblPrediksiValue);
            cardPrediksi.Controls.Add(lblPrediksiCaption);
            cardPrediksi.Location = new System.Drawing.Point(842, 142);
            cardPrediksi.Name = "cardPrediksi";
            cardPrediksi.Padding = new System.Windows.Forms.Padding(14, 12, 10, 8);
            cardPrediksi.Size = new System.Drawing.Size(260, 130);
            cardPrediksi.TabIndex = 7;
            // 
            // lblPrediksiCaption
            // 
            lblPrediksiCaption.Dock = System.Windows.Forms.DockStyle.Top;
            lblPrediksiCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblPrediksiCaption.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblPrediksiCaption.Location = new System.Drawing.Point(14, 12);
            lblPrediksiCaption.Name = "lblPrediksiCaption";
            lblPrediksiCaption.Size = new System.Drawing.Size(236, 24);
            lblPrediksiCaption.TabIndex = 0;
            lblPrediksiCaption.Text = "PERKIRAAN PANEN BERIKUTNYA";
            // 
            // lblPrediksiValue
            // 
            lblPrediksiValue.Dock = System.Windows.Forms.DockStyle.Top;
            lblPrediksiValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblPrediksiValue.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            lblPrediksiValue.Location = new System.Drawing.Point(14, 36);
            lblPrediksiValue.Name = "lblPrediksiValue";
            lblPrediksiValue.Size = new System.Drawing.Size(236, 48);
            lblPrediksiValue.TabIndex = 1;
            lblPrediksiValue.Text = "—";
            // 
            // lblPrediksiNote
            // 
            lblPrediksiNote.Dock = System.Windows.Forms.DockStyle.Fill;
            lblPrediksiNote.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblPrediksiNote.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblPrediksiNote.Location = new System.Drawing.Point(14, 84);
            lblPrediksiNote.Name = "lblPrediksiNote";
            lblPrediksiNote.Size = new System.Drawing.Size(236, 38);
            lblPrediksiNote.TabIndex = 2;
            lblPrediksiNote.Text = "Belum ada data panen";
            // 
            // lblTabelJudul
            // 
            lblTabelJudul.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTabelJudul.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            lblTabelJudul.Location = new System.Drawing.Point(28, 292);
            lblTabelJudul.Name = "lblTabelJudul";
            lblTabelJudul.Size = new System.Drawing.Size(600, 30);
            lblTabelJudul.TabIndex = 8;
            lblTabelJudul.Text = "▰  Riwayat Panen Terbaru";
            // 
            // lblTabelPetunjuk
            // 
            lblTabelPetunjuk.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            lblTabelPetunjuk.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblTabelPetunjuk.Location = new System.Drawing.Point(28, 324);
            lblTabelPetunjuk.Name = "lblTabelPetunjuk";
            lblTabelPetunjuk.Size = new System.Drawing.Size(900, 24);
            lblTabelPetunjuk.TabIndex = 9;
            lblTabelPetunjuk.Text = "Perkiraan untuk satu hari setelah tanggal panen, dihitung dari rata-rata hingga 3 catatan terakhir.";
            // 
            // dgvPanenTerbaru
            // 
            dgvPanenTerbaru.AllowUserToAddRows = false;
            dgvPanenTerbaru.AllowUserToDeleteRows = false;
            dgvPanenTerbaru.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvPanenTerbaru.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPanenTerbaru.BackgroundColor = System.Drawing.Color.White;
            dgvPanenTerbaru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvPanenTerbaru.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(231, 240, 250);
            dgvPanenTerbaru.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvPanenTerbaru.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            dgvPanenTerbaru.ColumnHeadersHeight = 38;
            dgvPanenTerbaru.EnableHeadersVisualStyles = false;
            dgvPanenTerbaru.GridColor = System.Drawing.Color.FromArgb(225, 232, 240);
            dgvPanenTerbaru.Location = new System.Drawing.Point(26, 354);
            dgvPanenTerbaru.Name = "dgvPanenTerbaru";
            dgvPanenTerbaru.ReadOnly = true;
            dgvPanenTerbaru.RowHeadersVisible = false;
            dgvPanenTerbaru.RowTemplate.Height = 34;
            dgvPanenTerbaru.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPanenTerbaru.Size = new System.Drawing.Size(1130, 310);
            dgvPanenTerbaru.TabIndex = 10;
            dgvPanenTerbaru.Columns.Add("Tanggal", "TANGGAL PANEN");
            dgvPanenTerbaru.Columns.Add("Total", "TOTAL");
            dgvPanenTerbaru.Columns.Add("Baik", "TELUR BAIK");
            dgvPanenTerbaru.Columns.Add("Rusak", "TELUR RUSAK");
            dgvPanenTerbaru.Columns.Add("Persen", "KUALITAS (%)");
            dgvPanenTerbaru.Columns.Add("TanggalPrediksi", "PREDIKSI TANGGAL");
            dgvPanenTerbaru.Columns.Add("Prediksi", "PERKIRAAN TELUR");
            dgvPanenTerbaru.Columns.Add("Keterangan", "KETERANGAN");
            // 
            // lblCatatanKaki
            // 
            lblCatatanKaki.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblCatatanKaki.ForeColor = System.Drawing.Color.FromArgb(105, 121, 139);
            lblCatatanKaki.Location = new System.Drawing.Point(28, 675);
            lblCatatanKaki.Name = "lblCatatanKaki";
            lblCatatanKaki.Size = new System.Drawing.Size(1050, 42);
            lblCatatanKaki.TabIndex = 11;
            lblCatatanKaki.Text = "Persentase kualitas menunjukkan bagian telur baik dari seluruh telur yang dicatat; angka prediksi hanya perkiraan berdasarkan riwayat.";
            // 
            // panelHalaman
            // 
            panelHalaman.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            panelHalaman.Controls.Add(panelHalamanKonten);
            panelHalaman.Controls.Add(btnKembali);
            panelHalaman.Controls.Add(lblHalaman);
            panelHalaman.Dock = System.Windows.Forms.DockStyle.Fill;
            panelHalaman.Location = new System.Drawing.Point(24, 18);
            panelHalaman.Name = "panelHalaman";
            panelHalaman.Size = new System.Drawing.Size(1156, 763);
            panelHalaman.TabIndex = 12;
            panelHalaman.Visible = false;
            // 
            // btnKembali
            // 
            btnKembali.BackColor = System.Drawing.Color.FromArgb(0, 111, 77);
            btnKembali.FlatAppearance.BorderSize = 0;
            btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnKembali.ForeColor = System.Drawing.Color.White;
            btnKembali.Location = new System.Drawing.Point(12, 10);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new System.Drawing.Size(130, 38);
            btnKembali.TabIndex = 0;
            btnKembali.Text = "← Dashboard";
            btnKembali.UseVisualStyleBackColor = false;
            // 
            // lblHalaman
            // 
            lblHalaman.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblHalaman.ForeColor = System.Drawing.Color.FromArgb(34, 49, 69);
            lblHalaman.Location = new System.Drawing.Point(160, 10);
            lblHalaman.Name = "lblHalaman";
            lblHalaman.Size = new System.Drawing.Size(850, 38);
            lblHalaman.TabIndex = 1;
            lblHalaman.Text = "Halaman";
            lblHalaman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelHalamanKonten
            // 
            panelHalamanKonten.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelHalamanKonten.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            panelHalamanKonten.Location = new System.Drawing.Point(0, 58);
            panelHalamanKonten.Name = "panelHalamanKonten";
            panelHalamanKonten.Size = new System.Drawing.Size(1156, 705);
            panelHalamanKonten.TabIndex = 2;
            // 
            // Beranda
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            ClientSize = new System.Drawing.Size(1424, 861);
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Controls.Add(contentPanel);
            Controls.Add(topbar);
            Controls.Add(sidebar);
            MinimumSize = new System.Drawing.Size(1120, 720);
            Name = "Beranda";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MONTERA | Dashboard";
            sidebar.ResumeLayout(false);
            topbar.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            panelHalaman.ResumeLayout(false);
            cardTotal.ResumeLayout(false);
            cardKualitas.ResumeLayout(false);
            cardRataRata.ResumeLayout(false);
            cardPrediksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPanenTerbaru).EndInit();
            ResumeLayout(false);
        }
    }
}
