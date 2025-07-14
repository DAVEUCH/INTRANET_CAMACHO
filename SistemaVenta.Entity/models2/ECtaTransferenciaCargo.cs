using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECtaTransferenciaCargo
    {
        public int CtasTransferenciaCargoId { get; set; }
        public int IdcuentaContable { get; set; }
        public int CtasTransferenciaCargoIdcuentaContableCargo { get; set; }
        public int CtasTransferenciaCargoPorcentaje { get; set; }
    }
}
