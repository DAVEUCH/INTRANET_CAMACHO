using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EBuscarPersona
    {
        public string? DocIdentidad { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string Empleado { get; set; } = null!;
    }
}
