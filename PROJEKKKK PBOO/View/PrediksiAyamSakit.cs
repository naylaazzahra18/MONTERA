using PROJEKKKK_PBOO.Controller;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace PROJEKKKK_PBOO.PrediksiAyam
{
    public partial class PrediksiAyamSakit : Form
    {
        private readonly PrediksiAyamController _controller = new PrediksiAyamController();

        public PrediksiAyamSakit()
        {
            InitializeComponent();
            // Menghubungkan tombol
            btnSimpan.Click += btnSimpan_Click;
            btnReset.Click += btnReset_Click;
            btnHapus.Click += btnHapus_Click;
        }

        // TOMBOL SIMPAN
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DateTime tanggal;
            int jumlahAyam, ayamSakit;

            if (!DateTime.TryParseExact(
                txtTanggal.Text, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out tanggal))
            {
                MessageBox.Show("Format tanggal harus dd/MM/yyyy!");
                return;
            }

            if (!int.TryParse(txtJumlahAyam.Text, out jumlahAyam) ||
                !int.TryParse(txtAyamSakit.Text, out ayamSakit))
            {
                MessageBox.Show("Masukkan jumlah ayam dengan benar!");
                return;
            }

            try
            {
                bool dataAwal = dgvHasil.Rows.Count == 0;
                double sebelumnya = dataAwal
                    ? 0
                    : Convert.ToDouble(dgvHasil.Rows[dgvHasil.Rows.Count - 1].Cells[3].Value);
                string status = _controller.HitungPrediksi(
                    jumlahAyam,
                    ayamSakit,
                    sebelumnya,
                    dataAwal,
                    out double persentase);

                dgvHasil.Rows.Add(
                    tanggal.ToString("dd/MM/yyyy"),
                    jumlahAyam,
                    ayamSakit,
                    persentase,
                    status);

                MessageBox.Show("Data berhasil disimpan!");

                txtTanggal.Clear();
                txtJumlahAyam.Clear();
                txtAyamSakit.Clear();
                txtTanggal.Focus();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // TOMBOL RESET
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTanggal.Clear();
            txtJumlahAyam.Clear();
            txtAyamSakit.Clear();
            txtTanggal.Focus();
        }
        // TOMBOL HAPUS
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvHasil.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus!");
                return;
            }
            foreach (DataGridViewRow row in dgvHasil.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dgvHasil.Rows.Remove(row);
                }
            }
            MessageBox.Show("Data berhasil dihapus!");
        }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void txtTanggal_TextChanged(object sender, EventArgs e) { }
    }
}
