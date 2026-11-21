using System;

namespace PROJEKKKK_PBOO.Models
{
    public class DataPanen
    {
        private int _jumlahTotal;
        private int _telurBaik;
        private int _telurRusak;

        public DateTime Tanggal { get; set; }

        public int JumlahTotal
        {
            get => _jumlahTotal;
            set
            {
                if (value < 0 || value < _telurBaik + _telurRusak)
                    throw new ArgumentOutOfRangeException(nameof(value), "Jumlah total tidak boleh negatif atau lebih kecil dari telur baik dan rusak.");
                _jumlahTotal = value;
            }
        }

        public int TelurBaik
        {
            get => _telurBaik;
            set
            {
                if (value < 0 || value + _telurRusak > _jumlahTotal)
                    throw new ArgumentOutOfRangeException(nameof(value), "Jumlah telur baik tidak sesuai dengan jumlah total.");
                _telurBaik = value;
            }
        }

        public int TelurRusak
        {
            get => _telurRusak;
            set
            {
                if (value < 0 || value + _telurBaik > _jumlahTotal)
                    throw new ArgumentOutOfRangeException(nameof(value), "Jumlah telur rusak tidak sesuai dengan jumlah total.");
                _telurRusak = value;
            }
        }

        public string Keterangan { get; set; } = string.Empty;

        public double PersentaseBaik => JumlahTotal == 0
            ? 0
            : (double)TelurBaik / JumlahTotal * 100;
    }
}