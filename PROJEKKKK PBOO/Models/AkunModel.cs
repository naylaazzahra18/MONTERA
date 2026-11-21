
namespace PROJEKKKK_PBOO.Models
{
    public enum PeranAkun
    {
        Owner,
        Karyawan
    }

    public class AkunModel
    {
        public PeranAkun? Autentikasi(string username, string password)
        {
            if (username == "owner" && password == "owner123")
                return PeranAkun.Owner;

            if (username == "karyawan" && password == "karyawan123")
                return PeranAkun.Karyawan;

            return null;
        }

        public bool ValidasiLogin(string username, string password)
        {
            return Autentikasi(username, password).HasValue;
        }
    }
}
