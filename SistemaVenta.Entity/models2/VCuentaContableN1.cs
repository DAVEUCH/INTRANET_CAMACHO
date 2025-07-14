using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCuentaContableN1
    {
        public int Pkid { get; set; }
        public string? EntidadAsociada { get; set; }
        public string? TipoEntidadAsociada { get; set; }
        public int? Nivel { get; set; }
    }
}
