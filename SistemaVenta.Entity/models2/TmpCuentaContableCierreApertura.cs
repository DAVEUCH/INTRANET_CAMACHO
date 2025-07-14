using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TmpCuentaContableCierreApertura
    {
        public int Pkid { get; set; }
        public int IdconfiguracionCierreApertura { get; set; }
        public int IdcuentaContable { get; set; }
    }
}
