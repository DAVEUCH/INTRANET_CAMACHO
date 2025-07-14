using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvAlmacenFt
    {
        public int Pkid { get; set; }
        public int Idsucursal { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
    }
}
