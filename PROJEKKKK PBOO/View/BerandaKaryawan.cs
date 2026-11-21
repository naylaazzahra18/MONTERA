using System.Drawing;
using System.Windows.Forms;

namespace PROJEKKKK_PBOO.View
{
    public class BerandaKaryawan : Form
    {
        public BerandaKaryawan()
        {
            Text = "MONTERA: Sistem Monitoring dan Prediksi Tren Panen serta Jumlah Ayam Sakit | Karyawan";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1440, 900);
            MinimumSize = new Size(1120, 720);
            BackColor = Color.FromArgb(245, 248, 252);
            Controls.Add(new BerandaDashboard(isOwner: false));
        }
    }
}
