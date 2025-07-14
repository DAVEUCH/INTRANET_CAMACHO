using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCuentaContable
    {
        public int Pkid { get; set; }
        public string? Cuenta { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
