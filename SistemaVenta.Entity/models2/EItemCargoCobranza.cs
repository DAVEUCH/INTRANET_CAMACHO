using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemCargoCobranza
    {
        public int ItemsId { get; set; }
        public int ItemsIddocCobrarPagar { get; set; }
        public int IdcargoCobranza { get; set; }
        public decimal ItemsSaldo { get; set; }
        public string? ItemsNumeroMedioPago { get; set; }
        public string? ItemsNumeroDocumento { get; set; }
        public decimal? ItemsMontoCobranza { get; set; }
        public int? ItemsIdtipoMedioDePago { get; set; }
    }
}
