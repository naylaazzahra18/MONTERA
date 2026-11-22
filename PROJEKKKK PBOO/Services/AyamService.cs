using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using PROJEKKKK_PBOO.Models;

namespace PROJEKKKK_PBOO.Services
{
    public class AyamService : IAyamRepository
    {
        private readonly string _fileData;
        private readonly List<DataAyam> _daftarData;

        public AyamService() : this(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "ayam.json"))
        {
        }

        public AyamService(string fileData)
        {
            _fileData = fileData ?? throw new ArgumentNullException(nameof(fileData));
            string? folder = Path.GetDirectoryName(_fileData);
            if (!string.IsNullOrEmpty(folder))
                Directory.CreateDirectory(folder);

            _daftarData = new List<DataAyam>();
            MuatData();
        }

        public void MuatData()
        {
            _daftarData.Clear();
            if (!File.Exists(_fileData))
                return;

            List<DataAyam> data = JsonSerializer.Deserialize<List<DataAyam>>(File.ReadAllText(_fileData)) ?? new List<DataAyam>();
            _daftarData.AddRange(data);
        }

        public IReadOnlyList<DataAyam> AmbilSemua()
        {
            return _daftarData.OrderByDescending(data => data.Tanggal).ToList().AsReadOnly();
        }

        public void Tambah(DataAyam data)
        {
            ArgumentNullException.ThrowIfNull(data);
            TambahBanyak(new[] { data });
        }

        public void TambahBanyak(IReadOnlyList<DataAyam> data)
        {
            ArgumentNullException.ThrowIfNull(data);
            if (data.Any(item => item == null))
                throw new ArgumentException("Data ayam tidak boleh berisi nilai kosong.", nameof(data));

            _daftarData.AddRange(data);
            SimpanKeFile();
        }

        public void Hapus(DateTime tanggal, StatusAyam status)
        {
            _daftarData.RemoveAll(data => data.Tanggal.Date == tanggal.Date && data.Status == status);
            SimpanKeFile();
        }

        private void SimpanKeFile()
        {
            string json = JsonSerializer.Serialize(_daftarData, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_fileData, json);
        }
    }
}
