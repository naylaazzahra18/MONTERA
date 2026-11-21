using System.Drawing;
using System.Windows.Forms;

namespace PROJEKKKK_PBOO.View
{
    internal static class UiTheme
    {
        private static readonly Color Background = Color.FromArgb(245, 248, 252);
        private static readonly Color Green = Color.FromArgb(0, 111, 77);
        private static readonly Color Text = Color.FromArgb(34, 49, 69);

        public static void Apply(Form form)
        {
            form.BackColor = Background;
            form.ForeColor = Text;
            form.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            form.StartPosition = FormStartPosition.CenterScreen;

            switch (form.GetType().Name)
            {
                case "Login":
                    form.Text = "🐔 Kandang Pintar | Login";
                    break;
                case "MenuUtama":
                    form.Text = "🐔 Kandang Pintar | Beranda Owner";
                    break;
                case "BerandaKaryawan":
                    form.Text = "🐣 Kandang Pintar | Beranda Karyawan";
                    break;
                case "MonitoringPanen":
                    form.Text = "🥚 Kandang Pintar | Monitoring Panen";
                    break;
                case "PrediksiAyamSakit":
                    form.Text = "🐔 Kandang Pintar | Prediksi Kesehatan Ayam";
                    break;
                case "PrediksiTelur":
                    form.Text = "🥚 Kandang Pintar | Prediksi Telur";
                    break;
            }

            StyleControls(form.Controls);
        }

        private static void StyleControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button button)
                {
                    StyleButton(button);
                }
                else if (control is TextBox textBox)
                {
                    textBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                    textBox.BackColor = Color.White;
                    textBox.ForeColor = Text;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                    comboBox.BackColor = Color.White;
                    comboBox.ForeColor = Text;
                }
                else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                }
                else if (control is DataGridView grid)
                {
                    StyleGrid(grid);
                }
                else if (control is Label label)
                {
                    label.ForeColor = Text;
                    label.Font = new Font("Segoe UI", label.Font.Size, label.Font.Bold ? FontStyle.Bold : FontStyle.Regular);
                }
                else if (control is Panel panel)
                {
                    panel.BackColor = Color.White;
                }

                if (control.HasChildren)
                    StyleControls(control.Controls);
            }
        }

        private static void StyleButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.UseVisualStyleBackColor = false;
            button.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            button.ForeColor = Color.White;
            button.Cursor = Cursors.Hand;

            if (button.Name.IndexOf("Hapus", System.StringComparison.OrdinalIgnoreCase) >= 0)
            {
                button.BackColor = Color.FromArgb(179, 73, 65);
                AddIcon(button, "🗑 ");
            }
            else if (button.Name.IndexOf("Reset", System.StringComparison.OrdinalIgnoreCase) >= 0)
            {
                button.BackColor = Color.FromArgb(185, 132, 47);
                AddIcon(button, "↻ ");
            }
            else if (button.Name.IndexOf("Cari", System.StringComparison.OrdinalIgnoreCase) >= 0)
            {
                button.BackColor = Color.FromArgb(76, 128, 91);
                AddIcon(button, "🔎 ");
            }
            else if (button.Name.IndexOf("Keluar", System.StringComparison.OrdinalIgnoreCase) >= 0)
            {
                button.BackColor = Color.FromArgb(93, 105, 94);
                AddIcon(button, "↩ ");
            }
            else
            {
                button.BackColor = Green;
                if (button.Name.IndexOf("Simpan", System.StringComparison.OrdinalIgnoreCase) >= 0)
                    AddIcon(button, "💾 ");
                else if (button.Name.IndexOf("Login", System.StringComparison.OrdinalIgnoreCase) >= 0)
                    AddIcon(button, "🔐 ");
                else if (button.Name.IndexOf("Monitoring", System.StringComparison.OrdinalIgnoreCase) >= 0)
                    AddIcon(button, "🐔 ");
                else if (button.Name.IndexOf("Prediksi", System.StringComparison.OrdinalIgnoreCase) >= 0)
                    AddIcon(button, "📊 ");
            }
        }

        private static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.GridColor = Color.FromArgb(225, 231, 222);
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 240, 250);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Text;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Text;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(213, 232, 214);
            grid.DefaultCellStyle.SelectionForeColor = Text;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(246, 249, 244);
            grid.RowTemplate.Height = 30;
        }

        private static void AddIcon(Button button, string icon)
        {
            if (!button.Text.StartsWith(icon.Trim()))
                button.Text = icon + button.Text;
        }
    }
}
