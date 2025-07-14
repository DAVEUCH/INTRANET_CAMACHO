using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpRequerimientoCompra
    {
        public int Pkid { get; set; }
        public string? EstadoAprobacion { get; set; }
        public int? Idalmacen { get; set; }
        public string EstadoFacturacion { get; set; } = null!;
        public DateTime? FechaAprobacion { get; set; }
        public bool? RequiereAprobacion { get; set; }

        public virtual Cp Pk { get; set; } = null!;
    }
}
