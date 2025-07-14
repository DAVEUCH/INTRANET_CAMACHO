using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EmpresaTransporte
    {
        public int Pkid { get; set; }
        public string? Campo { get; set; }

        public virtual Cliente Pk { get; set; } = null!;
    }
}
