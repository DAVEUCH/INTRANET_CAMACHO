using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VerificacionCtasTransferenciaRca
    {
        public int Pkid { get; set; }
        public string? Cuenta { get; set; }
        public bool? TieneTransferencia { get; set; }
        public int? Expr1 { get; set; }
        public int? IdcuentaContableCargo { get; set; }
        public string? Expr2 { get; set; }
        public int? Porcentaje { get; set; }
        public int? Expr3 { get; set; }
        public int? IdcuentaContableAbono { get; set; }
        public string? Expr4 { get; set; }
        public int? Expr5 { get; set; }
        public int? Nivel { get; set; }
    }
}
