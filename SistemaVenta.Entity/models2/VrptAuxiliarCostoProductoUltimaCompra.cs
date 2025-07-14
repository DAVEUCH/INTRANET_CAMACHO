using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptAuxiliarCostoProductoUltimaCompra
    {
        public int Pkid { get; set; }
        public int Idproducto { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal? ValorVentaUnitario { get; set; }
    }
}
