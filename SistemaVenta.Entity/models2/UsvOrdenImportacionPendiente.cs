using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvOrdenImportacionPendiente
    {
        public string NumDoc { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Proveedor { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal Total { get; set; }
        public string EstadoFacturacion { get; set; } = null!;
        public string EstadoEntrega { get; set; } = null!;
        public DateTime? FechaEmbarque { get; set; }
        public DateTime? FechaLlegada { get; set; }
        public string Observacion { get; set; } = null!;
    }
}
