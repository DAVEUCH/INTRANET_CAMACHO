using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EstadoFinancieroRubroCuentaContable
    {
        public int Pkid { get; set; }
        public int IdcuentaContable { get; set; }
        public int TipoSaldo { get; set; }
        public int IdestadoFinancieroRubro { get; set; }
        public decimal Porcentaje { get; set; }

        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
        public virtual EstadoFinancieroRubro IdestadoFinancieroRubroNavigation { get; set; } = null!;
    }
}
