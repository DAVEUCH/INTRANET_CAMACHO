using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCuentaContableN5
    {
        public int Pkid1 { get; set; }
        public string? EntidadAsociada1 { get; set; }
        public string? TipoEntidadAsociada1 { get; set; }
        public int Pkid2 { get; set; }
        public string EntidadAsociada2 { get; set; } = null!;
        public string TipoEntidadAsociada2 { get; set; } = null!;
        public int Pkid3 { get; set; }
        public string EntidadAsociada3 { get; set; } = null!;
        public string TipoEntidadAsociada3 { get; set; } = null!;
        public int Pkid4 { get; set; }
        public string EntidadAsociada4 { get; set; } = null!;
        public string TipoEntidadAsociada4 { get; set; } = null!;
        public int Pkid5 { get; set; }
        public string EntidadAsociada5 { get; set; } = null!;
        public string TipoEntidadAsociada5 { get; set; } = null!;
        public int Pkidcc { get; set; }
    }
}
