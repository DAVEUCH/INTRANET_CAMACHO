using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabVentasPorProductoGroupSum
    {
        public int? TransacVentas { get; set; }
        public int? NumItems { get; set; }
        public int? CantidadProductos { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public int? CantidadClientes { get; set; }
        public decimal? ImpVentasSol { get; set; }
        public decimal? ImpVentasDol { get; set; }
    }
}
