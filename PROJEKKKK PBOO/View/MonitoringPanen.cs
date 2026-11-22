using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PROJEKKKK_PBOO.Controller;
using PROJEKKKK_PBOO.Models;
using System.Linq; // Untuk fitur LINQ / pencarian

namespace PROJEKKKK_PBOO.View
{
    public partial class MonitoringPanen : Form
    {
        private readonly PanenController _controller;

        public MonitoringPanen()
        {
            InitializeComponent();
            _controller = new PanenController();
            panelInput.Resize += (_, _) => AturLayoutInput();
            panelFilter.Resize += (_, _) => AturLayoutFilter();
            AturLayoutInput();
            AturLayoutFilter();
        }

        private void AturLayoutInput()
        {
            int lebar = panelInput.ClientSize.Width;
            txtKeterangan.Width = Math.Max(180, lebar - txtKeterangan.Left - 20);
            btnSimpan.Left = lebar - 454;
            btnHapus.Left = lebar - 280;
        }

        private void AturLayoutFilter()
        {
            int lebar = panelFilter.ClientSize.Width;
            txtCari.Width = Math.Min(260, Math.Max(120, lebar - 680));
            btnCari.Left = txtCari.Right + 10;
            btnReset.Left = btnCari.Right + 10;
            label9.Left = btnReset.Right + 12;
            cmbFilterBulan.Left = label9.Right + 10;
            cmbFilterBulan.Width = Math.Max(120, lebar - cmbFilterBulan.Left - 20);
        }

        // 1. Berjalan otomatis saat form pertama kali dibuka
        private void MonitoringPanen_Load(object sender, EventArgs e)
        {
            dtpTanggal.Value = DateTime.Today;

            // --- INISIALISASI COMBOBOX FILTER BULAN ---
            cmbFilterBulan.Items.Clear();
            cmbFilterBulan.Items.Add("Semua Bulan");

            // Mengambil nama-nama bulan dari sistem (Januari, Februari, dll)
            string[] namaBulan = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            for (int i = 0; i < 12; i++)
            {
                cmbFilterBulan.Items.Add(namaBulan[i]);
            }

            // Set default ke "Semua Bulan" (index 0)
            cmbFilterBulan.SelectedIndex = 0;
            // ------------------------------------------

            MuatTabel();
        }

        // 2. Fungsi utama untuk mengambil data dan menampilkan ke tabel
        private void MuatTabel()
        {
            List<DataPanen> data = _controller.AmbilSemuaData();
            TampilkanKeTabel(data);
            HitungTotalKeseluruhan(data);
        }

        // Fungsi bantuan untuk menampilkan List data ke DataGridView
        private void TampilkanKeTabel(List<DataPanen> data)
        {
            dgvPanen.Rows.Clear();

            // Mengisi data ke tabel
            foreach (DataPanen d in data)
            {
                dgvPanen.Rows.Add(
                    d.Tanggal.ToString("dd-MM-yyyy"),
                    d.JumlahTotal,
                    d.TelurBaik,
                    d.TelurRusak,
                    d.PersentaseBaik.ToString("F2") + " %",
                    d.Keterangan);
            }
        }

        // Fungsi untuk menghitung total keseluruhan
        private void HitungTotalKeseluruhan(List<DataPanen> data)
        {
            if (data.Count == 0)
            {
                lblTotal.Text = "Belum ada data panen.";
                return;
            }

            int totalTelur = data.Sum(d => d.JumlahTotal);
            int totalBaik = data.Sum(d => d.TelurBaik);
            double rataRataPersen = totalTelur == 0 ? 0 : (double)totalBaik / totalTelur * 100;

            lblTotal.Text = $"Total Data: {data.Count} Hari  |  Total Telur: {totalTelur:N0} Butir  |  Telur Baik: {totalBaik:N0} Butir ({rataRataPersen:F2}%)";
        }

        // 3. Event tombol Simpan Data
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string error = _controller.Simpan(
                dtpTanggal.Value,
                txtTotal.Text.Trim(),
                txtBaik.Text.Trim(),
                txtRusak.Text.Trim(),
                txtKeterangan.Text.Trim());

            if (error != "")
            {
                MessageBox.Show(error, "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Data panen berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTotal.Clear();
            txtBaik.Clear();
            txtRusak.Clear();
            txtKeterangan.Clear();

            MuatTabel(); // Refresh tabel
        }

        // 4. Event tombol Hapus (Dengan Konfirmasi)
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvPanen.CurrentRow == null) return;

            DialogResult dialog = MessageBox.Show("Apakah kamu yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                DateTime tgl = DateTime.ParseExact(
                    dgvPanen.CurrentRow.Cells[0].Value.ToString(),
                    "dd-MM-yyyy", null);

                _controller.Hapus(tgl);
                MuatTabel(); // Refresh tabel
            }
        }

        // 5. Event tombol Cari
        private void btnCari_Click(object sender, EventArgs e)
        {
            string kataKunci = txtCari.Text.Trim().ToLower();

            if (kataKunci == "")
            {
                MuatTabel();
                return;
            }

            List<DataPanen> semuaData = _controller.AmbilSemuaData();
            List<DataPanen> dataHasilCari = new List<DataPanen>();

            foreach (DataPanen d in semuaData)
            {
                string tanggalStr = d.Tanggal.ToString("dd-MM-yyyy");
                string keteranganStr = d.Keterangan.ToLower();

                if (tanggalStr.Contains(kataKunci) || keteranganStr.Contains(kataKunci))
                {
                    dataHasilCari.Add(d);
                }
            }

            TampilkanKeTabel(dataHasilCari);
            HitungTotalKeseluruhan(dataHasilCari);

            if (dataHasilCari.Count == 0)
            {
                MessageBox.Show("Data dengan kata kunci '" + kataKunci + "' tidak ditemukan.", "Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 6. Event tombol Reset Pencarian
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
            cmbFilterBulan.SelectedIndex = 0; // Kembalikan filter bulan ke "Semua Bulan"
            MuatTabel(); // Tampilkan semua data lagi
        }

        // 7. Event saat Filter Bulan diubah-ubah
        private void cmbFilterBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Jika belum ada data atau index 0 (Semua Bulan) dipilih, tampilkan semua
            if (cmbFilterBulan.SelectedIndex <= 0)
            {
                MuatTabel();
                return;
            }

            // Ambil nomor bulan (1 = Januari, 2 = Februari, dst)
            // Karena index 0 adalah "Semua Bulan", kita kurangi 1.
            int bulanDipilih = cmbFilterBulan.SelectedIndex;

            List<DataPanen> semuaData = _controller.AmbilSemuaData();
            List<DataPanen> dataTerfilter = new List<DataPanen>();

            // Saring data
            foreach (DataPanen d in semuaData)
            {
                if (d.Tanggal.Month == bulanDipilih)
                {
                    dataTerfilter.Add(d);
                }
            }

            TampilkanKeTabel(dataTerfilter);
            HitungTotalKeseluruhan(dataTerfilter);
        }
    }
}