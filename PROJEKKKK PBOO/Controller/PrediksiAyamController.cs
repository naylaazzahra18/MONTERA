using System;
using System.Collections.Generic;
using System.Linq;
using PROJEKKKK_PBOO.Models;
using PROJEKKKK_PBOO.Services;

namespace PROJEKKKK_PBOO.Controller
{
    public class PrediksiAyamController
    {
        private readonly IAyamRepository _repository;

        public PrediksiAyamController() : this(new AyamService())
        {
        }

        public PrediksiAyamController(IAyamRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public IReadOnlyList<HasilPrediksiAyam> AmbilRiwayatPrediksi()
        {
            _repository.MuatData();
            List<IGrouping<DateTime, DataAyam>> perTanggal = _repository.AmbilSemua()
                .GroupBy(data => data.Tanggal.Date)
                .OrderBy(grup => grup.Key)
                .ToList();
            List<HasilPrediksiAyam> hasil = new List<HasilPrediksiAyam>();
            double? persentaseSebelumnya = null;

            foreach (IGrouping<DateTime, DataAyam> grup in perTanggal)
            {
                int jumlahBaik = grup.Where(data => data.Status == StatusAyam.Baik).Sum(data => data.Jumlah);
                int jumlahSakit = grup.Where(data => data.Status == StatusAyam.Sakit).Sum(data => data.Jumlah);
                int jumlahMati = grup.Where(data => data.Status == StatusAyam.Mati).Sum(data => data.Jumlah);
                int jumlahHidup = jumlahBaik + jumlahSakit;
                double persentase = jumlahHidup == 0
                    ? 0
                    : (double)jumlahSakit / jumlahHidup * 100;
                string statusTren;

                if (jumlahHidup == 0)
                    statusTren = "Tidak ada ayam hidup";
                else if (!persentaseSebelumnya.HasValue)
                    statusTren = "Data awal";
                else
                    statusTren = new PrediksiAyamModel(jumlahHidup, jumlahSakit)
                        .TentukanStatus(persentaseSebelumnya.Value, persentase);

                hasil.Add(new HasilPrediksiAyam
                {
                    Tanggal = grup.Key,
                    JumlahAyamHidup = jumlahHidup,
                    JumlahAyamSakit = jumlahSakit,
                    JumlahAyamMati = jumlahMati,
                    PersentaseSakit = Math.Round(persentase, 2),
                    StatusTren = statusTren
                });

                if (jumlahHidup > 0)
                    persentaseSebelumnya = persentase;
            }

            return hasil.AsReadOnly();
        }
    }
}
