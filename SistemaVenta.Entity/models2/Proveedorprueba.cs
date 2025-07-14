using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Proveedorprueba
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? DocIdentidad { get; set; }
        public bool Activo { get; set; }
    }
}
