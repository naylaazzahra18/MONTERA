using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PROJEKKKK_PBOO.Models;

namespace PROJEKKKK_PBOO.Services
{
    public class PanenService
    {
        private readonly string _folderData;
        private readonly string _filePanen;
        public List<DataPanen> DaftarPanen { get; private set; }

        public PanenService()
        {
            _folderData = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            _filePanen = Path.Combine(_folderData, "panen.csv");

            if (!Directory.Exists(_folderData))
                Directory.CreateDirectory(_folderData);

            DaftarPanen = new List<DataPanen>();
            MuatData();
        }

        public void MuatData()
        {
            DaftarPanen.Clear();
            if (!File.Exists(_filePanen)) return;

            foreach (string baris in File.ReadAllLines(_filePanen))
            {
                if (string.IsNullOrWhiteSpace(baris)) continue;
                string[] kolom = baris.Split(';');
                if (kolom.Length < 5) continue;

                DaftarPanen.Add(new DataPanen
                {
                    Tanggal = DateTime.Parse(kolom[0]),
                    JumlahTotal = int.Parse(kolom[1]),
                    TelurBaik = int.Parse(kolom[2]),
                    TelurRusak = int.Parse(kolom[3]),
                    Keterangan = kolom[4]
                });
            }
        }

        public void Tambah(DataPanen data)
        {
            DaftarPanen.Add(data);
            DaftarPanen = DaftarPanen.OrderBy(d => d.Tanggal).ToList();
            SimpanKeFile();
        }

        public void Hapus(DateTime tanggal)
        {
            DaftarPanen.RemoveAll(d => d.Tanggal.Date == tanggal.Date);
            SimpanKeFile();
        }

        private void SimpanKeFile()
        {
            List<string> baris = new List<string>();
            foreach (DataPanen d in DaftarPanen)
            {
                baris.Add($"{d.Tanggal:yyyy-MM-dd};{d.JumlahTotal};{d.TelurBaik};{d.TelurRusak};{d.Keterangan}");
            }
            File.WriteAllLines(_filePanen, baris);
        }
    }
}