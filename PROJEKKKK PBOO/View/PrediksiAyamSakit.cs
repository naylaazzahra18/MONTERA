using System.Globalization;
using System.Windows.Forms;
using PROJEKKKK_PBOO.Controller;
using PROJEKKKK_PBOO.Models;

namespace PROJEKKKK_PBOO.PrediksiAyam
{
    public partial class PrediksiAyamSakit : Form
    {
        private readonly PrediksiAyamController _controller = new PrediksiAyamController();

        public PrediksiAyamSakit()
        {
            InitializeComponent();
            panelInput.Resize += (_, _) => AturLayoutPanelInput();
            AturLayoutPanelInput();
            MuatRiwayatMonitoring();
        }

        private void AturLayoutPanelInput()
        {
            int lebarTeks = Math.Max(100, panelInput.ClientSize.Width - btnMuatUlang.Width - 60);
            lblSumberData.Width = lebarTeks;
            lblRingkasan.Width = lebarTeks;
            btnMuatUlang.Left = panelInput.ClientSize.Width - btnMuatUlang.Width - 20;
        }

        private void btnMuatUlang_Click(object? sender, System.EventArgs e)
        {
            MuatRiwayatMonitoring();
        }

        private void MuatRiwayatMonitoring()
        {
            IReadOnlyList<HasilPrediksiAyam> hasil = _controller.AmbilRiwayatPrediksi();
            dgvHasil.Rows.Clear();

            foreach (HasilPrediksiAyam data in hasil.OrderByDescending(item => item.Tanggal))
            {
                dgvHasil.Rows.Add(
                    data.Tanggal.ToString("dd/MM/yyyy", CultureInfo.CurrentCulture),
                    data.JumlahAyamHidup.ToString("N0", CultureInfo.CurrentCulture),
                    data.JumlahAyamSakit.ToString("N0", CultureInfo.CurrentCulture),
                    data.JumlahAyamMati.ToString("N0", CultureInfo.CurrentCulture),
                    data.PersentaseSakit.ToString("F2", CultureInfo.CurrentCulture) + "%",
                    data.StatusTren);
            }

            if (hasil.Count == 0)
            {
                lblRingkasan.Text = "Belum ada data. Tambahkan catatan pada menu Monitoring Ayam.";
                return;
            }

            HasilPrediksiAyam terbaru = hasil[hasil.Count - 1];
            lblRingkasan.Text = $"Data terbaru {terbaru.Tanggal.ToString("dd MMM yyyy", CultureInfo.GetCultureInfo("id-ID"))}  |  " +
                $"Ayam sakit {terbaru.PersentaseSakit:F2}% dari ayam hidup  |  Tren: {terbaru.StatusTren}.";
        }
    }
}
