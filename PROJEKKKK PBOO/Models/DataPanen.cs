using System;

namespace PROJEKKKK_PBOO.Models
{
    public class DataPanen
    {
        // Properti untuk form desain barumu
        public DateTime Tanggal { get; set; }
        public int JumlahTotal { get; set; }
        public int TelurBaik { get; set; }
        public int TelurRusak { get; set; }
        public string Keterangan { get; set; }

        // --- TAMBAHAN UNTUK LAPORAN: Perhitungan Persentase Otomatis ---
        public double PersentaseBaik
        {
            get
            {
                if (JumlahTotal == 0) return 0;
                return ((double)TelurBaik / JumlahTotal) * 100;
            }
        }
        // ---------------------------------------------------------------

        // Properti lama (untuk kebutuhan prediksi)
        public int AyamProduktif { get; set; }

        public int Telur
        {
            get { return TelurBaik; }
            set { TelurBaik = value; } // Supaya sinkron dengan TelurBaik
        }

        public double Produktivitas
        {
            get
            {
                if (AyamProduktif == 0) return 0;
                return (double)Telur / AyamProduktif;
            }
        }

        public double Persentase
        {
            get { return Produktivitas * 100; }
        }
    }
}