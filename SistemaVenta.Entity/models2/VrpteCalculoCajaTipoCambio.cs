using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteCalculoCajaTipoCambio
    {
        public DateTime Fecha { get; set; }
        public int IdcuentaContable { get; set; }
        public string? CuentaContableNumero { get; set; }
        public decimal? SaldoDolares { get; set; }
        public decimal? SaldoSoles { get; set; }
        public string? CuentaContableDescripcion { get; set; }
        public int Mov { get; set; }
    }
}
