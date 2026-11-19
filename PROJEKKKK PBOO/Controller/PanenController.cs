using System;
using System.Collections.Generic;
using PROJEKKKK_PBOO.Models;
using PROJEKKKK_PBOO.Services;

namespace PROJEKKKK_PBOO.Controller
{
    public class PanenController
    {
        private readonly PanenService _service;

        public PanenController()
        {
            _service = new PanenService();
        }

        public List<DataPanen> AmbilSemuaData()
        {
            return _service.DaftarPanen;
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
            _service.Hapus(tanggal);
        }
    }
}