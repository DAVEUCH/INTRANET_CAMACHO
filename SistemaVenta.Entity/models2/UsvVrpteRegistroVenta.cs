using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVrpteRegistroVenta
    {
        public string? Periodocod { get; set; }
        public string NroDocIdentidad { get; set; } = null!;
        public string? TipoComprobantePagoCod { get; set; }
        public string? NumeroSerie { get; set; }
        public int? NumCp { get; set; }
        public decimal? ValorVta { get; set; }
        public decimal? ValorIgv { get; set; }
        public decimal? Total { get; set; }
    }
}
