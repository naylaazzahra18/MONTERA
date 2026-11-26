using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using PROJEKKKK_PBOO.Controller;
using PROJEKKKK_PBOO.Models;

namespace PROJEKKKK_PBOO.View
{
    public partial class MonitoringAyam : Form
    {
        private readonly AyamController _controller = new AyamController();

        public MonitoringAyam()
        {
            InitializeComponent();
            panelInput.Resize += (_, _) => AturLayoutInput();
            panelFilter.Resize += (_, _) => AturLayoutFilter();
            AturLayoutInput();
            AturLayoutFilter();
            MuatPilihanBulan();
            MuatTabel();
        }

        private void AturLayoutInput()
        {
            int lebar = panelInput.ClientSize.Width;
            txtKeterangan.Width = Math.Max(180, lebar - 590);
            btnSimpan.Left = lebar - 440;
            btnReset.Left = lebar - 270;
            btnHapus.Left = lebar - 130;
        }

        private void AturLayoutFilter()
        {
            int lebar = panelFilter.ClientSize.Width;
            const int margin = 20;
            const int jarak = 12;
            const int lebarLabelBulan = 100;
            const int lebarComboMinimum = 170;
            const int lebarComboMaksimum = 250;

            cmbFilterBulan.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            int lebarCombo = Math.Min(lebarComboMaksimum, Math.Max(lebarComboMinimum, lebar / 4));
            cmbFilterBulan.Width = lebarCombo;
            cmbFilterBulan.Left = lebar - margin - cmbFilterBulan.Width;

            lblFilterBulan.Width = lebarLabelBulan;
            lblFilterBulan.Left = cmbFilterBulan.Left - jarak - lblFilterBulan.Width;

            btnResetFilter.Left = lblFilterBulan.Left - 20 - btnResetFilter.Width;
            btnCari.Left = btnResetFilter.Left - jarak - btnCari.Width;

            txtCari.Left = margin;
            txtCari.Width = Math.Max(180, btnCari.Left - jarak - txtCari.Left);
        }

        private void MuatPilihanBulan()
        {
            cmbFilterBulan.Items.Clear();
            cmbFilterBulan.Items.Add("Semua Bulan");
            cmbFilterBulan.Items.AddRange(CultureInfo.CurrentCulture.DateTimeFormat.MonthNames
                .Take(12)
                .Cast<object>()
                .ToArray());
            cmbFilterBulan.SelectedIndex = 0;
        }

        private void MuatTabel()
        {
            List<DataAyam> seluruhData = _controller.AmbilSemuaData().ToList();
            IEnumerable<IGrouping<DateTime, DataAyam>> perTanggal = seluruhData
                .GroupBy(item => item.Tanggal.Date);

            if (cmbFilterBulan.SelectedIndex > 0)
            {
                int bulan = cmbFilterBulan.SelectedIndex;
                perTanggal = perTanggal.Where(grup => grup.Key.Month == bulan);
            }

            string kataKunci = txtCari.Text.Trim();
            if (kataKunci.Length > 0)
            {
                perTanggal = perTanggal.Where(grup =>
                    grup.Key.ToString("dd-MM-yyyy").Contains(kataKunci, StringComparison.OrdinalIgnoreCase) ||
                    grup.Any(item => item.Status.ToString().Contains(kataKunci, StringComparison.OrdinalIgnoreCase) ||
                        item.Keterangan.Contains(kataKunci, StringComparison.OrdinalIgnoreCase)));
            }

            List<IGrouping<DateTime, DataAyam>> hasil = perTanggal
                .OrderByDescending(grup => grup.Key)
                .ToList();
            dgvAyam.Rows.Clear();
            foreach (IGrouping<DateTime, DataAyam> grup in hasil)
            {
                int jumlahBaik = grup.Where(item => item.Status == StatusAyam.Baik).Sum(item => item.Jumlah);
                int jumlahSakit = grup.Where(item => item.Status == StatusAyam.Sakit).Sum(item => item.Jumlah);
                int jumlahMati = grup.Where(item => item.Status == StatusAyam.Mati).Sum(item => item.Jumlah);
                int totalHarian = jumlahBaik + jumlahSakit + jumlahMati;
                string keterangan = string.Join("; ", grup
                    .Select(item => item.Keterangan.Trim())
                    .Where(teks => teks.Length > 0)
                    .Distinct());

                int index = dgvAyam.Rows.Add(
                    grup.Key.ToString("dd-MM-yyyy"),
                    keterangan,
                    totalHarian.ToString("N0", CultureInfo.CurrentCulture),
                    jumlahSakit.ToString("N0", CultureInfo.CurrentCulture));
                dgvAyam.Rows[index].Tag = grup.Key;
            }

            int totalBaik = hasil.Sum(grup => grup.Where(item => item.Status == StatusAyam.Baik).Sum(item => item.Jumlah));
            int totalSakit = hasil.Sum(grup => grup.Where(item => item.Status == StatusAyam.Sakit).Sum(item => item.Jumlah));
            lblRingkasan.Text = $"{hasil.Count} tanggal  |  Jumlah Ayam: {totalBaik:N0}  |  Ayam sakit: {totalSakit:N0}";
        }

        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            string hasil = _controller.SimpanRekap(
                dtpTanggal.Value,
                true, txtJumlahBaik.Text.Trim(),
                true, txtJumlahSakit.Text.Trim(),
                false, string.Empty,
                txtKeterangan.Text);
            if (hasil.Length > 0)
            {
                MessageBox.Show(hasil, "Periksa Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Rekap kondisi ayam berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtJumlahBaik.Clear();
            txtJumlahSakit.Clear();
            txtKeterangan.Clear();
            MuatTabel();
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            txtJumlahBaik.Clear();
            txtJumlahSakit.Clear();
            txtKeterangan.Clear();
            dtpTanggal.Value = DateTime.Today;
            txtJumlahBaik.Focus();
        }

        private void btnHapus_Click(object? sender, EventArgs e)
        {
            if (dgvAyam.CurrentRow?.Tag is not DateTime tanggal)
            {
                MessageBox.Show("Pilih tanggal yang ingin dihapus.", "Monitoring Ayam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult konfirmasi = MessageBox.Show(
                $"Hapus seluruh rekap ayam tanggal {tanggal:dd-MM-yyyy}?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (konfirmasi != DialogResult.Yes)
                return;

            _controller.Hapus(tanggal, StatusAyam.Baik);
            _controller.Hapus(tanggal, StatusAyam.Sakit);
            _controller.Hapus(tanggal, StatusAyam.Mati);
            MuatTabel();
        }

        private void btnCari_Click(object? sender, EventArgs e) => MuatTabel();

        private void btnResetFilter_Click(object? sender, EventArgs e)
        {
            txtCari.Clear();
            cmbFilterBulan.SelectedIndex = 0;
            MuatTabel();
        }

        private void cmbFilterBulan_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (IsHandleCreated)
                MuatTabel();
        }

        private void txtJumlahBaik_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAyam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
