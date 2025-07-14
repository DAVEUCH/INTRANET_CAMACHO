using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECuentaTransferenciaAbono
    {
        public int IdcuentaContable { get; set; }
        public int CtasTransferenciaAbonoId { get; set; }
        public int CtasTransferenciaAbonoIdcuentaContableAbono { get; set; }
        public int CtasTransferenciaAbonoPorcentaje { get; set; }
    }
}
