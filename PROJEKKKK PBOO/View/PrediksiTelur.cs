using System;
using System.Globalization;
using System.Windows.Forms;
using PROJEKKKK_PBOO.Controller;
using PROJEKKKK_PBOO.Models;

namespace PROJEKKKK_PBOO.Prediksi_Telur
{
    public partial class PrediksiTelur : Form
    {
        private readonly PrediksiTelurController _controller;

        public PrediksiTelur()
        {
            InitializeComponent();
            _controller = new PrediksiTelurController();
            MuatDataPrediksi();
        }

        private void btnMuatUlang_Click(object sender, EventArgs e)
        {
            MuatDataPrediksi();
        }

        private void MuatDataPrediksi()
        {
            var hasil = _controller.AmbilRiwayatPrediksi();
            dgvPanen.Rows.Clear();

            foreach (HasilPrediksi prediksi in hasil)
            {
                dgvPanen.Rows.Add(
                    prediksi.TanggalPanen.ToString("dd/MM/yyyy", CultureInfo.CurrentCulture),
                    prediksi.TelurBaikAktual.ToString("N0", CultureInfo.CurrentCulture),
                    prediksi.PersentaseTelurBaik.ToString("F1", CultureInfo.CurrentCulture) + "%",
                    prediksi.TanggalPrediksi.ToString("dd/MM/yyyy", CultureInfo.CurrentCulture),
                    prediksi.PerkiraanTelurBaik.ToString("N0", CultureInfo.CurrentCulture));
            }

            if (hasil.Count == 0)
            {
                lblRingkasan.Text = "Belum ada data panen. Tambahkan data di Monitoring Panen, lalu pilih Muat Ulang Data.";
                return;
            }

            HasilPrediksi prediksiTerbaru = hasil[hasil.Count - 1];
            lblRingkasan.Text = $"Prediksi berikutnya: {prediksiTerbaru.TanggalPrediksi.ToString("dddd, dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID"))}  |  " +
                $"sekitar {prediksiTerbaru.PerkiraanTelurBaik:N0} butir telur baik. " +
                $"Dihitung dari {prediksiTerbaru.JumlahDataAcuan} catatan panen terbaru.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dgvPanen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
