using PROJEKKKK_PBOO.Controller;
using PROJEKKKK_PBOO.Models;
using System;
using System.Windows.Forms;
namespace PROJEKKKK_PBOO.View
{
    public partial class Login : Form
    {
        LoginController controller = new LoginController();

        public Login()
        {
            InitializeComponent();

            // Mengatur tampilan
            panelLogin.SendToBack();
            txtPassword.UseSystemPasswordChar = true;

            // Menghubungkan tombol
            btnLogin.Click += btnLogin_Click;

            // Fitur lihat password
            chkLihatPassword.CheckedChanged += chkLihatPassword_CheckedChanged;
        }

        // Tombol Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Ambil input dari TextBox (pastikan nama TextBox-nya benar)
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();

            // 2. Panggil AkunModel
            AkunModel akun = new AkunModel();
            bool isValid = akun.ValidasiLogin(user, pass);

            // 3. Cek hasilnya
            if (isValid)
            {
                MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Buka Menu Utama
                MenuUtama menu = new MenuUtama();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password Salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lihat Password
        private void chkLihatPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !chkLihatPassword.Checked;
        }

        // Event bawaan Designer
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
