using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EProductoAgrupacionCuotaVentum
    {
        public int ProductosId { get; set; }
        public int IdagrupacionCuotaVenta { get; set; }
        public int ProductosIdproducto { get; set; }
        public int IdcuotaVenta { get; set; }
    }
}
