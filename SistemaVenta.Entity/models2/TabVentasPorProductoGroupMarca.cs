using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabVentasPorProductoGroupMarca
    {
        public int? MarcaId { get; set; }
        public string? MarcaCodigo { get; set; }
        public string? MarcaDescripcion { get; set; }
        public int? TransacVentas { get; set; }
        public int? NumItems { get; set; }
        public int? CantidadProductos { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public int? CantidadClientes { get; set; }
        public decimal? ImpVentasSol { get; set; }
        public decimal? ImpVentasDol { get; set; }
        public decimal? TotVentasDol { get; set; }
    }
}
