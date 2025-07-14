using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoClientePrueba
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string? DocIdentidad { get; set; }
        public string CodAnt { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
    }
}
