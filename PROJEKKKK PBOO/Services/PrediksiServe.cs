using System;
using System.Collections.Generic;
using System.Linq;
using PROJEKKKK_PBOO.Models;

namespace PROJEKKKK_PBOO.Services
{
    public class PrediksiService
    {
        private const int MaksimumDataAcuan = 3;

        public List<HasilPrediksi> BuatRiwayatPrediksi(IReadOnlyList<DataPanen> dataPanen)
        {
            if (dataPanen == null)
                throw new ArgumentNullException(nameof(dataPanen));

            List<DataPanen> dataUrut = dataPanen
                .OrderBy(data => data.Tanggal)
                .ToList();
            List<HasilPrediksi> hasil = new List<HasilPrediksi>();

            for (int i = 0; i < dataUrut.Count; i++)
            {
                int awal = Math.Max(0, i - MaksimumDataAcuan + 1);
                int jumlahDataAcuan = i - awal + 1;
                double rataRataTelurBaik = dataUrut
                    .Skip(awal)
                    .Take(jumlahDataAcuan)
                    .Average(data => data.TelurBaik);

                hasil.Add(new HasilPrediksi(
                    dataUrut[i].Tanggal,
                    dataUrut[i].Tanggal.AddDays(1),
                    dataUrut[i].TelurBaik,
                    (int)Math.Round(rataRataTelurBaik, MidpointRounding.AwayFromZero),
                    dataUrut[i].PersentaseBaik,
                    jumlahDataAcuan));
            }

            return hasil;
        }
    }
}