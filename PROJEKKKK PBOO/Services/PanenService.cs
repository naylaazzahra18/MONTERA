using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PROJEKKKK_PBOO.Models;

namespace PROJEKKKK_PBOO.Services
{
    public class PanenService : IPanenRepository
    {
        private readonly string _folderData;
        private readonly string _filePanen;
        private readonly List<DataPanen> _daftarPanen = new List<DataPanen>();

        public PanenService()
        {
            _folderData = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            _filePanen = Path.Combine(_folderData, "panen.csv");

            if (!Directory.Exists(_folderData))
                Directory.CreateDirectory(_folderData);

            MuatData();
        }

        public void MuatData()
        {
            _daftarPanen.Clear();
            if (!File.Exists(_filePanen)) return;

            foreach (string baris in File.ReadAllLines(_filePanen))
            {
                if (string.IsNullOrWhiteSpace(baris)) continue;
                string[] kolom = baris.Split(';');
                if (kolom.Length < 5) continue;

                _daftarPanen.Add(new DataPanen
                {
                    Tanggal = DateTime.Parse(kolom[0]),
                    JumlahTotal = int.Parse(kolom[1]),
                    TelurBaik = int.Parse(kolom[2]),
                    TelurRusak = int.Parse(kolom[3]),
                    Keterangan = kolom[4]
                });
            }
        }

        public IReadOnlyList<DataPanen> AmbilSemua()
        {
            return _daftarPanen.ToList().AsReadOnly();
        }

        public void Tambah(DataPanen data)
        {
            _daftarPanen.Add(data);
            _daftarPanen.Sort((a, b) => a.Tanggal.CompareTo(b.Tanggal));
            SimpanKeFile();
        }

        public void Hapus(DateTime tanggal)
        {
            _daftarPanen.RemoveAll(d => d.Tanggal.Date == tanggal.Date);
            SimpanKeFile();
        }

        private void SimpanKeFile()
        {
            List<string> baris = new List<string>();
            foreach (DataPanen d in _daftarPanen)
            {
                baris.Add($"{d.Tanggal:yyyy-MM-dd};{d.JumlahTotal};{d.TelurBaik};{d.TelurRusak};{d.Keterangan}");
            }
            File.WriteAllLines(_filePanen, baris);
        }
    }
}