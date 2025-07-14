using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemDocCobrarPagar
    {
        public int Pkid { get; set; }
        public int IddocCobrarPagar { get; set; }
        public int IdcuentaContable { get; set; }
        public int IdtipoAuxiliar { get; set; }
        public int Idauxiliar { get; set; }
        public string NumeroRegistro { get; set; } = null!;

        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
        public virtual DocCobrarPagar IddocCobrarPagarNavigation { get; set; } = null!;
        public virtual ItemCp Pk { get; set; } = null!;
    }
}
