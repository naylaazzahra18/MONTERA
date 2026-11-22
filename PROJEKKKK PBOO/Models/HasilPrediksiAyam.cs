using System;

namespace PROJEKKKK_PBOO.Models
{
    public class HasilPrediksiAyam
    {
        public DateTime Tanggal { get; set; }
        public int JumlahAyamHidup { get; set; }
        public int JumlahAyamSakit { get; set; }
        public int JumlahAyamMati { get; set; }
        public double PersentaseSakit { get; set; }
        public string StatusTren { get; set; } = string.Empty;
    }
}
