using System;

namespace PROJEKKKK_PBOO.Models
{
    public enum StatusAyam
    {
        Baik,
        Sakit,
        Mati
    }

    public class DataAyam
    {
        public DateTime Tanggal { get; set; }
        public StatusAyam Status { get; set; }
        public int Jumlah { get; set; }
        public string Keterangan { get; set; } = string.Empty;
    }
}
