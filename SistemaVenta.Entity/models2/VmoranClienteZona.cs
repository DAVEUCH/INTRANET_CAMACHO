using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VmoranClienteZona
    {
        public string? Codigo { get; set; }
        public string CodigoZona { get; set; } = null!;
        public int Idcliente { get; set; }
    }
}
