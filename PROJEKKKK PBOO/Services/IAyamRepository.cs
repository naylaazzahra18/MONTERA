using System;
using System.Collections.Generic;
using PROJEKKKK_PBOO.Models;

namespace PROJEKKKK_PBOO.Services
{
    public interface IAyamRepository
    {
        void MuatData();
        IReadOnlyList<DataAyam> AmbilSemua();
        void Tambah(DataAyam data);
        void TambahBanyak(IReadOnlyList<DataAyam> data);
        void Hapus(DateTime tanggal, StatusAyam status);
    }
}
