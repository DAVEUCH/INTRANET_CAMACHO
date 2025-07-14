using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasTipoMedioPagoAcumAnual
    {
        public int? Anio { get; set; }
        public int? Mes { get; set; }
        public decimal? Total { get; set; }
        public decimal? Efect { get; set; }
        public decimal? Chequ { get; set; }
        public decimal? Depos { get; set; }
        public decimal? Trans { get; set; }
        public decimal? Tarje { get; set; }
        public decimal? Credito { get; set; }
    }
}
