using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCargoCobranzaAbierto
    {
        public int Id { get; set; }
        public bool Cerrado { get; set; }
        public decimal Saldo { get; set; }
        public decimal Total { get; set; }
        public int IddocCobrarPagar { get; set; }
    }
}
