using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EUltimasVenta
    {
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string ClienteCodigo { get; set; } = null!;
        public string ProductoCodigo { get; set; } = null!;
    }
}
