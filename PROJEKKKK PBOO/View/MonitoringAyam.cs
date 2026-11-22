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
            chkBaik.Checked = true;
            AturInputJumlah();
            MuatPilihanBulan();
            MuatTabel();
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

        private void chkStatus_CheckedChanged(object? sender, EventArgs e)
        {
            AturInputJumlah();
        }

        private void AturInputJumlah()
        {
            txtJumlahBaik.Enabled = chkBaik.Checked;
            txtJumlahSakit.Enabled = chkSakit.Checked;
            txtJumlahMati.Enabled = chkMati.Checked;

            if (!chkBaik.Checked) txtJumlahBaik.Clear();
            if (!chkSakit.Checked) txtJumlahSakit.Clear();
            if (!chkMati.Checked) txtJumlahMati.Clear();
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
                    jumlahBaik.ToString("N0", CultureInfo.CurrentCulture),
                    jumlahSakit.ToString("N0", CultureInfo.CurrentCulture),
                    jumlahMati.ToString("N0", CultureInfo.CurrentCulture),
                    totalHarian.ToString("N0", CultureInfo.CurrentCulture),
                    keterangan);
                dgvAyam.Rows[index].Tag = grup.Key;
            }

            int totalBaik = hasil.Sum(grup => grup.Where(item => item.Status == StatusAyam.Baik).Sum(item => item.Jumlah));
            int totalSakit = hasil.Sum(grup => grup.Where(item => item.Status == StatusAyam.Sakit).Sum(item => item.Jumlah));
            int totalMati = hasil.Sum(grup => grup.Where(item => item.Status == StatusAyam.Mati).Sum(item => item.Jumlah));
            lblRingkasan.Text = $"{hasil.Count} tanggal  |  Ayam baik: {totalBaik:N0}  |  Ayam sakit: {totalSakit:N0}  |  Ayam mati: {totalMati:N0}";
        }

        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            string hasil = _controller.SimpanRekap(
                dtpTanggal.Value,
                chkBaik.Checked, txtJumlahBaik.Text.Trim(),
                chkSakit.Checked, txtJumlahSakit.Text.Trim(),
                chkMati.Checked, txtJumlahMati.Text.Trim(),
                txtKeterangan.Text);
            if (hasil.Length > 0)
            {
                MessageBox.Show(hasil, "Periksa Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Rekap kondisi ayam berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtJumlahBaik.Clear();
            txtJumlahSakit.Clear();
            txtJumlahMati.Clear();
            txtKeterangan.Clear();
            chkBaik.Checked = true;
            chkSakit.Checked = false;
            chkMati.Checked = false;
            AturInputJumlah();
            MuatTabel();
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            txtJumlahBaik.Clear();
            txtJumlahSakit.Clear();
            txtJumlahMati.Clear();
            txtKeterangan.Clear();
            chkBaik.Checked = true;
            chkSakit.Checked = false;
            chkMati.Checked = false;
            AturInputJumlah();
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
    }
}
