using System;

namespace PROJEKKKK_PBOO.Models
{
    public class HasilPrediksi
    {
        public DateTime TanggalPanen { get; }
        public DateTime TanggalPrediksi { get; }
        public int TelurBaikAktual { get; }
        public int PerkiraanTelurBaik { get; }
        public double PersentaseTelurBaik { get; }
        public int JumlahDataAcuan { get; }

        public HasilPrediksi(
            DateTime tanggalPanen,
            DateTime tanggalPrediksi,
            int telurBaikAktual,
            int perkiraanTelurBaik,
            double persentaseTelurBaik,
            int jumlahDataAcuan)
        {
            TanggalPanen = tanggalPanen;
            TanggalPrediksi = tanggalPrediksi;
            TelurBaikAktual = telurBaikAktual;
            PerkiraanTelurBaik = perkiraanTelurBaik;
            PersentaseTelurBaik = persentaseTelurBaik;
            JumlahDataAcuan = jumlahDataAcuan;
        }
    }
}
