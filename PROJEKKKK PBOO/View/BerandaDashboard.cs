using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using PROJEKKKK_PBOO.Controller;
using PROJEKKKK_PBOO.Models;
using PROJEKKKK_PBOO.Services;
using PROJEKKKK_PBOO.PrediksiAyam;
using PROJEKKKK_PBOO.Prediksi_Telur;

namespace PROJEKKKK_PBOO.View
{
    public class BerandaDashboard : UserControl
    {
        private static readonly Color Canvas = Color.FromArgb(245, 248, 252);
        private static readonly Color Ink = Color.FromArgb(34, 49, 69);
        private static readonly Color Muted = Color.FromArgb(105, 121, 139);
        private static readonly Color Green = Color.FromArgb(0, 111, 77);
        private static readonly Color Line = Color.FromArgb(225, 232, 240);

        private readonly bool _isOwner;
        private readonly PanenController _panenController = new PanenController();
        private readonly PrediksiService _prediksiService = new PrediksiService();
        private readonly DataGridView _grid = new DataGridView();
        private readonly Label _statusData = new Label();
        private readonly Label _summaryTotal = new Label();
        private readonly Label _summaryQuality = new Label();
        private readonly Label _summaryDaily = new Label();
        private readonly Label _summaryForecast = new Label();
        private readonly Label _forecastDate = new Label();

        public BerandaDashboard(bool isOwner)
        {
            _isOwner = isOwner;
            Dock = DockStyle.Fill;
            BackColor = Canvas;
            BuildLayout();
            MuatRingkasan();
        }

        private void BuildLayout()
        {
            Panel sidebar = new Panel
            {
                Dock = DockStyle.Left,
                Width = 218,
                BackColor = Color.White,
                Padding = new Padding(14, 14, 12, 12)
            };
            Panel separator = new Panel
            {
                Dock = DockStyle.Left,
                Width = 1,
                BackColor = Line
            };

            Label brand = new Label
            {
                Dock = DockStyle.Top,
                Height = 68,
                Text = "🐔  MONTERA\n      MONITORING KANDANG",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Green,
                TextAlign = ContentAlignment.MiddleLeft
            };
            Label menuTitle = new Label
            {
                Dock = DockStyle.Top,
                Height = 38,
                Text = "MENU OPERASIONAL",
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = Muted,
                TextAlign = ContentAlignment.BottomLeft,
                Padding = new Padding(5, 0, 0, 6)
            };
            FlowLayoutPanel nav = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                Padding = new Padding(0, 8, 0, 0),
                BackColor = Color.White
            };

            nav.Controls.Add(BuatTombolNavigasi("▦   Dashboard", true, MuatRingkasan));
            nav.Controls.Add(BuatTombolNavigasi("♧   Monitoring Panen", false, BukaMonitoringPanen));
            if (_isOwner)
            {
                nav.Controls.Add(BuatTombolNavigasi("♟   Monitoring Ayam", false, () =>
                    MessageBox.Show("Fitur Monitoring Ayam belum tersedia.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)));
                nav.Controls.Add(BuatTombolNavigasi("↗   Prediksi Ayam", false, BukaPrediksiAyam));
            }
            nav.Controls.Add(BuatTombolNavigasi("◷   Prediksi Telur", false, BukaPrediksiTelur));

            Panel sidebarFooter = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 90,
                BackColor = Color.White
            };
            Panel footerLine = new Panel { Dock = DockStyle.Top, Height = 1, BackColor = Line };
            Label userLabel = new Label
            {
                Dock = DockStyle.Top,
                Height = 44,
                Text = _isOwner ? "●  OWNER\n    Pengelola Kandang" : "●  KARYAWAN\n    Operasional Kandang",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Ink,
                TextAlign = ContentAlignment.MiddleLeft
            };
            Button logout = new Button
            {
                Dock = DockStyle.Bottom,
                Height = 36,
                Text = "↩  Keluar / Ganti Akun",
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Muted,
                TextAlign = ContentAlignment.MiddleLeft,
                Cursor = Cursors.Hand
            };
            logout.FlatAppearance.BorderSize = 0;
            logout.Click += (_, _) => FindForm()?.Close();
            sidebarFooter.Controls.Add(logout);
            sidebarFooter.Controls.Add(userLabel);
            sidebarFooter.Controls.Add(footerLine);

            sidebar.Controls.Add(nav);
            sidebar.Controls.Add(menuTitle);
            sidebar.Controls.Add(brand);
            sidebar.Controls.Add(sidebarFooter);

            Panel main = new Panel { Dock = DockStyle.Fill, BackColor = Canvas };
            Panel topbar = BuildTopbar();
            Panel content = BuildContent();
            main.Controls.Add(content);
            main.Controls.Add(topbar);

            Controls.Add(main);
            Controls.Add(separator);
            Controls.Add(sidebar);
        }

        private Panel BuildTopbar()
        {
            Panel topbar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 58,
                BackColor = Color.White,
                Padding = new Padding(22, 0, 22, 0)
            };
            Label facility = new Label
            {
                Dock = DockStyle.Left,
                Width = 360,
                Text = "▣  FACILITY: Kandang Ayam - Layer Farm",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Ink,
                TextAlign = ContentAlignment.MiddleLeft
            };
            Label live = new Label
            {
                Dock = DockStyle.Right,
                Width = 150,
                Text = "●  DATA PANEN LIVE",
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = Green,
                TextAlign = ContentAlignment.MiddleRight
            };
            Label tanggal = new Label
            {
                Dock = DockStyle.Right,
                Width = 190,
                Text = DateTime.Now.ToString("dd MMM yyyy  |  HH:mm", CultureInfo.GetCultureInfo("id-ID")),
                Font = new Font("Segoe UI", 8F, FontStyle.Regular),
                ForeColor = Muted,
                TextAlign = ContentAlignment.MiddleRight
            };
            topbar.Controls.Add(live);
            topbar.Controls.Add(tanggal);
            topbar.Controls.Add(facility);
            return topbar;
        }

        private Panel BuildContent()
        {
            Panel content = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Canvas,
                Padding = new Padding(22, 18, 22, 22)
            };

            Label title = new Label
            {
                Location = new Point(24, 20),
                Size = new Size(600, 36),
                Text = _isOwner ? "Dashboard Owner MONTERA" : "Dashboard Karyawan MONTERA",
                Font = new Font("Segoe UI", 19F, FontStyle.Bold),
                ForeColor = Ink
            };
            Label subtitle = new Label
            {
                Location = new Point(26, 58),
                Size = new Size(780, 32),
                Text = "Sistem Monitoring dan Prediksi Tren Panen serta Jumlah Ayam Sakit.",
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Muted
            };
            _statusData.Location = new Point(26, 96);
            _statusData.Size = new Size(540, 28);
            _statusData.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _statusData.ForeColor = Green;

            Button btnInput = new Button
            {
                Name = "btnInputPanen",
                Text = "+  Input Data Panen",
                Location = new Point(0, 0),
                Size = new Size(190, 38),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = Green,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnInput.FlatAppearance.BorderSize = 0;
            btnInput.Click += (_, _) => BukaMonitoringPanen();
            Panel actionHost = new Panel
            {
                Location = new Point(0, 20),
                Size = new Size(215, 44),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = Canvas
            };
            actionHost.Controls.Add(btnInput);
            actionHost.Resize += (_, _) => btnInput.Location = new Point(actionHost.Width - btnInput.Width, 0);

            TableLayoutPanel cards = new TableLayoutPanel
            {
                Location = new Point(24, 136),
                Size = new Size(1000, 126),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                ColumnCount = 4,
                RowCount = 1,
                BackColor = Canvas,
                Margin = Padding.Empty
            };
            for (int i = 0; i < 4; i++)
                cards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            cards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            cards.Controls.Add(BuatKartu("TOTAL TELUR TERDATA", _summaryTotal, "Butir tercatat di semua tanggal"), 0, 0);
            cards.Controls.Add(BuatKartu("KUALITAS TELUR BAIK", _summaryQuality, "Telur baik ÷ total panen"), 1, 0);
            cards.Controls.Add(BuatKartu("RATA-RATA PANEN", _summaryDaily, "Telur per hari pencatatan"), 2, 0);
            cards.Controls.Add(BuatKartu("PERKIRAAN BERIKUTNYA", _summaryForecast, _forecastDate), 3, 0);

            Label tableTitle = new Label
            {
                Location = new Point(26, 282),
                Size = new Size(600, 30),
                Text = "▰  Riwayat Panen Terbaru",
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Ink
            };
            Label tableHint = new Label
            {
                Location = new Point(26, 312),
                Size = new Size(900, 24),
                Text = "Perkiraan untuk satu hari setelah tanggal panen, dihitung dari rata-rata hingga 3 catatan terakhir.",
                Font = new Font("Segoe UI", 8.5F),
                ForeColor = Muted
            };
            _grid.Location = new Point(24, 345);
            _grid.Size = new Size(1000, 280);
            _grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _grid.ReadOnly = true;
            _grid.AllowUserToAddRows = false;
            _grid.AllowUserToDeleteRows = false;
            _grid.RowHeadersVisible = false;
            _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _grid.BackgroundColor = Color.White;
            _grid.BorderStyle = BorderStyle.None;
            _grid.GridColor = Line;
            _grid.EnableHeadersVisualStyles = false;
            _grid.ColumnHeadersHeight = 38;
            _grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 240, 250);
            _grid.ColumnHeadersDefaultCellStyle.ForeColor = Ink;
            _grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            _grid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            _grid.DefaultCellStyle.ForeColor = Ink;
            _grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 237, 228);
            _grid.DefaultCellStyle.SelectionForeColor = Ink;
            _grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 253);
            _grid.RowTemplate.Height = 34;
            _grid.Columns.Add("Tanggal", "TANGGAL PANEN");
            _grid.Columns.Add("Total", "TOTAL");
            _grid.Columns.Add("Baik", "TELUR BAIK");
            _grid.Columns.Add("Rusak", "TELUR RUSAK");
            _grid.Columns.Add("Persen", "KUALITAS (%)");
            _grid.Columns.Add("TanggalPrediksi", "PREDIKSI TANGGAL");
            _grid.Columns.Add("Prediksi", "PERKIRAAN TELUR");
            _grid.Columns.Add("Keterangan", "KETERANGAN");
            _grid.Columns[0].FillWeight = 100;
            _grid.Columns[1].FillWeight = 72;
            _grid.Columns[2].FillWeight = 76;
            _grid.Columns[3].FillWeight = 76;
            _grid.Columns[4].FillWeight = 83;
            _grid.Columns[5].FillWeight = 112;
            _grid.Columns[6].FillWeight = 100;
            _grid.Columns[7].FillWeight = 115;

            Label footnote = new Label
            {
                Location = new Point(26, 636),
                Size = new Size(900, 24),
                Text = "Persentase kualitas menunjukkan bagian telur baik dari seluruh telur yang dicatat; angka prediksi hanya perkiraan berdasarkan riwayat.",
                Font = new Font("Segoe UI", 8F),
                ForeColor = Muted
            };

            content.Controls.Add(title);
            content.Controls.Add(subtitle);
            content.Controls.Add(_statusData);
            content.Controls.Add(actionHost);
            content.Controls.Add(cards);
            content.Controls.Add(tableTitle);
            content.Controls.Add(tableHint);
            content.Controls.Add(_grid);
            content.Controls.Add(footnote);
            content.Resize += (_, _) =>
            {
                int width = Math.Max(600, content.ClientSize.Width - 48);
                cards.Width = width;
                _grid.Width = width;
                actionHost.Location = new Point(Math.Max(24, width - actionHost.Width + 24), 20);
            };
            return content;
        }

        private static Panel BuatKartu(string judul, Label nilai, string keterangan)
        {
            Label note = new Label
            {
                Text = keterangan,
                Font = new Font("Segoe UI", 8F),
                ForeColor = Muted
            };
            return BuatKartu(judul, nilai, note);
        }

        private static Panel BuatKartu(string judul, Label nilai, Label note)
        {
            Panel card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 12, 0),
                Padding = new Padding(14, 12, 10, 8)
            };
            Panel accent = new Panel { Dock = DockStyle.Top, Height = 3, BackColor = Green };
            Label heading = new Label
            {
                Dock = DockStyle.Top,
                Height = 24,
                Text = judul,
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                ForeColor = Muted
            };
            nilai.Dock = DockStyle.Top;
            nilai.Height = 43;
            nilai.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nilai.ForeColor = Ink;
            note.Dock = DockStyle.Fill;
            card.Controls.Add(note);
            card.Controls.Add(nilai);
            card.Controls.Add(heading);
            card.Controls.Add(accent);
            return card;
        }

        private static Button BuatTombolNavigasi(string text, bool selected, Action action)
        {
            Button button = new Button
            {
                Text = text,
                Width = 184,
                Height = 42,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0),
                BackColor = selected ? Green : Color.White,
                ForeColor = selected ? Color.White : Ink,
                Font = new Font("Segoe UI", 9F, selected ? FontStyle.Bold : FontStyle.Regular),
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 2, 0, 2)
            };
            button.FlatAppearance.BorderSize = 0;
            button.Click += (_, _) => action();
            return button;
        }

        private void MuatRingkasan()
        {
            List<DataPanen> data = _panenController.AmbilSemuaData()
                .OrderByDescending(item => item.Tanggal)
                .ToList();
            List<HasilPrediksi> prediksi = _prediksiService.BuatRiwayatPrediksi(data);
            int jumlahHari = data.Count;
            int total = data.Sum(item => item.JumlahTotal);
            int baik = data.Sum(item => item.TelurBaik);
            int rusak = data.Sum(item => item.TelurRusak);
            double kualitas = total == 0 ? 0 : (double)baik / total * 100;
            int rataHarian = jumlahHari == 0 ? 0 : (int)Math.Round((double)total / jumlahHari, MidpointRounding.AwayFromZero);

            _summaryTotal.Text = total.ToString("N0", CultureInfo.GetCultureInfo("id-ID"));
            _summaryQuality.Text = jumlahHari == 0 ? "—" : kualitas.ToString("F1", CultureInfo.GetCultureInfo("id-ID")) + "%";
            _summaryDaily.Text = jumlahHari == 0 ? "—" : rataHarian.ToString("N0", CultureInfo.GetCultureInfo("id-ID"));

            if (prediksi.Count == 0)
            {
                _summaryForecast.Text = "—";
                _forecastDate.Text = "Belum ada data panen";
                _statusData.Text = "Belum ada data. Mulai dengan mencatat panen pertama.";
            }
            else
            {
                HasilPrediksi terbaru = prediksi
                    .OrderByDescending(item => item.TanggalPanen)
                    .First();
                _summaryForecast.Text = terbaru.PerkiraanTelurBaik.ToString("N0", CultureInfo.GetCultureInfo("id-ID"));
                _forecastDate.Text = "butir • " + terbaru.TanggalPrediksi.ToString("dd MMM yyyy", CultureInfo.GetCultureInfo("id-ID"));
                _statusData.Text = $"●  {jumlahHari} hari tercatat     •     {baik:N0} telur baik     •     {rusak:N0} telur rusak";
            }

            _grid.Rows.Clear();
            Dictionary<DateTime, HasilPrediksi> lookup = prediksi.ToDictionary(item => item.TanggalPanen.Date);
            foreach (DataPanen panen in data.Take(8))
            {
                lookup.TryGetValue(panen.Tanggal.Date, out HasilPrediksi? hasil);
                _grid.Rows.Add(
                    panen.Tanggal.ToString("dd MMM yyyy", CultureInfo.GetCultureInfo("id-ID")),
                    panen.JumlahTotal.ToString("N0", CultureInfo.GetCultureInfo("id-ID")),
                    panen.TelurBaik.ToString("N0", CultureInfo.GetCultureInfo("id-ID")),
                    panen.TelurRusak.ToString("N0", CultureInfo.GetCultureInfo("id-ID")),
                    panen.PersentaseBaik.ToString("F1", CultureInfo.GetCultureInfo("id-ID")) + "%",
                    hasil?.TanggalPrediksi.ToString("dd MMM yyyy", CultureInfo.GetCultureInfo("id-ID")) ?? "—",
                    hasil?.PerkiraanTelurBaik.ToString("N0", CultureInfo.GetCultureInfo("id-ID")) ?? "—",
                    panen.Keterangan);
            }
        }

        private void BukaMonitoringPanen()
        {
            using MonitoringPanen form = new MonitoringPanen();
            form.ShowDialog(FindForm());
            MuatRingkasan();
        }

        private void BukaPrediksiAyam()
        {
            using PrediksiAyamSakit form = new PrediksiAyamSakit();
            form.ShowDialog(FindForm());
        }

        private void BukaPrediksiTelur()
        {
            using PrediksiTelur form = new PrediksiTelur();
            form.ShowDialog(FindForm());
            MuatRingkasan();
        }
    }
}
