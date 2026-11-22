using PROJEKKKK_PBOO.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROJEKKKK_PBOO
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
            Text = "MONTERA | Menu Operasional";
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnMonitoringAyam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form Monitoring Ayam belum dibuat");
        }

        private void btnMonitoringTelur_Click(object sender, EventArgs e)
        {
            // Membuka form sebagai jendela baru
            MonitoringPanen form = new MonitoringPanen();
            form.ShowDialog();
        }

        private void btnPrediksiAyam_Click(object sender, EventArgs e)
        {
            new PROJEKKKK_PBOO.PrediksiAyam.PrediksiAyamSakit().Show();
        }

        private void btnPrediksiTelur_Click(object sender, EventArgs e)
        {
            new PROJEKKKK_PBOO.Prediksi_Telur.PrediksiTelur().Show();
        }
    }
}