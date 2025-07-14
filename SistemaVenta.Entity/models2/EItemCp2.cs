using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemCp2
    {
        public int Id { get; set; }
        public int Idcp { get; set; }
        public int ItemDocCobrarPagarIddocCobrarPagar { get; set; }
        public int ItemDocCobrarPagarIdcuentaContable { get; set; }
    }
}
