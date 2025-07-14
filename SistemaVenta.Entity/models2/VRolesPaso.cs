using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VRolesPaso
    {
        public string? Id { get; set; }
        public string? Nombre { get; set; }
        public string? Padre { get; set; }
        public int Orden { get; set; }
        public string? Imagen { get; set; }
        public string? Expander { get; set; }
        public string? Selected { get; set; }
        public bool Activo { get; set; }
        public int Idroles { get; set; }
        public int Idproceso { get; set; }
    }
}
