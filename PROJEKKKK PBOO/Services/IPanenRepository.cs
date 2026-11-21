using System;
using System.Collections.Generic;
using PROJEKKKK_PBOO.Models;

namespace PROJEKKKK_PBOO.Services
{
    public interface IPanenRepository
    {
        void MuatData();
        IReadOnlyList<DataPanen> AmbilSemua();
        void Tambah(DataPanen data);
        void Hapus(DateTime tanggal);
    }
}
