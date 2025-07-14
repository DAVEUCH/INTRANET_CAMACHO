using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VPruebaReporteComision
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal? TotaMes { get; set; }
        public int? Idproveedor { get; set; }
        public bool Credito { get; set; }
        public int IdtipoCliente { get; set; }
        public decimal Comision { get; set; }
    }
}
