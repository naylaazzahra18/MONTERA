using System;
using System.Collections.Generic;
using System.Linq;
using PROJEKKKK_PBOO.Models;
using PROJEKKKK_PBOO.Services;

namespace PROJEKKKK_PBOO.Controller
{
    public class AyamController
    {
        private readonly IAyamRepository _repository;

        public AyamController() : this(new AyamService())
        {
        }

        public AyamController(IAyamRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public IReadOnlyList<DataAyam> AmbilSemuaData()
        {
            _repository.MuatData();
            return _repository.AmbilSemua();
        }

        public string SimpanRekap(
            DateTime tanggal,
            bool pilihBaik,
            string jumlahBaikText,
            bool pilihSakit,
            string jumlahSakitText,
            bool pilihMati,
            string jumlahMatiText,
            string keterangan)
        {
            if (!pilihBaik && !pilihSakit && !pilihMati)
                return "Pilih minimal satu kondisi ayam.";

            if (!CobaBacaJumlah(pilihBaik, jumlahBaikText, "baik", out int jumlahBaik, out string error))
                return error;
            if (!CobaBacaJumlah(pilihSakit, jumlahSakitText, "sakit", out int jumlahSakit, out error))
                return error;
            if (!CobaBacaJumlah(pilihMati, jumlahMatiText, "mati", out int jumlahMati, out error))
                return error;

            _repository.MuatData();
            IReadOnlyList<DataAyam> dataLama = _repository.AmbilSemua();
            StatusAyam? duplikat = new[]
            {
                (Dipilih: pilihBaik, Status: StatusAyam.Baik),
                (Dipilih: pilihSakit, Status: StatusAyam.Sakit),
                (Dipilih: pilihMati, Status: StatusAyam.Mati)
            }
                .Where(item => item.Dipilih)
                .Select(item => (StatusAyam?)item.Status)
                .FirstOrDefault(status => dataLama.Any(data => data.Tanggal.Date == tanggal.Date && data.Status == status));

            if (duplikat.HasValue)
                return $"Catatan ayam {duplikat.Value.ToString().ToLowerInvariant()} untuk tanggal tersebut sudah ada.";

            List<DataAyam> dataBaru = new List<DataAyam>();
            if (pilihBaik)
                dataBaru.Add(BuatData(tanggal, StatusAyam.Baik, jumlahBaik, keterangan));
            if (pilihSakit)
                dataBaru.Add(BuatData(tanggal, StatusAyam.Sakit, jumlahSakit, keterangan));
            if (pilihMati)
                dataBaru.Add(BuatData(tanggal, StatusAyam.Mati, jumlahMati, keterangan));

            _repository.TambahBanyak(dataBaru);
            return string.Empty;
        }

        private static bool CobaBacaJumlah(bool dipilih, string teks, string status, out int jumlah, out string error)
        {
            jumlah = 0;
            error = string.Empty;
            if (!dipilih)
                return true;

            if (!int.TryParse(teks, out jumlah) || jumlah <= 0)
            {
                error = $"Jumlah ayam {status} harus berupa angka lebih dari nol.";
                return false;
            }

            return true;
        }

        private static DataAyam BuatData(DateTime tanggal, StatusAyam status, int jumlah, string keterangan)
        {
            return new DataAyam
            {
                Tanggal = tanggal.Date,
                Status = status,
                Jumlah = jumlah,
                Keterangan = keterangan.Trim()
            };
        }

        public void Hapus(DateTime tanggal, StatusAyam status)
        {
            _repository.MuatData();
            _repository.Hapus(tanggal, status);
        }
    }
}
