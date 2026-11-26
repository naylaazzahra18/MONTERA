using System;
using System.Collections.Generic;
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
    public partial class Beranda : Form
    {
        private readonly bool _isOwner;
        private Form? _halamanAktif;
        private readonly PanenController _panenController = new PanenController();
        private readonly PrediksiService _prediksiService = new PrediksiService();

        public Beranda() : this(false)
        {
        }

        public Beranda(bool isOwner)
        {
            InitializeComponent();
            _isOwner = isOwner;
            TerapkanPeran();
            HubungkanAksi();
            MuatRingkasan();
        }

        private void TerapkanPeran()
        {
            lblAktor.Text = _isOwner
                ? "●  OWNER\n "
                : "●  KARYAWAN\n";
            lblJudul.Text = _isOwner
                ? "Dashboard Owner MONTERA"
                : "Dashboard Karyawan MONTERA";
            btnMonitoringAyam.Visible = true;
            btnPrediksiAyam.Visible = _isOwner;
            btnPrediksiTelur.Visible = _isOwner;
            Text = _isOwner
                ? "MONTERA | Dashboard Owner"
                : "MONTERA | Dashboard Karyawan";
            lblWaktu.Text = DateTime.Now.ToString("dd MMM yyyy  |  HH:mm", CultureInfo.GetCultureInfo("id-ID"));
        }

        private void HubungkanAksi()
        {
            btnKeluar.Click += (_, _) => Close();
            btnKembali.Click += (_, _) => TampilkanDashboard();
            btnInputPanen.Click += (_, _) => BukaMonitoringPanen();
            btnMonitoringPanen.Click += (_, _) => BukaMonitoringPanen();
            btnPrediksiTelur.Click += (_, _) => BukaPrediksiTelur();
            btnPrediksiAyam.Click += (_, _) => BukaPrediksiAyam();
            btnMonitoringAyam.Click += (_, _) => BukaMonitoringAyam();
            btnDashboard.Click += (_, _) => TampilkanDashboard();
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
            int rataHarian = jumlahHari == 0
                ? 0
                : (int)Math.Round((double)total / jumlahHari, MidpointRounding.AwayFromZero);
            CultureInfo lokal = CultureInfo.GetCultureInfo("id-ID");

            lblTotalValue.Text = total.ToString("N0", lokal);
            lblKualitasValue.Text = jumlahHari == 0 ? "—" : kualitas.ToString("F1", lokal) + "%";
            lblRataValue.Text = jumlahHari == 0 ? "—" : rataHarian.ToString("N0", lokal);

            if (prediksi.Count == 0)
            {
                lblPrediksiValue.Text = "—";
                lblPrediksiNote.Text = "Belum ada data panen";
                lblStatusData.Text = "Belum ada data. Mulai dengan mencatat panen pertama.";
            }
            else
            {
                HasilPrediksi terbaru = prediksi
                    .OrderByDescending(item => item.TanggalPanen)
                    .First();
                lblPrediksiValue.Text = terbaru.PerkiraanTelurBaik.ToString("N0", lokal);
                lblPrediksiNote.Text = "butir • " + terbaru.TanggalPrediksi.ToString("dd MMM yyyy", lokal);
                lblStatusData.Text = $"●  {jumlahHari} hari tercatat     •     {baik:N0} telur baik     •     {rusak:N0} telur rusak";
            }

            dgvPanenTerbaru.Rows.Clear();
            Dictionary<DateTime, HasilPrediksi> hasilPerTanggal = prediksi
                .ToDictionary(item => item.TanggalPanen.Date);
            foreach (DataPanen panen in data.Take(8))
            {
                hasilPerTanggal.TryGetValue(panen.Tanggal.Date, out HasilPrediksi? hasil);
                dgvPanenTerbaru.Rows.Add(
                    panen.Tanggal.ToString("dd MMM yyyy", lokal),
                    panen.JumlahTotal.ToString("N0", lokal),
                    panen.TelurBaik.ToString("N0", lokal),
                    panen.TelurRusak.ToString("N0", lokal),
                    panen.PersentaseBaik.ToString("F1", lokal) + "%",
                    hasil?.TanggalPrediksi.ToString("dd MMM yyyy", lokal) ?? "—",
                    hasil?.PerkiraanTelurBaik.ToString("N0", lokal) ?? "—",
                    panen.Keterangan);
            }
        }

        private void BukaMonitoringPanen()
        {
            TampilkanHalaman(new MonitoringPanen(), "Monitoring Panen");
        }

        private void BukaPrediksiAyam()
        {
            TampilkanHalaman(new PrediksiAyamSakit(), "Prediksi Kesehatan Ayam");
        }

        private void BukaMonitoringAyam()
        {
            TampilkanHalaman(new MonitoringAyam(), "Monitoring Ayam");
        }

        private void BukaPrediksiTelur()
        {
            TampilkanHalaman(new PrediksiTelur(), "Prediksi Produksi Telur");
        }

        private void TampilkanHalaman(Form halaman, string judul)
        {
            if (_halamanAktif != null)
            {
                panelHalamanKonten.Controls.Remove(_halamanAktif);
                _halamanAktif.Dispose();
            }

            _halamanAktif = halaman;
            halaman.TopLevel = false;
            halaman.FormBorderStyle = FormBorderStyle.None;
            halaman.WindowState = FormWindowState.Normal;
            halaman.MinimumSize = System.Drawing.Size.Empty;
            halaman.ShowInTaskbar = false;
            halaman.Dock = DockStyle.Fill;
            panelHalamanKonten.Controls.Add(halaman);
            lblHalaman.Text = judul;
            panelHalaman.Visible = true;
            panelHalaman.BringToFront();
            halaman.Show();
        }

        private void TampilkanDashboard()
        {
            if (_halamanAktif != null)
            {
                panelHalamanKonten.Controls.Remove(_halamanAktif);
                _halamanAktif.Dispose();
                _halamanAktif = null;
            }

            panelHalaman.Visible = false;
            MuatRingkasan();
        }

        private void lblLive_Click(object sender, EventArgs e)
        {

        }
    }
}
