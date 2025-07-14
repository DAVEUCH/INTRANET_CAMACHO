using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCuentaContableN
    {
        public int Pkid { get; set; }
        public int? IdcuentaContablePadre { get; set; }
        public string? EntidadAsociada { get; set; }
        public string? TipoEntidadAsociada { get; set; }
    }
}
