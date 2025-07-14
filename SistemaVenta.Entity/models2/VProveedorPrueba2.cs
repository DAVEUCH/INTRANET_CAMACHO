using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VProveedorPrueba2
    {
        public int Pkid { get; set; }
        public string? DocIdentidad { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public bool Activo { get; set; }
    }
}
