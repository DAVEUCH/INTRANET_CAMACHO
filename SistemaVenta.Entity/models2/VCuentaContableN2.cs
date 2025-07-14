using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCuentaContableN2
    {
        public int Pkid { get; set; }
        public string? EntidadAsociada { get; set; }
        public string? TipoEntidadAsociada { get; set; }
        public int Pkid2 { get; set; }
        public string EntidadAsociada2 { get; set; } = null!;
        public string TipoEntidadAsociada2 { get; set; } = null!;
        public int Pkidcc { get; set; }
    }
}
