using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VLiquidacionCajaContbilidadNess
    {
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal? Efectivo { get; set; }
        public decimal? Cheque { get; set; }
        public decimal? Tarjeta { get; set; }
        public decimal? Deposito { get; set; }
        public string Sucursal { get; set; } = null!;
        public string? Desde { get; set; }
        public string? Hasta { get; set; }
    }
}
