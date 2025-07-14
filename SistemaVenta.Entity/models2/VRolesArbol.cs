using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VRolesArbol
    {
        public string? Id { get; set; }
        public string? Nombre { get; set; }
        public string? Padre { get; set; }
        public int Orden { get; set; }
        public string? Imagen { get; set; }
        public string? Expander { get; set; }
        public string? Selected { get; set; }
        public int Activo { get; set; }
    }
}
