using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EWapCpCajaEntradum
    {
        public string DocCobrar { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string NumCp { get; set; } = null!;
        public string Simbolo { get; set; } = null!;
        public decimal Total { get; set; }
        public int IddocCobrarPagar { get; set; }
        public int Id { get; set; }
    }
}
