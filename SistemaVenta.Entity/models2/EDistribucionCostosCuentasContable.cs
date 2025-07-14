using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDistribucionCostosCuentasContable
    {
        public int DistribucionCostosCuentasContablesId { get; set; }
        public int Id { get; set; }
        public int DistribucionCostosCuentasContablesIdcuentaContable { get; set; }
        public int IdcuentaContable { get; set; }
        public int IddistribucionCosto { get; set; }
    }
}
