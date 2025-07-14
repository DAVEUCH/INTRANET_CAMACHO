using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VColasAsignada
    {
        public string? IdtipoReferenciado { get; set; }
        public string? Ruta { get; set; }
        public string? Valor { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Direccion { get; set; }
    }
}
