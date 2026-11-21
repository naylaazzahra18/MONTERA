
using PROJEKKKK_PBOO.Models;
using System;

namespace PROJEKKKK_PBOO.Controller
{
    public class PrediksiAyamController
    {
        public string HitungPrediksi(
            int jumlahAyam,
            int ayamSakit,
            double sebelumnya,
            bool dataAwal,
            out double persentase)
        {
            Prediksi prediksi = new PrediksiAyamModel(jumlahAyam, ayamSakit);
            persentase = prediksi.HitungPersentase();

            // Menentukan status
            if (dataAwal)
            {
                return "Data Awal";
            }

            return prediksi.TentukanStatus(
                sebelumnya, persentase);
        }
    }
}
