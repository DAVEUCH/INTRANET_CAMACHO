using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VPruebaCliente1
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? DocIdentidad { get; set; }
        public bool Activo { get; set; }
        public int IdtipoCliente { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
