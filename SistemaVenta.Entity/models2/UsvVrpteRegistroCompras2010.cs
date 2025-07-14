using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVrpteRegistroCompras2010
    {
        public string? Periodocod { get; set; }
        public string? NroDocIdentidad { get; set; }
        public string? ClienteNombre { get; set; }
        public int? TipoComprobantePagoCod { get; set; }
        public string? NumeroSerie { get; set; }
        public string? NumCp { get; set; }
        public decimal? Total { get; set; }
    }
}
