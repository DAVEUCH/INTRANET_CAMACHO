using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCargoAbono
    {
        public int PkidcargoAbono { get; set; }
        public int IdcuentaContable { get; set; }
        public decimal Abono { get; set; }
        public decimal Cargo { get; set; }
    }
}
