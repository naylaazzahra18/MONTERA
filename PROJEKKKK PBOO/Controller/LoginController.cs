using PROJEKKKK_PBOO.Models;

namespace PROJEKKKK_PBOO.Controller
{
    public class LoginController
    {
        private readonly AkunModel _akunModel = new AkunModel();

        public PeranAkun? Autentikasi(string username, string password)
        {
            return _akunModel.Autentikasi(username, password);
        }

        public bool ProsesLogin(string username, string password)
        {
            return Autentikasi(username, password).HasValue;
        }
    }
}
