using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TCliente
    {
        public int? ClienteId { get; set; }
        public string? ClienteNombre { get; set; }
        public int? TipoClienteId { get; set; }
    }
}
