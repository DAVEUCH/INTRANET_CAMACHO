using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionDocCobrarPagar
    {
        public int Pkid { get; set; }
        public int IdcuentaContable { get; set; }
        public int IdcptoOperacion { get; set; }
        public int IdtipoCp { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual CptoOperacion IdcptoOperacionNavigation { get; set; } = null!;
        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
        public virtual TipoCp IdtipoCpNavigation { get; set; } = null!;
    }
}
