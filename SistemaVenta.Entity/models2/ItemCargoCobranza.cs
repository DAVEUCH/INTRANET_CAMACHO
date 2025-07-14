using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCargoCobranza
    {
        public int Pkid { get; set; }
        public int IddocCobrarPagar { get; set; }
        public int IdcargoCobranza { get; set; }
        public decimal Saldo { get; set; }
        public string? NumeroMedioPago { get; set; }
        public string? NumeroDocumento { get; set; }
        public decimal? MontoCobranza { get; set; }
        public int? IdtipoMedioDePago { get; set; }

        public virtual CargoCobranza IdcargoCobranzaNavigation { get; set; } = null!;
    }
}
