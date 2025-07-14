using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ESucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public bool Activo { get; set; }
        public string Codigo { get; set; } = null!;
    }
}
