using PROJEKKKK_PBOO.Controller;
using PROJEKKKK_PBOO.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace PROJEKKKK_PBOO.View
{
    public partial class Login : Form
    {
        LoginController controller = new LoginController();

        public Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;

            // Menghubungkan tombol
            btnLogin.Click += btnLogin_Click;

            // Fitur lihat password
            chkLihatPassword.CheckedChanged += chkLihatPassword_CheckedChanged;
        }

        // Tombol Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            PeranAkun? peran = controller.Autentikasi(user, pass);

            if (peran.HasValue)
            {
                MessageBox.Show("Login Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form beranda = new Beranda(peran.Value == PeranAkun.Owner);

                beranda.FormClosed += (_, _) =>
                {
                    Show();
                    txtPassword.Clear();
                    txtUsername.Focus();
                };
                beranda.Show();
                Hide();
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
