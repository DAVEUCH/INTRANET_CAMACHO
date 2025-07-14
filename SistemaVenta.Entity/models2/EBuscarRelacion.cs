using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EBuscarRelacion
    {
        public int IdcpRelacionado { get; set; }
        public string Nombre { get; set; } = null!;
    }
}
