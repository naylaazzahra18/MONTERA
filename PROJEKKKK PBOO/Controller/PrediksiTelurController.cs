using System;
using System.Collections.Generic;
using PROJEKKKK_PBOO.Models;
using PROJEKKKK_PBOO.Services;

namespace PROJEKKKK_PBOO.Controller
{
    public class PrediksiTelurController
    {
        private readonly IPanenRepository _panenRepository;
        private readonly PrediksiService _prediksiService;

        public PrediksiTelurController()
            : this(new PanenService(), new PrediksiService())
        {
        }

        public PrediksiTelurController(
            IPanenRepository panenRepository,
            PrediksiService prediksiService)
        {
            _panenRepository = panenRepository ?? throw new ArgumentNullException(nameof(panenRepository));
            _prediksiService = prediksiService ?? throw new ArgumentNullException(nameof(prediksiService));
        }

        public List<HasilPrediksi> AmbilRiwayatPrediksi()
        {
            _panenRepository.MuatData();
            return _prediksiService.BuatRiwayatPrediksi(_panenRepository.AmbilSemua());
        }
    }
}
