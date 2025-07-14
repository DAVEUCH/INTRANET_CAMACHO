using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VcuentasEditarPolo
    {
        public int? Idcuenta { get; set; }
        public int? IdcuentaPadre { get; set; }
        public string? Cuenta { get; set; }
        public string? CuentaNombre { get; set; }
        public int? Pkid { get; set; }
        public int? IdcuentaContablePadre { get; set; }
        public string? Expr1 { get; set; }
        public string? CuentaNombreReal { get; set; }
        public string? Descripcion { get; set; }
    }
}
