using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCuentaComparar
    {
        public int Pkid { get; set; }
        public int? IdcuentaContablePadre { get; set; }
        public string? Cuenta { get; set; }
        public string? Descripcion { get; set; }
        public string? CuentaNombreReal { get; set; }
    }
}
