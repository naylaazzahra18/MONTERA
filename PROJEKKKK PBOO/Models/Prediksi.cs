using System;

namespace PROJEKKKK_PBOO.Models
{
    public class Prediksi
    {
        private int jumlahAyam;
        private int ayamSakit;

        public int JumlahAyam
        {
            get { return jumlahAyam; }
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Jumlah ayam harus lebih dari 0");
                jumlahAyam = value;
            }
        }
        public int AyamSakit
        {
            get { return ayamSakit; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Ayam sakit tidak boleh negatif");
                ayamSakit = value;
            }
        }
        public Prediksi(int jumlahAyam, int ayamSakit)
        {
            JumlahAyam = jumlahAyam;
            AyamSakit = ayamSakit;

            if (ayamSakit > jumlahAyam)
                throw new ArgumentException("Ayam sakit tidak boleh melebihi jumlah ayam");
        }
        public virtual double HitungPersentase()
        {
            return (double)AyamSakit / JumlahAyam * 100;
        }

        public virtual string TentukanStatus(double sebelumnya, double sekarang)
        {
            if (sekarang > sebelumnya) return "Meningkat";
            if (sekarang < sebelumnya) return "Menurun";
            return "Stabil";
        }
    }
}