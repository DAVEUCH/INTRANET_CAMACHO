using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TVendedor
    {
        public int? VendedorId { get; set; }
        public string? VendedorNombre { get; set; }
        public int FuerzaVentasId { get; set; }
    }
}
