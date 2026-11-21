using System;
using System.Collections.Generic;
using System.Linq;
using PROJEKKKK_PBOO.Models;
using PROJEKKKK_PBOO.Services;

namespace PROJEKKKK_PBOO.Controller
{
    public class PanenController
    {
        private readonly IPanenRepository _service;

        public PanenController() : this(new PanenService())
        {
        }

        public PanenController(IPanenRepository service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public List<DataPanen> AmbilSemuaData()
        {
            _service.MuatData();
            return _service.AmbilSemua().ToList();
        }

        public string Simpan(DateTime tanggal, string totalStr, string baikStr, string rusakStr, string keterangan)
        {
            int total, baik, rusak;

            if (!int.TryParse(totalStr, out total) || total < 0)
                return "Jumlah Total harus berupa angka dan tidak boleh negatif.";

            if (!int.TryParse(baikStr, out baik) || baik < 0)
                return "Jumlah Telur Baik harus berupa angka dan tidak boleh negatif.";

            if (!int.TryParse(rusakStr, out rusak) || rusak < 0)
                return "Jumlah Telur Rusak harus berupa angka dan tidak boleh negatif.";

            // Validasi: Total harus sama dengan Baik + Rusak
            if (total != (baik + rusak))
                return "Jumlah Total harus sama dengan (Telur Baik + Telur Rusak).";

            _service.MuatData();
            if (_service.AmbilSemua().Any(d => d.Tanggal.Date == tanggal.Date))
                return "Data panen untuk tanggal tersebut sudah ada.";

            _service.Tambah(new DataPanen
            {
                Tanggal = tanggal,
                JumlahTotal = total,
                TelurBaik = baik,
                TelurRusak = rusak,
                Keterangan = keterangan
            });

            return ""; // Sukses
        }

        public void Hapus(DateTime tanggal)
        {
            _service.MuatData();
            _service.Hapus(tanggal);
        }
    }
}