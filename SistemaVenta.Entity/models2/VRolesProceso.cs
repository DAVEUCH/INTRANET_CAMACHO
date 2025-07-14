using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VRolesProceso
    {
        public string? Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Padre { get; set; }
        public int Orden { get; set; }
        public string Imagen { get; set; } = null!;
        public string Expander { get; set; } = null!;
        public string Selected { get; set; } = null!;
        public bool Activo { get; set; }
        public int Idroles { get; set; }
    }
}
