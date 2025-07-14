using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EEstadoFinancieroRubroCuentaContable
    {
        public int CuentasContablesId { get; set; }
        public int CuentasContablesIdcuentaContable { get; set; }
        public int IdestadoFinancieroRubro { get; set; }
        public int CuentasContablesTipoSaldo { get; set; }
        public decimal CuentasContablesPorcentaje { get; set; }
    }
}
