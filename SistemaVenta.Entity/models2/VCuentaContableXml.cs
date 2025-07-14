using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCuentaContableXml
    {
        public int Id { get; set; }
        public string Cuenta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
    }
}
