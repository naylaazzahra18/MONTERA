using System;

namespace PROJEKKKK_PBOO.Models
{
    // Inharitance 
    public class PrediksiAyamModel : Prediksi
    {
        public PrediksiAyamModel(int jumlahAyam, int ayamSakit)
            : base(jumlahAyam, ayamSakit) { }

        // Override
        public override double HitungPersentase()
        {
            return Math.Round(base.HitungPersentase(), 2);
        }

        public override string TentukanStatus(double sebelumnya, double sekarang)
        {
            if (sekarang > sebelumnya) return "Meningkat (perlu perhatian)";
            if (sekarang < sebelumnya) return "Menurun (membaik)";
            return "Stabil";
        }
    }
}

