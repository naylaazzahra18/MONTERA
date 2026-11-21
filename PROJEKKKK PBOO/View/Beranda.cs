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
                ? "●  OWNER\n    Pengelola Kandang"
                : "●  KARYAWAN\n    Operasional Kandang";
            lblJudul.Text = _isOwner
                ? "Dashboard Owner MONTERA"
                : "Dashboard Karyawan MONTERA";
            btnMonitoringAyam.Visible = _isOwner;
            btnPrediksiAyam.Visible = _isOwner;
            Text = _isOwner
                ? "MONTERA | Dashboard Owner"
                : "MONTERA | Dashboard Karyawan";
            lblWaktu.Text = DateTime.Now.ToString("dd MMM yyyy  |  HH:mm", CultureInfo.GetCultureInfo("id-ID"));
        }

        private void HubungkanAksi()
        {
            btnKeluar.Click += (_, _) => Close();
            btnInputPanen.Click += (_, _) => BukaMonitoringPanen();
            btnMonitoringPanen.Click += (_, _) => BukaMonitoringPanen();
            btnPrediksiTelur.Click += (_, _) => BukaPrediksiTelur();
            btnPrediksiAyam.Click += (_, _) => BukaPrediksiAyam();
            btnMonitoringAyam.Click += (_, _) => MessageBox.Show(
                "Fitur Monitoring Ayam belum tersedia.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            btnDashboard.Click += (_, _) => MuatRingkasan();
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
            using MonitoringPanen form = new MonitoringPanen();
            form.ShowDialog(this);
            MuatRingkasan();
        }

        private void BukaPrediksiAyam()
        {
            using PrediksiAyamSakit form = new PrediksiAyamSakit();
            form.ShowDialog(this);
        }

        private void BukaPrediksiTelur()
        {
            using PrediksiTelur form = new PrediksiTelur();
            form.ShowDialog(this);
            MuatRingkasan();
        }
    }
}
